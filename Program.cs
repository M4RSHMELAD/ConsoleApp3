using ConsoleApp3;
using System;

class Program : Vector3D
{
    static void Main(string[] args)
    {
        Vector3D A1 = new Vector3D(0, 0, 0);
        Vector3D B1 = new Vector3D(4, 4, 4);
        Vector3D A2 = new Vector3D(2, 0, 0);
        Vector3D B2 = new Vector3D(2, 4, 4);

        Segment3D seg1 = new Segment3D(A1, B1);
        Segment3D seg2 = new Segment3D(A2, B2);

        Vector3D intersection;
        if (IntersectionChecker.Intersect(seg1, seg2, out intersection))
        {
            Console.WriteLine($"Intersection point: ({intersection.X}, {intersection.Y}, {intersection.Z})");
        }
        else
        {
            Console.WriteLine("Segments do not intersect.");
        }
    }
}
