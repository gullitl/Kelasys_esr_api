
using Kelasys.ESR.Contract;
using Kelasys.ESR.DataAccess;
using Kelasys.ESR.Entity;

namespace Kelasys.ESR.Services {
    public class InstitutionService : CrudService<Institution>, IInstitutionService {
        public InstitutionService(AppDbContext context) : base(context) {
        }
    }
}
