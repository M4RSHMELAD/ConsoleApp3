using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Segment3D
    {
        public Vector3D Start { get; set; }
        public Vector3D End { get; set; }

        public Segment3D(Vector3D start, Vector3D end)
        {
            Start = start;
            End = end;
        }

        public Vector3D Direction()
        {
            return End - Start;
        }
    }

}
