using BraindsRebeca.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BraindsRebeca.Repositorios
{
    public class BraindRepository : IBraindRepository
    {
        public readonly BraindContext _context;
        public BraindRepository(BraindContext context)
        {
            _context = context;
        }

        public async Task<Braind> Creater(Braind braind)
        {
                     
            _context.Brainds.Add(braind);            

            await _context.SaveChangesAsync();

            return braind;
        }

        public async Task Delete(int id)
        {
            var BraindToDelete = await _context.Brainds.FindAsync(id);
             _context.Brainds.Remove(BraindToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Braind>> Get()
        {
            return await _context.Brainds.ToListAsync();
        }

        public async Task<Braind> Get(int id)
        {
            return await _context.Brainds.FindAsync(id);
        }

        public async Task Update(Braind braind)
        {
            _context.Entry(braind).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
