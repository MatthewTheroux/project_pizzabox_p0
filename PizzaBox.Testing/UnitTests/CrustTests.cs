// [I]. HEAD
//  A] Libraries

using System;
using System.Collections.Generic;
using Xunit;

using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Models.Components;

///
namespace PizzaBox.Testing
{
  /// Tests for Components
  public class ComponentTests
  {
    //  B] Fields & Properties
    public static IEnumerable<object[]> values = new List<object[]>()
    {
      new object[] { new PizzaCrust() },
      new object[] { new PizzaSauce() },
      new object[] { new PizzaSpice() }
    };


    [Fact]
    public void Test_PizzaCrust()
    {
      // arrange
      var sut = new PizzaCrust();

      // act
      var actual = sut.Name;

      // assert
      Assert.True(actual == "PizzaCrust");
      Assert.True(sut.ToString() == actual);
    }

    /// <summary>
    /// 
    /// </summary>
    [Fact]
    public void Test_PizzaSauce()
    {
      var sut = new PizzaSauce();

      Assert.True(sut.Name.Equals("PizzaSauce"));
    }

    /// <summary>
    /// 
    /// </summary>
    [Fact]
    public void Test_PizzaSpice()
    {
      var sut = new PizzaSpice();

      Assert.True(sut.Name.Equals("PizzaSpice"));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="component"></param>
    [Theory]
    [MemberData(nameof(values))]
    public void Test_ComponentName(AComponent component)
    {
      Assert.NotNull(component.Name);
      Assert.Equal(component.Name, component.ToString());
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="componentName"></param>
    /// <param name="x"></param>
    [Theory]
    [InlineData("PizzaCrust")]
    [InlineData("PizzaSauce")]
    [InlineData("PizzaSpice")]
    public void Test_ComponentNameSimple(string componentName)
    {
      Assert.NotNull(componentName);
    }

  }// /cla
}// /ns
// EoF
