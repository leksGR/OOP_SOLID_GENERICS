PercentageDiscount finalAmount_1 = new PercentageDiscount();
FixedAmountDiscount finalAmount_2 = new FixedAmountDiscount();
finalAmount_1.Calculate(200, 40);
finalAmount_2.Calculate(200, 40);
public abstract class Discount 
{
    public abstract void Calculate(int amount, double discount);
}
public class PercentageDiscount : Discount // Класс, в котором метод Calculate, получая процент скидки, рассчитывает сумму покупки
{
    public override void Calculate(int amount, double percent)
    {
        Console.WriteLine($"{amount}$ при скидке {percent}% : {amount - amount * (percent / 100)}$");
    }
}
public class FixedAmountDiscount : Discount // Класс, в котором метод Calculate, получая фиксированную сумму скидки, рассчитывает сумму покупки
{
    public override void Calculate(int amount, double fixedAmountDiscount)
    {
        Console.WriteLine($"{amount}$ при сумме скидки {fixedAmountDiscount}$ : {amount - fixedAmountDiscount}$");
    }
}
