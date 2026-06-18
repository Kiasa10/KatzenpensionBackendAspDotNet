using KatzenpensionApi.Data;
using KatzenpensionApi.Dtos.Rooms;
using Microsoft.EntityFrameworkCore;

namespace KatzenpensionApi.Repositories.Room
{
    public class RoomRepository(AppDbContext context) : IRoomRepository
    {
        public async Task<List<RoomDto>> GetAllRooms()
        {
            return await context.Rooms.Select(r => new RoomDto(
                r.Id,
                r.Title,
                r.Cost,
                r.ImageUrlReact,
                r.ImageUrlAngular,
                r.DescriptionShort,
                r.DescriptionLong,
                r.CatsPossible))
                .ToListAsync();
        }
    }
}


