using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LanchesMac.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }

        [Required(ErrorMessage = "O nome do lanche deve ser informado")] //Define que o campo CategoriaNome é obrigatório
        [Display(Name = "Nome do Lanche")]//Define o nome do campo quando o usuário for preencher este campo no sistema
        [StringLength(80, MinimumLength =10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo")] //Define a capacidade maxima de caracteres aceita no campo CategoriaNome
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição do lanche deve ser informada")] //Define que o campo CategoriaNome é obrigatório
        [Display(Name = "Descrição do Lanche")]//Define o nome do campo quando o usuário for preencher este campo no sistema
        [StringLength(200, MinimumLength = 20, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo")] //Define a capacidade maxima de caracteres aceita no campo CategoriaNome
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "A descrição detalhada do lanche dever ser informada")] //Define que o campo CategoriaNome é obrigatório
        [Display(Name = "Descrição detalhada do Lanche")]//Define o nome do campo quando o usuário for preencher este campo no sistema
        [StringLength(200, MinimumLength = 20, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo")] //Define a capacidade maxima de caracteres aceita no campo CategoriaNome
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "Informe o preço do lanche")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1,999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido ?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; } //Criação da chave estrangeira
        public virtual Categoria Categoria{ get; set; }// definir o relacionamento com a tabela lanche

    }
}
