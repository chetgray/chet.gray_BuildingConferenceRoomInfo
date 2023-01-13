using System.Collections.Generic;
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
            IEnumerable<BuildingModel> models = _bll.GetExamples();
            IList<BuildingViewModel> viewModels = new List<BuildingViewModel>();

            foreach (BuildingModel model in models)
            {
                viewModels.Add(ConvertToViewModel(model));
            }

            return View(viewModels);
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
