﻿using System.Collections.Generic;

using BuildingConferenceRoomInfo.Web.Models;

namespace BuildingConferenceRoomInfo.Web.BusinessLogic.BLLs
{
    internal class BuildingBLL
    {
        private IList<BuildingModel> _models;

        public IList<BuildingModel> GetAll()
        {
            _models = new List<BuildingModel>
            {
                new BuildingModel
                {
                    Id = 1,
                    Name = "Louisville HQ",
                    AddressStreet = "888 W Market St",
                    AddressCity = "Louisville",
                    AddressState = "KY",
                    AddressZip = "40202",
                    AddressCountry = "United States",
                    MainPhone = "(844) 492-9782",
                    FloorCount = 10,
                    ConferenceRoomCount = 4,
                },
                new BuildingModel
                {
                    Id = 2,
                    Name = "Chicago",
                    AddressStreet = "1330 W Fulton St #300",
                    AddressCity = "Chicago",
                    AddressState = "IL",
                    AddressZip = "60607",
                    AddressCountry = "United States",
                    MainPhone = "(312) 858-1219",
                    FloorCount = 9,
                    ConferenceRoomCount = 4,
                },
                new BuildingModel
                {
                    Id = 3,
                    Name = "Denver",
                    AddressStreet = "7900 E Union Ave #400",
                    AddressCity = "Denver",
                    AddressState = "CO",
                    AddressZip = "80237",
                    AddressCountry = "United States",
                    MainPhone = "(844) 555-9782",
                    FloorCount = 8,
                    ConferenceRoomCount = 4,
                },
                new BuildingModel
                {
                    Id = 4,
                    Name = "Duluth",
                    AddressStreet = "2055 Sugarloaf Cir",
                    AddressCity = "Duluth",
                    AddressState = "GA",
                    AddressZip = "30097",
                    AddressCountry = "United States",
                    MainPhone = "(770) 342-0200",
                    FloorCount = 7,
                    ConferenceRoomCount = 4,
                },
                new BuildingModel
                {
                    Id = 5,
                    Name = "Lehi",
                    AddressStreet = "1550 Digital Dr",
                    AddressCity = "Lehi",
                    AddressState = "UT",
                    AddressZip = "84043",
                    AddressCountry = "United States",
                    MainPhone = "(844) 555-2879",
                    FloorCount = 6,
                    ConferenceRoomCount = 4,
                },
            };

            return _models;
        }
    }
}