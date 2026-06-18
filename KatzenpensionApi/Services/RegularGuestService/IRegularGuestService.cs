using KatzenpensionApi.Dtos.RegularGuests;

namespace KatzenpensionApi.Services.RegularGuestService
{
    public interface IRegularGuestService
    {
        public Task<List<RegularGuestDto>> GetAllGuests();
    }
}
