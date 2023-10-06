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
                switchboard.AddAppliance(fanAppliance);
                switchboard.AddSwitch(fanSwitch);
            }

            for (int i = 1; i <= numOfACs; i++)
            {
                Appliance acAppliance = new Appliance("AC", i);
                Switch acSwitch = new Switch(i, acAppliance.Id);
                switchboard.AddAppliance(acAppliance);
                switchboard.AddSwitch(acSwitch);
            }

            for (int i = 1; i <= numOfBulbs; i++)
            {
                Appliance bulbAppliance = new Appliance("Bulb", i);
                Switch bulbSwitch = new Switch(i, bulbAppliance.Id);
                switchboard.AddAppliance(bulbAppliance);
                switchboard.AddSwitch(bulbSwitch);
            }

            Console.WriteLine("************* Switchboard Menu ************");
            Console.WriteLine($"Total number of switches: {switchboard.switches.Count}");


            for (int i = 0; i < switchboard.appliances.Count; i++)
            {
                var appliance = switchboard.appliances[i];
                string applianceState = appliance.IsOn ? "On" : "Off";
                Console.WriteLine($"{i + 1}. {appliance.Name} {appliance.Id} is \"{applianceState}\"");
            }
        }
    }
}
