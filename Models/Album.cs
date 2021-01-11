using System;
using System.Collections.Generic;
using System.Text;

namespace XamEFCore.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public String Nombre{ get; set; }
        public int ArtistaID { get; set; }
        public Artista Artista { get; set; }

        public string Titulo { get; set; }
        public double Precio { get; set; }
        public int Anio { get; set; }
    }
}