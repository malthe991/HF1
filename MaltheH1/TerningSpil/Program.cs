
namespace TerningSpil
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input amount of dice");
            int NumberOfDice = Convert.ToInt32(Console.ReadLine());



            Random random = new Random();

            int[] diceRolls = new int[NumberOfDice];

            int rollCount = 0;


            do
            {
                for (int i = 0; i < NumberOfDice; i++)
                {
                    diceRolls[i] = random.Next(1, 7);
                }

                rollCount++;
            }
            while (!Roll6(diceRolls));

            Console.WriteLine("It took " + rollCount + " rolls to get all dice to 6");

        }
        static bool Roll6(int[] diceRolls)
        {
            foreach (int roll in diceRolls)
            {
                if (roll != 6)
                {
                    return false;
                }


            }
            return true;


        }
    }
}