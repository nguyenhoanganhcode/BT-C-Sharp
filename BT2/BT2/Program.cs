using System;
namespace BT2
{
    internal class Bt2
    {
        static void Main(string[] args)
        {
            string ten;
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            ten = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            Console.WriteLine(" Hello " + ten);
            Console.ReadLine();
        }
    }
}
