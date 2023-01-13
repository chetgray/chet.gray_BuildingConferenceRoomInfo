using System.Collections.Generic;
using System.Web.Mvc;

using BuildingConferenceRoomInfo.Web.BusinessLogic.BLLs;
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
            return RedirectToAction("List");
        }

        // GET: ConferenceRoom/List
        public ActionResult List()
        {
            List<ConferenceRoomModel> models = (List<ConferenceRoomModel>)_bll.GetAll();
            List<ConferenceRoomViewModel> viewModels =
                (List<ConferenceRoomViewModel>)ConvertManyToViewModels(models);

            return View(viewModels);
        }

        [NonAction]
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

        [NonAction]
        public IEnumerable<ConferenceRoomViewModel> ConvertManyToViewModels(
            IEnumerable<ConferenceRoomModel> models
        )
        {
            List<ConferenceRoomViewModel> viewModels = new List<ConferenceRoomViewModel>();

            foreach (ConferenceRoomModel model in models)
            {
                viewModels.Add(ConvertToViewModel(model));
            }

            return viewModels;
        }
    }
}
