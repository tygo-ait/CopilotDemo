namespace CopilotDemo.Demos
{
    // Demo interface
    internal interface ICalculator
    {
        double Ceiling(double d);
        double Floor(double d);
        double Round(double d);
    }

    // Class with partial implementation
    internal class AdaptivePaste_CompleteInterface : ICalculator
    {
        // Copy and paste to complete the interface implementation
        public double Ceiling(double d)
        {
            return Math.Ceiling(d);
        }
    }
}