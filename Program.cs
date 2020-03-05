using System;
using Models;

namespace Bakery
{
  public class Program
  {
    public static string Order {get; set;}
    public static int TotalCost {get; set;}
    private static Bread _newBread = new Bread();
    private static Pastry _newPastry = new Pastry();
    public static void Main()
    {
      Welcome();
      OrderScreen();
    }

    public static void Welcome()
    {
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine(" Bread: Buy 2, get 1 free. A single loaf costs $5. \n Pastry: Buy 1 for $2 or 3 for $5. ");
      Console.WriteLine("Start your order: (Press 'Enter')");
      Console.ReadLine();
      Console.WriteLine("Would you like to order Bread or Pastry?\n (to order bread, type:  'bread' \n to order pastry, type: 'pastry') ");
    }
    public static void OrderScreen()
    {
      Order = Console.ReadLine().ToLower();
      if ( Order == "bread")
      {
        Console.WriteLine("Enter how many bread you want:");
        string stringBread = Console.ReadLine();
        int inputtedBreadNum = int.Parse(stringBread);
        _newBread.BreadOrder(inputtedBreadNum);
        Console.WriteLine(_newBread.BreadUpdate);
        AddScreen();
      }
      else if (Order == "pastry")
      {
        Console.WriteLine("Enter how many pastries you want: ");
        string strPastry = Console.ReadLine();
        int inputtedPastryNum = int.Parse(strPastry);
        _newPastry.PastryOrder(inputtedPastryNum);
        Console.WriteLine(_newPastry.PastryUpdate);
        AddScreen(); 
      }        
    }
    public static void AddScreen()
    {
      TotalCost =  _newBread.BreadTotalPrice + _newPastry.PastryTotalPrice;
      Console.WriteLine("Would you like to add more to your order? ('yes' or 'no')");
      string addMore = Console.ReadLine();
      if(addMore == "yes")
      {
      Console.WriteLine("What would you like to add? ('bread' or 'pastry')");
      OrderScreen();
      }
      else
      {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"Thank you for your order. \n Total price : ${TotalCost}");
      }
    }

  }
}