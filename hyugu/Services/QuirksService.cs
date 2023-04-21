using hyugu.Models;
using Microsoft.EntityFrameworkCore;

namespace hyugu.Services
{
    public class QuirksService : IQuirkService
    {
        private readonly HeroContext _context;
        public QuirksService (HeroContext context)
        {
            _context = context;
        }


        public async Task<List<Quirk>> Create(Quirk newQuirk)
        {

            _context.Quriks.Add(newQuirk);
            await _context.SaveChangesAsync();
            //return await _context.Quriks.ToListAsync();
            return await GetAll();

        }

        public async Task<bool> Update(Quirk quirk)
        {
            var quirk1 = await _context.Quriks.FindAsync(quirk.Id);
            if (quirk == null) return false;

            //try catch
            _context.Quriks.Update(quirk);
            await _context.SaveChangesAsync();
            
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var quirk = await _context.Quriks.FindAsync(id);
            if (quirk == null) return false; 

            //try catch
            _context.Quriks.Remove(quirk);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<Quirk?> GetOne(int id)
        {
            var quirk = await _context.Quriks.FindAsync(id);
            if (quirk is null) return null;
            return quirk;
        }

        public async Task<List<Quirk>> GetAll()
        {
            return await _context.Quriks.ToListAsync();
        }


    }
}
