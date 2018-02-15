using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISS.LIB;
namespace Day1
{
    
        class Coin
        {

            int face;
            public void Flip()
            {
                face = MyMath.RNDInt(2);
            }

            public int GetFace()
            {
                return face;
            }
        }
}
