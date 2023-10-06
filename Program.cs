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


            while (true)
            {
                switchboard.DisplaySwitchBoardMenu();
                Console.WriteLine("Enter the device number to control (0 to exit):");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 0)
                {
                    break;
                }
                else if (choice >= 1 && choice <= switchboard.appliances.Count)
                {
                    var selectedSwitch = switchboard.switches.Find(s => s.ApplianceId == switchboard.appliances[choice - 1].Id);
                    if (selectedSwitch != null)
                    {
                        string toggleState = selectedSwitch.IsOn ? "Off" : "On";

                        Console.WriteLine($"1. {switchboard.appliances[choice - 1].Name} {switchboard.appliances[choice - 1].Id} to switch {toggleState}.");
                        Console.WriteLine("2. Back");

                        int controlChoice = Convert.ToInt32(Console.ReadLine());

                        if (controlChoice == 1)
                        {
                            selectedSwitch.Toggle(switchboard);
                        }
                    }
              
                }
                else
                {
                    Console.WriteLine("Invalid device number Please enter a valid device number.");
                }

            }

        }
    }
}
