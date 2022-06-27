// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string str_ftl = @"C:\Users\k\Desktop\test";



FilesSourceLocation filesSourceLocation = new FilesSourceLocation(str_ftl);
List<FileMetadata> metadataList = filesSourceLocation.GetMetaDataList();

System.Console.WriteLine("Hello");
// MetadataAnalizer metadataAnalizer = new MetadataAnalizer();
// metadataAnalizer.LoadMedadataList(metadataList);
// metadataAnalizer.AnalizeData();
// Dictionary<string, string> fileNamesDictionary = metadataAnalizer.CreateNewFileNamesDictionary();


// TargetFiles targetFiles = new TargetFiles();
// targetFiles.CreateDictionary();
// targetFiles.CreateBaseOn(fileNamesDictionary);



