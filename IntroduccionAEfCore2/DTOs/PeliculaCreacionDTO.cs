﻿namespace IntroduccionAEfCore2.DTOs
{
    public class PeliculaCreacionDTO
    {
       
        public string Titulo { get; set; }
        public bool EnCines { get; set; }
        public DateTime FechaEstreno { get; set; }       
        public List<int> Generos { get; set; } = new List<int>();
        public List<PeliculaActorCreacionDTO> PeliculasActores { get; set; } = new List<PeliculaActorCreacionDTO>();
    }
}
