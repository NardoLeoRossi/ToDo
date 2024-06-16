using System.ComponentModel.DataAnnotations;

namespace ToDo.Core.Requests.Projects;

public class CreateProjectRequest
{
    [Required(ErrorMessage = "O Nome é obrigatório!")]
    [MaxLength(30, ErrorMessage = "O Nome deve conter no máximo 30 caracteres!")]
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    [Required(ErrorMessage ="O usuário de criação do projeto é obrigatório!")]
    public Guid UserId { get; set; }
}