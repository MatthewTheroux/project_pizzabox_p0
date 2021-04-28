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
  /// a pizza topped with all of the meats
  public class PepperoniPizza : APizza
  {
    //  B] Fields and Properties


    // [II]. BODY
    ///
    public PepperoniPizza()
    {
      //  a) head
      Name = "Pepperoni Pizza";

      //  b)  body
      // Pepperoni pizza needs a thin-'n-crispy crust, by default.
      Crust = new PizzaCrust(PizzaCrust.Choice.CRACKER_THIN);
      Sauce = new PizzaSauce(PizzaSauce.Choice.SMOOTH_MARINARA);

      // Add it, twice.
      AddTopping(new PizzaToppingMeat(PizzaToppingMeat.Choice.PEPPERONI) as PizzaTopping);
      AddTopping(new PizzaToppingMeat(PizzaToppingMeat.Choice.PEPPERONI) as PizzaTopping);

      //  c) foot  =created
    }
  }
}// /ns
 // EoF