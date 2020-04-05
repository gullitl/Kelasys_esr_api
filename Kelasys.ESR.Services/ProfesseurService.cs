﻿
using Kelasys.ESR.Contract;
using Kelasys.ESR.DataAccess;
using Kelasys.ESR.Entity;

namespace Kelasys.ESR.Services {
    public class ProfesseurService : CrudService<Professeur>, IProfesseurService {
        public ProfesseurService(AppDbContext context) : base(context) {
        }
    }
}