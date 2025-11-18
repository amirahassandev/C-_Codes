using System.Collections;


namespace TestCodes;

public class PayItem
{
    public string Name { get; set; }
    public int Value { get; set; }
}

public class Employee : IEnumerable<PayItem>
{
    private readonly List<PayItem> _payItems = new();
    public string Name { get; set; }

    public void AddPayItem(string name, int value)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentNullException("name");
        }
        _payItems.Add(new PayItem{Name = name, Value = value});
    }

    // public IEnumerator<PayItem> GetEnumerator()
    // {
    //     Console.WriteLine("GetEnumerator");
    //     return _payItems.GetEnumerator();
    // }

    // public IEnumerator<PayItem> GetEnumerator()
    // {
    //     return new PayItemsEnumerator(_payItems);
    // }

    public IEnumerator<PayItem> GetEnumerator()
    {
        Console.WriteLine("GetEnumerator_Yield");

        foreach(var item in _payItems)
        {
            yield return item;
        }
    }

    

    // Explicit Casting
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    
}


// private class PayItemsEnumerator : IEnumerator<PayItem>
// {
//     private readonly List<PayItem> _payItems;
//     private int _currentIndex = -1;

//     public PayItemsEnumerator(List<PayItem> payItems)
//     {
//         _payItems = payItems ?? throw new ArgumentNullException(nameof(payItems));
//     }
//     public PayItem Current => _payItems[_currentIndex];

//     // Explicit Casting (Prefer Not Change) => Just It Call Implicit
//     object IEnumerator.Current => Current;

//     public void Dispose()
//     {
//         throw new NotImplementedException();
//     }

//     // Need : List and Index to Iteration
//     public bool MoveNext()
//     {
//         return _currentIndex++ < _payItems.Count;
//     }

//     public void Reset()
//     {
//         _currentIndex = -1;
//     }
// }

