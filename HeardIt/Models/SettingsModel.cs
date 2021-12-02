using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Google.Cloud.TextToSpeech.V1;
using Google.Protobuf.Collections;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HeardIt.Models
{
    public class SettingsModel
    {
        [Required] [DataType(DataType.Text)] public string? SubredditInput { get; set; }

        public List<SelectListItem> SubredditSorts { get; set; } = new()
        {
            new SelectListItem("Top", "top"),
            new SelectListItem("Hot", "hot"),
            new SelectListItem("New", "new"),
            new SelectListItem("Rising", "rising")
        };
        
        public List<SelectListItem> SubredditTime { get; set; } = new()
        {
            new SelectListItem("Now", "hour"),
            new SelectListItem("Today", "day"),
            new SelectListItem("This Week", "week"),
            new SelectListItem("This Month", "month"),
            new SelectListItem("This Year", "year"),
            new SelectListItem("All Time", "all")
        };
        
        public List<SelectListItem> CommentSorts { get; set; } = new()
        {
            new SelectListItem("Best", "confidence"),
            new SelectListItem("Top", "top"),
            new SelectListItem("New", "new"),
            new SelectListItem("Controversial", "controversial"),
            new SelectListItem("Old", "old"),
            new SelectListItem("QA", "qa")
        };
        
        public string? Voice { get; set; }
        public string? Language { get; set; } = "en-US";
        public IEnumerable<string> Languages { get; set; }
        public RepeatedField<Voice> VoiceNames { get; set; }

    }
    
}