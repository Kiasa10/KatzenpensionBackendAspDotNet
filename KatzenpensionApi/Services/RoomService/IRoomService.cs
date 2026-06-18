using KatzenpensionApi.Dtos.Rooms;

namespace KatzenpensionApi.Services.RoomService
{
    public interface IRoomService
    {
        public Task<List<RoomDto>> GetAllRooms();
    }
}
