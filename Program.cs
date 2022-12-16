using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calCircle
{
    class Circle
    {
        public float radius { get; set; }

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public float Round()
        {
            return (float)Math.PI * 2 * radius;
        }
        public float Area()
        {
            return (float)Math.PI * (float)Math.Sqrt(radius);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle cir1 = new Circle(5);

            Console.Write("원둘레:{0}, 원넓이:{1}", cir1.Round(), cir1.Area());
        }
    }
}