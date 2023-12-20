#load paths.cake

public static class Settings
{
	public static readonly string BuildConfiguration = "Release";

	public static readonly MSBuildSettings MSBuildSettings = new MSBuildSettings().WithProperty("OutDir", Paths.BuildDirectory);
	public static readonly MSBuildSettings TestMSBuildSettings = new MSBuildSettings().WithProperty("OutDir", Paths.TestResultsDirectory);
	//public static readonly DotNetBuildSettings BuildSettings = new DotNetBuildSettings
    //{
   //      Configuration = BuildConfiguration,
   //      OutputDirectory = Paths.BuildDirectory,
         //Verbosity = DotNetCoreVerbosity.Diagnostic
         //Verbosity = DotNetCoreVerbosity.Detailed
         //Verbosity = DotNetCoreVerbosity.Normal
         //Verbosity = DotNetCoreVerbosity.Minimal
     //    Verbosity = DotNetCoreVerbosity.Quiet
     //};

	
}