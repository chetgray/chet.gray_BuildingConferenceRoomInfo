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

        public BuildingModel Insert(BuildingModel model)
        {
            BuildingDTO dto = ConvertToDto(model);
            return ConvertToModel(_repository.Insert(dto));
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

        private BuildingDTO ConvertToDto(BuildingModel model)
        {
            return new BuildingDTO
            {
                Id = model.Id,
                Name = model.Name,
                AddressStreet = model.AddressStreet,
                AddressCity = model.AddressCity,
                AddressState = model.AddressState,
                AddressZip = model.AddressZip,
                AddressCountry = model.AddressCountry,
                MainPhone = model.MainPhone,
                FloorCount =
                    model.FloorCount
                    ?? throw new NullReferenceException(
                        $"{nameof(model)}.{nameof(model.FloorCount)} not set to an "
                            + $"instance of {typeof(BuildingDTO).GetProperty(nameof(BuildingDTO.FloorCount)).PropertyType}."
                    ),
                ConferenceRoomCount =
                    model.ConferenceRoomCount
                    ?? throw new NullReferenceException(
                        $"{nameof(model)}.{nameof(model.ConferenceRoomCount)} not set to an "
                            + $"instance of {typeof(BuildingDTO).GetProperty(nameof(BuildingDTO.ConferenceRoomCount)).PropertyType}."
                    ),
            };
        }
    }
}
