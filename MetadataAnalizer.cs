internal class MetadataAnalizer
{
    List<FileMetadata> m_fileMetadataList;

    public MetadataAnalizer(List<FileMetadata> fileMetadataList)
    {
        m_fileMetadataList = fileMetadataList;
    }

    private string AnalizeAndPrepareFileNameProposal(FileMetadata fileMetadata)
    {
        string strNewFileNameProposal = string.Empty;
        // if(fileMetadata.CreationTime)
        // if(fileMetadata.CreationTimeUtc)
        // if(fileMetadata.LastWriteTime)
        // if(fileMetadata.LastWriteTimeUtc)
        // fileMetadata.Name

        return strNewFileNameProposal;
    }

    public List<FileInfo> AnalizeAndCreateNewFileNamesList()
    {
        List<FileInfo> resultFileInfoList = new List<FileInfo>();

        foreach (FileMetadata fileMetadata in m_fileMetadataList)
        {
            FileInfo fileInfo = new FileInfo();
            fileInfo.NewFileNameProposal = AnalizeAndPrepareFileNameProposal(fileMetadata);
            fileInfo.OryginalFilePath = fileMetadata.FilePath;

            resultFileInfoList.Add(fileInfo);
        }
        return resultFileInfoList;
    }
}