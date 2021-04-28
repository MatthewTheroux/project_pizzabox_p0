// [I]. HEAD
//  A] Libraries
using System;
using System.Collections.Generic;
using System.IO;

using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Stores;

/// 
namespace PizzaBox.Client.Singletons
{
  /// A store picker.
  public class StoreSingleton : AnEntitySingleton
  {
    //  B] Fields and Properties
    //   1. static
    //public static StoreSingleton SingularInstance;

    private const string XML_FILEPATH = @"data/stores.xml";

    public List<string> storeChoices = new List<string>();
    // 2. 
    private int indexSelected = -1; // ='unselected"

    private string storeSelected = "no store selected";


    // [II]. BODY
    public StoreSingleton()
    {
      // <!!!> circular reference
      // if (_singularInstance == null)
      // {
      //   _singularInstance = new StoreSingleton();
      // }
    }

    // Read the choices for this datatype.
    private void ReadChoicesIntoTheList()
    {
      //choicesOfTheSingleton.Add("No choices."); // [0]
      try
      {
        StreamReader reader = new StreamReader(XML_FILEPATH);
        //read
      }
      catch (IOException readFail)
      {
        readFail.ToString();
      }
      finally { } //close
    }// /md 'Read..'


    /// Display the selection choices on to the screen.
    public void DisplayTheChoicesOnToTheScreen()
    {
      System.Console.WriteLine("Please select a store from the following choices: ");
      int _counter = -1; // 'UNPOPULATED'
      foreach (string _item in storeChoices)
      {
        ++_counter;
        System.Console.WriteLine(_counter + ": " + _item);
      }
      System.Console.WriteLine();

    }// /md 'Display..'

    public int RetrieveTheUserSelectionOfChoices()
    {
      //  a) head
      //int _selectedChoice_int = -1;
      string _userInput_str = "";
      bool _isValidSelection = false;

      //  b) body
      while (!_isValidSelection)
      {
        _userInput_str = System.Console.ReadLine();
        //isValidSelection = int.TryParse(_userInput_str, out _selectedChoice_int);
        _isValidSelection = int.TryParse(_userInput_str, out indexSelected);
      }

      //  c) foot
      //return _selectedChoice_int;
      return indexSelected;
    }// /md --choose


    private void GetTheStore()
    {
      storeSelected = storeChoices[indexSelected];
      System.Console.WriteLine($"You picked {storeSelected}.\n");
    }

    // [III]. FOOT
    /// The string representation
    public override string ToString()
    {
      return storeSelected;
    }
  }
}