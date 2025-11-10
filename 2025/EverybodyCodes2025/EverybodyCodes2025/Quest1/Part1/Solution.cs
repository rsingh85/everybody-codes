namespace EverybodyCodes2025.Quest1.Part1
{
    internal class Solution : ISolution
    {
        public void Run()
        {
            var names = "Oryaris,Rylarvash,Orahzyth,Maralendris,Gavtal,Raltal,Vyrzar,Vornrex,Drakdra,Tharkyris".Split(',');
            var instructions = "L1,R5,L7,R3,L2,R6,L2,R8,L6,R6,L3".Split(',');
            var pointer = 0;

            foreach (var instruction in instructions)
            {
                var direction = instruction[0];
                var steps = int.Parse(instruction[1].ToString());
                var stepsInDirection = direction == 'L' ? -steps : steps;

                if ((pointer + stepsInDirection) < 0)
                    pointer = 0;
                else if ((pointer + stepsInDirection) >= names.Length)
                    pointer = names.Length - 1;
                else
                    pointer = pointer + stepsInDirection;
            }

            Console.WriteLine(names[pointer]);
        }
    }
}
