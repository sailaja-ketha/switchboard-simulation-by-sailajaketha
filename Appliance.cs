
namespace SwitchBoardSimulation
{
    public class Appliance
    {
        public string Name { get; set; }
        public bool IsOn { get; set; }

        public Appliance(string name)
        {
            Name = name;
            IsOn = false;
        }
    }
}
