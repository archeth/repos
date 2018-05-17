using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            long number, typeid, cityid, tableid, recordid;
            number = 1267165676175383;
            typeid = number >> 49;
            cityid = number >> 38;
            tableid = number >> 36;
            recordid = number >> 19;
            Console.WriteLine("Type ID is:" + typeid);
            Console.WriteLine("City ID is:" + cityid);
            Console.WriteLine("Table ID is:" + tableid);
            Console.WriteLine("Record ID is:" + recordid);
            Console.ReadKey();
        }
    }
}
