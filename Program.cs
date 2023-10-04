namespace SwitchBoardSimulation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("**********Switch Board Simulation************");
            Switchboard switchboard = new Switchboard();

            Console.Write("Enter the number of fans: ");
            int noOfFans = int.Parse(Console.ReadLine());
            switchboard.AddAppliance("Fan", noOfFans);

            Console.Write("Enter the number of ACs: ");
            int noOfACs = int.Parse(Console.ReadLine());
            switchboard.AddAppliance("AC", noOfACs);

            Console.Write("Enter the number of bulbs: ");
            int noOfBulbs = int.Parse(Console.ReadLine());
            switchboard.AddAppliance("Bulb", noOfBulbs);

            while (true)
            {
                switchboard.ShowSwitchBoardMenu();
                Console.WriteLine("Enter the appliance number to control or to back:");
                int choice = int.Parse(Console.ReadLine());
                if (choice >= 1)
                {
                    Console.WriteLine("1. Switch On/Off");
                    Console.WriteLine("2. Back");
                    int option = int.Parse(Console.ReadLine());

                    if (option == 1)
                    {
                        switchboard.ChangeApplianceState(choice-1);
                    }
                }
            }
        }
    }
}
