using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Icomparable_Icomparer
{
    class Program:IComparable<Program>//to implement sort method this interface is invoked
    {
        public int sid { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public float Marks { get; set; }

        public int CompareTo(Program other)
        {
            if (this.sid > other.sid)
                return 1;
            else if (this.sid < other.sid)
                return -1;
            else
                return 0;
             }
    }


    class TestStudent
    {
        static void Main()
        {
            Program s1 = new Program { sid = 101, Name = "sajan", Class = 10, Marks = 532.0f };
            Program s2 = new Program { sid = 107, Name = "suresh", Class = 10, Marks = 500.0f };
            Program s3 = new Program { sid = 103, Name = "suman", Class = 10, Marks = 537.0f };
            Program s4 = new Program { sid = 104, Name = "bob", Class = 10, Marks = 534.0f };
            Program s5 = new Program { sid = 109, Name = "steve", Class = 10, Marks = 590.0f };
            Program s6 = new Program { sid = 106, Name = "Thomson", Class = 10, Marks = 544.0f };
            Program s7 = new Program { sid = 100, Name = "duke", Class = 10, Marks = 520.0f };
            List<Program> ss = new List<Program>() { s1, s2, s3, s4, s5, s6, s7 };//in dictionary we will use add method to get the list 

            foreach (Program i in ss)
                Console.WriteLine(i.sid + " " + i.Name + " " + i.Class + " " + i.Marks);
           ss.Sort();
           ss.Reverse();

            Console.ReadLine();
        }
    }
}



    

