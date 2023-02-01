using System.Collections.Generic;

using BuildingConferenceRoomInfo.Data.DTOs;
using BuildingConferenceRoomInfo.Data.Repositories;
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
        private readonly ConferenceRoomRepository _repository;

        public ConferenceRoomBLL()
        {
            _repository = new ConferenceRoomRepository();
        }

        public ConferenceRoomSize? GetSize(ConferenceRoomModel model)
        {
            if (model.Capacity >= 21)
            {
                return ConferenceRoomSize.Large;
            }
            else if (model.Capacity >= 11)
            {
                return ConferenceRoomSize.Medium;
            }
            else if (model.Capacity >= 1)
            {
                return ConferenceRoomSize.Small;
            }
            else
            {
                return null;
            }
        }

        public List<ConferenceRoomModel> GetAll()
        {
            List<ConferenceRoomDTO> dtos = _repository.GetAll();
            List<ConferenceRoomModel> models = new List<ConferenceRoomModel>();
            foreach (ConferenceRoomDTO dto in dtos)
            {
                models.Add(ConvertToModel(dto));
            }

            return models;
        }

        private ConferenceRoomModel ConvertToModel(ConferenceRoomDTO dto)
        {
            return new ConferenceRoomModel
            {
                Id = dto.Id,
                Name = dto.Name,
                BuildingName = dto.BuildingName,
                Phone = dto.Phone,
                IsAVCapable = dto.IsAVCapable,
                Capacity = dto.Capacity,
            };
        }
    }
}
