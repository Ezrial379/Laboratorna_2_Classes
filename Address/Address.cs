
class Program
{
    static void Main(string[] args)
    {
        Address address = new Address();

        address.Index = 02000;
        address.Country = "Ukraine";
        address.City = "Kyiv";
        address.Street = "Kioto";
        address.House = "19A";
        address.Apartment = 20;

        address.Print();
    }

        }

class Address {
    private int index = 0;
    private string country = "Undefined";
    private string city = "Undefined";
    private string street = "Undefined";
    private string house = "Undefined";
    private int apartment = 0;

    public int Index { get { return index; } set { index = value; } }
    public string Country { get { return country; } set { country = value; } }
    public string City { get { return city; } set { city = value; } }
    public string Street { get { return street; } set { street = value; } }
    public string House { get { return house; } set { house = value; } }
    public int Apartment { get { return apartment; } set { apartment = value; } }

    public void Print()
    {
        Console.WriteLine($"Index: {index},  Country: {country}, City: {city}, Street: {street}, House: {house}, Apartment: {apartment}");
    }
}
