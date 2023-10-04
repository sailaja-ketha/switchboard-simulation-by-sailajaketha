
namespace SwitchBoardSimulation
{
    public class Appliance
    {
        public string NameOfAppliance { get; set; }
        public bool StateOfAppliance { get; set; }

        public Appliance(string name)
        {
            NameOfAppliance = name;
            StateOfAppliance = false;
        }

        public void ChangeDeviceState()
        {
            StateOfAppliance = !StateOfAppliance;
            
        }
    }
}
