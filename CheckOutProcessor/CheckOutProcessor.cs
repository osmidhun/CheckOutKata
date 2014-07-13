namespace CheckOutProcessor
{
    public class CheckOutProcessor
    {
        private int _countB;
        private int _countA;

        public CheckOutProcessor()
        {
            Total = 0;
            _countA = 0;
            _countB = 0;
        }

        public decimal CheckOut(string skuId, decimal price)
        {
            if (skuId=="A")
            {
                _countA += 1;
                if (_countA == 3)
                {
                    Total -= 20;
                }
            }
            if (skuId == "B")
            {
                _countB += 1;
                if (_countB == 2)
                {
                    Total -= 15;
                }
            }
            Total += price;
          
            return Total;
        }
        

        protected decimal Total { get; set; }
    }
}
