﻿using System.Collections.Generic;
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
            IEnumerable<ConferenceRoomModel> models = _bll.GetExamples();
            IList<ConferenceRoomViewModel> viewModels = new List<ConferenceRoomViewModel>();

            foreach (ConferenceRoomModel model in models)
            {
                viewModels.Add(ConvertToViewModel(model));
            }

            return View(viewModels);
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
