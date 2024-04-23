namespace C_sharp_constructors_this_overloading_encapsulation
{
    struct Point
    {
        public double X;
        public double Y;

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
