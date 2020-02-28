using System;
using Models;

namespace Bakery
{
  public class Program
  {
    static string order;

    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("Bread: Pastry: "   );
      // add Price for both
      Console.WriteLine("Start your order: (Press 'Enter')");
      Console.ReadLine();
      OrderScreen();
      AddScreen();
    }

    public static void AddScreen()
    {
      Console.WriteLine("Would you like to add more to your order? ('yes' or 'no'");
      string addMore = Console.ReadLine();
      if(addMore == "yes")
      {
      Console.WriteLine("What would you like to add? ('bread' or 'pastry')");
      OrderScreen();
      }
      else
      {
        // total and thank you screen
      }
    }
    public static void OrderScreen()
    {
      Console.WriteLine("Would you like to order Bread or Pastry? (to order bread, type:  'bread'-- to order pastry, type: 'pastry') ");
      order = Console.ReadLine().ToLower();
      if ( order == "bread")
      {
        Console.WriteLine("Enter how many bread you want:");
        string stringBread = Console.ReadLine();
        int inputtedBreadNum = int.Parse(stringBread);
        TotalOrderBread(inputtedBreadNum);
        Console.WriteLine(newBread.BreadUpdate);
      }
      else if (order == "pastry")
      {
        Console.WriteLine("Enter how many pastries you want: ");
        string strPastry = Console.ReadLine();
        int inputtedPastryNum = int.Parse(strPastry);
        TotalOrderPastry(inputtedPastryNum);
        Console.WriteLine(newPastry.PastryUpdate);
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



  }
}