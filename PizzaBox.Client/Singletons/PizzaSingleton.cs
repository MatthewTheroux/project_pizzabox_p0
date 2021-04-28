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
    public List<APizza> PizzaChoices;

    public string theSelectedPizza;

    public int theSelectedPizzaIndex;
    private List<string> Pizzas { get; set; }

    /// Finally! We get our pizza
    public APizza ThePizza { get; private set; }


    // [II]. BODY
    /// Populate the choices for pizza.
    public PizzaSingleton() { Create(); }
    private void Create() //a Factory
    {
      //  a) head
      PopulateThePizzaChoices();
      PopulateTheChoiceStringList();//<!> x-depr

      //  b) body
      DisplayTheChoices();
      RetrieveTheUserSelection();
      //theSelectedPizza = PizzaFromList(theSelectedPizzaIndex);

      //  c) foot
      ThePizza = PizzaChoices[theSelectedPizzaIndex];
    }// /'Create'

    private void PopulateThePizzaChoices()
    {
      PizzaChoices = new List<APizza>();
      PizzaChoices.Add(new CustomPizza()); //0

      PizzaChoices.Add(new PepperoniPizza());
      PizzaChoices.Add(new CheesePizza());
      PizzaChoices.Add(new VeggiePizza());
      PizzaChoices.Add(new MeatPizza());
    }// /md 'Pop..Choices'

    //<!> x-depr
    private void PopulateTheChoiceStringList()
    {
      Pizzas = new List<string>();
      Pizzas.Add("custom");
      Pizzas.Add("cheese");
      Pizzas.Add("veggie");
      Pizzas.Add("meat");
    }

    //<!> x-depr
    private void DisplayThePizzaChoicesOnToTheScreen1() //<!> x-depr
    {
      int _index = -1;
      foreach (string pizza in Pizzas)
      {
        System.Console.WriteLine($"{++_index}: {pizza} pizza");
      }
    }

    /// 
    private void DisplayTheChoices()
    {
      int _pizzaIndex = 0;
      foreach (APizza _pizza in PizzaChoices)
      {
        System.Console.WriteLine(
          $"{_pizzaIndex++}: {_pizza}");
      }
    }// /md 'Display..Choices..'

    ///
    private int RetrieveTheUserSelection()
    {
      //  a) head
      string _userInput = "";
      int _menuIndex = -1; //unselected
      bool _isValidPizzaSelection = false;

      //  b) body
      while (!_isValidPizzaSelection)
      {
        //   i) ..head
        _userInput = System.Console.ReadLine();

        //   ii) ..body
        //    (a) Verify that the user entered an integer
        _isValidPizzaSelection = int.TryParse(_userInput, out _menuIndex);
        if (!_isValidPizzaSelection) continue;

        //    (b) Verify that the integer is a valid menu selection.
        if (_menuIndex >= PizzaChoices.Count
            || _menuIndex < 0)
        {
          _isValidPizzaSelection = false;
        }

        //   iii) ..foot
      }// /while !valid

      //  c) foot
      return theSelectedPizzaIndex = _menuIndex;
    }

    private string PizzaFromList(int _n)
    {
      return Pizzas[theSelectedPizzaIndex];
    }

    // x-depr
    // private APizza PizzaFromList(int _n)
    // {
    //   return PizzaChoices[theSelectedPizzaIndex];
    // }




    // [III].FOOT

    // x-depr
    // public string ToString1()
    // {
    //   //  a) head
    //   string _s = "invalid pizza";

    //   //  b) body
    //   try { _s = theSelectedPizza; }
    //   catch (Exception ioe) { ioe.ToString(); }

    //   //  c) foot
    //   return _s;
    // }// /'ToString'


    /// the string representation of the PizzaSingleton as

    public override string ToString() { return ThePizza.ToString(); }
  }// /cla
}// /ns
 // EoF