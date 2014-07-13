using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOutProcessor
{
    public class OfferStore : IOfferStore
    {

        private readonly Dictionary<string, OfferData> _store;

        public OfferStore()
        {
            _store = new Dictionary<string, OfferData>();
        }

        public void Add(OfferData data)
        {
            _store.Add(data.SkuId, data);
        }

        public decimal GetOfferAmount(string skuId, int count)
        {
            OfferData offerData;
            if (_store.TryGetValue(skuId, out offerData))
            {
                var result = 0;
                var reminder = 0;
                result = Math.DivRem(count, offerData.OfferEligibiltyCount, out reminder);
                if (reminder == 0)
                {
                    return offerData.OfferAmount * result;
                }
            }

            return 0;
        }

    }
}
