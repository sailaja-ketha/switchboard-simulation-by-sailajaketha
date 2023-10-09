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
                Appliance fanAppliance = new Appliance("Fan", i);
                Switch fanSwitch = new Switch(i, fanAppliance.Id); 
                switchboard.AddSwitch(fanSwitch);
            }

            for (int i = 1; i <= numOfACs; i++)
            {
                Appliance acAppliance = new Appliance("AC", i);
                Switch acSwitch = new Switch(i + numOfFans, acAppliance.Id);
                switchboard.AddSwitch(acSwitch);
            }

            for (int i = 1; i <= numOfBulbs; i++)
            {
                Appliance bulbAppliance = new Appliance("Bulb", i);
                Switch bulbSwitch = new Switch(i + numOfFans + numOfACs, bulbAppliance.Id);
                switchboard.AddSwitch(bulbSwitch);
            }
            Console.WriteLine(switchboard.switches.Count);
        }
    }
}
