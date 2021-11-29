using System.ComponentModel.DataAnnotations;

namespace HeardIt.Models
{
    public class SettingsModel
    {
        [Required]
        [DataType(DataType.Text)]
        public string? SubredditInput { get; set; }
        
    }
    
}