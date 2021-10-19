using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace AspNetCoreTodo.Models
{
  public class TodoItem
  {
    public Guid Id { get; set; }
    public bool isDone { get; set; }

    [Required]
    public string Title { get; set; }
    public DateTimeOffset? DueAt { get; set; }
  }
}