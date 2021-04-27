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
    /// Pizza size choices, where index = radius in inches
    public enum Choice
    {

      ONE_MAN = 6,
      MEDIUM = 12,
      LARGE = 14,
      SHEET = 20,

      UNSUPPORTED = 86
    }

    public Choice Selection { get; private set; }

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