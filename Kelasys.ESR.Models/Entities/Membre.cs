﻿using Kelasys.esr.Utils.Enumerations;

namespace Kelasys.esr.Models.Entities {
    public class Membre : EntityBase{
        public string Nom { get; set; }
        public string Postnom { get; set; }
        public string Prenom { get; set; }
        public Sexe Sexe { get; set; }
        public string Photo { get; set; }
        public string Email { get; set; }
        public Utilisateur Utilisateur { get; set; }
    }
}
