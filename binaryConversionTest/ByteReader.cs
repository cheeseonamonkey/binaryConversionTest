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
        public void WriteToBin(string aa)
        {
            FileStream fileStream = File.Open("stuff.bin", FileMode.Create, FileAccess.ReadWrite);

            BinaryWriter binaryWriter = new BinaryWriter(fileStream);
            binaryWriter.Write(aa);

            binaryWriter.Flush();
            binaryWriter.Dispose();

        }
    }
}
