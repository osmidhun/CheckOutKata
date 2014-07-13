using System.Collections.Generic;

namespace CheckOutProcessor
{
    public class CheckOutProcess : ICheckOutProcess
    {
        private readonly IOfferStore _store;
        
        private readonly Dictionary<string, int> _checkOutCounter;

        public CheckOutProcess(IOfferStore store)
        {
            _store = store;

            
            _checkOutCounter=new Dictionary<string, int>();
            Total = 0;
            
        }

        public decimal CheckOut(string skuId, decimal price)
        {
            if (_checkOutCounter.ContainsKey(skuId))
            {
                _checkOutCounter[skuId] += 1;
            }
            else
            {
                _checkOutCounter.Add(skuId,1);
            }
            Total += price;
            Total -= _store.GetOfferAmount(skuId, _checkOutCounter[skuId]);
            return Total;
        }


        protected decimal Total { get;private set; }
    }


}
