
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
 
        }


    }
}
