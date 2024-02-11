using System.ComponentModel.DataAnnotations;
namespace BulkyBookWeb.Models;

public class Companies
{
    [Key]
    public int company_id { get; set; }
    public string company_name { get; set; }
}