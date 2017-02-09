using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Airal.Shipping.Models
{
    public class ShippingData
    {
        public string Shipper { get; internal set; }
        public string TrackingCode { get; internal set; }
    }
}