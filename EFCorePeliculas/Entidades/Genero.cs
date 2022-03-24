using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCorePeliculas.Entidades;

/*
 * Con la propiedad Table podemos indicar que la tabla tendra el nombre que
 * indiquemos dentro, al igual que con el Schema le indicamos el esquema al
 * que pertenece dicha tabla
 */
[Table("TablaGeneros",Schema = "peliculas")]
public class Genero
{
    // [Key]
    public int Identificador { get; set; }
    
    /*
     * Podemos usar StringLength o MaxLength para expecificar un limite
     * Con la propiedad Required indicamos que el campo es requerido
     * Con la propiedad [Column()] indicamos el nombre del campo en la DB
     */
    // [StringLength(150)]
    // [MaxLength(150)]
    // [Required]
    // [Column("NombreGenero")]
    public string Nombre { get; set; }
}