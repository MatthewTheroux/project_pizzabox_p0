// [I]. HEAD
//  A]
using System;

using PizzaBox.Domain.Abstracts;


namespace PizzaBox.Domain.Models.Components.Toppings
{
  public class PizzaToppingMeat : PizzaTopping
  {
    //  B]
    public enum Choice
    {
      PEPPERONI = 1,
      HAM,
      CHICKEN,
      SAUSAGE,
      BEEF,
      BACON,


      UNSUPPORTED = 86
    }
    public Choice Selection { get; set; }


    // [II]. BODY
    /// direct constructor
    public PizzaToppingMeat(Choice _selection) { Selection = _selection; }

    /// index-based constructor
    public PizzaToppingMeat(int _n) { Selection = (Choice)_n; }

    /// blank constructor
    public PizzaToppingMeat() : this(1) { }


    /// string constructor
    public PizzaToppingMeat(string _selectionText)
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