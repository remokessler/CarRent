namespace CarRent.Backend.Domain.Cars
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public Brand(string name)
        {
            Name = name;
        }
    }
}