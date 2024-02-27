
using Core.Util.Data;
using FichaAvaliacao.API.Data.Context;
using FichaAvaliacao.API.Domain.Interface;
using FichaAvaliacao.API.Domain.Model;

namespace FichaAvaliacao.API.Data.Repositories
{
    public class AnamneseRepository : BaseRepository<Anamnese>, IAnamneseRepository
    {
        private readonly BDContext _context;
        public AnamneseRepository(BDContext context) : base(context)
        {
            _context = context;
        }
    }
}
