// [I]. HEAD
//  A] Libraries
using System;
using System.Collections.Generic;

using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Pizzas;

///
namespace PizzaBox.Client.Singletons
{
  /// Retrieve a singular instance of a particular pizza.
  public class PizzaSingleton : AnEntitySingleton
  {
    // B]
    //public static 

    public string theSelectedPizza;

    public int theSelectedPizzaIndex;
    public List<string> Pizzas { get; set; }




    // [II]. BODY
    /// Populate the choices for pizza.
    public PizzaSingleton() { Create(); }
    private void Create()
    {
      PopulateTheChoiceList();
      DisplayThePizzaChoicesOnToTheScreen();
      RetrieveTheUserSelectionOfPizzaChoices();
      theSelectedPizza = PizzaFromList(theSelectedPizzaIndex);
    }
    private void PopulateTheChoiceList()
    {
      Pizzas = new List<string>();
      Pizzas.Add("custom");
      Pizzas.Add("pepperoni");
      Pizzas.Add("veggie");
      Pizzas.Add("meat");
    }

    // override
    protected void DisplayThePizzaChoicesOnToTheScreen()
    {
      int _index = -1;
      foreach (string pizza in Pizzas)
      {
        System.Console.WriteLine($"{++_index}: {pizza} pizza");
      }
    }

    protected int RetrieveTheUserSelectionOfPizzaChoices()
    {
      //  a) head
      string _s = "";
      int _n = -1;
      bool _isValidPizzaSelection = false;

      //  b) body
      while (!_isValidPizzaSelection)
      {
        _s = System.Console.ReadLine();
        _isValidPizzaSelection = int.TryParse(_s, out _n);
      }

      //  c) foot
      return theSelectedPizzaIndex = _n;
    }

    protected string PizzaFromList(int _n)
    {
      return Pizzas[theSelectedPizzaIndex];
    }


    // [III].FOOT
    public override string ToString()
    {
      //  a) head
      string _s = "invalid pizza";

      //  b) body
      try { _s = theSelectedPizza; }
      catch (Exception ioe) { ioe.ToString(); }

      //  c) foot
      return _s;
    }
  }
}