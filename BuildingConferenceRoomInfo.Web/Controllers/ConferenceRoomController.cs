using System.Linq;
using System.Web.Mvc;

using BuildingConferenceRoomInfo.Web.BusinessLayer.BLLs;
using BuildingConferenceRoomInfo.Web.Models;
using BuildingConferenceRoomInfo.Web.ViewModels;

namespace BuildingConferenceRoomInfo.Web.Controllers
{
    public class ConferenceRoomController : Controller
    {
        // GET: ConferenceRoom
        public ActionResult Index()
        {
            var conferenceRoomViewModels = ConferenceRoomBLL
                .GetExamples()
                .Select((model) => ConvertToViewModel(model));
            return View(conferenceRoomViewModels);
        }

        public static ConferenceRoomViewModel ConvertToViewModel(ConferenceRoomModel model)
        {
            return new ConferenceRoomViewModel
            {
                Id = model.Id,
                Name = model.Name,
                Building = BuildingController.ConvertToViewModel(model.Building),
                Phone = model.Phone,
                IsAVCapable = model.IsAVCapable,
                Capacity = model.Capacity,
            };
        }
    }
}
