using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class IntersectionChecker
    {
        public static bool Intersect(Segment3D seg1, Segment3D seg2, out Vector3D intersection)
        {
            intersection = new Vector3D();

            Vector3D dir1 = seg1.Direction();
            Vector3D dir2 = seg2.Direction();
            Vector3D diff = seg2.Start - seg1.Start; // Начало нааправляющего вектора

            // Скалярные произведения для системы
            double dot11 = dir1.Dot(dir1);
            double dot12 = dir1.Dot(dir2);
            double dot22 = dir2.Dot(dir2);
            double dot1d = dir1.Dot(diff);
            double dot2d = dir2.Dot(diff);
            // Знаменатель уравнения
            double denominator = dot11 * dot22 - dot12 * dot12;

            if (Math.Abs(denominator) < 1e-9)
            {
                Console.WriteLine("Отрезки параллельны или совпадают.");
                return false;
            }

            double t = (dot22 * dot1d - dot12 * dot2d) / denominator;
            double s = (dot11 * dot2d - dot12 * dot1d) / denominator;

            // Проверка значений t и s
            Console.WriteLine($"t = {t}, s = {s}");

            // Вычисление возможной точки пересечения
            Vector3D possibleIntersection = seg1.Start + dir1 * t;
            Console.WriteLine($"Возможная точка пересечения: ({possibleIntersection.X}, {possibleIntersection.Y}, {possibleIntersection.Z}), тк выходит за границы [0, 1]");

            // Проверяем, лежат ли точки пересечения в пределах отрезков
            if (t >= 0 && t <= 1 && s >= 0 && s <= 1)
            {
                intersection = possibleIntersection;
                return true;
            }

            return false;
        }
    }
}
