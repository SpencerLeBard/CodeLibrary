using System;
using CodeLibrary.Services;

namespace CodeLibrary.Controllers
{
  class LibraryController
  {
    private bool _running { get; set; }
    private LibraryService _service { get; set; }
    public void Run()
    {
      while (_running)
      {
        getUserInput();
      }
    }


    private void GetUserInput()
    {
      Console.WriteLine("Options:\nAdd,Info,Checkout Return");
      string input = Console.ReadLine().ToLower();
      switch (input)
      {
        case "add":
          Add();
          break;
        case "info":
          Read();
          break;
        case "checkout":
          Checkout();
          break;
        case "returnbook":
          ReturnBook();
          break;
        case "delete":
          Delete();
          break;
        case "quit":
          _running = false;
          break;
        default:
          Console.WriteLine("You Are Invalid");
          break;
      }
    }

    private void Delete()
    {
      throw new NotImplementedException();
    }

    private void getUserInput()
    {
      throw new NotImplementedException();
    }
    private void ReturnBook()
    {
      throw new NotImplementedException();
    }

    private void Checkout()
    {
      string selectionStr = Console.ReadLine();
      if (int.TryParse(selectionStr, out int selection) && selection > 0)
      {
        Console.WriteLine("Success!");
      }
      Console.WriteLine("Invalid Number: Selection must be a number greater than 0");
    }

    private void Read()
    {
      throw new NotImplementedException();
    }

    void Add()
    {
      _service.Add()
  }
  }
}