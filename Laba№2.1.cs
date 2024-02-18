public class Document
{
    public string Name { get; set; }
    public string Author { get; set; }
    public string[] Keywords { get; set; }
    public string Subject { get; set; }
    public string FilePath { get; set; }

    public virtual string GetDocumentInfo()
    {
        return $"Name: {Name}\nAuthor: {Author}\nKeywords: {string.Join(", ", Keywords)}\nSubject: {Subject}\nFilePath: {FilePath}";
    }
}

public class WordDocument : Document
{
    public int PageCount { get; set; }

    public override string GetDocumentInfo()
    {
        return base.GetDocumentInfo() + $"\nPageCount: {PageCount}";
    }
}

public class PdfDocument : Document
{
    public int Version { get; set; }

    public override string GetDocumentInfo()
    {
        return base.GetDocumentInfo() + $"\nVersion: {Version}";
    }
}

public class ExcelDocument : Document
{
    public bool IsProtected { get; set; }

    public override string GetDocumentInfo()
    {
        return base.GetDocumentInfo() + $"\nIsProtected: {IsProtected}";
    }
}

public class TxtDocument : Document
{
    public int LineCount { get; set; }

    public override string GetDocumentInfo()
    {
        return base.GetDocumentInfo() + $"\nLineCount: {LineCount}";
    }
}

public class HtmlDocument : Document
{
    public bool HasImages { get; set; }

    public override string GetDocumentInfo()
    {
        return base.GetDocumentInfo() + $"\nHasImages: {HasImages}";
    }
}
