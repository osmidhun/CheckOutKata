using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOutProcessor
{
  public  class OfferStore
  {

      private readonly Dictionary<string, OfferData> _store;

      public OfferStore()
      {
          _store=new Dictionary<string, OfferData>();
      }

      public void Add(OfferData data)
      {
          _store.Add(data.SkuId, data);
      }

      public decimal GetOfferAmount(string skuId, int count)
      {
         
          return 0;
      }

  }
}
