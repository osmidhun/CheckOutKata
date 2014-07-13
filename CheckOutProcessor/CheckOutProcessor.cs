namespace CheckOutProcessor
{
    public class CheckOutProcessor
    {
        public CheckOutProcessor()
        {
            Total = 0;
            Count = 0;
        }

        public decimal CheckOut(string skuId, decimal price)
        {
            if (skuId=="A")
            {
                Count += 1;
                if (Count == 3)
                {
                    Total -= 20;
                }
            }
            Total += price;
          
            return Total;
        }
        protected int Count { get; set; }
        protected decimal Total { get; set; }
    }
}
