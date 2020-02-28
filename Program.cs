using System;
using Models;

namespace Bakery
{
  public class Program
  {
    static string order;
    static int totalCost;

    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("Bread: Buy 2, get 1 free. A single loaf costs $5. \n Pastry: Buy 1 for $2 or 3 for $5. ");
      Console.WriteLine("Start your order: (Press 'Enter')");
      Console.ReadLine();
      Console.WriteLine("Would you like to order Bread or Pastry? (to order bread, type:  'bread'-- to order pastry, type: 'pastry') ");
      OrderScreen();
    }

    
    public static void OrderScreen()
    {
      order = Console.ReadLine().ToLower();
      if ( order == "bread")
      {
        Console.WriteLine("Enter how many bread you want:");
        string stringBread = Console.ReadLine();
        int inputtedBreadNum = int.Parse(stringBread);
        TotalOrderBread(inputtedBreadNum);
        Console.WriteLine(newBread.BreadUpdate);
        UpdateBreadCost();
        AddScreen();
      }
      else if (order == "pastry")
      {
        Console.WriteLine("Enter how many pastries you want: ");
        string strPastry = Console.ReadLine();
        int inputtedPastryNum = int.Parse(strPastry);
        TotalOrderPastry(inputtedPastryNum);
        Console.WriteLine(newPastry.PastryUpdate);
        UpdatePastryCost();
        AddScreen(); 
      }        
    }
    public static void AddScreen()
    {
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
        Console.WriteLine($"Thank you for your order. \n Total price : ${totalCost}");
      }
    }
    static Bread newBread = new Bread();
    static Pastry newPastry = new Pastry();
    public static void TotalOrderBread(int inputtedBreadNum)
    {
      newBread.BreadOrder(inputtedBreadNum);
    }
    public static void TotalOrderPastry( int inputtedPastryNum)
    {
      newPastry.PastryOrder(inputtedPastryNum);
    }

    public static void UpdateBreadCost()
    {
      totalCost += newBread.BreadTotalPrice;
    }
    public static void UpdatePastryCost()
    {
      totalCost += newPastry.PastryTotalPrice;
    }
    
  }
}