namespace BuildingConferenceRoomInfo.Business.Models
{
    public class ConferenceRoomModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BuildingName { get; set; }
        public string Phone { get; set; }
        public bool IsAVCapable { get; set; }
        public int? Capacity { get; set; }
    }
}
