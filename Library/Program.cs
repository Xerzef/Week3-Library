class Book
{
    // Properties
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;

    // Constructer for Book object
    public Book(string bookTitle, string bookAuthor, string bookISBN, int bookNoOfPages)
        { 
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
        NoOfPages = bookNoOfPages;

       }



    void DisplayInfo()
    {
        // Output the book information to the console
        Console.WriteLine("Book information");
        Console.WriteLine("-----------------");
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine($"Book.No Of Pages: {NoOfPages}");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        // Create a new instance of the book class
        Book book = new Book("C# for beginners","Bill Gates","12345678",200);




        // output book info to console
        book.DisplayInfo();
       


    }    
}
