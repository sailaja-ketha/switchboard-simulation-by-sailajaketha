namespace SwitchBoardSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************* Switch Board Simulation ************");
            Console.Write("Enter the number of fans: ");
            int numOfFans = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of ACs: ");
            int numOfACs = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of bulbs: ");
            int numOfBulbs = Convert.ToInt32(Console.ReadLine());

            
            Switchboard switchboard = new Switchboard();

            
            for (int i = 1; i <= numOfFans; i++)
            {
                Switch fanSwitch = new Switch(i, i); 
                switchboard.AddSwitch(fanSwitch);
            }

            for(int i = 1;i <= numOfACs; i++)
            {
                Switch acSwitch = new Switch(i, i);
                switchboard.AddSwitch(acSwitch);

            }

            for( int i = 1; i<=numOfBulbs; i++)
            {
                Switch bulbSwitch = new Switch(i, i);
                switchboard.AddSwitch(bulbSwitch);
            }

        


            Console.WriteLine("************* Switchboard Menu ************");
            Console.WriteLine($"Total number of switches: {switchboard.switches.Count}");

           

           
        }
    }
}
