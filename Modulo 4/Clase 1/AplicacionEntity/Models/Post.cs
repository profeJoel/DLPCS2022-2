using System;
using System.Collections.Generic;

namespace AplicacionEntity.Models
{
    public partial class Post
    {
        public int PostId { get; set; }
        public string Titulo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
    }
}
