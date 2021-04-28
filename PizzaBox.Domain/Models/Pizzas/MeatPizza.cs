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
  public class MeatPizza : APizza
  {
    //  B] Fields and Properties


    // [II]. BODY
    ///
    public MeatPizza()
    {
      //  a) head
      Name = "Meat Pizza";

      //  b)  body
      // Meat pizza needs a thick crust, by default.
      Crust = new PizzaCrust(PizzaCrust.Choice.CHICAGO_DEEP_DISH);
      Sauce = new PizzaSauce(PizzaSauce.Choice.CHUNKY_MARINARA);

      // foreach (PizzaToppingMeat _meat in Enum.GetValues(typeof(PizzaToppingMeat.Choice)))
      // {
      //   if (_meat.ToString() != "UNSUPPORTED") { AddTopping(_meat); }
      // }

      AddTopping(new PizzaToppingMeat(PizzaToppingMeat.Choice.PEPPERONI));
      AddTopping(new PizzaToppingMeat(PizzaToppingMeat.Choice.HAM));
      AddTopping(new PizzaToppingMeat(PizzaToppingMeat.Choice.BACON));
      AddTopping(new PizzaToppingMeat(PizzaToppingMeat.Choice.SAUSAGE));
      AddTopping(new PizzaToppingMeat(PizzaToppingMeat.Choice.BEEF));


      //  c) foot  =created
    }
  }
}// /ns
 // EoF