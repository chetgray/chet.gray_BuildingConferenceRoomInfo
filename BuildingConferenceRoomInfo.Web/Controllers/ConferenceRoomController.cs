﻿using System.Collections.Generic;
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
            List<ConferenceRoomModel> models = _bll.GetAll();
            List<ConferenceRoomViewModel> viewModels = ConvertManyToViewModels(models);

            return View(viewModels);
        }

        // GET: ConferenceRoom/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: ConferenceRoom/Details
        public ActionResult Details(ConferenceRoomViewModel viewModel)
        {
            return View(viewModel);
        }

        private ConferenceRoomViewModel ConvertToViewModel(ConferenceRoomModel model)
        {
            return new ConferenceRoomViewModel
            {
                Id = model.Id,
                Name = model.Name,
                BuildingName = model.Building.Name,
                Phone = model.Phone,
                IsAVCapable = model.IsAVCapable,
                Capacity = model.Capacity,
            };
        }

        private List<ConferenceRoomViewModel> ConvertManyToViewModels(
            List<ConferenceRoomModel> models
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
