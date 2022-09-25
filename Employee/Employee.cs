class Program
{
    static void Main(string[] args)
    {
        Employee emp1 = new("Tom", "Hanks"); // Створюється об'єкт з Ім'ям Том, Прізвищем Хенкс

        emp1.Print(); // Викликаємо метод для відображення Імені та Прізвища
        emp1.Oklad(args); // Викликаємо метод для вибору посади, обрахунку зарплатні, та податку
    }
}
class Employee
{
        public string name;
        public string lastname;
        public Employee(string name = "Unk", string lastname = "Unk") // Поля класу називаються так само, як і параметри - використовуємо this.
        {
            this.name = name;
            this.lastname = lastname;
        }
        public void Print() => Console.WriteLine($"Name: {name}  Lastname: {lastname}"); // Виводимо ім'я да прізвище
        public void Oklad(string[] args) // Створюємо метод
        {
            int min = 13000, posada, exp; // створюємо змінні "min" (мінімальний оклад нижчої ланки, від якої відштовхуємось), "посада" і "стаж"

            double oklad = 0, coef_posada = 0, coef_exp = 0, podatok = 0; // Створюємо змінні "оклад" (шукане), "коефіцієнт посади" (він буде змінюватись
                                                                          // в залежності від посади), "коефіцієнт стажу" (він буде змінюватись
                                                                          // в залежності від стажу) і "податок" (шукане)

        Console.WriteLine("Вкажiть посаду вашого працiвника цифрою вiд 1 до 3"); // Визначаємо посаду працівника, присвоюючи кожній посаді свій номер
            Console.WriteLine("1 - junior");
            Console.WriteLine("2 - middle");
            Console.WriteLine("3 - senior");
            posada = int.Parse(Console.ReadLine());

        switch (posada) // Кожна посада має різний коефіцієнт, який буде множитись на мінімальний оклад. Вище посада - вище коефіцієнт - вища зп
        {
                case 1: // Джун
                    coef_posada = 1.08;
                    break;

                case 2: // Мудл
                    coef_posada = 2;
                    break;

                case 3: // Сеньйор
                    coef_posada = 2.5;
                    break;

            default:
                Console.WriteLine("You are banned from this server :3 Try again"); // При не вірно введеному числі нічого не вийде
                break;

            }
            Console.WriteLine($"Вкажiть стаж вашого працiвника в роках: "); // Просимо ввести стаж працівника
            exp = int.Parse(Console.ReadLine());
            if (exp <= 5)         // Використовуємо оператор if для визначення коефіцієнта стажу. Вище стаж - вище коефіцієнт - вища зп
            {
                coef_exp = 1.15;
            }
            if (exp > 5 && exp <= 10)
            {
                coef_exp = 1.30;
            }
            if (exp > 10)
            {
                coef_exp = 1.50;
            }

            Console.WriteLine($"Оклад Вашого працiвника: {oklad = min * coef_posada * coef_exp}"); // Рахуємо оклад перемножуючи мінімальний оклад нижчої ланки,
                                                                                            // коефіцієнт посади і коефіцієнт стажу.
            
            
            Console.WriteLine($"Податок на зарплатню працiвника: {podatok = oklad * 0.18}"); //Аби порахувати податок - множимо оклад на податок на доходи
                                                                                             //фізичних осіб (18%)
    }
    }


