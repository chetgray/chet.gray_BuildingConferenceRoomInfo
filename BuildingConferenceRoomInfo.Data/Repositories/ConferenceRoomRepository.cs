using System.Collections.Generic;
using System.Data;

using BuildingConferenceRoomInfo.Data.DTOs;

namespace BuildingConferenceRoomInfo.Data.Repositories
{
    public class ConferenceRoomRepository : BaseRepository
    {
        public List<ConferenceRoomDTO> GetAll()
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            DataTable dataTable = _dal.ExecuteStoredProcedure(
                "spA_ConferenceRoom_GetAll",
                parameters
            );
            List<ConferenceRoomDTO> dtos = new List<ConferenceRoomDTO>();
            foreach (DataRow row in dataTable.Rows)
            {
                dtos.Add(ConvertToDto(row));
            }

            return dtos;
        }

        private ConferenceRoomDTO ConvertToDto(DataRow row)
        {
            return new ConferenceRoomDTO
            {
                Id = (int)row["ConferenceRoomId"],
                Name = (string)row["ConferenceRoomName"],
                BuildingName = (string)row["ConferenceRoomBuildingName"],
                Phone = (string)row["ConferenceRoomPhone"],
                IsAVCapable = (bool)row["ConferenceRoomIsAVCapable"],
                Capacity = (int)row["ConferenceRoomCapacity"],
            };
        }
    }
}
