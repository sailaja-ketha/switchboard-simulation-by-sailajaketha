
namespace SwitchBoardSimulation
{
    public class Switchboard
    {
        public List<Appliance> appliances = new List<Appliance>();

        public void AddAppliance(string name, int count)
        {
            for (int i = 1; i <= count; i++)
            {
                appliances.Add(new Appliance($"{name} {i}"));
            }
        }

        public void ShowSwitchBoardMenu()
        {
            Console.WriteLine("Switchboard Menu:");
            for (int i = 0; i < appliances.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {appliances[i].NameOfAppliance} is {(appliances[i].StateOfAppliance ? "On" : "Off")}");
            }
        }

        public void ChangeApplianceState(int index)
        { 
            appliances[index].ChangeDeviceState();
        }
    }
}
