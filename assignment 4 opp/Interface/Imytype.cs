using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4_opp.Interface
{
    public interface Imytype
    {
        //Default access Modifier inside Interface => Internal
        //Privite access Modifier is not allowed in interface

        //1-signature for property [Namee -Type-{set}|{get}]
        public int Id {  get; set; } 
        //inside class or struct =>automatic property
        //compiler will generate Privite Hidden Attribute [Backing field]


        //inside interface =>signature for property

        //2-signature for Method [name -method type-parameter]
         public void MyFun(int x);
        //3-Default ITmplement Method 
        public void Print()
        {
            Console.WriteLine("hello default Implment Method");
        }

    }
}
