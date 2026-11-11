# Compila o Projeto Matemática e salva um print de cada tela em docs\prints.
# Uso: dois cliques em tools\TIRAR-PRINTS.bat (precisa do Visual Studio com "Desenvolvimento para desktop com .NET").
$ErrorActionPreference = 'Stop'
Start-Transcript -Path (Join-Path $PSScriptRoot 'ultimo-log.txt') -Force | Out-Null
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
    $build = Join-Path $env:TEMP ('projeto_matematica_prints_' + [guid]::NewGuid().ToString('N'))
    & $msbuild 'Projeto Matemática.csproj' /t:Rebuild /p:Configuration=Release "/p:OutDir=$build\" /v:minimal /nologo
    if ($LASTEXITCODE -ne 0) { throw 'A compilacao falhou (veja as mensagens acima).' }
    $exe = Get-ChildItem -Path $build -Filter '*.exe' | Select-Object -First 1
    if (-not $exe) { throw 'Nao achei o .exe compilado.' }

    # 2) Abrir cada tela, preencher um exemplo e salvar a imagem
    Write-Host '2/2  Tirando os prints...' -ForegroundColor Yellow
    Add-Type -AssemblyName System.Windows.Forms, System.Drawing
    Add-Type -Namespace Win -Name Dpi -MemberDefinition '[DllImport("user32.dll")] public static extern bool SetProcessDPIAware();'
    [void][Win.Dpi]::SetProcessDPIAware()
    # Fecha telas que tenham ficado abertas de uma execução anterior
    Get-CimInstance Win32_Process -Filter "Name='powershell.exe'" | Where-Object { $_.CommandLine -like '*-EncodedCommand*' -and $_.ProcessId -ne $PID } | ForEach-Object { Stop-Process -Id $_.ProcessId -Force -ErrorAction SilentlyContinue }
    [System.Windows.Forms.Application]::EnableVisualStyles()
    $asm = [Reflection.Assembly]::LoadFrom($exe.FullName)
    $saida = Join-Path $raiz 'docs\prints'
    New-Item -ItemType Directory -Force -Path $saida | Out-Null

    function C($form, $nome) { $form.Controls.Find($nome, $true) | Select-Object -First 1 }
    function Nova($tipo) { [Activator]::CreateInstance($asm.GetType("Projeto_Matemática.$tipo")) }

    # Abre a tela no meio do monitor, preenche o exemplo e fotografa a tela como ela aparece de verdade
    function Foto($tipo, $arquivo, [scriptblock]$preparar) {
        $f = Nova $tipo
        $f.StartPosition = 'CenterScreen'; $f.TopMost = $true; $f.ShowInTaskbar = $false
        $f.Show(); $f.Activate(); [System.Windows.Forms.Application]::DoEvents()
        if ($preparar) { & $preparar $f; [System.Windows.Forms.Application]::DoEvents() }
        $f.Refresh(); Start-Sleep -Milliseconds 700; [System.Windows.Forms.Application]::DoEvents()
        $b = $f.Bounds
        $bmp = New-Object Drawing.Bitmap($b.Width, $b.Height)
        $g = [Drawing.Graphics]::FromImage($bmp)
        $g.CopyFromScreen($b.X, $b.Y, 0, 0, $b.Size)
        $g.Dispose()
        $bmp.Save((Join-Path $saida $arquivo), [Drawing.Imaging.ImageFormat]::Png)
        $bmp.Dispose(); $f.Hide(); $f.Dispose()
        Write-Host "  ok  $arquivo" -ForegroundColor Green
    }

    # Simula a tecla Enter num campo (chama o mesmo código que roda quando a pessoa aperta Enter)
    function Enter($form, $campo, $metodo) {
        $m = $form.GetType().GetMethod($metodo, [Reflection.BindingFlags]'NonPublic,Public,Instance')
        $argumentos = [object[]]::new(2)
        $argumentos[0] = (C $form $campo)
        $argumentos[1] = [System.Windows.Forms.KeyPressEventArgs]::new([char]13)
        [void]$m.Invoke($form, $argumentos)
        $tb = (C $form $campo); $tb.Select($tb.Text.Length, 0); $form.ActiveControl = $null; $tb.Refresh()
    }

    Foto 'Frm_Abertura'   '00-abertura.png'                 { param($f) ($f.GetType().GetField('Timer_Abertura','NonPublic,Instance').GetValue($f)).Stop() }
    Foto 'Frm_Acesso'     '01-menu.png'                     $null
    Foto 'Frm_Operacao'   '02-operacoes-aritmeticas.png'    { param($f) (C $f 'Txt_Numero1').Text = '12'; (C $f 'Txt_Numero2').Text = '4'
                                                              foreach ($b in 'Btn_Adicao','Btn_Subtracao','Btn_Multiplicacao','Btn_Divisao') { (C $f $b).PerformClick() } }
    Foto 'Frm_Par'        '03-par-ou-impar.png'             { param($f) (C $f 'Txt_Numeral').Text = '28'; Enter $f 'Txt_Numeral' 'Txt_Numeral_KeyPress' }
    Foto 'Frm_Positivo'   '04-positivo-negativo-neutro.png' { param($f) (C $f 'Txt_Numero').Text = '-7'; Enter $f 'Txt_Numero' 'Txt_Numero_KeyPress' }
    Foto 'Frm_Dobro'      '05-dobro.png'                    { param($f) (C $f 'Txt_Dobro').Text = '25'; Enter $f 'Txt_Dobro' 'Txt_Numero_KeyPress' }
    Foto 'Frm_Antecessor' '06-antecessor-e-sucessor.png'    { param($f) (C $f 'Txt_Inteiro').Text = '10'
                                                              foreach ($b in 'Btn_Antecessor','Btn_Sucessor','Btn_Lixeira') { (C $f $b).Visible = $true }
                                                              (C $f 'Btn_Antecessor').PerformClick(); (C $f 'Btn_Sucessor').PerformClick() }
    Foto 'Frm_Maior'      '07-maior-ou-menor.png'           { param($f) (C $f 'Txt_Primeiro').Text = '15'; (C $f 'Txt_Segundo').Text = '9'; Enter $f 'Txt_Segundo' 'Txt_Segundo_KeyPress' }
    Foto 'Frm_Igual'      '08-igual-ou-diferente.png'       { param($f) (C $f 'Txt_Primeiro').Text = '8'; (C $f 'Txt_Segundo').Text = '5'; Enter $f 'Txt_Segundo' 'Txt_Segundo_KeyPress' }

    Write-Host ''
    Write-Host "PRONTO! Prints salvos em: $saida" -ForegroundColor Green
    Write-Host 'Pode avisar o Claude.' -ForegroundColor Green
}
catch {
    Write-Host ''
    Write-Host "Deu erro: $($_.Exception.Message)" -ForegroundColor Red
    Write-Host $_.InvocationInfo.PositionMessage -ForegroundColor DarkGray
    Write-Host 'Tire uma foto desta tela e mande para o Claude.' -ForegroundColor Red
}
Stop-Transcript | Out-Null
Read-Host 'Aperte Enter para fechar'
