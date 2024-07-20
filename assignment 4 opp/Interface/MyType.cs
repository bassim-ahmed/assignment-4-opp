using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4_opp.Interface
{
   //iNTERFACE IS A CODE BETWEEN 2 DEVELOPER
   //class:class----Inherit
   //class:Interface--iMPLEMENT
   //struct:INterfaCE--implement
   //interface:interface--inherited

    internal class MyType : Imytype
    {
        //public int id;
        //public int Id {
        //    get { return id; }
        //    set { id = value; }
        //}
        public int Id { get; set; }
        //non static fuwnction 
        public void MyFun(int x)
        {
            Console.WriteLine($" HEloo world x:{x},ID:{Id}");
        }
    }
}
