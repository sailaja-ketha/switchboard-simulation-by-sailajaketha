namespace SwitchBoardSimulation
{
    class Program
    {
        public static void Main(string[] args)
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
                Appliance fan = new Appliance($"Fan {i}");
                Switch fanSwitch = new Switch(fan);
                switchboard.AddSwitch(fanSwitch);
            }

            for (int i = 1; i <= numOfACs; i++)
            {
                Appliance ac = new Appliance($"AC {i}");
                Switch acSwitch = new Switch(ac);
                switchboard.AddSwitch(acSwitch);
            }
            for (int i = 1; i <= numOfBulbs; i++)
            {
                Appliance bulb = new Appliance($"Bulb {i}");
                Switch bulbSwitch = new Switch(bulb);
                switchboard.AddSwitch(bulbSwitch);
            }

            switchboard.Run();
        }
    }
}
