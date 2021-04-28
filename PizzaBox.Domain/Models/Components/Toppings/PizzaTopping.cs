using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models.Components.Toppings //<!> update
{
  public abstract class APizzaTopping : AComponent
  {

    public static readonly Price BASE_PRICE = new Price(.50M);


    // [III]. FOOT
    /// Default constructor for a Topping if none can be found.
    public abstract override string ToString();
    // {
    //   return "topping";
    // }
  }// /cla
}// /ns
 // EoF