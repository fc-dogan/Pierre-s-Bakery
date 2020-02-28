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
      BreadAmount = 0;
      BreadPrice = 5;
      BreadTotalPrice = 0;
      BreadUpdate = "";
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
     BreadUpdate =$"{BreadAmount} loaves of Bread = ${BreadTotalPrice}";
    }


  }
}