using System;
using Models;

namespace Bakery
{
  public class Program
  {

    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("Bread: Pastry: "   );
      // add Price for both
      Console.WriteLine("Start your order: (Press 'Enter')");
      Console.ReadLine();
      Console.WriteLine("Would you like to order Bread or Pastry? (to order bread, type:  'bread'-- to order pastry, type: 'pastry') ");
      Console.ReadLine();
    }




  }
}