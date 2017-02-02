using Airal.Shipping.Models;
using Swashbuckle.Swagger.Annotations;
using System.Web.Http;

namespace Airal.Shipping.Controllers
{
    public class ShippingDataController : ApiController
    {
        // GET api/shippingdata
        [SwaggerOperation("GetShippingData")]
        public ShippingData Get()
        {
            return ShippingDataFactory.GetData();
        }
    }
}
