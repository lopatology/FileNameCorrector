using Xunit;
using System.IO;

namespace Tests.FileNameCorrector;

public class FilesSourceLocationTests
{
    [Fact]
    public void EmptyLocationPathShouldThrowException()
    {
        FilesSourceLocation fsl = new FilesSourceLocation(string.Empty);
        Assert.Throws<FileLoadException>(() => fsl.GetMetaDataList());
    }
}
