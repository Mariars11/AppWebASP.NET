using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descrição { get; set; }
        [Range(1,10, ErrorMessage = "Valor fora da faixa[Informe entre 1 e 10 inclusives]")]
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categorias { get; set; }
    }
}