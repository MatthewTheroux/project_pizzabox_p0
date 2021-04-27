// [!]. ABOUT
/// <credit> johnc on StackOverflow </credit>

// [I]. HEAD
//  A] Libraries
using System;
using System.Collections.Generic;


/// 
namespace PizzaBox.Client.Utilities
{
  // [II]. BODY
  /// tools for leveraging enums
  public static class EnumUtils
  {
    /// Parse an enum of a generic type.
    public static T ParseEnum<T>(string value, T defaultValue) where T : struct, IConvertible
    {
      //  a) head
      if (!typeof(T).IsEnum) throw new ArgumentException("T must be an enumerated type");
      if (string.IsNullOrEmpty(value)) return defaultValue;

      //  b) body
      foreach (T item in Enum.GetValues(typeof(T)))
      {
        if (item.ToString().ToLower().Equals(value.Trim().ToLower())) return item;
      }

      //  c) foot
      return defaultValue;
    }
  }
}