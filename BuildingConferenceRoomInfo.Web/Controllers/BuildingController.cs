﻿using System.Collections.Generic;
using System.Web.Mvc;

using BuildingConferenceRoomInfo.Business.BLLs;
using BuildingConferenceRoomInfo.Business.Models;
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
            List<BuildingModel> models = _bll.GetAll();
            List<BuildingViewModel> viewModels = ConvertManyToViewModels(models);

            return View(viewModels);
        }

        // GET: Building/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Building/Create
        [HttpPost]
        public ActionResult Create(BuildingCreatorViewModel viewModel)
        {
            viewModel.AlertContext = null;
            viewModel.AlertMessage = "";

            if (ModelState.IsValid)
            {
                BuildingModel model = ConvertToModel(viewModel);
                BuildingClassification classification = _bll.GetClassification(model);
                BuildingType? type = _bll.GetType(model);
                string successMessage =
                    $"Building information entry successful for {viewModel.Name} in "
                    + $"{viewModel.AddressCity}! This is a {classification} "
                    + $"{type?.ToString() ?? "undetermined type"} building.";
                ModelState.Clear();
                viewModel = new BuildingCreatorViewModel
                {
                    AlertContext = BootstrapContext.Success,
                    AlertMessage = successMessage
                };
            }
            //BuildingModel model = ConvertToModel(viewModel);
            //_bll.Create(model);

            return View(viewModel);
        }

        // GET: Building/Details
        public ActionResult Details(BuildingViewModel viewModel)
        {
            return View(viewModel);
        }

        private BuildingViewModel ConvertToViewModel(BuildingModel model)
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

        private List<BuildingViewModel> ConvertManyToViewModels(List<BuildingModel> models)
        {
            List<BuildingViewModel> viewModels = new List<BuildingViewModel>();

            foreach (BuildingModel model in models)
            {
                viewModels.Add(ConvertToViewModel(model));
            }

            return viewModels;
        }

        private BuildingModel ConvertToModel(BuildingCreatorViewModel viewModel)
        {
            return new BuildingModel
            {
                Name = viewModel.Name,
                AddressStreet = viewModel.AddressStreet,
                AddressCity = viewModel.AddressCity,
                AddressState = viewModel.AddressState,
                AddressZip = viewModel.AddressZip,
                AddressCountry = viewModel.AddressCountry,
                MainPhone = viewModel.MainPhone,
                FloorCount = viewModel.FloorCount,
                ConferenceRoomCount = viewModel.ConferenceRoomCount,
            };
        }
    }
}
