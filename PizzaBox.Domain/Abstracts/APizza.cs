//
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Pizzas;
using PizzaBox.Domain.Models.Components;
using PizzaBox.Domain.Models.Components.Toppings;

/// 
namespace PizzaBox.Domain.Abstracts
{

  //[DataContract]
  [XmlInclude(typeof(CustomPizza))]
  //[XmlInclude(typeof(PepperroniPizza))]
  [XmlInclude(typeof(CheesePizza))]
  [XmlInclude(typeof(MeatPizza))]
  [XmlInclude(typeof(VeggiePizza))]
  public abstract class APizza : AModel
  {    //  B] Fields and Properties
    public string Name { get; set; }
    public PizzaSize Size { get; set; }
    public long SizeEntityId { get; set; }
    public PizzaCrust Crust { get; set; }
    public PizzaSauce Sauce { get; set; }
    public PizzaToppingCheese Cheese { get; set; }
    public List<APizzaTopping> Toppings { get; set; }
    public PizzaSpice Spice { get; set; }



    /// e.g., a one-man pizza with no toppings is $5.
    private static readonly Price BASE_PRICE = new Price(5M);


    /// Calculates the full price of the pizza, based on size and # of toppings
    public Price Price
    {
      get
      {
        return new Price(
          Size.PriceMultiplier() *
          (BASE_PRICE.Amount //pizza
           + (Toppings.Count * APizzaTopping.BASE_PRICE.Amount)
          ));
      }
    }

    //  C] 
    /// Construct a default-defined pizza (as a concrete child).
    public APizza() { Factory(); }

    private void Factory()
    {
      // Fill with defaults.
      Size = new PizzaSize(1);
      SizeEntityId = 1;//(int)Size;//int.Parse(Size).GetValue();
      Crust = new PizzaCrust();
      Sauce = new PizzaSauce();
      Cheese = new PizzaToppingCheese();
      Toppings = new List<APizzaTopping>(); //<!>
      Spice = new PizzaSpice();
    }// /defaut inherited factory


    // [II]. BODY
    // Why?
    //public void setCrust(PizzaCrust crust) { Crust = crust; }


    public void AddTopping(APizzaTopping _topping) { Toppings.Add(_topping); }

    /// [III]. FOOT
    public override string ToString()
    {
      //<!> Use StringBuilder
      StringBuilder asString = new StringBuilder("{a ");
      asString.Append($"a {Size} ");
      asString.Append($"{Crust} crust pizza, ");
      asString.Append($"with {Sauce} sauce, ");
      asString.Append($"{Cheese} cheese, ");

      foreach (APizzaTopping _topping in Toppings)
      {
        asString.Append("{_topping}, ");
      }
      asString.Append($"and {Spice} spices");
      asString.Append($": {Price}");

      return asString.ToString();
    }// /'ToString'

  }// /cla 'APizza'
}// /ns
 // EoF