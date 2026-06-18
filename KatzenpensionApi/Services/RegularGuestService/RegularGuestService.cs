using KatzenpensionApi.Dtos.RegularGuests;
using KatzenpensionApi.Repositories.RegularGuest;

namespace KatzenpensionApi.Services.RegularGuestService
{
    public class RegularGuestService(IRegularGuestRepository guestRepo) : IRegularGuestService
    {
        public async Task<List<RegularGuestDto>> GetAllGuests()
        {
            return await guestRepo.GetAllGuests();
        }
    }
}
