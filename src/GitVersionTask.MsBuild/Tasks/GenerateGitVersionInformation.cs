using Microsoft.Build.Framework;

namespace GitVersion.MSBuildTask.Tasks
{
    public class GenerateGitVersionInformation : GitVersionTaskBase
    {
        [Required]
        public string ProjectFile { get; set; }

        [Required]
        public string IntermediateOutputPath { get; set; }

        [Required]
        public string Language { get; set; }

        [Output]
        public string GitVersionInformationFilePath { get; set; }

        public override bool Execute() => TaskProxy.GenerateGitVersionInformation(this);
    }
}
