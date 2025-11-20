namespace DocumentApprovalWorkflow;

// public class Document
// {
//     public string Status { get; set; } = "Draft";

//     public string Submit()
//     {
//         if (Status == "Draft")
//         {
//             Status = "Submitted";
//             return "Document submitted.";
//         }
//         else if (Status == "Submitted")
//         {
//             return "Already submitted.";
//         }
//         else if (Status == "UnderReview" || Status == "Approved")
//         {
//             return "Cannot submit now.";
//         }
//         else if (Status == "Rejected")
//         {
//             Status = "Submitted";
//             return "Resubmitted after rejection.";
//         }
//         else if (Status == "Archived")
//         {
//             return "Document archived. Can't submit.";
//         }
//         else
//         {
//             return "Invalid state.";
//         }
//     }

//     public string Review()
//     {
//         if (Status == "Submitted")
//         {
//             Status = "UnderReview";
//             return "Document under review.";
//         }
//         else if (Status == "UnderReview")
//         {
//             return "Already under review.";
//         }
//         else
//         {
//             return "Cannot review.";
//         }
//     }

//     public string Approve()
//     {
//         if (Status == "UnderReview")
//         {
//             Status = "Approved";
//             return "Document approved.";
//         }
//         else
//         {
//             return "Cannot approve.";
//         }
//     }

//     public string Reject()
//     {
//         if (Status == "UnderReview")
//         {
//             Status = "Rejected";
//             return "Document rejected.";
//         }
//         else
//         {
//             return "Cannot reject.";
//         }
//     }

//     public string Archive()
//     {
//         if (Status == "Approved" || Status == "Rejected")
//         {
//             Status = "Archived";
//             return "Document archived.";
//         }
//         else
//         {
//             return "Cannot archive.";
//         }
//     }
// }
