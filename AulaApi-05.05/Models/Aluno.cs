using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace AulaApi_05._05.Models
{
    public class Aluno
    {
        public int Id { get; set; }  // Id com I maiúsculo
        public required string Nome { get; set; }
        public int Idade { get; set; }
    }
}