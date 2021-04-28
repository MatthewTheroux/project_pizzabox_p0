// [I]. HEAD
//  A] Libraries
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
//using Wait = System.Threading.Thread;

using PizzaBox.Client;
using PizzaBox.Client.Singletons;

using PizzaBox.Domain;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

using PizzaBox.Storing;
using PizzaBox.Storing.Repositories;

///
namespace PizzaBox.Client
{

  public class Program
  {

    // B] fields & props
    private static DateTime OrderCreationTimestamp;

    private static string theCustomerSelected;

    private static StoreSingleton storeSingleton;
    private static int storeChoiceSelectionIndex = -1; //'unset' <?>

    private static string theStoreSelected;

    private static List<APizza> thePizzasSelected;

    private static PizzaOrder TheOrder;

    private static bool didOrderSucceed = false;

    private const string ORDER_REPOSITORY_PATH = @"data/orders.txt";


    //[II]. BODY
    /// the entry point for the program
    //public
    static void Main(string[] args) { Run(); }
    private static void Run()
    {
      //  a) head
      Hello();

      //  b) body
      BuildTheOrder();

      //  c) foot
      FinalizeTheOrder();
    }// /'Run'

    ///
    private static void Hello()
    {
      System.Console.WriteLine("Hello.  Welcome to PizzaBox, the world's first pizza-only delivery system.");
      System.Console.WriteLine();
      OrderCreationTimestamp = DateTime.Now;
    }// /'Hello'

    ///
    private static void BuildTheOrder()
    {
      //  a) head
      SelectACustomer();
      //SelectAStore();

      //  b) body
      SelectSomePizzas();

      //  c) foot
      BuildTheOrderObject();//...
      ExitTheApplication();

    }// /md 'Build..'


    /// Select a customer for the order.
    private static void SelectACustomer()
    {
      System.Console.Write("What is your name, please? ");
      theCustomerSelected = System.Console.ReadLine();
      System.Console.WriteLine();
    }

    /// Select a store for the order.
    private static void SelectAStore() { theStoreSelected = new StoreSingleton().ToString(); }
    private static void SelectSomePizzas()
    {
      int _numberOfPizzas = 0;
      bool _doContinueToOrderPizzas = true;
      while (_doContinueToOrderPizzas)
      {
        AddAPizza();
        _numberOfPizzas++;
        if (_numberOfPizzas >= PizzaOrder.MAXIMUM_NUMBER_OF_PIZZAS)
          _doContinueToOrderPizzas = false;
        else
        {
          System.Console.Write("Add another pizza? (Y/N)?  ");
          string _s = System.Console.ReadLine();
          if (_s != "Y") { _doContinueToOrderPizzas = false; }
        }
      }
    }// /md 'ChoosePizzas'

    ///
    private static void AddAPizza()
    {
      PizzaSingleton _ps = new PizzaSingleton();
      //string _pizzaAsString = _ps.ToString();
      thePizzasSelected.Add(_ps.ThePizza);
    }

    ///
    private static void BuildTheOrderObject()
    {
      System.Console.WriteLine("\n We're putting that together for you. ....");
      TheOrder = new PizzaOrder(
        OrderCreationTimestamp,
        theCustomerSelected,
        theStoreSelected,
        thePizzasSelected
      );
    }// /md 'BuildTheOrderObject'


    // [III]. FOOT
    ///
    private static void FinalizeTheOrder()
    {
      ReviewTheOrder();
      PaymentOperations();//<!>rename
      SendTheOrder();
    }

    ///
    private static void ReviewTheOrder()
    {
      System.Console.WriteLine();
      System.Console.WriteLine(TheOrder); //multi-line
      System.Console.Write("-------------------------");
      System.Console.Write("Press [ENTER] to confirm.");
      System.Console.ReadLine();
      System.Console.Write(".........................");
      System.Threading.Thread.Sleep(250);
    }// /md 'Review..'

    #region PaymentOps
    ///
    private static void PaymentOperations()
    {
      //  a) head
      bool _isPaymentMethodValid = false;
      while (!_isPaymentMethodValid)
      {
        ProvidePaymentInformation();
        _isPaymentMethodValid = doConfirmPaymentInformationProvided();
      }// /wl !valid

      ConfirmUserSubmissionOfPayment();
      ProcessPayment();
    }// /md 'PaymentStuff'

    ///
    private static void ProvidePaymentInformation()
    {
      //<...>
      System.Console.WriteLine(".... Payment Information Received.");
      System.Threading.Thread.Sleep(111);
    }

    /// Confirms that the payment
    private static bool doConfirmPaymentInformationProvided()
    {
      bool _isPaymentMethodValid = false;
      //<...>
      System.Console.WriteLine(".... Payment Information Confirmed.");
      _isPaymentMethodValid = true;
      return _isPaymentMethodValid;
    }// /md 'doConfirmPaymentInfo..'

    /// 
    private static void ConfirmUserSubmissionOfPayment()
    {
      System.Console.Write("Press [ENTER] to confirm submission of payment.");
      System.Console.ReadLine();
    }

    /// Posts the payment to the provided payment method.
    private static void ProcessPayment()
    {
      //<...>
      System.Console.WriteLine($".... Payment of ${TheOrder.TotalPrice.WithTax} was successfully submitted from Fred Belome.");
      System.Threading.Thread.Sleep(250);
      System.Console.WriteLine("-----------------------------------------------------------------------------(Thanks, Fred).");
    }// /md 'Proc..Payment
    #endregion PaymentOps

    #region orderStuff
    ///  C] 
    private static void SendTheOrder()
    {
      System.Console.WriteLine();
      System.Console.WriteLine("Sending Your Order, ...NOW.");
      System.Threading.Thread.Sleep(250);
      TheOrder.SentAt = DateTime.Now;
      System.Console.WriteLine($"Your order has been received by {theStoreSelected}.");
      System.Threading.Thread.Sleep(100);

      System.Console.WriteLine("We have magically pinpointed your location.");//X
      System.Console.Write(" and should be Hot-to-You ");// at ___
      System.Console.WriteLine(" in about 45 minutes.");// calc

    }// /md 'SendTheOrder'

    private static void StoreTheOrder()
    {
      //  a) head
      System.Threading.Thread.Sleep(250);
      System.Console.WriteLine();
      System.Console.WriteLine("Storing your order to the repository. ....");

      //  b) body
      try
      {
        StreamWriter _writer = new StreamWriter(ORDER_REPOSITORY_PATH);
        _writer.WriteLine();
        _writer.WriteLine(TheOrder);
        _writer.WriteLine();
      }
      catch (IOException ioe)
      {
        System.Console.WriteLine("Write access to the 'Orders' repository was denied at this time for an unknown reason.");
        System.Console.WriteLine(ioe.ToString());
      }

      //  c) foot
    }// /md 'StoreTheOrder'

    private static void ViewAllOrders()
    {
      //  a) head
      System.Threading.Thread.Sleep(500);
      System.Console.WriteLine("---------------------------------");
      System.Console.Write("Press [ENTER] to view all orders.");
      System.Console.ReadLine();
      System.Console.WriteLine("---------------------------------");


      //  b) body
      try
      {
        using (StreamReader _reader = new StreamReader(ORDER_REPOSITORY_PATH))
        {
          string line;
          while ((line = _reader.ReadLine()) != null)
          {
            System.Threading.Thread.Sleep(50);
            System.Console.WriteLine(line);
          }
        }// /usg '_reader'
      }
      catch (IOException ioe)
      {
        System.Console.WriteLine("Read access to the 'Orders' repository was denied at this time for an unknown reason.");
        System.Console.WriteLine(ioe.ToString());
      }
      System.Console.WriteLine("===========================================");
      System.Console.WriteLine("[End of the 'Order' Repository].");

    }// /md 'ViewAllOrders'

    #endregion orderStuff

    ///
    private static void ExitTheApplication()
    {
      System.Console.Write("Press [ENTER] to exit the application.");
      System.Console.ReadLine();
      System.Console.WriteLine("*Exited the application successfully.*");
    }


  }// /cla
}// /ns
 // EoF