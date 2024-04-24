using System.Threading.Channels;

namespace Task2;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Потрібно: Створити клас Converter. У тілі класу створити користувальницький конструктор,
 * який приймає три речові аргументи, і ініціалізує поля, що відповідають курсу 3-х основних валют,
 * по відношенню до гривні – public Converter (double usd, double eur, double rub).
 * Написати програму, яка виконуватиме конвертацію з гривні в одну із зазначених валют,
 * також програма повинна проводити конвертацію із зазначених валют у гривню. 
 */
class Program
{
    static void Main(string[] args)
    {
        const string menu = @"Виберіть необхідну дію:
1. Конвертувати UAH в USD
2. Конвертувати UAH в EUR
3. Конвертувати UAH в USDT
4. Конвертувати USD в UAH
5. Конвертувати EUR в UAH
6. Конвертувати USDT в UAH";
        Converter converter = new Converter(40.05, 43.50, 41.60);
        string currency = "UAH" ,currencyTemp = "UAH", selectAction ="" ;
        while (true)
        {
            Console.WriteLine(menu);
            string enterSelectPoint = Console.ReadLine();
            switch (enterSelectPoint)
            {
                case "4":
                    selectAction = "uan_from_usd";
                    currency = "UAH";
                    currencyTemp = "USD";
                    break;
                case "5":
                    selectAction = "uan_from_eur";
                    currency = "UAH";
                    currencyTemp = "EUR";
                    break;
                case "6":
                    selectAction = "uan_from_usdt";
                    currency = "UAH";
                    currencyTemp = "USDT";
                    break;
                case "1":
                    selectAction = "usd";
                    currency = "USD";
                    currencyTemp = "UAH";
                    break;
                case "2":
                    selectAction = "eur";
                    currency = "EUR";
                    currencyTemp = "UAH";
                        break;
                case "3": 
                    selectAction = "usdt";
                    currency = "USDT";
                    currencyTemp = "UAH";
                    break;
            }
          
            Console.WriteLine("Введіть суму для конвертації");
            Decimal.TryParse(Console.ReadLine(), out decimal value);
            Console.WriteLine(new string('*',30));
            Console.Write($"{value} "+ currencyTemp +"\n");
            
            Console.WriteLine($"Результат конвертації {converter.ConvertTo(selectAction, value):F2} "+currency);
            Console.WriteLine(new string('*',30));
        }
    }
}