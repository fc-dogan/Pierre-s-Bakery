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
      Console.WriteLine("Would you like to order Bread or Pastry? (to order bread, type:  'bread'-- to order pastry, type: 'pastry') ");
      order = Console.ReadLine().ToLower();
      OrderScreen();

    }
    public static void OrderScreen()
    {
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