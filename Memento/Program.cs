namespace Memento;

internal class program
{
    static void Main(String[] args)
    {
        TextEditor editor = new TextEditor(); // Orgenator
        History history = new History(); // CarTaker

        editor.Content = "Hello";
        int index = history.AddMemento(editor.SaveMemento());
        System.Console.WriteLine(index); // 0

        editor.Content = "Hello World";
        index = history.AddMemento(editor.SaveMemento());
        System.Console.WriteLine(index); // 1

        System.Console.WriteLine(history.GetMemento(0).GetContent()); // Hello 

        editor.RestoreMemento(history.GetMemento(0)); 
        System.Console.WriteLine(editor.Content); // Hello

        System.Console.WriteLine(history.GetMemento(1).GetContent()); // Hello World

        history.Undo(editor);
        Console.WriteLine(editor.Content); // → Hello World

        history.Undo(editor);
        Console.WriteLine(editor.Content); // → Hello

        history.Undo(editor);
        Console.WriteLine(editor.Content); // → No history

    }
}