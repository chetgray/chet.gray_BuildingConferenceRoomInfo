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
            return RedirectToAction("List");
        }

        // GET: Building/List
        public ActionResult List()
        {
            IEnumerable<BuildingModel> models = _bll.GetAll();
            IEnumerable<BuildingViewModel> viewModels = ConvertManyToViewModels(models);

            return View(viewModels);
        }

        [NonAction]
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

        [NonAction]
        public IEnumerable<BuildingViewModel> ConvertManyToViewModels(
            IEnumerable<BuildingModel> models
        )
        {
            ICollection<BuildingViewModel> viewModels = new List<BuildingViewModel>();

            foreach (BuildingModel model in models)
            {
                viewModels.Add(ConvertToViewModel(model));
            }

            return viewModels;
        }
    }
}
