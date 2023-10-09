using Switchboard;

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
            List<Appliance>appliances  = new List<Appliance>();

            for (int i = 1; i <= numOfFans; i++)
            {
                Appliance fanAppliance = new Appliance("Fan", i);
                appliances.Add(fanAppliance);
                Switch fanSwitch = new Switch(i, fanAppliance.Id); 
                switchboard.AddSwitch(fanSwitch);   
            }

            for (int i = 1; i <= numOfACs; i++)
            {
                Appliance acAppliance = new Appliance("AC", i + numOfFans);
                appliances.Add(acAppliance);
                Switch acSwitch = new Switch(i + numOfFans, acAppliance.Id);
                switchboard.AddSwitch(acSwitch);
            }

            for (int i = 1; i <= numOfBulbs; i++)
            {
                Appliance bulbAppliance = new Appliance("Bulb", i + numOfFans + numOfACs);
                appliances.Add(bulbAppliance);
                Switch bulbSwitch = new Switch(i + numOfFans + numOfACs, bulbAppliance.Id);
                switchboard.AddSwitch(bulbSwitch);  
            }
            Console.WriteLine(switchboard.switches.Count);
            Console.WriteLine(appliances.Count);

            Console.WriteLine("Switchboard Menu:");
            while (true)
            {
                
                for (int i = 0; i < switchboard.switches.Count; i++)
                {
                    Switch currentSwitch = switchboard.switches[i];
                    Appliance currentAppliance = appliances.FirstOrDefault(a => a.Id == currentSwitch.ApplianceId);
                    string status = currentSwitch.IsOn ? Constants.On: Constants.Off;
                    Console.WriteLine($"{i + 1}. {currentAppliance.Name} {currentAppliance.Id} is \"{status}\"");
                }

                Console.WriteLine("Enter the device number or  to Back : ");
                int selectedDeviceNumber = Convert.ToInt32(Console.ReadLine());

                if (selectedDeviceNumber == 0)
                {
                    break;
                }

                else if (selectedDeviceNumber >= 1 && selectedDeviceNumber <= switchboard.switches.Count)
                {

                    Switch selectedSwitch = switchboard.switches[selectedDeviceNumber - 1];
                    Appliance selectedAppliance = appliances.FirstOrDefault(a => a.Id == selectedSwitch.ApplianceId);
                    string status = selectedSwitch.IsOn ? Constants.Off : Constants.On;
                    Console.WriteLine($"1.Switch {selectedAppliance.Name} {selectedAppliance.Id} \"{status}\"");
                    Console.WriteLine("2.Back");

                    int controlChoice = Convert.ToInt32(Console.ReadLine());

                    if (controlChoice == 1)
                    {
                        selectedSwitch.ToggleSwitch();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid device number Please Enter valid number.");
                }    
            }
        }
    }
}
