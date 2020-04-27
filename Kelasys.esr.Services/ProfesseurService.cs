
using Kelasys.esr.Contracts;
using Kelasys.esr.DataAccess.Contexts;
using Kelasys.esr.Models.Entities;

namespace Kelasys.esr.Services {
    public class ProfesseurService : CrudService<Professeur>, IProfesseurService {
        public ProfesseurService(AppDbContext context) : base(context) {
        }
    }
}
