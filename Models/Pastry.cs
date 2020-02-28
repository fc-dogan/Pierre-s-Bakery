namespace Models
{
  public class Pastry
  {
    public int PastryAmount {get; set;}
    public int PastryPrice {get; set;}
    public int PastryTotalPrice {get; set;}
    public string PastryUpdate {get; set;}
    
    public Pastry()
    {
      PastryAmount = 0;
      PastryPrice = 3;
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
      PastryTotalPrice = PastryAmount * PastryPrice;
      PastryUpdate =$"{PastryAmount} pastry = ${PastryTotalPrice}";
      }

  }
}