using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4_opp.Interface
{
    internal interface ISeris
    {
        public int Current {  get; set; }
        public void GetNext();
        public void Reset()
        {
            Current = 0;
        }
    }
}
