using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace Project2104.DataModels
{
    public class Shoe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        public Shoe(int id, string name, double price, string image, string category, string description)
        {
            Id = id;
            Name = name;
            Price = price;
            Image = image;
            Category = category;
            Description = description;
        }
    }


}
