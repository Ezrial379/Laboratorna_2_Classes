
class Program
{
    static void Main(string[] args)
    {
        Converter convert1 = new Converter(); // об'єкт 1

        Console.Write("Введіть кількість гривен: ");
        convert1.Amount_UAH = Convert.ToInt32(Console.ReadLine()); // Зчитуємо гривни
        convert1.UAH_in_curr(); // викликаємо метод UAH_in_curr


        Converter convert2 = new Converter(); //об'єкт 2


        Console.Write("Введіть кількість USD: ");
        convert2.Amount_USD = Convert.ToInt32(Console.ReadLine()); // зчитуємо доллари переводимо зі строкового в числовий 
        Console.Write("Введіть кількість EUR: ");
        convert2.Amount_EUR = Convert.ToInt32(Console.ReadLine()); // зчитуємо євро переводимо зі строкового в числовий 
        Console.Write("Введіть кількість PLN: ");
        convert2.Amount_PLN = Convert.ToInt32(Console.ReadLine()); // зчитуємо злоті переводимо зі строкового в числовий 
        convert2.Curr_in_UAH(); // викликаємо метод Curr_in_UAH
    }
        }
class Converter
{

    private double usd; //  ||
    private double eur; //  ||> в цих рядках вводимо змінні, які будуть курсами купівлі валюти 
    private double pln; //  ||
    private int amount_uah; // ||
    private int amount_usd; // ||> в цих рядках вводимо змінні, які потім будемо вводити вручну - це кількістю грошей, яку треба перевести 
    private int amount_eur; // ||
    private int amount_pln; // ||


    public Converter() // користувацький консруктор
    {
        Console.WriteLine("Конвертація валюти: ");
        usd = 41.70;
        eur = 40.51;
        pln = 8.25;
        amount_uah = 0;
        amount_usd = 0;
        amount_eur = 0;
        amount_pln = 0;
    }

    public int Amount_UAH                                        //
    { get { return amount_uah; } set { amount_uah = value; } }   //
    public int Amount_USD                                        //
    { get { return amount_usd; } set { amount_usd = value; } }   //  В рядках 44-51 вводимо властивості, які потім вводитимо вручну
    public int Amount_EUR                                        //     
    { get { return amount_eur; } set { amount_eur = value; } }   //
    public int Amount_PLN                                        //
    { get { return amount_pln; } set { amount_pln = value; } }   //


    public void UAH_in_curr() // метод переведення гривни в валюту
    {
        Console.WriteLine($"{amount_uah} UAH в:");
        Console.WriteLine($"USD = {amount_uah / usd};");
        Console.WriteLine($"EUR = { amount_uah / eur};");
        Console.WriteLine($"PLN = {amount_uah / pln};");
    }
    public void Curr_in_UAH() // метод переведення валюти в гривну
    {
        Console.WriteLine($"{amount_usd} USD = {amount_usd * usd} UAH;");
        Console.WriteLine($"{amount_eur} EUR = {amount_eur * eur} UAH;");
        Console.WriteLine($"{amount_pln} PLN = {amount_pln * pln} UAH");
    }
}
