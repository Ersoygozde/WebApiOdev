namespace MyFirstConsoleApp;

internal class Program
{// blok code blogu 
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //string int decimal double float boolean datetime object
        // type degisken_adi = degeri; // degisken syntax yapisi // syntax hatasi => kodlama yaparken kodda yapilan harf ya da tanimlama  hatasi
        string nameLastname = "Taner Saydam";
        int age = 33;
        decimal salary = 47500.20m;
        bool isActive = true; //false olumsuz -- 0 => false / 1 => true
        DateTime startDate = DateTime; // September 26, 2023 21:23.10,000
        string name = "Taner";
        Console.WriteLine("Merhaba " + name);
        string readLine = Console.ReadLine();
        Console.WriteLine("Yazdigin sey: " + readLine);
        string readline = Console.ReadLine();
        Console.WriteLine("Yazdigin sey:" + readline);

    }

}// scope