namespace ConsoleApp4
{



    // Yalniz bir meqsed dasiyan class dir Single 
    public class FileManager  
    {
        public readonly Ilogger logger;

        public FileManager (Ilogger logger)
        {
            this.logger = logger;
        }


        public void ReadFile(string filePath)
        {
            //Fayli oxuyan funksiya yanlis oldugu halda eror tutur kod cokmur 
            try
            {
                Console.WriteLine($"Reading file: {filePath}");
            }
            catch (Exception ex)
            {
                logger.LogError($"Error reading file: {ex.Message}");
            }
        }

        public void WriteFile(string filePath, string content)
        {
            try
            {
                // File melumat yazir yanlis oldugu halda eroru tutur qoymur kod coksun ! 
                Console.WriteLine($"Writing to file: {filePath}");
            }
            catch (Exception ex)
            {
                logger.LogError($"Error writing to file: {ex.Message}");
            }
        }





    }

    public interface Ilogger
    {
        void LogError(string message);
        void LogInfo (string message);

    }

    public class Logger : Ilogger
    {
        public void LogError(string message )
        {
            Console.WriteLine($"Eror Message : {message}");

        }

        public void LogInfo (string message)
        {

            Console.WriteLine($"Info : {message}");
        }
    }

class Program
    {
        static void Main(string[] args)
        {
            Ilogger iloggerlogger = new Logger();
            FileManager fileManager = new FileManager(iloggerlogger);
            string filePath = "Single.txt";
            string content = "Single prinsip !";

            fileManager.ReadFile(filePath);
            fileManager.WriteFile(filePath, content);
        }
    }


}