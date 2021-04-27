// [I]. HEAD
//  A] usings
using System;

namespace PizzaBox.Domain.Abstracts
{
  public abstract class ACoupon
  {
    //  B] Properties
    public int Id { get; protected set; } //unique?
    public DateTime ExperationDate { get; protected set; }
    public AModel ItemToGetTheDealOn { get; protected set; }
    public float NewPriceOfTheItem { get; protected set; }
    public float PercentOffOfTheItem { get; protected set; }
    public float DiscountAmountOffOfTheItem { get; protected set; }


    // [II]. BODY

    // [III]. FOOT
    public abstract override string ToString();
  }// /cla 'ACoupon'
}// /ns '..Abstracts'
 // EoF