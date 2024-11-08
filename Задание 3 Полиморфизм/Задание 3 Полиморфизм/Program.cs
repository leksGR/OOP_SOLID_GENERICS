Dog dog = new Dog();
Cat cat = new Cat();
dog.MakeSound();
cat.MakeSound();

public class Animal
{
    public virtual void MakeSound() 
    {
        Console.WriteLine("Животное говрит:");
    }
}
public class Dog : Animal
{
    public override void MakeSound()
    {
        base.MakeSound();
        Console.WriteLine("Гав-гав\n");
    }
}
public class Cat : Animal
{
    public override void MakeSound()
    {
        base.MakeSound();
        Console.WriteLine("Мяу-мяу\n");
    }
}