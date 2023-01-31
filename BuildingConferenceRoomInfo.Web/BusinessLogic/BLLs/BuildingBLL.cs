using System;
using System.Collections.Generic;

using BuildingConferenceRoomInfo.Data.DTOs;
using BuildingConferenceRoomInfo.Data.Repositories;
using BuildingConferenceRoomInfo.Web.Models;

namespace BuildingConferenceRoomInfo.Web.BusinessLogic.BLLs
{
    public enum BuildingClassification
    {
        Campus = 1,
        Satellite
    }

    public enum BuildingType
    {
        Standard = 1,
        Tower
    }

    internal class BuildingBLL
    {
        private readonly BuildingRepository _repository;

        public BuildingBLL()
        {
            _repository = new BuildingRepository();
        }

        public BuildingClassification GetClassification(BuildingModel model)
        {
            if (
                model.AddressCity.Equals("Louisville", StringComparison.OrdinalIgnoreCase)
                && (
                    model.AddressState.Equals("Kentucky", StringComparison.OrdinalIgnoreCase)
                    || model.AddressState.Equals("KY", StringComparison.OrdinalIgnoreCase)
                )
            )
            {
                return BuildingClassification.Campus;
            }
            else
            {
                return BuildingClassification.Satellite;
            }
        }

        public BuildingType? GetType(BuildingModel model)
        {
            if (model.FloorCount >= 6)
            {
                return BuildingType.Tower;
            }
            else if (model.FloorCount >= 1)
            {
                return BuildingType.Standard;
            }
            else
            {
                return null;
            }
        }

        public List<BuildingModel> GetAll()
        {
            List<BuildingDTO> dtos = _repository.GetAll();
            List<BuildingModel> models = new List<BuildingModel>();
            foreach (BuildingDTO dto in dtos)
            {
                models.Add(ConvertToModel(dto));
            }

            return models;
        }

        private BuildingModel ConvertToModel(BuildingDTO dto)
        {
            if (dto is null)
            {
                return null;
            }
            return new BuildingModel
            {
                Id = dto.Id,
                Name = dto.Name,
                AddressStreet = dto.AddressStreet,
                AddressCity = dto.AddressCity,
                AddressState = dto.AddressState,
                AddressZip = dto.AddressZip,
                AddressCountry = dto.AddressCountry,
                MainPhone = dto.MainPhone,
                FloorCount = dto.FloorCount,
                ConferenceRoomCount = dto.ConferenceRoomCount,
            };
        }
    }
}
