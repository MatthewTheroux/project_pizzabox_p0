// [I]. HEAD
//  A]
using System;

using PizzaBox.Domain.Abstracts;


namespace PizzaBox.Domain.Models.Components.Toppings
{
  public class PizzaToppingFruit : PizzaTopping
  {
    //  B]
    public enum Choice
    {
      PINEAPPLE = 1,

      MANDARIN_ORANGE,

      APPLE,

      CHERRY,


      UNSUPPORTED = 86
    }
    public Choice Selection { get; set; }


    // [II]. BODY
    /// direct constructor
    public PizzaToppingFruit(Choice _selection) { Selection = _selection; }

    /// index-based constructor
    public PizzaToppingFruit(int _n) { Selection = (Choice)_n; }

    /// blank constructor
    public PizzaToppingFruit() : this(1) { }


    /// string constructor
    public PizzaToppingFruit(string _selectionText)
    {
      //   a) head: Normalize the string input, somewhat.
      _selectionText = _selectionText.Replace(" ", "_");

      //  b) body: 
      Choice _selection = Choice.UNSUPPORTED;
      Enum.TryParse(_selectionText, true, out _selection);

      //  c) foot: 
      Selection = _selection;
    }

    // [III]. FOOT
    public override string ToString()
    {
      return this.GetType() + ":" + Selection.ToString();
    }
  }
}