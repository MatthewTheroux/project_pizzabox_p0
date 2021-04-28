// [I]. HEAD
//  A]
using System;

using PizzaBox.Domain.Abstracts;


namespace PizzaBox.Domain.Models.Components.Toppings
{
  public class PizzaToppingVeggie : PizzaTopping
  {
    //  B]
    public enum Choice
    {
      MUSHROOM = 1,

      ZUCCINI,

      BROCCOLI,

      ROASTED_RED_BELL_PEPPER,
      GREEN_BELL_PEPPER,

      ONION,

      CARROT,

      BANANA_PEPPER,

      DICED_TOMATO,


      UNSUPPORTED = 86
    }
    public Choice Selection { get; set; }


    // [II]. BODY
    /// direct constructor
    public PizzaToppingVeggie(Choice _selection) { Selection = _selection; }

    /// index-based constructor
    public PizzaToppingVeggie(int _n) { Selection = (Choice)_n; }

    /// blank constructor
    public PizzaToppingVeggie() : this(1) { }


    /// string constructor
    public PizzaToppingVeggie(string _selectionText)
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