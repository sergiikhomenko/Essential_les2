namespace Task4;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
   Потрібно: Створити клас Invoice. У тілі класу створити три поля int account, 
   string customer, string provider, які мають бути проініціалізовані один раз 
   (при створенні екземпляра даного класу) без можливості їхньої подальшої зміни.
   У тілі класу створити два закриті поля string article, 
    int quantity
    Створити метод розрахунку вартості замовлення з ПДВ та без ПДВ.
    Написати програму, яка виводить на екран суму оплати замовленого товару з ПДВ чи без ПДВ.
 */
public class Invoice
{
    private readonly int _account;
    private readonly string _customer, _provider;
    
    private string _article;
    private  int _quantity ;
    private  decimal _price ;

    public Invoice(int account, string customer, string provider, 
        string article, int quantity, decimal price)
    {
        _account = account;
        _customer = customer;
        _provider = provider;
        _article = article;
        _quantity = quantity;
        _price = price;
    }

    public void CollCalcInvose(int pointMenu)
    {
        switch (pointMenu)
        {
            case 1: 
                Console.WriteLine($"Сума замовлення з ПДВ: {CalcInvoseVsPDV(_price, _quantity)}");
                break;
            case 2:
                Console.WriteLine($"Сума замовлення без ПДВ: {CalcInvose(_price, _quantity)}");
                break;
            default: Console.WriteLine("Дана опція не доступна");
                break;
        }
    }

    decimal CalcInvoseVsPDV(decimal price, int  quantity)
    {
        decimal sumInvoseVsPDV;
        decimal totalSumForGoods = quantity * price;
        sumInvoseVsPDV = totalSumForGoods +  (totalSumForGoods * (decimal)0.2);
        return sumInvoseVsPDV;
    }
    
     decimal CalcInvose(decimal price, int  quantity)
    {
        return quantity * price;
    }
}