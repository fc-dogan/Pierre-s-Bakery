namespace Models
{
  public class Pastry
  {
    public int PastryAmount {get; set;}
    public int PastryPrice {get; set;}
    // public int DiscountedPrice {get; set;}
    public int PastryTotalPrice {get; set;}
    public string PastryUpdate {get; set;}
    
    public Pastry()
    {
      PastryAmount = 0;
      PastryPrice = 2;
      // DiscountedPrice = 5;
      PastryTotalPrice = 0;
      PastryUpdate = "";
    }

      public void PastryOrder(int inputtedAmount)
      {
        AddPastry(inputtedAmount);
        CalculateTotal();
      }

      private void AddPastry(int inputtedAmount)
      {
        PastryAmount += inputtedAmount;
      }

      private void CalculateTotal()
      {
        if (PastryAmount % 3 == 0)
        {
          // for three pastries:
          PastryPrice = 5;
          PastryTotalPrice = (PastryAmount/3) * PastryPrice;
          PastryUpdate =$"{PastryAmount} pastry = ${PastryTotalPrice}";
        }
        else 
        {
          PastryPrice = 2;
          PastryTotalPrice = PastryAmount * PastryPrice;
          PastryUpdate =$"{PastryAmount} pastry = ${PastryTotalPrice}";
        }
      }

  }
}