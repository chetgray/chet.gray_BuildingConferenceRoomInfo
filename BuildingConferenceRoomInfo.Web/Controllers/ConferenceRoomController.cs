using System.Linq;
using System.Web.Mvc;

using BuildingConferenceRoomInfo.Web.BusinessLayer.BLLs;
using BuildingConferenceRoomInfo.Web.Models;
using BuildingConferenceRoomInfo.Web.ViewModels;

namespace BuildingConferenceRoomInfo.Web.Controllers
{
    public class ConferenceRoomController : Controller
    {
        private readonly ConferenceRoomBLL _bll = new ConferenceRoomBLL();
        private readonly BuildingController _buildingController = new BuildingController();

        // GET: ConferenceRoom
        public ActionResult Index()
        {
            var conferenceRoomViewModels = _bll.GetExamples()
                .Select((model) => ConvertToViewModel(model));
            return View(conferenceRoomViewModels);
        }

        public ConferenceRoomViewModel ConvertToViewModel(ConferenceRoomModel model)
        {
            return new ConferenceRoomViewModel
            {
                Id = model.Id,
                Name = model.Name,
                Building = _buildingController.ConvertToViewModel(model.Building),
                Phone = model.Phone,
                IsAVCapable = model.IsAVCapable,
                Capacity = model.Capacity,
            };
        }
    }
}
