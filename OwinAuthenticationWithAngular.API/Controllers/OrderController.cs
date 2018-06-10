using OwinAuthenticationWithAngular.API.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace OwinAuthenticationWithAngular.API.Controllers
{
    [RoutePrefix("api/Orders")]
    public class OrderController : ApiController
    {
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            List<Order> orders = new List<Order>
            {
                new Order {Id = 10248, CustomerName = "Lazada", CustomerAddress = "Hougang", IsShipped = true },
                new Order {Id = 10249, CustomerName = "Qoo10", CustomerAddress = "Yishun", IsShipped = false},
                new Order {Id = 10250,CustomerName = "Amazon", CustomerAddress = "Woodlands", IsShipped = false },
                new Order {Id = 10251,CustomerName = "Carousel", CustomerAddress = "Ang Mo Kio", IsShipped = false},
                new Order {Id = 10252,CustomerName = "Zalora", CustomerAddress = "Raffles Place", IsShipped = true}
            };

            return Ok(orders);
        }
    }
}
