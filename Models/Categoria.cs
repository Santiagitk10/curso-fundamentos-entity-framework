using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace proyectoef.Models;

public class Categoria
{
    //[Key]
    public Guid CategoriaId {get;set;}

    //[Required]
    //[MaxLength(150)]
    public string Nombre {get;set;}
    public string Descripcion {get;set;}
    public int Peso {get;set;}

    //SE USA PARA QUE NO SE GENERE UN CICLO YA QUE TAREAS TIENE UNA CATEGORÍA, PERO LA CATEGORÍA TIENE UN
    //LISTADO DE TAREAS TAMBIÉN
    [JsonIgnore]
    public virtual ICollection<Tarea> Tareas {get;set;}
}
