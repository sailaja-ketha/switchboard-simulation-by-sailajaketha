
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

        

    }
    
}
