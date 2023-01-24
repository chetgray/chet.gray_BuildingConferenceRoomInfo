using System.ComponentModel.DataAnnotations;

namespace BuildingConferenceRoomInfo.Web.ViewModels
{
    public class ConferenceRoomViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Building")]
        public string BuildingName { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "A/V Capable")]
        public bool IsAVCapable { get; set; }

        [Required]
        public int Capacity { get; set; }
    }
}
