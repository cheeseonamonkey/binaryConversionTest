using System;

namespace binaryConversionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{ByteConverter.ByteToHex("10010000")}");
            Console.WriteLine($"\n");
            Console.WriteLine($"{ByteConverter.HexToByte("90")}");

            ByteReader byteReader = new ByteReader();

            byteReader.WriteToBin();
            byteReader.ReadFromBin();

        }
    }
}
