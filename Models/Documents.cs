namespace RazorPagesWebApp.Models;

public class Documents
{
    public string? DocTypes { get; set; }
    public int DocId { get; set; }
    public DateTime CreationDate { get; set; }
}

public class DocumentModel
{
   
    public string? DocumentUpload { get; set; }
}