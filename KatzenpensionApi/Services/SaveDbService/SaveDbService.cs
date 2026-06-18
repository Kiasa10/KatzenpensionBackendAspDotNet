using KatzenpensionApi.Data;

namespace KatzenpensionApi.Services.SaveDbService
{
    public class SaveDbService(AppDbContext context) : ISaveDbService
    {
        public async void SaveDbChanges()
        {
            await context.SaveChangesAsync();
        }
    }
}
