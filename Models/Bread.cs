namespace Models
{
  public class Bread
  {
    public int BreadAmount {get; set;}
    public int BreadPrice {get; set;}
    public int BreadTotalPrice {get; set;}
    public string BreadUpdate {get; set;}
    
    public Bread()
    {
      BreadPrice = 5;  
    }

    public void BreadOrder(int inputtedAmount)
    {
      AddBread(inputtedAmount);
      CalculateTotal();
    }

    private void AddBread(int inputtedAmount)
    {
      BreadAmount += inputtedAmount;
    }

    private void CalculateTotal()
    {
      BreadTotalPrice = BreadAmount * BreadPrice;
      if (BreadAmount > 2)
      {
        int discount = BreadPrice * (BreadAmount/3);
        BreadTotalPrice -= discount; 
        BreadUpdate =$"{BreadAmount} loaves of Bread = ${BreadTotalPrice}";
      } 
      else
      {
        BreadUpdate =$"{BreadAmount} loaves of Bread = ${BreadTotalPrice}";
      } 
    }

  }
}