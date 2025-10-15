namespace CopilotDemo.Demos
{
    internal class DocGen
    {
        // GitHub Copilot can generate documentation for your code.
        // Try asking it to add summaries to the methods in this file and apply them.

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException();
            return (double)a / b;
        }
    }
}
