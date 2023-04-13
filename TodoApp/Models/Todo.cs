using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models;

public enum Status { NotStarted, InProgress, Completed }

public class Todo
{
    [Key]
    public int Id { get; set; }

    [Required]
    [DisplayName("Name")]
    public string Name { get; set; }

    public string? Description { get; set; }

    [DisplayName("Create DataTime")]
    public DateTime CreateDataTime { get; set; } = DateTime.Now;

    [Required]
    [DisplayName("End DataTime")]
    public DateTime EndDataTime { get; set; }

    public Status Status { get; set; }

    public bool Hidden { get; set; } = false;
}
