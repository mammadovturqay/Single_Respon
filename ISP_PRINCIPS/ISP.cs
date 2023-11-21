


//  dersde islediyim amozon drobox kimidi amma bunda ferqliidi 
public interface IReadable
{
    void Read();
}

public interface IWritable
{
    void Write();
}

public class Printer : IReadable, IWritable
{
    public void Read()
    {
        // Printerin oxuma funksionalıq
    }

    public void Write()
    {
        // Printerin yazma funksionalıq
    }
}

public class Scanner : IReadable
{
    public void Read()
    {
        // Scannerin oxuma funksionalıq
    }
}

public class Program
{
    static void Main(string[] args)
    {
        IReadable printer = new Printer();
        printer.Read(); // Printerin oxuma funksionalıq

        IWritable printerWritable = new Printer();
        printerWritable.Write(); // Printerin yazma funksionalıq

        IReadable scanner = new Scanner();
        scanner.Read(); // Scannerin oxuma funksionalıq

        // IWritable scannerWritable = new Scanner();
        // scannerWritable.Write(); // Scanner de yazmaq kimi funksiya olmadiginin sehv cixir . Ancaq oxumaq olar 
        // Bile bile yazb comment almiwam 
    }
}
