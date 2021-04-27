// [I]. HEAD
//  A]
using System;

using PizzaBox.Domain.Abstracts;


namespace PizzaBox.Domain.Models.Components.Toppings
{
  public class PizzaToppingCheese : PizzaTopping
  {
    //  B]
    public enum Choice
    {
      NONE = 0,
      MOZZERELLA,
      MOZZ_PROV_MIX,
      PROVOLONE,
      CHEDDAR,
      GORGONZOLA,

      UNSUPPORTED = 86
    }
    public Choice Selection { get; set; }


    // [II]. BODY
    /// direct constructor
    public PizzaToppingCheese(Choice _selection) { Selection = _selection; }

    /// index-based constructor
    public PizzaToppingCheese(int _n) { Selection = (Choice)_n; }

    /// blank constructor
    public PizzaToppingCheese() : this(1) { }


    /// string constructor
    public PizzaToppingCheese(string _selectionText)
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