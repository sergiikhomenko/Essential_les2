using System.Reflection.Metadata;

namespace Task3;
/*
 *Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Потрібно створити клас Employee. У тілі класу створити користувальницький конструктор,
 * який приймає два рядкові аргументи, та ініціалізує поля, що відповідають прізвищу
 * та імені співробітника. Створити метод, що розраховує оклад співробітника
 * (залежно від посади та стажу) та податковий збір.
 * Написати програму, яка виводить на екран інформацію про співробітника
 * (прізвище, ім'я, посада), оклад та податковий збір.
 */ 
public class Employee
{ 
    private string _fname, _lname;
    private string _post;
    private int _yearWork;
    private decimal _salary;
    
    public Employee(string firstName, string lastName, string post,int yearWork)
    {
        _fname = firstName; 
        _lname = lastName;
        _post = post;
        _yearWork = yearWork;
    }

    public void CallCalcSalary()
    {
        CalcSalary(_post,_yearWork);
    }

     void CalcSalary(string post, int yearWork)
    {
        decimal selaryKof = 1;
        if (yearWork <= 5)
        {
            selaryKof = 10;
        }
        if (yearWork >=10)
        {
            selaryKof = 20;
        }
        switch (post)
        {
            case "бухгалтер": 
            case "інженер":
                _salary = 20000;
                break;
            case "деректор":
                _salary = 30000;
                break;
            case "прибиральник":
                _salary = 8500;
                break;
        } 
        decimal selaryAndYearWork =_salary + (_salary*selaryKof)/100;
        decimal tax = selaryAndYearWork * (decimal)0.2;
        decimal selaryAndTax =  selaryAndYearWork - tax;
        
        Console.WriteLine();
        Console.WriteLine($"Прізвище {_lname}\n" +
                          $"Імя {_fname} \n" +
                          $"Посада {_post}\n" +
                          $"Стаж {_yearWork}\n");
        Console.WriteLine(new string('*',30));
        Console.WriteLine($"Заробітня плата з урахуванням стажу та за мінусом податку {selaryAndTax} \n" +
                          $"Податок становить: {tax}\n" +
                          $"Надбавка за роки праці: {selaryKof}%\n" +
                          $"Надбавка за роки праці: {(_salary*selaryKof)/100}");
        Console.WriteLine(new string('*',30));
        
    }
}