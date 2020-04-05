using System.ComponentModel.DataAnnotations;

namespace Kelasys.ESR.Entity {
    public class Institution : EntityBase {
        public string Nom { get; set; }
        public string Sigle { get; set; }
        public string Logo { get; set; }
    }
}
