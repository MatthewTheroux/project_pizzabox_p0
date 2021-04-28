// [I]. HEAD
//  A] Libraries

using System;
using System.Collections.Generic;
using Xunit;

using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models.Stores;

///
namespace PizzaBox.Testing
{
  /// Tests for stores
  public class StoreTests
  {
    //  B] Fields & Properties
    public static IEnumerable<object[]> values = new List<object[]>()
    {
      new object[] { new FamilyPizzaStore() },
      new object[] { new ExpressPizzaStore() }
    };


    [Fact]
    public void Test_FamilyPizzaStore()
    {
      // arrange
      var sut = new FamilyPizzaStore();

      // act
      var actual = sut.Name;

      // assert
      Assert.True(actual == "FamilyPizzaStore");
      Assert.True(sut.ToString() == actual);
    }

    /// <summary>
    /// 
    /// </summary>
    [Fact]
    public void Test_ExpressPizzaStore()
    {
      var sut = new ExpressPizzaStore();

      Assert.True(sut.Name.Equals("ExpressPizzaStore"));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="store"></param>
    [Theory]
    [MemberData(nameof(values))]
    public void Test_StoreName(AStore store)
    {
      Assert.NotNull(store.Name);
      Assert.Equal(store.Name, store.ToString());
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="storeName"></param>
    /// <param name="x"></param>
    [Theory]
    [InlineData("FamilyPizzaStore")]
    [InlineData("ExpressPizzaStore")]
    public void Test_StoreNameSimple(string storeName)
    {
      Assert.NotNull(storeName);
    }

  }// /cla
}// /ns
// EoF
