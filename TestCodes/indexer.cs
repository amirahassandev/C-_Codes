namespace TestCodes;

public class Book
{
    public int id { get; set; }
    public string title { get; set; }
    public string authour { get; set; }
}

public class BookCollection
{
    private Book[] books = new Book[5];

    public Book this[int index]
    {
        get
        {
            return books[index];
        }
        set
        {
            books[index] = value;
        }
    }
    public Book this[string title]
    {
        get
        {
            foreach (var book in books)
            {
                if (book != null && book.title == title)
                {
                    return book;
                }
            }
            return null;
        }
        set
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i]?.title == title)
                {
                    books[i] = value;
                    return;
                }
                
            }

            throw new InvalidOperationException("Book not found");
        }

    }

}