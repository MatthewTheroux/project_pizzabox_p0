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
  /// a pizza topped with all of the veggies
  public class VeggiePizza : APizza
  {
    //  B] Fields and Properties


    // [II]. BODY
    ///
    public VeggiePizza()
    {
      //  a) head
      Name = "Veggie Pizza";

      //  b)  body
      // Veggie pizza needs a thin crust, by default.
      Crust = new PizzaCrust(PizzaCrust.Choice.NY_THIN);

      // foreach (PizzaToppingMeat _veggie in Enum.GetValues(typeof(PizzaToppingVeggie.Choice)))
      // {
      //   if (_veggie.ToString() != "UNSUPPORTED") { AddTopping(_veggie); }
      // }

      AddTopping(new PizzaToppingVeggie(PizzaToppingVeggie.Choice.MUSHROOM));
      AddTopping(new PizzaToppingVeggie(PizzaToppingVeggie.Choice.GREEN_BELL_PEPPER));
      AddTopping(new PizzaToppingVeggie(PizzaToppingVeggie.Choice.ONION));
      AddTopping(new PizzaToppingVeggie(PizzaToppingVeggie.Choice.BANANA_PEPPER));
      AddTopping(new PizzaToppingVeggie(PizzaToppingVeggie.Choice.DICED_TOMATO));

      //  c) foot  =created
    }
  }
}// /ns
 // EoF