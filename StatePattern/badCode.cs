// namespace StatePattern;

// public class Order
// {
//     public string Status { get; set; } = "Pending";

//     public string Next()
//     {
//         if (Status == "Pending")
//         {
//             Status = "Processing";
//             return "Order is now being processed.";
//         }
//         else if (Status == "Processing")
//         {
//             Status = "Shipped";
//             return "Order has been shipped.";
//         }
//         else if (Status == "Shipped")
//         {
//             Status = "Delivered";
//             return "Order delivered successfully.";
//         }
//         else if (Status == "Delivered")
//         {
//             return "Order is already completed.";
//         }
//         else if (Status == "Canceled")
//         {
//             return "Order was canceled. No next state.";
//         }
//         else
//         {
//             return "Unknown state!";
//         }
//     }

//     public string Cancel()
//     {
//         if (Status == "Delivered")
//         {
//             return "Delivered orders cannot be canceled.";
//         }
//         else if (Status == "Canceled")
//         {
//             return "Order already canceled.";
//         }
//         else
//         {
//             Status = "Canceled";
//             return "Order canceled successfully.";
//         }
//     }
// }
