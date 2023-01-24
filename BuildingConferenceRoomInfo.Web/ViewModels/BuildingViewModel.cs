using System.ComponentModel.DataAnnotations;

namespace BuildingConferenceRoomInfo.Web.ViewModels
{
    public class BuildingViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string AddressStreet { get; set; }

        [Required]
        [Display(Name = "City")]
        public string AddressCity { get; set; }

        [Required]
        [Display(Name = "State")]
        public string AddressState { get; set; }

        [Required]
        [Display(Name = "ZIP")]
        public string AddressZip { get; set; }

        [Required]
        [Display(Name = "Country")]
        public string AddressCountry { get; set; }

        [Required]
        [Display(Name = "Main Phone Number")]
        public string MainPhone { get; set; }

        [Required]
        [Display(Name = "Number of Floors")]
        public int? FloorCount { get; set; }

        [Required]
        [Display(Name = "Number of Conference Rooms")]
        public int? ConferenceRoomCount { get; set; }
    }
}
