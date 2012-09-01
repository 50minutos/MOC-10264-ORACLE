using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _005_ExtendingModelClass.Models
{
    [MetadataTypeAttribute(typeof(GeneroMetadata))]
    partial class Genero
    {
        public sealed class GeneroMetadata
        {
            public int Codigo { get; set; }

            [Required(ErrorMessage = "O nome é obrigatório")]
            public String Nome { get; set; }

            [Required(ErrorMessage = "O sexo é obrigatório")]
            public char Sexo { get; set; }

            private GeneroMetadata()
            {
            }
        }
    }
}