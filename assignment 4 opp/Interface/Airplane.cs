using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4_opp.Interface
{
    internal class Airplane : Vehicle, IMoveable, IFlyable
    {
        //airplane inherit from vechile and interfaces  (IMovable,Iflyable)

        public void Backward()
        {
            Console.WriteLine(" airplane move backward "); 
        }

        void IMoveable.Forward()
        {
            Console.WriteLine(" airplane move forwaard ground ");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine(" airplane move forwaard  ");
        }

        void IMoveable.Left()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Left()
        {
            throw new NotImplementedException();
        }

        void IMoveable.Right()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Right()
        {
            throw new NotImplementedException();
        }
    }
}
