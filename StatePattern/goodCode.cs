namespace StatePattern;

public interface IOrderState
{
    public string Next(Order order);
    public string Cancel(Order order);
}

public class Order
{
    public IOrderState State { get; set; }
    public Order()
    {
        State = new DraftOrderState();
    }
    public string Next()
    {
        return State.Next(this);
    }
    public string Cancel()
    {
        return State.Cancel(this);
    }
}

public class DraftOrderState: IOrderState
{
    public string Next(Order order)
    {
        order.State = new PendingOrderState();
        return "Order moved to Pending.";
    }
    public string Cancel(Order order)
    {
        return "Order canceled successfully.";
    }
}

public class PendingOrderState: IOrderState
{
    public string Next(Order order)
    {
        order.State = new ProcessingOrderState();
        return "Order has been shipped.";
    }
    public string Cancel(Order order)
    {
        return "Order canceled successfully.";
    }
}

public class ProcessingOrderState: IOrderState
{
    public string Next(Order order)
    {
        order.State = new ShippedOrderState();
        return "Order has been shipped.";
    }
    public string Cancel(Order order)
    {
        return "Order canceled successfully.";
    }
}

public class ShippedOrderState: IOrderState
{
    public string Next(Order order)
    {
        order.State = new DeliveredOrderState();
        return "Order delivered successfully.";
    }
    public string Cancel(Order order)
    {
        return "Order canceled successfully.";
    }
}

public class DeliveredOrderState: IOrderState
{
    public string Next(Order order)
    {
        order.State = new CanceledOrderState();
        return "Order is already completed.";
    }
    public string Cancel(Order order)
    {
        return "Delivered orders cannot be canceled.";
    }
}

public class CanceledOrderState: IOrderState
{
    public string Next(Order order)
    {
        return "Order was canceled. No next state.";
    }
    public string Cancel(Order order)
    {
        return "Order already canceled.";
    }
}