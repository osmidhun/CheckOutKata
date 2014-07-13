using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOutProcessor
{
    public class OfferData
    {
        public string SkuId { get; set; }
        public decimal OfferAmount { get; set; }
        public int OfferEligibiltyCount { get; set; }

    }
}
