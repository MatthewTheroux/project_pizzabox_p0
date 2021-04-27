// [I]. HEAD
//  A] usings
using System.Text;

using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class Customer
  {
    //  B] Properties
    private static int _idCounter = 0;
    private int _id;
    //public string Title { get; private set; } //Mr., Mrs., etc.
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public PhoneNumber PhoneNumber { get; set; }
    public Address Address { get; set; }

    //  C] Constructs
    public Customer(string fname = "unknown", string lname = "unknown")
    {

    }


    // [III]. FOOT
    public string FullName()
    {
      return FirstName + " " + LastName;
    }

    public override string ToString()
    {
      return FullName();
    }

  }// /cla 'Customer'
}// /ns 
 // EoF