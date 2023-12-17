using System.ComponentModel.Design;

namespace ChatUIConsoleApp2;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hi, I am Chat UI.");
        Console.WriteLine("I want to know you better.");
        Console.WriteLine("Please tell me your name?");
        string name = Console.ReadLine(); // sari ya da mavi alt cizgi warning
        Console.WriteLine("Nice to meet you" + name);
        Console.WriteLine("Where are you from?");
        string from = Console.ReadLine();
        Console.WriteLine("Oww, that's great! I am from US");
        Console.WriteLine("How old are you?");
        string age = Console.ReadLine(); // kirmizi alt cizgi hata
        Console.WriteLine("Great! Ok, your name is " + name + " you write me from " + from + " and you are " + age + " years old.");
        Console.WriteLine("Am I correct?");
        string result = Console.ReadLine();
        //sart bloglari
        if (result == "Yes")
        {
            Console.WriteLine("That is great. I am really happy!");
        }
        else if (result == "No")
        {
            Console.WriteLine("Oww, I am sorry for misunderstanding");
        }   
        else 
        {
            Console.WriteLine("I don't understand your response!");
        }
        { 
        



        }
    }       
}