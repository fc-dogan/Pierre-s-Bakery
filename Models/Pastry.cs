namespace Models
{
  public class Pastry
  {
    public int PastryAmount {get; set;}
    public int PastryPrice {get; set;} = 2;
    
    public int PastryTotalPrice {get; set;}
    public string PastryUpdate {get; set;}
    
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
        if (PastryAmount > 2)
        {
          int beforeDiscountPrice = PastryAmount * PastryPrice;
          PastryTotalPrice = beforeDiscountPrice - (PastryAmount / 3);
          PastryUpdate =$"{PastryAmount} pastry = ${PastryTotalPrice}";
        }
        else 
        {
          PastryTotalPrice = PastryAmount * PastryPrice;
          PastryUpdate =$"{PastryAmount} pastry = ${PastryTotalPrice}";
        }
      }

  }
}