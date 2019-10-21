using System;
using System.Collections.Generic;

namespace _1.MethodOverriding
{
    partial class Program
    {
        public class canvas
        {
            public void DrowShape(List<Shape> shapes)
            {
                foreach (var shape in shapes)
                {
                    shape.Draw();
                }
            }
        }
    }
}
