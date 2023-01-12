using System.ComponentModel.DataAnnotations;

namespace BuildingConferenceRoomInfo.Web.ViewModels
{
    public class ConferenceRoomViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BuildingViewModel Building { get; set; }

        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        [Display(Name = "A/V Capable")]
        public bool IsAVCapable { get; set; }
        public int Capacity { get; set; }
    }
}
