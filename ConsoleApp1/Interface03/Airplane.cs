using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface03
{
    //to implement Explicitly or implicitly ask yourself is Methods in IMoveable equal to methods in IFlyable?
    //if no implement it Explicitly
    internal class Airplane : vehicle, IMovable, IFlyable
    {
        void IMovable.Backword()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Backword()
        {
            throw new NotImplementedException();
        }

        void IMovable.Forward()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Forward()
        {
            throw new NotImplementedException();
        }

        void IMovable.Left()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Left()
        {
            throw new NotImplementedException();
        }

        void IMovable.Right()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Right()
        {
            throw new NotImplementedException();
        }
    }
}
