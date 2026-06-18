using KatzenpensionApi.Dtos.RegularGuests;

namespace KatzenpensionApi.Repositories.RegularGuest
{
    public interface IRegularGuestRepository
    {
        public Task<List<RegularGuestDto>> GetAllGuests();
    }
}
