using Microsoft.OData.Edm;
using NPOI.SS.Util;
using System;
using System.ComponentModel.DataAnnotations;

namespace BraindsRebeca.Models
{
    public class Braind
    {
        public int Id { get; set; }       
        public string Nome { get; set; }       
        public string Telefone { get; set; }
        public string Descricao { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Data { get; set; }

        
        

    }
}
