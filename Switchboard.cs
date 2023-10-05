
namespace SwitchBoardSimulation
{
    public class Switchboard
    {
        
        private List<Switch> switches = new List<Switch>();

        public void AddSwitch(Switch switchToAdd)
        {
            switches.Add(switchToAdd);
        }

        public void ShowSwitchBoardMenu()
        {
            Console.WriteLine("Switchboard Menu:");
            for (int i = 0; i < switches.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {switches[i].ConnectedAppliance.Name} is {(switches[i].ConnectedAppliance.IsOn ? "On" : "Off")}");
            }
        }

        public void Run()
        {
            while (true)
            {
                ShowSwitchBoardMenu();
                Console.WriteLine("Enter the device number to control or  to back:");
                int choice = Convert.ToInt32(Console.ReadLine());
            
                if (choice >= 1)
                {
                    Console.WriteLine("1. Switch On");
                    Console.WriteLine("2. Switch Off");
                    Console.WriteLine("3. Back");
                    int option = Convert.ToInt32(Console.ReadLine());
                    if (option == 1)
                    {
                        switches[choice - 1].TurnOn();
                    }
                    else if (option == 2)
                    {
                        switches[choice - 1].TurnOff();
                    }
                    
                }
               
            }
        }
    }
}
