using KatzenpensionApi.Dtos.Rooms;
using KatzenpensionApi.Repositories.Room;

namespace KatzenpensionApi.Services.RoomService
{
    public class RoomService(IRoomRepository roomRepo) : IRoomService
    {
        public async Task<List<RoomDto>> GetAllRooms()
        {
            return await roomRepo.GetAllRooms();
        }
    }
}
