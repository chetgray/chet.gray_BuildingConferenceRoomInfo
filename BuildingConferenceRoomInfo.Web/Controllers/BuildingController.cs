using System.Linq;
using System.Web.Mvc;

using BuildingConferenceRoomInfo.Web.BusinessLayer.BLLs;
using BuildingConferenceRoomInfo.Web.Models;
using BuildingConferenceRoomInfo.Web.ViewModels;

namespace BuildingConferenceRoomInfo.Web.Controllers
{
    public class BuildingController : Controller
    {
        private readonly BuildingBLL _bll = new BuildingBLL();

        // GET: Building
        public ActionResult Index()
        {
            var buildingViewModels = _bll.GetExamples()
                .Select((model) => ConvertToViewModel(model));
            return View(buildingViewModels);
        }

        public BuildingViewModel ConvertToViewModel(BuildingModel model)
        {
            return new BuildingViewModel
            {
                Id = model.Id,
                Name = model.Name,
                AddressStreet = model.AddressStreet,
                AddressCity = model.AddressCity,
                AddressState = model.AddressState,
                AddressZip = model.AddressZip,
                AddressCountry = model.AddressCountry,
                MainPhone = model.MainPhone,
                FloorCount = model.FloorCount,
                ConferenceRoomCount = model.ConferenceRoomCount,
            };
        }
    }
}
