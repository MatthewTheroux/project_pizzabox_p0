// [I]. HEAD
//  A] Libraries
using System;
using System.Collections.Generic;

using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.Components;
using PizzaBox.Domain.Models.Components.Toppings;

///
namespace PizzaBox.Domain.Models.Pizzas
{
  /// a pizza topped with all of the cheeses
  public class CheesePizza : APizza
  {
    //  B] Fields and Properties


    // [II]. BODY
    ///
    public CheesePizza()
    {
      //  a) head
      Name = "Cheese Pizza";

      //  b)  body
      // Cheese pizza needs a smooth crust, by default.
      Crust = new PizzaCrust(PizzaCrust.Choice.BUBBLY_ITALIAN);

      // foreach (PizzaToppingCheese _cheese in Enum.GetValues(typeof(PizzaToppingCheese.Choice)))
      // {
      //   string _ch = _cheese.ToString();
      //   if (_ch != "UNSUPPORTED" && _ch != "NO")
      //     { AddTopping(_cheese); }
      // }

      AddTopping(new PizzaToppingCheese(PizzaToppingCheese.Choice.CHEDDAR));
      AddTopping(new PizzaToppingCheese(PizzaToppingCheese.Choice.MOZZ_PROV_MIX));
      AddTopping(new PizzaToppingCheese(PizzaToppingCheese.Choice.GORGONZOLA));




      //  c) foot  =created
    }
  }
}// /ns
 // EoF