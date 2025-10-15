namespace CopilotDemo.Demos
{
    internal class NextEditSuggestions
    {
        // Try to get next edit suggestions from Copilot here
        // Try changing the classname from Point to Point3D and see what Copilot suggests, do not use the Code Suggestions feature.
        // If code suggestions show up, try adding private int z; then clicking on Point after changing the classname.

        public class Point
        {
            private int x;
            private int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public double GetDistance(Point other)
            {
                return Math.Sqrt((x - other.x) * (x - other.x) + (y - other.y) * (y - other.y));
            }
        }
    }
}
