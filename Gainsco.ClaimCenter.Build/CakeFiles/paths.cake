public static class Paths
{
	public static readonly string SolutionFile = "..\\Gainsco.ClaimCenter.sln";	
			
	public static readonly string BuildDirectory = "..\\.build";
	public static readonly string TestResultsDirectory = "..\\.testResults";	
	public static readonly string ArtifactDirectory = "..\\.artifacts";

	//public static readonly string UnitTestProjectPath = TestResultsDirectory + "\\Gainsco.Policy.UnitTests.dll";

	public static readonly string PackageZipPath = ArtifactDirectory + "\\Gainsco.ClaimCenter.zip";

	public static readonly string AllFilesInBuildDirectory = BuildDirectory + "\\*.*";
	public static readonly string AllFilesInTestResultsDirectory = TestResultsDirectory + "\\*.*";
	public static readonly string AllFilesInArtifactDirectory = ArtifactDirectory + "\\*.*";	
	public static readonly string AllFilesAndFoldersInArtifactDirectory = ArtifactDirectory + "\\**";	
	public static readonly FilePath CodeCoverageResultsFile = TestResultsDirectory + "\\coverage.xml";
	
}