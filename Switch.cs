
namespace SwitchBoardSimulation
{
    public class Switch
    {
        public int Id { get; set; } // ?? how
        public int ApplianceId { get; set; } // ?? how
        public bool IsOn { get; set; }
        public Switch(int id, int applianceId)
        {
            Id = id;
            ApplianceId = applianceId;
            IsOn = false;  
        }

        public void ToggleSwitch()
        {
            IsOn= !IsOn;
        }
    }
}
