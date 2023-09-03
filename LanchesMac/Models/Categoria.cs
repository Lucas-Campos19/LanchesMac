using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        //Data annotations
        [StringLength(100, ErrorMessage ="O tamanho máximo é de 100 caracteres")] //Define a capacidade maxima de caracteres aceita no campo CategoriaNome
        [Required(ErrorMessage ="Informe o nome da categoria")] //Define que o campo CategoriaNome é obrigatório
        [Display (Name ="Nome")]//Define o nome do campo quando o usuário for preencher este campo no sistema
        public string CategoriaNome { get; set; }

        [StringLength(200, ErrorMessage = "O tamanho máximo é de 200 caracteres")] //Define a capacidade maxima de caracteres aceita no campo CategoriaNome
        [Required(ErrorMessage = "Informe a descrição da categoria")] //Define que o campo CategoriaNome é obrigatório
        [Display(Name = "Descrição")]//Define o nome do campo quando o usuário for preencher este campo no sistema
        public string Descricao { get; set; }

        public List<Lanche> Lanches { get; set;}
    }
}
