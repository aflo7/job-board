using System.ComponentModel.DataAnnotations;
namespace BulkyBookWeb.Models;

public class Job
{
    [Key]
    public int job_id { get; set; }
    public string job_title { get; set; }
    public int category_id { get; set; }
}
