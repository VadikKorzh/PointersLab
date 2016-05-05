using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Pointers
{
    class Program
    {
        unsafe static void ShowInfo(Point3d* p3dPtr)
        {
            Point3d p = *p3dPtr;
            Console.WriteLine($"Size of {p.GetType().Name}: {sizeof(Point3d)}");
            Console.WriteLine($"{nameof(p.X)} = {p3dPtr->X}");
            Console.WriteLine($"{nameof(p.Y)} = {p3dPtr->Y}");
            Console.WriteLine($"{nameof(p.Z)} = {p3dPtr->Z}");
        }

        unsafe static void Main(string[] args)
        {
            Point3d p1 = new Point3d { X = 222, Y = 111, Z = 333 };
            Console.WriteLine("Initialized point: " + p1);

            Point3d* p3dPtr = &p1;
            p3dPtr->X = 0;
            p3dPtr->Y = 0;
            p3dPtr->Z = -1111;

            Console.WriteLine("Modified via pointers point: " + p1);
            ShowInfo(p3dPtr);
        }
    }
}
