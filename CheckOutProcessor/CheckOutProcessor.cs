namespace CheckOutProcessor
{
    public class CheckOutProcessor
    {
        private int CountB;
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
            if (skuId == "B")
            {
                CountB += 1;
                if (CountB == 2)
                {
                    Total -= 15;
                }
            }
            Total += price;
          
            return Total;
        }
        protected int Count { get; set; }
        protected decimal Total { get; set; }
    }
}
