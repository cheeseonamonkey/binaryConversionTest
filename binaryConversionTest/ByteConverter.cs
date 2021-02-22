using System;
using System.Collections.Generic;
using System.Text;

namespace binaryConversionTest
{
    public static class ByteConverter
    {
        //takes a binary string, int, or byte and converts to hex
        public static string ByteToHex(string binaryString)
        {
            sbyte sbite = Convert.ToSByte(binaryString, 2);
            return ByteToHex(sbite);
        }
        public static string ByteToHex(sbyte sbite)
        {
            return ByteToHex((byte)sbite);
        }
        public static string ByteToHex(byte bite)
        {
            string hex = bite.ToString("X");
            return hex;
        }

        //takes hex as a string or int and converts to a binary string
        public static string HexToByte(string hex)
        {
            sbyte bite = Convert.ToSByte(hex, 16);
            string bin = Convert.ToString((byte)bite, 2);

            //adds trailing zeros
            int n = 8 - bin.Length;
            if (n > 0)
                for (int i = 0; i < n; i++)
                    bin = $"0{bin}";

            return bin;
        }
        public static string HexToByte(int hex)
        {
            return HexToByte(hex.ToString());
        }
    }
}
