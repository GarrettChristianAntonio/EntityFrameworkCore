﻿using System.ComponentModel.DataAnnotations;

namespace IntroduccionAEfCore2.Entidades
{
    public class Pelicula
    {
        public int Id { get; set; }
        
        public string Titulo { get; set; }
        public bool EnCines { get; set; }
       
        public DateTime FechaEstreno { get; set; }
        public HashSet<Comentario> Comentarios { get; set; } = new HashSet<Comentario>();
        public HashSet<Genero> Generos { get; set; } = new HashSet<Genero>();
        public List<PeliculaActor> PeliculasActores { get; set; } = new List<PeliculaActor>();

    }
}
