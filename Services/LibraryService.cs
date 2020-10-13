using System;
using System.Collections.Generic;
using CodeLibrary.Models;

namespace CodeLibrary.Services
{

  class LibraryService
  {
    public List<Book> Books { get; set; }
    public string GetBooks(bool available)
    {
      string list = "";
      for (int i = 0; i < Books.Count; i++)
      {
        var book = Books[i];
        if (book.IsAvailable == available)
        {
          list += $"{i + 1}. {book.Title} - by {book.Author}\n";
        }
      }
      return list;
    }

    string Checkout(int selection)
    {
      var books = Books.FindAll(b => b.IsAvailable == true);
      if (selection <= books.Count)
      {
        books[selection].IsAvailable = false;
        return "Enjoy your book";
      }
      return "Invalid Input, please provide a number listed";
    }

    void ReturnBook()
    {
      Console.WriteLine(GetBooks(false));
    }

    void Add()
    {
      System.Console.Write("Title: ");
      string title = Console.ReadLine();
      System.Console.Write("Author: ");
      string author = Console.ReadLine();
      System.Console.Write("Description: ");
      string description = Console.ReadLine();
      Book newBook = new Book(title, author, description);
      _service.Add(newBook);
      System.Console.WriteLine($"Successfully added {title} to the collection");
    }
    void Delete()
    {
      Console.Write("Enter the Title you wish to remove: ");
      string title = Console.ReadLine().ToLower();
      int index = _service.FindIndexByTitle(title);
      if (index == -1)
      {
        Console.WriteLine("No Book by that Title");
        return;
      }
      Console.WriteLine("Type 'confirm' to remove book");
      string confirm = Console.ReadLine().ToLower();
      if (confirm != "confirm")
      {
        Console.WriteLine("Invalid input, book will not be deleted");
        return;
      }
      _service.Remove(index);
      Console.WriteLine("Successfully Removed Book");
    }
    public LibraryService()
    {
      Books = new List<Book>(){
          new Book("Twilight", "Stephanie Mayer", "supa gay")
        };
    }
  }
}