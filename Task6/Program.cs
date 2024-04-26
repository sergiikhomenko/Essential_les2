namespace Task6;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Потрібно: Створити клас User, що містить інформацію про користувача
 * (логін, ім'я, прізвище, вік, дату заповнення анкети). Поле дата заповнення
 * анкети має бути проініціалізоване лише один раз (при створенні екземпляра
 * цього класу) без можливості його подальшої зміни. Реалізуйте виведення на
 * екран інформації про користувача.
 */
class Program
{
    static void Main(string[] args)
    {
        string login, fName, lName;
        int age;
        while (true)
        {
            Console.WriteLine("Введіть дані про користувача");
            
            Console.WriteLine("Введіть логін ");
            login = Console.ReadLine();
            
            Console.WriteLine("Введвть імя");
            fName = Console.ReadLine();
            
            Console.WriteLine("Введіть прізвище");
            lName = Console.ReadLine();
            
            Console.WriteLine("Введіть вік");
            Int32.TryParse(Console.ReadLine(), out age);
            
            User user = new User(login, fName, lName, age,DateTime.Now);
            Console.WriteLine(new string('*',40));
            user.OutInformUser();
            
            Console.ReadKey();
            Console.Clear();
        }
        
    }
}