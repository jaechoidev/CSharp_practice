using System;

namespace A069_Property
{
    class Rectangle
    {
        private double width;
        private double height;

        public double GetWidth()
        {
            return width;
        }
        public double GetHeight()
        {
            return height;
        }
        public void SetWidth(double width)
        {
            if (width > 0)
            {
                this.width = width;
            }
        }
        public void SetHeight(double height)
        {
            if (height > 0)
            {
                this.height = height;
            }
        }
    }


    class RectWithProp
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    class RectWithPropFull
    {
        private double width;
        private double height;

        public double Width
        {
            get { return width; }
            set { if (value > 0) width = value; }
        }

        public double Height
        {
            get { return height; }
            set { if (value > 0) height = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.SetWidth(10.0);
            r.SetHeight(10.0);
            Console.WriteLine("Area of r is {0}", r.GetWidth() * r.GetHeight());

            RectWithProp rProp = new RectWithProp();
            rProp.Width = 10.0;
            rProp.Height = 10.0;
            Console.WriteLine("Area of rProp is {0}", rProp.Width * rProp.Height);

            RectWithPropFull rPF = new RectWithPropFull();
            rPF.Width = 10.0;
            rPF.Height = 10.0;
            Console.WriteLine("Area of rPF is {0}", rProp.Width * rProp.Height);

        }
    }
}
