using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.MethodOverriding
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var sheaps = new List<Shape>();
            sheaps.Add(new Shape { Width = 100, Hight = 100, Type = ShapeType.Circle });
            sheaps.Add(new Shape { Width = 100, Hight = 30, Type = ShapeType.Rectangle });

            var canvas = new canvas();
            canvas.DrowShape(sheaps);
        }
    }
}
