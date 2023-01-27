namespace BuildingConferenceRoomInfo.Web.ViewModels
{
    public class ConferenceRoomCreatorViewModel : ConferenceRoomViewModel
    {
        public BootstrapContext? AlertContext { get; set; }
        public string AlertMessage { get; set; }
    }
}
