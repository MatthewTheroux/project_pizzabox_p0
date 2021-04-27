// [I]. HEAD
//  A] usings
using System;
using System.Collections.Generic;
using System.IO;

/// 
namespace PizzaBox.Client.Selectors
{
  /// Select ONE of 'an Object<T>' as an integer from all available choices.
  public abstract class ASelectable
  {
    //  B] fields and properties
    ///
    private Type SelectorType;//<T> where Type : class ;

    ///
    protected string headerMessage = "Select a choice from the list.";


    ///
    protected string xmlFilepath = "filepath unset";

    ///
    protected List<string> selectorChoices
      = new List<string>();


    private int indexOfChoiceInTheList = -1; // ='unchosen'

    // Instantiate a concrete child member.
    // public ASelectable()
    // {

    // }

    // [II]. BODY
    /// Read the choices for this datatype.
    protected bool ReadChoicesIntoTheList()
    {
      //  a) head
      bool didSucceed = false;
      //<!> verify path is to an xml file.

      selectorChoices.Add("No choices."); // [0]

      //  b) body
      try
      {
        StreamReader reader = new StreamReader(xmlFilepath);
        //read

        didSucceed = true;
      }
      catch (IOException readFail)
      {
        readFail.ToString();//<!>
      }

      //  c) foot
      finally { } //close

      return didSucceed;
    }// /md 'Read..'


    /// Display the selection choices on to the screen.
    public void DisplayTheChoicesOnToTheScreen()
    {
      int _counter = -1; // 'UNPOPULATED'
      foreach (string _item in selectorChoices)
      {
        ++_counter;
        System.Console.WriteLine(_counter + ": " + _item);
      }
    }// /md 'Display..'


    ///
    public int RetrieveTheUserChoiceSelection()
    {
      //  a) head
      //int _selectedChoice_index = -1; //'unchosen'
      string _userInput_str = "";
      bool isValidSelection = false;

      //  b) body
      while (!isValidSelection)
      {
        _userInput_str = System.Console.ReadLine();
        //isValidSelection = int.TryParse(_userInput_str, out _selectedChoice_index);
        isValidSelection = int.TryParse(_userInput_str, out indexOfChoiceInTheList);
      }

      //  c) foot
      //return _selectedChoice_index;
      return indexOfChoiceInTheList;
    }// /md --choose



    // [III]. FOOT
    ///
    public Object GetChoice() //use <T>
    {
      Object _object = null;
      try
      {
        _object = selectorChoices[indexOfChoiceInTheList];
      }
      catch (Exception e) //<!> specify
      {
        e.ToString();
      }
      return _object;
    }


    ///
    public abstract override string ToString();

  }// /cla 'A Selector'
}// /ns