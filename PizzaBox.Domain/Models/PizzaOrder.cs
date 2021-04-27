// [I]. HEAD
//  A] 
using System;
using System.Collections.Generic;

using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class PizzaOrder : AnOrder
  {
    public List<@string> pizzasInCart { get; set; }


  }// /cla 'PizzaOrder'
}// /ns '..
 // EoF