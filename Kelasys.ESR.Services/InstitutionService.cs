
using Kelasys.ESR.Contracts;
using Kelasys.ESR.DataAccess.Contexts;
using Kelasys.ESR.Models.Entities;

namespace Kelasys.ESR.Services {
    public class InstitutionService : CrudService<Institution>, IInstitutionService {
        public InstitutionService(AppDbContext context) : base(context) {
        }
    }
}
