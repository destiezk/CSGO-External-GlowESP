using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace csgo_simple_glow
{
    class Mem
    {
        public static byte[] Read(int adr, int l)
        {
            byte[] lpBuffer = new byte[(l - 1) + 1];
            int lpNumberOfBytesRead = 1;
            Form1.ReadProcessMemory(Form1.csgoHandle, (IntPtr)adr, lpBuffer, lpBuffer.Length, ref lpNumberOfBytesRead);
            return lpBuffer;
        }
        public static object ReadBool(int adr, int l) =>
            BitConverter.ToBoolean(Read(adr, l), 0);
        public static object ReadInt(int adr, int l) =>
            BitConverter.ToInt32(Read(adr, l), 0);
        public static object ReadLong(int adr, int l) =>
            ToLong(Read(adr, l));
        public static object ReadSingle(int adr, int l) =>
            BitConverter.ToSingle(Read(adr, l), 0);
        private static object ToLong(byte[] byBytes)
        {
            long num = 0;
            int num3 = Information.UBound(byBytes, 1) - Information.LBound(byBytes, 1);
            for (int i = 0; i <= num3; i++)
            {
                if ((i == 0) & ((byBytes[0] & 0x80) > 0))
                {
                    num |= (long)Math.Round(-(byBytes[i] * Math.Pow(2.0, (double)(8 * ((Strings.Len(num) - 1) - i)))));
                }
                else
                {
                    num |= (long)Math.Round((double)(byBytes[i] * Math.Pow(2.0, (double)(8 * ((Strings.Len(num) - 1) - i)))));
                }
            }
            return num;
        }
        public static void Write(int adr, byte[] Bytes)
        {
            int lpNumberOfBytesRead = 1;
            Form1.WriteProcessMemory(Form1.csgoHandle, (IntPtr)adr, Bytes, Bytes.Length, ref lpNumberOfBytesRead);
        }
        public static void WriteBool(int adr, int l, bool val)
        {
            byte[] bytes = new byte[(l - 1) + 1];
            bytes = BitConverter.GetBytes(val);
            Write(adr, bytes);
        }
        public static void WriteInt(int adr, int l, int val)
        {
            byte[] bytes = new byte[(l - 1) + 1];
            bytes = BitConverter.GetBytes(val);
            Write(adr, bytes);
        }
        public static void WriteSingle(int adr, int l, float val)
        {
            byte[] bytes = new byte[(l - 1) + 1];
            bytes = BitConverter.GetBytes(val);
            Write(adr, bytes);
        }
    }
}


