namespace Task4;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
   Потрібно: Створити клас Invoice. У тілі класу створити три поля int account, 
   string customer, string provider, які мають бути проініціалізовані один раз 
   (при створенні екземпляра даного класу) без можливості їхньої подальшої зміни.
    У тілі класу створити два закриті поля string article, 
    int quantity Створити метод розрахунку вартості замовлення з ПДВ та без ПДВ.
    Написати програму, яка виводить на екран суму оплати замовленого товару з ПДВ чи без ПДВ.
 */
class Program
{
    static void Main(string[] args)
    {
        Invoice invoice = new Invoice(12345, "John Doe", "SomeProvider", 
            "SomeArticle", 10,456);

        while (true)
        {
            Console.WriteLine(@"1.Сума рахунку з ПДВ 
2. Сума рахунку без ПДВ ");
            int selectPointMenu;
        
            Int32.TryParse(Console.ReadLine(), out selectPointMenu);
            Console.WriteLine(new string('*' , 30));
            invoice.CollCalcInvose(selectPointMenu);
            Console.WriteLine(new string('*' , 30));
        }
    }
}