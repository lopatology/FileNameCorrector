// See https://aka.ms/new-console-template for more information
public class FilesSourceLocation
{
    /// <summary>
    /// Source files directory path
    /// </summary>
    private string m_strFilesSourceLocationPath;

    /// <summary>
    /// C-tor
    /// </summary>
    /// <param name="strFilesSourceLocationPath">Source files directory path</param>
    public FilesSourceLocation(string strFilesSourceLocationPath)
    {
        m_strFilesSourceLocationPath = strFilesSourceLocationPath;
    }



    /// <summary>
    /// Get files metadata list. When directory is incorrect or empty returns empty list.
    /// </summary>
    /// <returns>Files metadata list</returns>
    /// <exception cref="FileLoadException"></exception>
    public List<FileMetadata> GetMetaDataList()
    {
        DirectoryInfo directory = new DirectoryInfo(m_strFilesSourceLocationPath);

        if (!directory.Exists)
        {
            throw new FileLoadException("Wrong directory location", m_strFilesSourceLocationPath);
        }

        FileInfo[] filesCollection = directory.GetFiles();
        int filesCount = filesCollection.Count();
        if (filesCount == 0)
        {
            throw new FileNotFoundException($"Directory {m_strFilesSourceLocationPath} contains no files.");
        }

        System.Console.WriteLine($"{filesCount} files contains in folder {m_strFilesSourceLocationPath}");

        List<FileMetadata> fileMetadataList = new List<FileMetadata>();

        foreach (FileInfo fileInfo in filesCollection)
        {
            FileMetadata fm = new FileMetadata();
            // TODO KŁ: consider extention metod witch adds element when its value is not null  
            fm.ListOfDates.AddWhenNotNullOrEmpty(fileInfo.CreationTime);

            fm.ListOfDates.Add(fileInfo.CreationTime);
            fm.ListOfDates.Add(fileInfo.CreationTimeUtc);
            fm.ListOfDates.Add(fileInfo.LastWriteTime);
            fm.ListOfDates.Add(fileInfo.LastWriteTimeUtc);

            fm.CreationTime = fileInfo.CreationTime;
            fm.CreationTimeUtc = fileInfo.CreationTimeUtc;
            fm.LastWriteTime = fileInfo.LastWriteTime;
            fm.LastWriteTimeUtc = fileInfo.LastWriteTimeUtc;
            fm.Name = fileInfo.Name;
            fm.FilePath = fileInfo.FullName;

            fileMetadataList.Add(fm);
        }
        System.Console.WriteLine($"Complete! {fileMetadataList.Count()} metadata files read.");
        return fileMetadataList;
    }
}