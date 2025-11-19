namespace EverybodyCodes2025.Quest2.Part2
{
    internal class Solution : ISolution
    {
        public void Run()
        {
            (long x, long y) a = (-21703, 67997);
            (long x, long y) o = Add(a, (x: 1000, y: 1000));

            long engraveableCount = 0;

            for (long y = a.y; y <= o.y; y += 10)
            {
                for (long x = a.x; x <= o.x; x += 10)
                {
                    (long x, long y) point = (x, y);

                    if (IsEngraveable(point))
                        engraveableCount++;
                }
            }

            Console.WriteLine(engraveableCount);
        }

        private static (long x, long y) Add((long x, long y) a, (long x, long y) b) => (a.x + b.x, a.y + b.y);
        private static (long x, long y) Mult((long x, long y) a, (long x, long y) b) => ((a.x * b.x) - (a.y * b.y), (a.x * b.y) + (a.y * b.x));
        private static (long x, long y) Div((long x, long y) a, (long x, long y) b) =>  (a.x / b.x, a.y / b.y);

        private bool IsEngraveable((long x, long y) point)
        {
            var cycle = 0;
            var maxCycles = 100;
            (long x, long y) result = (0, 0);

            while (cycle < maxCycles)
            {
                cycle++;

                result = Mult(result, result);
                result = Div(result, (100000, 100000));
                result = Add(result, point);

                if (result.x < -1000000 || result.y < -1000000 || result.x > 1000000 || result.y > 1000000)
                {
                    //Console.WriteLine("P=[{0},{1}]   R=[{2},{3}]   C={4}", point.x, point.y, result.x, result.y, cycle);
                    return false;
                }
            }

            //Console.WriteLine("P=[{0},{1}]   R=[{2},{3}]   C={4}", point.x, point.y, result.x, result.y, cycle);
            return true;
        }
    }
}
