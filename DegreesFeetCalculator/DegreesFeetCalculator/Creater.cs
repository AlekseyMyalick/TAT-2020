namespace DegreesFeetCalculator
{
    class Creater : CreaterConverter
    {
        public override Converter CreateCelsiusFahrenheit()
        {
            return new CelsiusFahrenheit();
        }

        public override Converter CreateFeetMeters()
        {
            return new FeetMeters();
        }
    }
}
