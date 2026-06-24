using KatzenpensionApi.Data;
using KatzenpensionApi.Dtos.Rooms;
using KatzenpensionApi.Repositories.Mappings;
using Microsoft.EntityFrameworkCore;

namespace KatzenpensionApi.Repositories.Room
{
    public class RoomRepository(AppDbContext context) : IRoomRepository
    {
        public async Task<List<RoomDto>> GetAllRooms()
        {
            var rooms = await context.Rooms.ToListAsync();
            return rooms.Select(r => r.ToDto()).ToList();
        }
    }
}


