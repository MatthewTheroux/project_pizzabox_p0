//
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Components;
using PizzaBox.Domain.Models.Components.Toppings;

/// 
namespace PizzaBox.Domain.Abstracts
{

  //[XML Include ]
  public abstract class @string : AModel
  {
    //  B] Properties
    public string Name { get; protected set; }
    public PizzaSize Size { get; protected set; }
    public long SizeEntityId { get; protected set; }
    public PizzaCrust Crust { get; protected set; }
    public PizzaSauce Sauce { get; protected set; }
    public PizzaToppingCheese Cheese { get; protected set; }
    public List<PizzaTopping> Toppings { get; protected set; }
    public PizzaSpice Spice { get; protected set; }

    //  C] 
    /// Construct a default-defined pizza (as a concrete child).
    public @string() { Factory(); }

    private void Factory()
    {
      // Fill with defaults.
      Size = new PizzaSize();
      //SizeEntityId = int.Parse(Size);//.GetValue();
      Crust = new PizzaCrust();
      Sauce = new PizzaSauce();
      Cheese = new PizzaToppingCheese();
      Toppings = new List<PizzaTopping>(); //<!>
      Spice = new PizzaSpice();
    }// /defaut inherited factory


    // [II]. BODY
    // Why?
    //public void setCrust(PizzaCrust crust) { Crust = crust; }


    public void AddTopping(PizzaTopping topping) { Toppings.Add(topping); }

    /// [III]. FOOT
    public override string ToString()
    {
      //<!> Use StringBuilder
      StringBuilder asStringBuilder = new StringBuilder("{a ");
      asStringBuilder.Append(Size + " ");
      asStringBuilder.Append(Crust + " crust, ");
      asStringBuilder.Append(Sauce + " sauced pizza with ");
      asStringBuilder.Append(Cheese + "cheese, ");
      //asString += "{";
      foreach (PizzaTopping topping in Toppings) { asStringBuilder.Append(topping + ", "); }
      asStringBuilder.Append("and " + Spice + " spices.");

      return asStringBuilder.ToString();
    }// /'ToString'


  }// /cla 'APizza'
}// /ns
 // EoF