using FarolFInanceiro.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarolFInanceiro.Models;

public class ContaPagar
{
    public int Id { get; set; }

    public DateTime DataCadastro { get; set; } = DateTime.Today;

    [Required(ErrorMessage = "A descrição é obrigatória")]
    [StringLength(100, ErrorMessage = "A descrição pode ter no máximo 100 caracteres")]
    public string Descricao { get; set; } = string.Empty;

    [Required(ErrorMessage = "O valor é obrigatório")]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Valor { get; set; }

    [Required(ErrorMessage = "A data de vencimento é obrigatória")]
    public DateTime DataVencimento { get; set; } = DateTime.Today;

    public DateTime? DataPagamento { get; set; } = null;

    public bool Paga { get; set; }

    public string? ApplicationUserId { get; set; }

    public ApplicationUser? ApplicationUser { get; set; }
}