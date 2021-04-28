// [I]. HEAD
//  A] usings
using System;

using PizzaBox.Domain.Abstracts;

///
namespace PizzaBox.Domain.Models
{
  /// 
  public class PizzaSize : ASize
  {
    /// Pizza size choices, where index = price multiplier, NOT radius in inches, as previous.
    public enum Choice
    {

      ONE_MAN = 1, // 6"


      MEDIUM = 3, // 12"

      LARGE = 4, // 14"
      SHEET = 6, // ≈20"?

      UNSUPPORTED = 0//86
    }

    public Choice Selection { get; private set; }

    /// How much
    public int PriceMultiplier() { return (int)Selection; }


    // [II]. BODY
    public PizzaSize(Choice _selection) { Selection = _selection; }

    public PizzaSize(int _n) { Selection = (Choice)_n; }

    public PizzaSize() : this(Choice.LARGE) { }

    public PizzaSize(string _selectionName)
    {
      _selectionName = _selectionName.Replace(" ", "_");

      Choice _selection = Choice.UNSUPPORTED;
      Enum.TryParse(_selectionName, true, out _selection);
      Selection = _selection;
    }

    // [III]. FOOT
    public override string ToString()
    {
      return Selection.ToString();
    }

  }// /cla 'Size'
}// /ns
 // EoF