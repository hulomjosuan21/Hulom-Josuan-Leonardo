namespace MyApp
{
    public class Geometry
    {
        public int Area { get; set; }
        public double AreaT { get; set; }
        public int Perimeter { get; set; }
        public double Circumference { get; set; }
        public void CalculatePerimeter()
        {
            if (this is Square s)
            {
                s.Perimeter = 4 * s.Side;
            }
            else if (this is Rectangle r)
            {
                r.Perimeter = 2 * (r.Width + r.Height);
            }
            else if (this is Triangle t)
            {
                t.Perimeter = t.SideA + t.Base + t.SideC;
            }
            else if (this is Circle c)
            {
                c.Circumference = 2 * Math.PI * c.Radius;
            }
        }

        public void CalculateArea()
        {
            if (this is Square s)
            {
                s.Area = (int) Math.Pow(s.Side, 2);
            }
            else if (this is Rectangle r)
            {
                r.Area = r.Width * r.Height;
            }
            else if (this is Triangle t)
            {
                double x = (t.SideA + t.Base + t.SideC) / 2.0;
                t.AreaT = Math.Sqrt(x * (x - t.SideA) * (x - t.Base) * (x - t.SideC));
            }
            else if (this is Circle c)
            {
                c.Area = (int) (Math.PI * Math.Pow(c.Radius, 2));
            }
        }
    }
}