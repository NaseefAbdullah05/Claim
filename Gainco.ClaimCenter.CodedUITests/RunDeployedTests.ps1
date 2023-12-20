$mainDirectory = $(Get-Item $($MyInvocation.MyCommand.Path)).DirectoryName
$NUnitConsoleExe = "$mainDirectory\nunit3-console.exe"
$ReportUnitExe = "$mainDirectory\ReportUnit.exe"

&$NUnitConsoleExe Gainsco.ClaimCenter.CodedUITests.dll

&$ReportUnitExe "TestResult.xml"