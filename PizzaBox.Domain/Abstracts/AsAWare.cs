// [I]. HEAD
//  A] Libraries
using System;
using System.Text;


///
namespace PizzaBox.Domain.Abstracts
{
  ///
  public abstract class AsAWare
  {
    //  B] Fields & Properties
    /// yields the class type name;
    public string Type;

    /// how much customer pays to buy
    private double price = 0.00;
    public double Price
    {
      get { return As2Decimal(price); }
      set { price = value; }
    }

    /// the form of currency the customer uses to buy a ware
    private string currency = "USD"; // United States dollars
    public string Currency
    {
      get { return currency; }
      set { currency = value; }
    }


    // [II]. BODY
    /// 
    public double As2Decimal(double _amt)
    {
      double _result = 0;
      string _amtStringFormattedto2DecimalPlaces = String.Format("{0:C2}", _amt);
      double.TryParse(_amtStringFormattedto2DecimalPlaces, out _result);
      return _result;
    }

    /// 
    public override string ToString()
    {
      return Type + "@" + Price + " " + currency;
    }


  }// /cla
}// /ns