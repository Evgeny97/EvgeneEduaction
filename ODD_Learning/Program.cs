using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODD_Learning
{
    class Program
    {
        
        struct RectangleStruct
        {
            public int Width;
            public int Height;
        }

        class FigureClass
        {
            public int CentrX;
            public int CentrY;

            public virtual int CalcArea()
            {
                return 0;
            }
        }

        class CircleClass : FigureClass
        {
            public int Radius;

            public override int CalcArea()
            {
                return (int)(3.14 * Radius * Radius);
            }
        }

        class RectangleClass : FigureClass
        {
            private int Width;
            private int Height;

            public RectangleClass(int width, int height)
            {
                Width = width;
                Height = height;
            }

            public int GetWidth()
            {
                return Width;
            }

            public int GetHeight()
            {
                return Height;
            }

            public override int CalcArea()
            {
                return Width * Height;
            }
        }

        static void Main(string[] args)
        {
            RectangleStruct rectangleStruct = new RectangleStruct();
            rectangleStruct.Height = 5;
            rectangleStruct.Width = 10;
            int val = calcRectangleArea(rectangleStruct);
        }


        static void ClassFunction()
        {
            RectangleClass rectangClass = new RectangleClass(10, 5);
            int val = rectangClass.CalcArea();
        }

        static void function1()
        {
            RectangleStruct rectangleStruct = new RectangleStruct();
            rectangleStruct.Height = 15;
            rectangleStruct.Width = 99;
            int val = calcRectangleArea(rectangleStruct);
        }

        static int calcRectangleArea(RectangleStruct rectangle)
        {
            return rectangle.Width * rectangle.Height;
        }
    }
}
