using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.DTOS;

 public class UpdateFilmeDto 
 {
    
    [Required(ErrorMessage = "Nome é Obrigatório")]
    [StringLength(50, ErrorMessage = "Nome do Filme Invalido")]
    public string Tittle { get; set; }


    [Required(ErrorMessage ="Genero é Obrigatorio")]
    [StringLength(20, ErrorMessage ="Genero Invalido")]
    public string Gender { get; set; }



    [Required]
    [Range(50,240, ErrorMessage ="Duração Invalida")]
    public int Duration { get; set; }
 }