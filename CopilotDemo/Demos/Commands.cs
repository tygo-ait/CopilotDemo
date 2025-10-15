namespace CopilotDemo.Demos
{
    internal class Commands
    {
        // GitHub Copilot has various commands:
        // /doc, /explain, /fix, /help, /optimize, /tests
        // In this demo, you will use /optimize.
        // Run the /optimize command in the GitHub Copilot Chat.

        public int Sum(List<int> numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == i)
                    {
                        sum += numbers[j];
                    }
                }
            }
            return sum;
        }
    }
}
