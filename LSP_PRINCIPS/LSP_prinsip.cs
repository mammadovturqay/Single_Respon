public class Bird
{
    public virtual void Fly()
    {
        Console.WriteLine("Can fly ");
    }
}

public class Sparrow : Bird // serce ucur 
{
    public override void Fly()
    {
        Console.WriteLine("Serce ucur .. .");
    }
}

public class Chicken : Bird
{
    //Ucanmir )

}

class LSP_prinsip
{
    static void Main(string[] args)
    {
        Bird bird1 = new Sparrow();
        bird1.Fly(); 

        Bird bird2 = new Chicken();
        bird2.Fly(); 
    }
}
