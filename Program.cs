string str_ftl = @"C:\Users\k\Desktop\test";

System.Console.WriteLine("Read files list");
FilesSourceLocation filesSourceLocation = new FilesSourceLocation(str_ftl);
List<FileMetadata> metadataList = filesSourceLocation.GetMetaDataList();

System.Console.WriteLine("Analize metadata");
MetadataAnalizer metadataAnalizer = new MetadataAnalizer(metadataList);
List<OutputFileInfo> fileInfoList = metadataAnalizer.AnalizeAndCreateNewFileNamesList();

System.Console.WriteLine("Creating new file base on oryginal file");
TargetFiles targetFiles = new TargetFiles(fileInfoList);
targetFiles.Create();