// [I]. HEAD
//  A] 
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Stores;
using PizzaBox.Domain.Models.Pizzas;
using PizzaBox.Domain.Models.Components.Toppings;

///
namespace PizzaBox.Domain.Models
{
  public class PizzaOrder : AnOrder
  {
    //  B] fields & props
    public DateTime BeganAtTimestamp { get; set; }
    // {
    //   get { return BeganAtTimestamp; }
    //   set { BeganAtTimestamp = DateTime.Now; }
    // }

    //<!> Update to reference
    public string Customer { get; set; }
    public string Store { get; set; }
    public List<APizza> Pizzas { get; set; }
    public const int MAXIMUM_NUMBER_OF_PIZZAS = 5;

    public DateTime SentAt { get; set; }

    public Price TotalPrice
    {
      get
      {
        decimal _totalPrice = 0M;
        foreach (APizza _pizza in Pizzas)
        {
          _totalPrice += (decimal)_pizza.Price.Amount;
        }
        return new Price();
      }
    }


    // [II]. BODY

    /// direct constructor
    public PizzaOrder(string _customer, string _store, List<APizza> _pizzas)
    {
      BeganAtTimestamp = DateTime.Now;
      Customer = _customer;
      Store = _store;
      Pizzas = _pizzas;
    }
    /// 1-pizza constructor
    public PizzaOrder(string _customer, string _store, APizza _pizza)
    {
      Customer = _customer;
      Store = _store;
      List<APizza> _pizzas = new List<APizza>();
      _pizzas.Add(_pizza);
      Pizzas = _pizzas;
    }

    /// direct with the time created
    public PizzaOrder(DateTime _timestamp, string _customer, string _store, List<APizza> _pizzas) :
        this(_customer, _store, _pizzas)
    { BeganAtTimestamp = _timestamp; }


    // [III]. FOOT
    ///
    public override string ToString()
    {
      //  a) head
      StringBuilder sb = new StringBuilder();
      string _createdAt = BeganAtTimestamp.ToLocalTime().ToString();

      //  b) body
      sb.AppendLine($"Order Created @{_createdAt}");
      sb.AppendLine($"for {Customer}");
      sb.AppendLine($"at {Store}");

      int _index = 0;
      foreach (APizza _pizza in Pizzas)
      {
        sb.AppendLine("............................");

        sb.Append($"Pizza {++_index}: ");
        sb.AppendLine(_pizza.ToString());
      }
      sb.AppendLine("------------------------------");
      sb.AppendLine($"Order Total: ${TotalPrice.ToString()}");
      sb.AppendLine($"Sales Tax at {TotalPrice.SalesTaxRate * 100}%: ${TotalPrice.SalesTax})");
      sb.AppendLine($"Final total with tax: ${TotalPrice.WithTax}");
      sb.AppendLine("==============================");
      sb.AppendLine();

      //  c) foot
      return sb.ToString();
    }// /'ToString'

    //public void Review() { }
    //public void SendIt() { }


  }// /cla 'PizzaOrder'
}// /ns '..
 // EoF