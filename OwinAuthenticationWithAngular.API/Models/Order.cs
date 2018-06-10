namespace OwinAuthenticationWithAngular.API.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public bool IsShipped { get; set; }
    }
}