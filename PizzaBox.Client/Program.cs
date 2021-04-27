// [I]. HEAD
//  A] Libraries
using System;
using System.Collections.Generic;
using System.IO;

using PizzaBox.Client;
using PizzaBox.Client.Singletons;

using PizzaBox.Domain;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

using PizzaBox.Storing;
using PizzaBox.Storing.Repositories;

///
namespace PizzaBox.Client
{

  public class Program
  {

    // B] fields & props
    private static string customerChoiceSelection;

    private static StoreSingleton storeSingleton;
    private static int storeChoiceSelectionIndex = -1; //'unset'

    private static string storeChoiceSelection;

    private static List<string> pizzasToOrder;




    //[II]. BODY
    public static void Main(string[] args) { Run(); }
    private static void Run()
    {
      Hello();
      ChooseCustomer();
      ChooseStore();
      //ChoosePizzas();
      //SendOrder();
    }


    private static void Hello()
    {
      System.Console.WriteLine("Hello, Welcome to PizzaBox, the world's first pizza-only delivery system.");
      System.Console.WriteLine();
    }

    private static void ChooseCustomer()
    {
      System.Console.Write("What is your name, please? ");
      customerChoiceSelection = System.Console.ReadLine();
    }

    private static void ChooseStore() { storeChoiceSelection = new StoreSingleton().ToString(); }
    private static void ChoosePizzas()
    {
      bool _continue = true;
      while (_continue)
      {
        AddAPizza();

        System.Console.Write("Add another pizza? (Y/N)?  ");
        string _s = System.Console.ReadLine();
        if (_s != "Y") { _continue = false; }
      }
    }

    private static void AddAPizza()
    {
      pizzasToOrder.Add(new PizzaSingleton().ToString());
    }


  }// /cla
}// /ns