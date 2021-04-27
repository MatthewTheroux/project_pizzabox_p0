
using System.IO;

using PizzaBox.Domain.Abstracts;


namespace PizzaBox.Domain.Models.Stores
{
  public class ExpressPizzaStore : AStore
  {

    public ExpressPizzaStore()
    {
      Name = "Express Pizza";
    }



    // [III]. FOOT
    ///
    public override string ToString()
    {

      return Name;
    }
  }
}