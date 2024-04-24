namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        Employee vasya = new Employee("Вася", "Пупкін", "бухгалтер", 5);
        Employee toha = new Employee("Анатолій", "капітошка", "інженер", 10);
        Employee anastasiia = new Employee("Анастасія", "Чук", "деректор", 15);
        Employee oleksandr = new Employee("Олександр", "Циклоп", "прибиральник", 15);
        
        vasya.CallCalcSalary();
        toha.CallCalcSalary();
        anastasiia.CallCalcSalary();
        oleksandr.CallCalcSalary();
     
    }
}