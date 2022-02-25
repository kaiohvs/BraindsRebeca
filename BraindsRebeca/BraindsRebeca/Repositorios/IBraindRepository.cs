using BraindsRebeca.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BraindsRebeca.Repositorios
{
    public interface IBraindRepository
    {
        Task<IEnumerable<Braind>> Get();
        Task<Braind> Get(int id);
        Task<Braind> Creater(Braind braind);
        Task Update(Braind braind);
        Task Delete(int id);
    }
}
