using System;
using Models;

namespace Bakery
{
  public class Program
  {
    static string order;
    static int totalCost;
    static Bread newBread = new Bread();
    static Pastry newPastry = new Pastry();
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine(" Bread: Buy 2, get 1 free. A single loaf costs $5. \n Pastry: Buy 1 for $2 or 3 for $5. ");
      Console.WriteLine("Start your order: (Press 'Enter')");
      Console.ReadLine();
      Console.WriteLine("Would you like to order Bread or Pastry?\n (to order bread, type:  'bread' \n to order pastry, type: 'pastry') ");
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
        newBread.BreadOrder(inputtedBreadNum);
        Console.WriteLine(newBread.BreadUpdate);
        AddScreen();
      }
      else if (order == "pastry")
      {
        Console.WriteLine("Enter how many pastries you want: ");
        string strPastry = Console.ReadLine();
        int inputtedPastryNum = int.Parse(strPastry);
        newPastry.PastryOrder(inputtedPastryNum);
        Console.WriteLine(newPastry.PastryUpdate);
        AddScreen(); 
      }        
    }
    public static void AddScreen()
    {
      totalCost =  newBread.BreadTotalPrice + newPastry.PastryTotalPrice;
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

  }
}