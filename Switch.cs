
namespace SwitchBoardSimulation
{
    public class Switch
    {
        public Appliance ConnectedAppliance { get; set; }

        public Switch(Appliance appliance)
        {
            ConnectedAppliance = appliance;
        }

        public void TurnOn()
        {
            ConnectedAppliance.IsOn = true;
        }

        public void TurnOff()
        {
            ConnectedAppliance.IsOn = false;
        }
    }
}
