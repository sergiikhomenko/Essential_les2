namespace Task2;
/*
* клас Converter. У тілі класу створити користувальницький конструктор,
* який приймає три речові аргументи, і ініціалізує поля, що відповідають курсу 3-х основних валют,
* по відношенню до гривні – public Converter (double usd, double eur, double rub).
 */
public class Converter
{
    private  double _usd, _eur, _usdt;
    
    public Converter(double usd, double eur, double usdt)
    {
        _usd = usd;
        _eur = eur;
        _usdt = usdt;
    }

    public decimal ConvertTo(string currency, decimal sum)
    {
        decimal resultConvert = default;
        switch (currency)
        {
            case "usd": resultConvert = sum / (decimal)_usd;
                break;
            case "eur": resultConvert = sum / (decimal)_eur;
                break;
            case "usdt": resultConvert = sum / (decimal)_usdt;
                break;
            case "uan_from_usd": resultConvert = sum *(decimal) _usd;
                break;
            case "uan_from_eur": resultConvert = sum *(decimal) _eur;
                break;
            case "uan_from_usdt": resultConvert = sum *(decimal) _usdt;
                break;
        }
        return resultConvert;
    }
   
}