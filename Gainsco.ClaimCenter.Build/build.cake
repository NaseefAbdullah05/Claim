#load CakeFiles\paths.cake
#load CakeFiles\settings.cake

//#tool "nuget:?package=xunit.runner.console&version=2.4.1"
#tool "nuget:?package=NUnit.ConsoleRunner&version=3.10.0"
///////////////////////////////////////////////////////////////////////////////
// ARGUMENTS
///////////////////////////////////////////////////////////////////////////////

var target = Argument("target", "Package");
var packageVersion = Argument("packageVersion", "1.0.0.0");
var configuration = Argument("configuration", Settings.BuildConfiguration);

///////////////////////////////////////////////////////////////////////////////
// SETUP / TEARDOWN
///////////////////////////////////////////////////////////////////////////////

Setup(ctx =>
{
	// Executed BEFORE the first task.
	Information("Running tasks...");
});

Teardown(ctx =>
{
	// Executed AFTER the last task.
	Information("Finished running tasks.");
});

///////////////////////////////////////////////////////////////////////////////
// TASKS
///////////////////////////////////////////////////////////////////////////////

Task("Clean")
    .Does(() =>
    {		
		Information("Cleanup!!! old artifacts");

		if (DirectoryExists(Paths.ArtifactDirectory))
		{
			//Deletes the specified directory
			DeleteDirectory(Paths.ArtifactDirectory,  new DeleteDirectorySettings {
															Recursive = true,
															Force = true});
		}

		if (DirectoryExists(Paths.BuildDirectory))
		{
			DeleteDirectory(Paths.BuildDirectory,  new DeleteDirectorySettings {
															Recursive = true,
															Force = true});
		}

		if (DirectoryExists(Paths.TestResultsDirectory))
		{
			DeleteDirectory(Paths.TestResultsDirectory,  new DeleteDirectorySettings {
															Recursive = true,
															Force = true});
		}
    });

Task("Restore")
	.IsDependentOn("Clean")
	.Does(() => {
		Information("Restore!!!! NuGet packages using the specified settings");

		NuGetRestore(Paths.SolutionFile, new NuGetRestoreSettings { NoCache = true });
	})
	.ReportError(exception =>
	{  
		Information("Exception during Restore!!!! Calling Cake DotNetCoreRestore command for solution: " + Paths.SolutionFile);

		Information("Exception Message: " + exception.Message.ToString());
		Information("Exception Inner Exception: " + exception.ToString());	
		Information("Exception StackTrace: " + exception.StackTrace.ToString());	
	});

Task("Build")
    .IsDependentOn("Restore")
    .Does(() => {
	 Information("Build the solution using MSBuild");
	
	
	MSBuild("..\\Gainsco.ClaimCenter.CodedUITests.Framework\\Gainsco.ClaimCenter.CodedUITests.Framework.csproj", Settings.MSBuildSettings);
	MSBuild("..\\Gainsco.ClaimCenter.CodedUITests\\Gainsco.ClaimCenter.CodedUITests.csproj", Settings.TestMSBuildSettings);
});	

//TODO: copy test runner to test directory so it can be run against test dll
// nunit3-console.exe Gainsco.ClaimCenter.CodedUITests.dll 
Task("Copy Test Runner")
    .IsDependentOn("Build")
    .Does(() => {
	 Information("Copy Test Runner To Test Results Directory!!!!");

	 if (!DirectoryExists(Paths.TestResultsDirectory)) 
		{
			CreateDirectory(Paths.TestResultsDirectory);
		}	
		//copies a directory to a specified location
		CopyDirectory("tools\\NUnit.ConsoleRunner.3.10.0\\tools", Paths.TestResultsDirectory);
	
});	

Task("Package")
    .IsDependentOn("Copy Test Runner")
    .Does(() => {
		Information("Package! generated artifacts");
		if (!DirectoryExists(Paths.ArtifactDirectory))
		{
			//creates the specified directory
			CreateDirectory(Paths.ArtifactDirectory);
			
		}
		//Zips the specified directory
		Zip(Paths.TestResultsDirectory, Paths.ArtifactDirectory + "\\Gainsco.ClaimCenter." + packageVersion + ".zip");

    });


RunTarget(target);