using hyugu.Models;

namespace hyugu.Services
{
    public interface IQuirkService
    {
        public Task<List<Quirk>> Create(Quirk newQuirk);
        public Task<bool> Update(Quirk quirk);
        public Task<bool> Delete(int id);
        public Task<Quirk?> GetOne(int id);
        public Task<List<Quirk>> GetAll();
    }
}
