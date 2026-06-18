using KatzenpensionApi.Dtos.Rooms;

namespace KatzenpensionApi.Repositories.Room
{
    public interface IRoomRepository
    {
        public Task<List<RoomDto>> GetAllRooms();
    }
}
