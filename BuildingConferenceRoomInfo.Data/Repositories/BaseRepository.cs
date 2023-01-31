using System.Configuration;

using BuildingConferenceRoomInfo.Data.DataAccess;

namespace BuildingConferenceRoomInfo.Data.Repositories
{
    public abstract class BaseRepository
    {
        private protected readonly IDAL _dal;

        /// <summary>
        /// Creates a repository instance with a default <see cref="DAL"/> backend.
        /// </summary>
        private protected BaseRepository()
        {
            _dal = new DAL(
                ConfigurationManager.ConnectionStrings[
                    "BuildingConferenceRoomInfo.Data"
                ].ConnectionString
            );
        }
    }
}
