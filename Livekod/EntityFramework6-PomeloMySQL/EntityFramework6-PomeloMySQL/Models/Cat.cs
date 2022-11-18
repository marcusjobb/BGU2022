namespace Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Cat
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    // Age is not required
    public int Age { get; set; }

    // Ignore this field in mysql database 
    [NotMapped]
    public string Color{get;set;}

    // This one will not be ignored
    public string Breed { get; set; }
}