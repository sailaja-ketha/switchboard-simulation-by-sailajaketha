
namespace SwitchBoardSimulation
{
    public class Switchboard
    { 
        public List<Switch> switches = new List<Switch>();

        public void AddSwitch(Switch switchToAdd)
        {
            switches.Add(switchToAdd);
        }
    }
    
}
