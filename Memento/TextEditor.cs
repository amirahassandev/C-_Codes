namespace Memento;

public class TextEditor
{
    public string content;
    public string Content
    {
        get
        {
            if(content == null)
            {
                return "No History";
            }
            return content;
        }
        set
        {
            content = value;
        }
    }

    public Memento SaveMemento()
    {
        return new Memento(Content); // Snapshot
    }

    public void RestoreMemento(Memento memento)
    {
        Content = memento.GetContent();
    }
}

public class Memento
{
    private string Content {get;}
    public Memento(string content)
    {
        Content = content;
    }

    public string GetContent()
    {
        return Content;
    }

}

public class History // CareTaker
{
    public List<Memento> _history = new();
    public Stack<Memento> _historyExecute = new();
    public int AddMemento(Memento memento)
    {
        _history.Add(memento);
        _historyExecute.Push(memento);
        // System.Console.WriteLine($"Memento Index: {_history.Count - 1}");
        return _history.Count - 1;
    }

    public Memento GetMemento(int index) // Undo
    {
        if(index <= _history.Count - 1 && index > -1)
        {
            return _history[index];
        }
        return null;
    }

    public void Undo(TextEditor txt)
    {
        if (_historyExecute == null || _historyExecute.Count == 0)
        {
            txt.Content = "No history";
            return;
        }
        
        txt.Content = _historyExecute.Pop().GetContent();
    }
}