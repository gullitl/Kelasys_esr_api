using Kelasys.ESR.Contract;
using Kelasys.ESR.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StartupApp.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class ProfesseurController : ControllerBase {
        private ILogger<ProfesseurController> Logger { get; set; }
        private IProfesseurService ProfesseurService { get; }

        public ProfesseurController(ILogger<ProfesseurController> logger,
            IProfesseurService professeurService) {
            Logger = logger;
            ProfesseurService = professeurService;
        }

        [HttpGet("getallprofesseurs")]
        public async Task<ActionResult<IEnumerable<Professeur>>> GetAll() {
            return await ProfesseurService.GetAll();
        }

        [HttpGet("getprofesseurbyid/{id}")]
        public async Task<ActionResult<Professeur>> GetById(int id) {
            Professeur professeur = await ProfesseurService.GetById(id);
            if(professeur == null) {
                return NotFound();
            }

            return professeur;
        }

        [HttpPost("createprofesseur")]
        public async Task<ActionResult<Professeur>> Create(Professeur professeur) {
            return await ProfesseurService.Create(professeur);
        }

        [HttpPut("updateprofesseur")]
        public async Task<ActionResult<bool>> Update(Professeur professeur) {
            return await ProfesseurService.Update(professeur);
        }

        [HttpDelete("deleteprofesseurbyid/{id}")]
        public async Task<ActionResult<bool>> Delete(int id) {
            bool found = await ProfesseurService.Delete(id);

            if(!found) {
                return NotFound();
            }

            return found;
        }
    }
}
