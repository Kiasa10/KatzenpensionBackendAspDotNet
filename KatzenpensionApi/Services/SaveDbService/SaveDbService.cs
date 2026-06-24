using KatzenpensionApi.Data;

namespace KatzenpensionApi.Services.SaveDbService
{
    public class SaveDbService(AppDbContext context) : ISaveDbService
    {
        public async Task SaveDbChanges()
        {
            await context.SaveChangesAsync();
        }
    }
}
