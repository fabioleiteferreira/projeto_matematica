# Compila o Projeto Matemática e salva um print de cada tela em docs\prints.
# Uso: dois cliques em tools\TIRAR-PRINTS.bat (precisa do Visual Studio com "Desenvolvimento para desktop com .NET").
$ErrorActionPreference = 'Stop'
$raiz = Split-Path $PSScriptRoot -Parent
Set-Location $raiz
$Host.UI.RawUI.WindowTitle = 'Projeto Matematica - tirando prints'
Write-Host ''
Write-Host '=== PROJETO MATEMATICA - PRINTS DAS TELAS ===' -ForegroundColor Cyan

try {
    # 1) Compilar com o MSBuild do Visual Studio
    $vswhere = "${env:ProgramFiles(x86)}\Microsoft Visual Studio\Installer\vswhere.exe"
    $msbuild = & $vswhere -latest -prerelease -products * -requires Microsoft.Component.MSBuild -find 'MSBuild\**\Bin\MSBuild.exe' | Select-Object -First 1
    if (-not $msbuild) { throw 'Nao achei o MSBuild do Visual Studio.' }
    Write-Host '1/2  Compilando...' -ForegroundColor Yellow
    & $msbuild 'Projeto Matemática.csproj' /t:Build /p:Configuration=Release /v:minimal /nologo
    if ($LASTEXITCODE -ne 0) { throw 'A compilacao falhou (veja as mensagens acima).' }
    $exe = Get-ChildItem -Path (Join-Path $raiz 'bin\Release') -Filter '*.exe' | Select-Object -First 1
    if (-not $exe) { throw 'Nao achei o .exe compilado.' }

    # 2) Abrir cada tela, preencher um exemplo e salvar a imagem
    Write-Host '2/2  Tirando os prints...' -ForegroundColor Yellow
    Add-Type -AssemblyName System.Windows.Forms, System.Drawing
    [System.Windows.Forms.Application]::EnableVisualStyles()
    $asm = [Reflection.Assembly]::LoadFrom($exe.FullName)
    $saida = Join-Path $raiz 'docs\prints'
    New-Item -ItemType Directory -Force -Path $saida | Out-Null

    function C($form, $nome) { $form.Controls.Find($nome, $true) | Select-Object -First 1 }
    function Foto($tipo, $arquivo, [scriptblock]$preparar) {
        $f = [Activator]::CreateInstance($asm.GetType("Projeto_Matemática.$tipo"))
        $f.StartPosition = 'Manual'; $f.Location = New-Object Drawing.Point(-4000, 0); $f.ShowInTaskbar = $false
        $f.Show(); [System.Windows.Forms.Application]::DoEvents()
        if ($preparar) { & $preparar $f; [System.Windows.Forms.Application]::DoEvents() }
        Start-Sleep -Milliseconds 300; [System.Windows.Forms.Application]::DoEvents()
        $bmp = New-Object Drawing.Bitmap($f.Width, $f.Height)
        $f.DrawToBitmap($bmp, (New-Object Drawing.Rectangle(0, 0, $f.Width, $f.Height)))
        $bmp.Save((Join-Path $saida $arquivo), [Drawing.Imaging.ImageFormat]::Png)
        $bmp.Dispose(); $f.Hide(); $f.Dispose()
        Write-Host "  ok  $arquivo" -ForegroundColor Green
    }

    Foto 'Frm_Acesso'     '01-menu.png'                     $null
    Foto 'Frm_Operacao'   '02-operacoes-aritmeticas.png'    { param($f) (C $f 'Txt_Numero1').Text = '12'; (C $f 'Txt_Numero2').Text = '4'
                                                              foreach ($b in 'Btn_Adicao','Btn_Subtracao','Btn_Multiplicacao','Btn_Divisao') { (C $f $b).PerformClick() } }
    Foto 'Frm_Par'        '03-par-ou-impar.png'             { param($f) (C $f 'Txt_Numeral').Text = '28' }
    Foto 'Frm_Positivo'   '04-positivo-negativo-neutro.png' { param($f) (C $f 'Txt_Numero').Text = '-7' }
    Foto 'Frm_Dobro'      '05-dobro.png'                    { param($f) (C $f 'Txt_Dobro').Text = '25' }
    Foto 'Frm_Antecessor' '06-antecessor-e-sucessor.png'    { param($f) (C $f 'Txt_Inteiro').Text = '10'; (C $f 'Btn_Antecessor').PerformClick(); (C $f 'Btn_Sucessor').PerformClick() }
    Foto 'Frm_Maior'      '07-maior-ou-menor.png'           { param($f) (C $f 'Txt_Primeiro').Text = '15'; (C $f 'Txt_Segundo').Text = '9'; (C $f 'Lbl_Sinais').Text = '>' }
    Foto 'Frm_Igual'      '08-igual-ou-diferente.png'       { param($f) (C $f 'Txt_Primeiro').Text = '8'; (C $f 'Txt_Segundo').Text = '5'; (C $f 'Lbl_Interrogação').Text = '≠' }

    Write-Host ''
    Write-Host "PRONTO! Prints salvos em: $saida" -ForegroundColor Green
    Write-Host 'Pode avisar o Claude.' -ForegroundColor Green
}
catch {
    Write-Host ''
    Write-Host "Deu erro: $($_.Exception.Message)" -ForegroundColor Red
    Write-Host 'Tire uma foto desta tela e mande para o Claude.' -ForegroundColor Red
}
Read-Host 'Aperte Enter para fechar'
