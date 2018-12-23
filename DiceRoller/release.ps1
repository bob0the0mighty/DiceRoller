& "C:\Program Files (x86)\Windows Kits\10\bin\x86\signtool.exe" sign /tr http://timestamp.digicert.com /td sha256 /fd sha256 /a bin\Release\Dice.dll
D:\Programs\nuget.exe pack DiceRoller.nuspec
$vers = Get-ChildItem DiceRoller.*.nupkg | ForEach-Object { New-Object System.Version($_.Name.Substring(11, $_.Name.Length - 17)) } | Sort-Object -Descending
$pkg = "DiceRoller.$($vers[0].Major).$($vers[0].Minor).$($vers[0].Build).nupkg"
# Publish to NuGet; api key must be saved via nuget setApiKey beforehand
D:\Programs\nuget.exe sign $pkg -Timestamper http://timestamp.digicert.com -NonInteractive
D:\Programs\nuget.exe push $pkg -Source https://www.nuget.org
# Publish to GitHub (TODO: use github API for this)
Write-Output "Don't forget to cut a new release on GitHub!"