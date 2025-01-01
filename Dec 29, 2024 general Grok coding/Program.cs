using System;
// 1. CLASS DECLARATION:
public class Book
/*
 *Recall that a class is a user-defined template that defines structure, behaviour and attributes of objects
 *So here we have created a class called book
 */
{ 
    // 2. THE BELOW LINE IS A PROPERTY
    /*
     * Public: Lets the property be assessed from any code in any part of the program
     * String: Declaring the data type of the property (string = holds values)
     * Title: Name of the property. In this case we are literally calling it Title 
     * Get: Predefined "accessor". This is a read operation and will return the value of the property. In this case Title will be "fetched"
     * Set: Predefined "accessor"/ This is a write operation and will allow for the changing of the Title property 
     * BASIC VERSION COMMENTED OUT AND DETAILED VERSION PRESENTED 
     */
    //public string Title { get; set; }
    
    private string _title; // using the underscore here as common C# convenstion to distinguish this field from the public property 
    //  CRITICAL TO NOTE THAT THE ACTUAL DATA WILL BE STORED IN THE ABOVE = THIS IS WHAT GETS STORED TO / USED 
    public string Title
    {
        get
        { 
            return _title;
        }
        set
        {
            _title = value;
        }
    }
    public string Author { get; set; }
    public int Year { get; set; }
    /* Constructor
     * The below is a constructor, a special kind of method
     * It initialzies the properties of the book object
     */
    public Book(string title, string author, int year)
    { 
        Title = title;
        Author = author;
        Year = year;
    }
    // Method to display book into
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Year: {Year}"); // You need to get clear on the need to use capitals and why 
    
    }

}
class Program
{
    static void Main()
    {
        // Creation of an array of Book objects
        /*
         * ANALOGY FOR THE BELOW
         * 1. Book is a class that is a blueprint for creating a book
         * 2. The constructor above is the "recipe" for creating a book and we need author, title and year
         * 3. Declaring Book[] books is saying " I will have a bookshelf where I can put  several (3) book objects I made from the recipe above
         */
        Book[] books = new Book[3];
        books[0] = new Book("1984", "George Orwell", 1949); // NOTE THE FORMAT = flows from constructor above
        books[1] = new Book("To Kill a Mockingbird", "Harper Lee", 1960);
        books[2] = new Book("the Great Gatsby", "F. Scott Fitzherald", 1925);

        // display books 
        // TWO WAYS - the first below was from Grok and the second it a more "traditional" way to do it 
        Console.WriteLine("All Books:");
        foreach (Book book in books)
        {
            book.DisplayInfo(); // UNDERSTAND THIS IS A SEPERATE FROM ABOVE AND A SECOND COMMAND TO PRINT TO THE CONSOLE 
        }
        //for (int i = 0; i < books.Length; i++)
        //{ 
        //    Book book = books[i];   
        //    book.DisplayInfo();
        //}
        // Find and display oldest book
        Book oldestBook = books[0];
        Book newestBook = books[0];
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i].Year < oldestBook.Year)
            { 
                oldestBook = books[i];  
            }
            if (books[i].Year > newestBook.Year)
            { 
                newestBook = books[i];
            }
        }
        Console.WriteLine("\nThe oldest book in the collection is: ");
        oldestBook.DisplayInfo();
        Console.WriteLine("\nThe newest book in the collection is: ");
        newestBook.DisplayInfo();


    }



}



