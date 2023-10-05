
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
            Console.WriteLine("----------Switchboard Menu:---------");
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

                Console.WriteLine("Enter the device number to control or to back:");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice >= 1 && choice <= switches.Count)
                {
                    Switch selectedSwitch = switches[choice - 1];
                    string changeSwitchState = (selectedSwitch.ConnectedAppliance.IsOn ? "Off" : "On");
                    Console.WriteLine($"1. {selectedSwitch.ConnectedAppliance.Name} Switch {changeSwitchState}");
                    Console.WriteLine($"2. Back");

                    int option = Convert.ToInt32(Console.ReadLine());

                    if (option == 1)
                    {
                        if (selectedSwitch.ConnectedAppliance.IsOn)
                        {
                            selectedSwitch.TurnOff();
                        }
                        else
                        {
                            selectedSwitch.TurnOn();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid device number try again");
                }
            }
        }
    }
}
