using System.Collections.Generic;

using BuildingConferenceRoomInfo.Web.Models;

namespace BuildingConferenceRoomInfo.Web.BusinessLogic.BLLs
{
    public enum ConferenceRoomSize
    {
        Small = 1,
        Medium,
        Large
    }

    internal class ConferenceRoomBLL
    {
        private readonly BuildingBLL _buildingBll = new BuildingBLL();
        private List<ConferenceRoomModel> _models;

        public ConferenceRoomSize GetSize(ConferenceRoomModel model)
        {
            if (21 <= model.Capacity)
            {
                return ConferenceRoomSize.Large;
            }
            else if (11 <= model.Capacity)
            {
                return ConferenceRoomSize.Medium;
            }
            else
            {
                return ConferenceRoomSize.Small;
            }
        }

        public List<ConferenceRoomModel> GetAll()
        {
            _models = new List<ConferenceRoomModel>
            {
                new ConferenceRoomModel
                {
                    Id = 1,
                    Name = "Louisville 101",
                    BuildingName = _buildingBll.GetAll()[0].Name,
                    Phone = "(844) 492-9782 ext. 1",
                    IsAVCapable = false,
                    Capacity = 12,
                },
                new ConferenceRoomModel
                {
                    Id = 2,
                    Name = "Louisville 201",
                    BuildingName = _buildingBll.GetAll()[0].Name,
                    Phone = "(844) 492-9782 ext. 2",
                    IsAVCapable = true,
                    Capacity = 15,
                },
                new ConferenceRoomModel
                {
                    Id = 3,
                    Name = "Louisville 301",
                    BuildingName = _buildingBll.GetAll()[0].Name,
                    Phone = "(844) 492-9782 ext. 3",
                    IsAVCapable = false,
                    Capacity = 20,
                },
                new ConferenceRoomModel
                {
                    Id = 4,
                    Name = "Louisville 401",
                    BuildingName = _buildingBll.GetAll()[0].Name,
                    Phone = "(844) 492-9782 ext. 4",
                    IsAVCapable = true,
                    Capacity = 40,
                },
                new ConferenceRoomModel
                {
                    Id = 5,
                    Name = "Chicago 101",
                    BuildingName = _buildingBll.GetAll()[1].Name,
                    Phone = "(312) 858-1219 ext. 5",
                    IsAVCapable = false,
                    Capacity = 11,
                },
                new ConferenceRoomModel
                {
                    Id = 6,
                    Name = "Chicago 201",
                    BuildingName = _buildingBll.GetAll()[1].Name,
                    Phone = "(312) 858-1219 ext. 6",
                    IsAVCapable = true,
                    Capacity = 12,
                },
                new ConferenceRoomModel
                {
                    Id = 7,
                    Name = "Chicago 301",
                    BuildingName = _buildingBll.GetAll()[1].Name,
                    Phone = "(312) 858-1219 ext. 7",
                    IsAVCapable = false,
                    Capacity = 15,
                },
                new ConferenceRoomModel
                {
                    Id = 8,
                    Name = "Chicago 401",
                    BuildingName = _buildingBll.GetAll()[1].Name,
                    Phone = "(312) 858-1219 ext. 8",
                    IsAVCapable = true,
                    Capacity = 30,
                },
                new ConferenceRoomModel
                {
                    Id = 9,
                    Name = "Denver 101",
                    BuildingName = _buildingBll.GetAll()[2].Name,
                    Phone = "(844) 555-9782 ext. 9",
                    IsAVCapable = false,
                    Capacity = 10,
                },
                new ConferenceRoomModel
                {
                    Id = 10,
                    Name = "Denver 201",
                    BuildingName = _buildingBll.GetAll()[2].Name,
                    Phone = "(844) 555-9782 ext. 10",
                    IsAVCapable = true,
                    Capacity = 20,
                },
                new ConferenceRoomModel
                {
                    Id = 11,
                    Name = "Denver 301",
                    BuildingName = _buildingBll.GetAll()[2].Name,
                    Phone = "(844) 555-9782 ext. 11",
                    IsAVCapable = false,
                    Capacity = 25,
                },
                new ConferenceRoomModel
                {
                    Id = 12,
                    Name = "Denver 401",
                    BuildingName = _buildingBll.GetAll()[2].Name,
                    Phone = "(844) 555-9782 ext. 12",
                    IsAVCapable = true,
                    Capacity = 40,
                },
                new ConferenceRoomModel
                {
                    Id = 13,
                    Name = "Duluth 101",
                    BuildingName = _buildingBll.GetAll()[3].Name,
                    Phone = "(770) 342-0200 ext. 13",
                    IsAVCapable = false,
                    Capacity = 12,
                },
                new ConferenceRoomModel
                {
                    Id = 14,
                    Name = "Duluth 201",
                    BuildingName = _buildingBll.GetAll()[3].Name,
                    Phone = "(770) 342-0200 ext. 14",
                    IsAVCapable = true,
                    Capacity = 15,
                },
                new ConferenceRoomModel
                {
                    Id = 15,
                    Name = "Duluth 301",
                    BuildingName = _buildingBll.GetAll()[3].Name,
                    Phone = "(770) 342-0200 ext. 15",
                    IsAVCapable = false,
                    Capacity = 20,
                },
                new ConferenceRoomModel
                {
                    Id = 16,
                    Name = "Duluth 401",
                    BuildingName = _buildingBll.GetAll()[3].Name,
                    Phone = "(770) 342-0200 ext. 16",
                    IsAVCapable = true,
                    Capacity = 40,
                },
                new ConferenceRoomModel
                {
                    Id = 17,
                    Name = "Lehi 101",
                    BuildingName = _buildingBll.GetAll()[4].Name,
                    Phone = "(844) 555-2879 ext. 17",
                    IsAVCapable = false,
                    Capacity = 12,
                },
                new ConferenceRoomModel
                {
                    Id = 18,
                    Name = "Lehi 201",
                    BuildingName = _buildingBll.GetAll()[4].Name,
                    Phone = "(844) 555-2879 ext. 18",
                    IsAVCapable = true,
                    Capacity = 15,
                },
                new ConferenceRoomModel
                {
                    Id = 19,
                    Name = "Lehi 301",
                    BuildingName = _buildingBll.GetAll()[4].Name,
                    Phone = "(844) 555-2879 ext. 19",
                    IsAVCapable = false,
                    Capacity = 20,
                },
                new ConferenceRoomModel
                {
                    Id = 20,
                    Name = "Lehi 401",
                    BuildingName = _buildingBll.GetAll()[4].Name,
                    Phone = "(844) 555-2879 ext. 20",
                    IsAVCapable = true,
                    Capacity = 40,
                },
            };

            return _models;
        }
    }
}
