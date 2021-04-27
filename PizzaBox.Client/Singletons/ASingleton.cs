// // [I]. HEAD
//  A] usings
using System;
//using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.IO;

using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;


/// 
namespace PizzaBox.Client.Singletons
{
  /// Select ONE of 'an Object<T>' as an integer from all available choices.
  public class ASingleton //abstract
  {
    //  B] fields and properties
    ///
    private Type SingletonType; //<T>
    public static ASingleton singularInstance
    {
      get
      {
        if (singularInstance == null) { singularInstance = new ASingleton(); }
        return singularInstance;
      }
      private set { singularInstance = value; }
    }


    ///
    protected string headerMessage = "Select a choice from the list.";

    ///
    protected string filepath = "filepath unset";

    ///
    protected List<string> choicesOfTheSingleton
      = new List<string>();




    //     // [II]. BODY
    //     /// Read the choices for this datatype.
    //     private void ReadChoicesIntoTheList()
    //     {
    //       choicesOfTheSingleton.Add("No choices."); // [0]
    //       try
    //       {
    //         StreamReader reader = new StreamReader(filepath);
    //         //read
    //       }
    //       catch (IOException readFail)
    //       {
    //         readFail.ToString();
    //       }
    //       finally { }
    //     }// /md 'Read..'


    //     /// Display the selection choices on to the screen.
    //     public void DisplayTheChoicesOnToTheScreen()
    //     {
    //       int _counter = -1; // 'UNPOPULATED'
    //       foreach (string _item in choicesOfTheSingleton)
    //       {
    //         ++_counter;
    //         System.Console.WriteLine(_counter + ": " + _item);
    //       }
    //     }// /md 'Display..'

    //     public int RetrieveTheUserSelectionOfChoices()
    //     {
    //       //  a) head
    //       int _selectedChoice_int = -1;
    //       string _userInput_str = "";
    //       bool _isValidSelection = false;

    //       //  b) body
    //       while (!_isValidSelection)
    //       {
    //         _userInput_str = System.Console.ReadLine();
    //         _isValidSelection = int.TryParse(_userInput_str, out _selectedChoice_int);
    //       }

    //       //  c) foot
    //       return _selectedChoice_int;
    //     }// /md --choose
    //     //#endregion currently unfeasable

    public override string ToString()//; abstract
    {
      return "";
    }

  }// /cla
}// /ns