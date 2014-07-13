namespace CheckOutProcessor
{
    public interface ICheckOutProcessor
    {
        decimal CheckOut(string skuId, decimal price);
    }
}