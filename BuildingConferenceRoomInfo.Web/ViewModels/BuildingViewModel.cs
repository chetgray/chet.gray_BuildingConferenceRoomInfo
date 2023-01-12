using System.ComponentModel.DataAnnotations;

namespace BuildingConferenceRoomInfo.Web.ViewModels
{
    public class BuildingViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Address")]
        public string AddressStreet { get; set; }

        [Display(Name = "City")]
        public string AddressCity { get; set; }

        [Display(Name = "State")]
        public string AddressState { get; set; }

        [Display(Name = "ZIP")]
        public string AddressZip { get; set; }

        [Display(Name = "Country")]
        public string AddressCountry { get; set; }

        [Display(Name = "Main Phone Number")]
        public string MainPhone { get; set; }

        [Display(Name = "Number of Floors")]
        public int FloorCount { get; set; }

        [Display(Name = "Number of Conference Rooms")]
        public int ConferenceRoomCount { get; set; }
    }
}
