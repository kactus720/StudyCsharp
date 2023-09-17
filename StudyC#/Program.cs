using System;
using System.IO;
namespace Program.cs

{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            using (FileStream stream = new FileStream("info.txt", FileMode.Open))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                stream.Write(array, 0, array.Length);
            }



        }
    }
        
}
