namespace CheckOutProcessor
{
    public class CheckOutProcessor
    {
        public CheckOutProcessor()
        {
            Total = 0;
        }

        public decimal CheckOut(string skuId, decimal price)
        {
            Total += price;
            return Total;
        }

        protected decimal Total { get; set; }
    }
}
