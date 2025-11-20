namespace DocumentApprovalWorkflow;

// public interface IDocumentState
// {
//     public string Submit(Document document);
//     public string Review(Document document);
//     public string Approve(Document document);
//     public string Reject(Document document);
//     public string Archive(Document document);
// }

public abstract class DocumentState
{
    public abstract string Submit(Document document);
    public virtual string Review(Document document)
    {
        return "Cannot review.";
    }
    public virtual string Approve(Document document)
    {
        return "Cannot approve.";
    }
    public virtual string Reject(Document document)
    {
        return "Cannot reject.";
    }
    public virtual string Archive(Document document)
    {
        return "Cannot archive.";
    }
}

public class Document
{
    public DocumentState State { get; set; }
    public Document()
    {
        State = new DraftDocumentState();
    }
    public string Submit()
    {
        return State.Submit(this);
    }
    public string Review()
    {
        return State.Review(this);
    }
    public string Approve()
    {
        return State.Approve(this);
    }
    public string Reject()
    {
        return State.Reject(this);
    }
    public string Archive()
    {
        return State.Archive(this);
    }
}

public class DraftDocumentState: DocumentState
{
    public override string Submit(Document document)
    {
        document.State = new SubmittedDocumentState();
        return "Document submitted.";
    }
    // public string Review(Document document);
    // public string Approve(Document document);
    // public string Reject(Document document);
    // public string Archive(Document document);
}

public class SubmittedDocumentState: DocumentState
{
    public override string Submit(Document document)
    {
        return "Already submitted.";
    }
    public override string Review(Document document)
    {
        document.State = new UnderReviewDocumentState();
        return "Document under review.";
    }
    // public string Approve(Document document);
    // public string Reject(Document document);
    // public string Archive(Document document); 
}

public class UnderReviewDocumentState: DocumentState
{
    public override string Submit(Document document)
    {
        return "Cannot submit now.";
    }
    public override string Review(Document document)
    {
        return "Already under review.";
    }
    public override string Approve(Document document)
    {
        document.State = new ApprovedDocumentState();
        return "Document approved.";
    }
    public override string Reject(Document document)
    {
        document.State = new RejectedDocumentState();
        return "Document rejected.";
    }
    // public string Archive(Document document); 
}

public class ApprovedDocumentState: DocumentState
{
    public override string Submit(Document document)
    {
        return "Cannot submit now.";
    }
    // public string Review(Document document);
    // public string Approve(Document document);
    // public string Reject(Document document);
    public override string Archive(Document document)
    {
        document.State = new ArchivedDocumentState();
        return "Document archived.";
    }   
}

public class RejectedDocumentState: DocumentState
{
    public  override string Submit(Document document)
    {
        document.State = new SubmittedDocumentState();
        return "Resubmitted after rejection.";
    }
    // public string Review(Document document);
    // public string Approve(Document document);
    // public string Reject(Document document);
    public override string Archive(Document document)
    {
        document.State = new ArchivedDocumentState();
        return "Document archived.";
    }  
}

public class ArchivedDocumentState: DocumentState
{
    public override string Submit(Document document)
    {
        return "Document archived. Can't submit.";
    }
    // public string Review(Document document);
    // public string Approve(Document document);
    // public string Reject(Document document);
    // public string Archive(Document document);  
}