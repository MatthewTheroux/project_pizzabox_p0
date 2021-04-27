// [I]. HEAD
//  A] usings
using System;

///
namespace PizzaBox.Domain.Abstracts
{
  public abstract class AComponent : AModel
  {
    //abstract
    public string ComponentName { get; protected set; }
    // public enum Choice
    // {
    //   UNSUPPORTED = 86
    // }
    // private Choice selection = Choice.UNSUPPORTED;
    // public Choice Selection
    // {
    //   get { return selection; }
    //   set { selection = value; }
    // }

    // [II]. BODY
    public AComponent()
    {
      ComponentName = this.GetType().Name;
    }

    // public AComponent(Choice _selection) : this()
    // {
    //   Selection = _selection;
    // }

    // [III]. FOOT
    // public override string ToString()
    // {
    //   return Selection.ToString();
    // }
    public abstract override string ToString();


  }// /cla 'AComponent'
}// /ns '..Abstracts'
 // EoF