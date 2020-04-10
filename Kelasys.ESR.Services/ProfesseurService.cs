
using Kelasys.ESR.Contracts;
using Kelasys.ESR.DataAccess.Contexts;
using Kelasys.ESR.Models.Entities;

namespace Kelasys.ESR.Services {
    public class ProfesseurService : CrudService<Professeur>, IProfesseurService {
        public ProfesseurService(AppDbContext context) : base(context) {
        }
    }
}
