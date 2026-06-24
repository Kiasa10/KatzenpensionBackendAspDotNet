using KatzenpensionApi.Data;
using KatzenpensionApi.Dtos.RegularGuests;
using KatzenpensionApi.Repositories.Mappings;
using Microsoft.EntityFrameworkCore;

namespace KatzenpensionApi.Repositories.RegularGuest
{
    public class RegularGuestRepository(AppDbContext context) : IRegularGuestRepository
    {
        public async Task<List<RegularGuestDto>> GetAllGuests()
        {
            var guests = await context.RegularGuests.ToListAsync();
            return guests.Select(g => g.ToDto()).ToList();
        }
    }
}
