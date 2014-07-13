namespace CheckOutProcessor
{
    public interface IOfferStore
    {
        decimal GetOfferAmount(string skuId, int count);
    }
}