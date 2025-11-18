namespace EverybodyCodes2025.Quest2.Part1
{
    internal class Solution : ISolution
    {
        public void Run()
        {
            (int x, int y) a = (160, 50);
            (int x, int y) result = (0, 0);
            var cycle = 0;
            var maxCycles = 3;

            while (cycle < maxCycles)
            {
                result = (result.x * result.x - result.y * result.y, result.x * result.y + result.y * result.x);
                result = (result.x / 10, result.y / 10);
                result = (result.x + a.x, result.y + a.y);

                cycle++;
            }

            Console.WriteLine("[{0},{1}]", result.x, result.y);
        }
    }
}
