namespace Task6;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Потрібно: Створити клас User, що містить інформацію про користувача
 * (логін, ім'я, прізвище, вік, дату заповнення анкети). Поле дата заповнення
 * анкети має бути проініціалізоване лише один раз (при створенні екземпляра
 * цього класу) без можливості його подальшої зміни. Реалізуйте виведення на
 * екран інформації про користувача.
 */
public class User
{
    private string _login, _fname, _lname; 
    private int _age;
    private readonly DateTime _dateCreaate;
    public User( string login, string fName, string lName, int age, DateTime dateCreate )
    {
        _login = login;
        _fname = fName;
        _lname = lName;
        _age = age;
        _dateCreaate = dateCreate;
    }

    public void OutInformUser()
    {
        Console.WriteLine($"Логін: {_login}\n" +
                          $"Імя: {_fname}\n" +
                          $"Прізвище: {_lname}\n" +
                          $"Вік: {_age}\n" +
                          $"Дата заповнення: {_dateCreaate.Day}.{_dateCreaate.Month}.{_dateCreaate.Year}" );
    }
}