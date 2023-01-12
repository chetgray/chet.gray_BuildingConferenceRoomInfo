namespace BuildingConferenceRoomInfo.Web.ViewModels
{
    public class ConferenceRoomViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BuildingViewModel Building { get; set; }
        public string Phone { get; set; }
        public bool IsAVCapable { get; set; }
        public int Capacity { get; set; }
    }
}
