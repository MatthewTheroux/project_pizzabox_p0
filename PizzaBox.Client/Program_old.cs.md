// // [I]. HEAD
// //  A] Libraries
// using System;


// using PizzaBox.Client.Singletons;

// using PizzaBox.Domain;
// using PizzaBox.Domain.Abstracts;
// using PizzaBox.Domain.Models;
// using PizzaBox.Domain.Models.Stores;
// using PizzaBox.Domain.Models.Pizzas;
// using PizzaBox.Domain.Models.Components;
// using PizzaBox.Domain.Models.Components.Toppings;

// using PizzaBox.Storing;
// using PizzaBox.Storing.Repositories;

// namespace PizzaBox.Client
// {
//   /// <summary>
//   /// 
//   /// </summary>
//   public class Program
//   {
//     //  B] fields & props
//     //   1.
//     private static readonly PizzaSingleton _pizzaSingleton = PizzaSingleton.Instance;
//     private static readonly StoreSingleton _storeSingleton = StoreSingleton.Instance;

//     /// <summary>
//     /// Entry point.
//     /// </summary>
//     private static void Main() { Run(); }

//     /// <summary>
//     /// 
//     /// </summary>
//     private static void Run()
//     {
//       var order = new PizzaOrder();

//       System.Console.WriteLine("**Welcome to PizzaBox**");
//       PrintStoreList();

//       order.Customer = SelectCustomer();
//       order.Store = SelectStore();
//       order.Pizza = SelectPizza();
//     }



//     /// <summary>
//     /// 
//     /// </summary>
//     private static void PrintOrder(@string pizza)
//     {
//       System.Console.WriteLine($"Your order is: {pizza}");
//     }

//     /// <summary>
//     /// 
//     /// </summary>
//     private static void PrintPizzaList()
//     {
//       var index = 0;

//       foreach (var item in _pizzaSingleton.Pizzas)
//       {
//         System.Console.WriteLine($"{++index} - {item}");
//       }
//     }

//     /// <summary>
//     /// 
//     /// </summary>
//     private static void PrintStoreList()
//     {
//       var index = 0;

//       foreach (var item in _storeSingleton.Stores)
//       {
//         System.Console.WriteLine($"{++index} - {item}");
//       }
//     }

//     /// <summary>
//     /// 
//     /// </summary>
//     /// <returns> the selected store </returns>
//     private static AStore SelectStore()
//     {
//       bool isValid = int.TryParse(System.Console.ReadLine(), out int input);
//       if (!isValid) { return null; }

//       PrintPizzaList();

//       return _storeSingleton.Stores[input - 1];
//     }

//     /// <summary>
//     /// 
//     /// </summary>
//     /// <returns> the selected pizza</returns>
// `````````    private static @string SelectPizza()
//     {
//       bool isValid = int.TryParse(System.Console.ReadLine(), out int input);
//       if (!isValid) { return null; }

//       var pizza = _pizzaSingleton.Pizzas[input - 1];

//       PrintOrder(pizza);

//       return pizza;
//     }
//   }
// }// /ns
//  // EoF