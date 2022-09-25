
class Program
{
    static void Main(string[] args)
    {
        User someUser = new User();
        someUser.Login = "Ezrial";
        someUser.Name = "Jack";
        someUser.Lastname = "Trueman";
        someUser.Age = 18;
        someUser.SetDate(DateTime.UtcNow);
        someUser.Print();
    }
}

class User
{
    private string login;
    private string name;
    private string lastname;
    private int age;
    private static DateTime date; // Ставимо static, щоб поле класу стало статичним 

    public string Login { get { return login; } set { login = value; } }
    public string Name { get { return name; } set { name = value; } }
    public string Lastname { get { return lastname; } set { lastname = value; } }
    public int Age { get { return age; } set { age = value; } }
    public void SetDate(DateTime date)
    {
        User.date = date;  // this. використати не вийде, тому напряму звертаємось до класу.
    }
    public void Print()
    {
        Console.WriteLine($"Login: {login}; Name: {name}; Lastname: {lastname}; Age: {age}; Date: {date} ");
    }
}