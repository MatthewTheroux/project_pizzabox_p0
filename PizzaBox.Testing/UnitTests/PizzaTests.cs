//*
// [I]. HEAD
//  A] Libraries

using System;
using System.Collections.Generic;
using Xunit;

using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.Pizzas;

///
namespace PizzaBox.Testing
{
  /// Tests for pizzas
  public class PizzaTests
  {
    //  B] Fields & Properties
    public static IEnumerable<object[]> values = new List<object[]>()
    {
      new object[] { new CheesePizza() },
      //new object[] { new PepperoniPizza() },
      new object[] { new VeggiePizza() },
      new object[] { new MeatPizza() }
    };


    [Fact]
    public void Test_CheesePizza()
    {
      // arrange
      var sut = new CheesePizza();

      // act
      var actual = sut.Name;

      // assert
      Assert.True(actual == "CheesePizza");
      Assert.True(sut.ToString() == actual);
    }

    /// <summary>
    /// 
    /// </summary>
    [Fact]
    public void Test_VeggiePizza()
    {
      var sut = new VeggiePizza();

      Assert.True(sut.Name.Equals("VeggiePizza"));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="pizza"></param>
    [Theory]
    [MemberData(nameof(values))]
    public void Test_PizzaName(APizza pizza)
    {
      Assert.NotNull(pizza.Name);
      Assert.Equal(pizza.Name, pizza.ToString());
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="pizzaName"></param>
    /// <param name="x"></param>
    [Theory]
    [InlineData("CheesePizza")]
    [InlineData("VeggiePizza")]
    [InlineData("Meatizza")]
    public void Test_PizzaNameSimple(string pizzaName)
    {
      Assert.NotNull(pizzaName);
    }

  }// /cla
}// /ns
// EoF */
