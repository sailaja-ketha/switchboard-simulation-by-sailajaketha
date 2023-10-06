
namespace SwitchBoardSimulation
{
    public class Switch
    {
        public int Id { get; set; }
        public int ApplianceId { get; set; }
        public bool IsOn { get; set; }  

        public Switch(int id, int applianceId)
        {
            Id = id;
            ApplianceId = applianceId;
            IsOn = false;
        }



        public void Toggle(Switchboard switchboard)
        {
            IsOn = !IsOn;
            var appliance = switchboard.appliances.Find(a => a.Id == ApplianceId);
            if (appliance != null)
            {
                appliance.Toggle();
            }
        }
        

    }
}
