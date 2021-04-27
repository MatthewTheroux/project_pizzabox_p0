// [I]. HEAD
//  A] Libraries
using System;
using System.Collections.Generic;

/// 
namespace PizzaBox.Domain.Abstracts
{
  public abstract class AStore : AModel
  {
    public int CorporateLocationNumber { get; set; }
    public string Name { get; set; }
    ///
    public string Type { get; protected set; }

    ///
    public PhoneNumber PhoneNumber { get; protected set; }

    ///
    public Address Address { get; protected set; }


    ///
    public List<AnOrder> Orders { get; set; }


    // [II]. BODY
    /// Make a concrete child instance of a store.
    public AStore()
    {
      SetStoreType();
    }

    private void SetStoreType()
    {
      try { Type = this.GetType().Name; }
      //<!> update ex
      catch (Exception e)
      {
        e.ToString();
        Type = "a store";
      }
    }


    public abstract override string ToString();

  }// /cla ‘AStore’

}// /ns ‘...Abstracts’