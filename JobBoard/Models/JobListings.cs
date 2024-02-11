namespace BulkyBookWeb.Models;
using System.ComponentModel.DataAnnotations;

public class JobListings
{
    [Key]
    public int listing_id { get; set; }
    public int job_id { get; set; }
    public string listing_title { get; set; }
    public string listing_description { get; set; }
    public DateTime listing_date { get; set; }
    public int company_id { get; set; }
}
