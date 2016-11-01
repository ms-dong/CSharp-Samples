using System;
using System.IO;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        public static Stream ByteToStream(Byte[] byteArray)
        {
            //MemoryStream stream = new MemoryStream();
            //stream.Write(byteArray, 0, byteArray.Length);
            return new MemoryStream(byteArray);
        }
    }
}
