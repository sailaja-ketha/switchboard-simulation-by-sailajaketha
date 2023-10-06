
namespace SwitchBoardSimulation
{
    public class Switchboard
    { 
        public List<Switch> switches = new List<Switch>();
        public List<Appliance> appliances = new List<Appliance>();

        public void AddSwitch(Switch switchToAdd)
        {
            switches.Add(switchToAdd);
        }

        public void AddAppliance(Appliance applianceToAdd)
        {
            appliances.Add(applianceToAdd);
        }

        public void DisplaySwitchBoardMenu()
        {
            for (int i = 0; i < appliances.Count; i++)
            {
                var appliance = appliances[i];
                string applianceState = appliance.IsOn ? "On" : "Off";
                Console.WriteLine($"{i + 1}. {appliance.Name} {appliance.Id} is \"{applianceState}\"");
            }
        }
        

    }
    
}
