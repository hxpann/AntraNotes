using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02UnderstandingTypes
{
    public class DataTypes
    {
        public static void MyDataTypes()
        {
            Console.WriteLine("sbyte: \t{0}\t{1}\t{2}", typeof(sbyte), sbyte.MaxValue, sbyte.MinValue);
            Console.WriteLine("byte: \t{0}\t{1}\t{2}", typeof(byte), byte.MaxValue, byte.MinValue);
            Console.WriteLine("short: \t{0}\t{1}\t{2}", typeof(short), short.MaxValue, short.MinValue);
            Console.WriteLine("ushort: \t{0}\t{1}\t{2}", typeof(ushort), ushort.MaxValue, ushort.MinValue);
            Console.WriteLine("int: \t{0}\t{1}\t{2}", typeof(int), int.MaxValue, int.MinValue);
            Console.WriteLine("unit: \t{0}\t{1}\t{2}", typeof(uint), uint.MaxValue, uint.MinValue);
            Console.WriteLine("long: \t{0}\t{1}\t{2}", typeof(long), long.MaxValue, long.MinValue);
            Console.WriteLine("ulong: \t{0}\t{1}\t{2}", typeof(ulong), ulong.MaxValue, ulong.MinValue);
            Console.WriteLine("float: \t{0}\t{1}\t{2}", typeof(float), float.MaxValue, float.MinValue);
            Console.WriteLine("double: \t{0}\t{1}\t{2}", typeof(double), double.MaxValue, double.MinValue);
            Console.WriteLine("decimal: \t{0}\t{1}\t{2}", typeof(decimal), decimal.MaxValue, decimal.MinValue);
        }
    }
}
