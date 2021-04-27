// [I]. HEAD
//  A]
using System;

using PizzaBox.Domain.Abstracts;


namespace PizzaBox.Domain.Models.Components
{
  public class PizzaCrust : APizzaComponent
  {
    //  B]
    public enum Choice
    {
      ADKINS_CRUSTLESS = 0,
      CRACKER_THIN,
      NY_THIN,
      BUBBLY_ITALIAN,
      TRADITIONAL_PAN,
      CHICAGO_DEEP_DISH,
      STUFFED,

      CALZONE,
      SANDWICH_ROLL,

      UNSUPPORTED = 86

    }
    public Choice Selection { get; set; }

    // [II]. BODY
    // Direct cxtr
    public PizzaCrust(Choice _selection) { Selection = _selection; }

    public PizzaCrust(int _n) { Selection = (Choice)_n; }
    public PizzaCrust() : this(1) { }
    public PizzaCrust(string _selectionText)
    {
      _selectionText = _selectionText.Replace(" ", "_");

      Choice _selection = Choice.UNSUPPORTED;
      Enum.TryParse(_selectionText, true, out _selection);
      Selection = _selection;
    }

    // [III]. FOOT
    public override string ToString()
    {
      return this.GetType() + ":" + Selection.ToString();
    }

  }
}