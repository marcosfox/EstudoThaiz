namespace Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("tbAluno")]
    public partial class Aluno
    {
        public int id { get; set; }

        [StringLength(200)]
        public string nome { get; set; }

        [StringLength(200)]
        public string telefone { get; set; }

        [StringLength(11)]
        public string CPF { get; set; }

        [StringLength(200)]
        public string email { get; set; }
    }
}
