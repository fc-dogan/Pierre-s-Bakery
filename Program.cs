using System;
using Models;

namespace Bakery
{
  public class Program
  {
    // public int BreadTotalPrice;

    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("Bread: Pastry: "   );
      // add Price for both
      Console.WriteLine("Start your order: (Press 'Enter')");
      Console.ReadLine();
      Console.WriteLine("Would you like to order Bread or Pastry? (to order bread, type:  'bread'-- to order pastry, type: 'pastry') ");
      string breadOrder = Console.ReadLine().ToLower();
      if ( breadOrder == "bread")
      {
        Console.WriteLine("Enter how many bread you want:");
        string stringBread = Console.ReadLine();
        int inputtedBreadNum = int.Parse(stringBread);
        TotalOrderBread(inputtedBreadNum);
        Console.WriteLine(newBread.BreadUpdate);
      }
    }

    static Bread newBread = new Bread();
    public static void TotalOrderBread(int inputtedBreadNum)
    {
      newBread.BreadOrder(inputtedBreadNum);
    }




  }
}