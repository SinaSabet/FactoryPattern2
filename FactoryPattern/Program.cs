Creator creator = new Creator();

var result=creator.CreateProduct("ConcreteProduct2");

result.Excute();

Console.ReadKey();

public abstract class  Product
{
    public abstract void Excute();

}


public class ConcreteProduct1 : Product
{
    public override void Excute()
    {
        Console.WriteLine("Run ConcreteProduct1");
    }
}


public class ConcreteProduct2 : Product
{
    public override void Excute()
    {
        Console.WriteLine("Run ConcreteProduct2");
    }
}


public abstract class CreatorAbstraction
{
    public abstract Product CreateProduct(string concreteClass);
}

public class Creator : CreatorAbstraction
{
    public override Product CreateProduct(string concreteClass)
    {
        if (concreteClass== "ConcreteProduct1")
        {
            return new ConcreteProduct1();
        }
        if (concreteClass== "ConcreteProduct2")
        {
            return new ConcreteProduct2();

        }
        else
        {
            return new ConcreteProduct1();

        }
    }
}
