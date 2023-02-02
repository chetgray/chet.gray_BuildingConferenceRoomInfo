using System.Collections.Generic;
using System.Data;

using BuildingConferenceRoomInfo.Data.DTOs;

namespace BuildingConferenceRoomInfo.Data.Repositories
{
    public class BuildingRepository : BaseRepository
    {
        public BuildingDTO Insert(BuildingDTO dto)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@buildingName", dto.Name },
                { "@buildingAddressStreet", dto.AddressStreet },
                { "@buildingAddressCity", dto.AddressCity },
                { "@buildingAddressState", dto.AddressState },
                { "@buildingAddressZip", dto.AddressZip },
                { "@buildingAddressCountry", dto.AddressCountry },
                { "@buildingMainPhone", dto.MainPhone },
                { "@buildingFloorCount", dto.FloorCount },
                { "@buildingConferenceRoomCount", dto.ConferenceRoomCount },
            };
            DataTable resultTable = _dal.ExecuteStoredProcedure(
                "spA_Building_Insert",
                parameters
            );

            return ConvertToDto(resultTable.Rows[0]);
        }

        public List<BuildingDTO> GetAll()
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            DataTable dataTable = _dal.ExecuteStoredProcedure(
                "spA_Building_GetAll",
                parameters
            );
            List<BuildingDTO> dtos = new List<BuildingDTO>();
            foreach (DataRow row in dataTable.Rows)
            {
                dtos.Add(ConvertToDto(row));
            }

            return dtos;
        }

        private BuildingDTO ConvertToDto(DataRow row)
        {
            return new BuildingDTO
            {
                Id = (int)row["BuildingId"],
                Name = (string)row["BuildingName"],
                AddressStreet = (string)row["BuildingAddressStreet"],
                AddressCity = (string)row["BuildingAddressCity"],
                AddressState = (string)row["BuildingAddressState"],
                AddressZip = (string)row["BuildingAddressZip"],
                AddressCountry = (string)row["BuildingAddressCountry"],
                MainPhone = (string)row["BuildingMainPhone"],
                FloorCount = (int)row["BuildingFloorCount"],
                ConferenceRoomCount = (int)row["BuildingConferenceRoomCount"],
            };
        }
    }
}
