﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntroduccionAEfCore2.Entidades
{
    public class Actor
    {
        public int Id { get; set; }

      
        public string Nombre { get; set; } = null!;
        
        public decimal Fortuna { get; set; }
       
        public DateTime FechaNacimiento { get; set; }
        public List<PeliculaActor> PeliculasActores { get; set; } = new List<PeliculaActor>();
    }
}
