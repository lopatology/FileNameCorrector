// See https://aka.ms/new-console-template for more information
public class FileMetadata
{
    public List<DateTime> ListOfDates {get; internal set;} = new List<DateTime>();
    public DateTime CreationTime { get; internal set; }
    public DateTime CreationTimeUtc { get; internal set; }
    public DateTime LastWriteTime { get; internal set; }
    public DateTime LastWriteTimeUtc { get; internal set; }
    public string Name { get; internal set; } = string.Empty;
    public string FilePath { get; internal set; } = string.Empty;
}