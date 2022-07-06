internal class MetadataAnalizer
{
    List<FileMetadata> m_fileMetadataList;

    public MetadataAnalizer(List<FileMetadata> fileMetadataList)
    {
        m_fileMetadataList = fileMetadataList;
    }

    private string CreateBestNameForNewFile(FileMetadata fileMetadata)
    {
        string strNewFileNameProposal = string.Empty;

        // if(fileMetadata.CreationTime)
        // if(fileMetadata.CreationTimeUtc)
        // if(fileMetadata.LastWriteTime)
        // if(fileMetadata.LastWriteTimeUtc)
        // fileMetadata.Name

        return strNewFileNameProposal;
    }

    public List<OutputFileInfo> AnalizeAndCreateNewFileNamesList()
    {
        List<OutputFileInfo> resultFileInfoList = new List<OutputFileInfo>();

        foreach (FileMetadata fileMetadata in m_fileMetadataList)
        {
            OutputFileInfo fileInfo = new OutputFileInfo();
            fileInfo.NewFileNameProposal = CreateBestNameForNewFile(fileMetadata);
            fileInfo.OryginalFilePath = fileMetadata.FilePath;

            resultFileInfoList.Add(fileInfo);
        }
        return resultFileInfoList;
    }
}