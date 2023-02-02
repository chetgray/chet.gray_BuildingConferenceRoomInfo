using System.Collections.Generic;
using System.Data;

using BuildingConferenceRoomInfo.Data.DTOs;

namespace BuildingConferenceRoomInfo.Data.Repositories
{
    public class ConferenceRoomRepository : BaseRepository
    {
        public ConferenceRoomDTO Insert(ConferenceRoomDTO dto)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@conferenceRoomName", dto.Name },
                { "@conferenceRoomBuildingName", dto.BuildingName },
                { "@conferenceRoomPhone", dto.Phone },
                { "@conferenceRoomIsAVCapable", dto.IsAVCapable },
                { "@conferenceRoomCapacity", dto.Capacity }
            };
            DataTable resultTable = _dal.ExecuteStoredProcedure(
                "spA_ConferenceRoom_Insert",
                parameters
            );

            return ConvertToDto(resultTable.Rows[0]);
        }

        public List<ConferenceRoomDTO> GetAll()
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            DataTable resultTable = _dal.ExecuteStoredProcedure(
                "spA_ConferenceRoom_GetAll",
                parameters
            );
            List<ConferenceRoomDTO> dtos = new List<ConferenceRoomDTO>();
            foreach (DataRow row in resultTable.Rows)
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
