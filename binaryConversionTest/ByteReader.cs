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

            //something is fucky in this method
            //


            byte bite = (byte) Convert.ToSByte(8);

            BinaryWriter binWriter = new BinaryWriter(fileStream);
            binWriter.Write(bite);

            binWriter.Flush();
            binWriter.Close();
        }

        public void ReadFromBin()
        {
            FileStream fileStream = File.Open("stuff.bin", FileMode.Create);

            BinaryReader binReader = new BinaryReader(fileStream);

            byte bite = binReader.ReadByte();

            Console.WriteLine(bite);
        }
    }
}
