using KatzenpensionApi.Data;
using KatzenpensionApi.Dtos.RegularGuests;
using Microsoft.EntityFrameworkCore;

namespace KatzenpensionApi.Repositories.RegularGuest
{
    public class RegularGuestRepository(AppDbContext context) : IRegularGuestRepository
    {
        public async Task<List<RegularGuestDto>> GetAllGuests()
        {
            return await context.RegularGuests.Select(g => new RegularGuestDto(
                g.Id,
                g.Name,
                g.Age,
                g.ImageUrlReact,
                g.ImageUrlAngular,
                g.DescriptionShort,
                g.DescriptionLong)).ToListAsync();
        }
    }
}
