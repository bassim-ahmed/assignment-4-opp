using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4_opp.Interface
{
    internal class SerisByTwo : ISeris
    {
        public int Current {  get; set; }

        public void GetNext()
        {
            Current += 2;
        }

      
    }

}
