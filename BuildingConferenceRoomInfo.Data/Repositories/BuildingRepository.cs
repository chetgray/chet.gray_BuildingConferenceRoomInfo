using System.Collections.Generic;
using System.Data;

using BuildingConferenceRoomInfo.Data.DTOs;

namespace BuildingConferenceRoomInfo.Data.Repositories
{
    public class BuildingRepository : BaseRepository
    {
        /// <inheritdoc cref="BaseRepository()"/>
        public BuildingRepository() { }

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
