using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace binaryConversionTest
{
    class ByteReader
    {
        public ByteReader()
        {
        }

        //write method for debugging sanity
        public void WriteToBin()
        {
            FileStream fileStream = File.Open("stuff.bin", FileMode.Create);

            //Something is fucky in this method
            //I think it is failing to write


            byte bite = (byte) Convert.ToSByte(8);
            Console.WriteLine($"{bite}");

            BinaryWriter binWriter = new BinaryWriter(fileStream);

            binWriter.Flush();
            binWriter.Close();
        }

        public void ReadFromBin()
        {
            FileStream fileStream = File.Open("stuff.bin", FileMode.Create);

            BinaryReader binReader = new BinaryReader(fileStream);

            byte bite = binReader.ReadByte();

            binReader.Close();

            Console.WriteLine(bite);
        }
    }
}
