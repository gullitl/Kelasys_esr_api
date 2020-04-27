
using Kelasys.esr.Contracts;
using Kelasys.esr.DataAccess.Contexts;
using Kelasys.esr.Models.Entities;

namespace Kelasys.esr.Services {
    public class InstitutionService : CrudService<Institution>, IInstitutionService {
        public InstitutionService(AppDbContext context) : base(context) {
        }
    }
}
