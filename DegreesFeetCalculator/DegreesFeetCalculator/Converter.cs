namespace DegreesFeetCalculator
{
    abstract class Converter
    {
        public abstract double ReverseTransfer(double symbol);
        public abstract double DirectTransfer(double symbol);
        public abstract double Convert(double temperature, string convertName);
    }
    
}
