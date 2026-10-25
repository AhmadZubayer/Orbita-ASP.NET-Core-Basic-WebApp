namespace Orbita_ProductTrackingApp_ASP.NET_Core.Models
{
    public class Supplier
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Supplier(string name, string email, string phone)
        {
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
        }
    }
}
