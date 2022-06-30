using Xunit;

namespace Tests.FileNameCorrector;

public class FilesSourceLocationTests
{
    [Fact]
    public void EmptyLocationPathShouldThrowException()
    {
        FilesSourceLocation fsl = new FilesSourceLocation(LocalPath.Empty);
        fsl.GetMetaDataList();
        
    }
}

    public enum LocalPath
    {
        Empty = string.Empty,
        Correct = "CorrectPath",
        Incorrect = "IncorrectPath"
    }