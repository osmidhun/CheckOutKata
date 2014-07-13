namespace CheckOutProcessor
{
    public interface ICheckOutProcess
    {
        decimal CheckOut(string skuId, decimal price);
    }
}