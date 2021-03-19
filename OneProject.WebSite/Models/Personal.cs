using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OneProject.WebSite.Models
{
    public class Personal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Positions { get; set; }

        [JsonPropertyName("social-media")]
        public List<SocialMedia> SocialMedias { get; set; }

        [JsonPropertyName("about-me")]
        public List<AboutMe> AboutMes { get; set; }
        public List<Experience> Experiences { get; set; }

        [JsonPropertyName("project-experiences")]
        public List<ProjectExperience> ProjectExperiences { get; set; }

        [JsonPropertyName("professional-skills")]
        public List<ProfessionalSkill> ProfessionalSkills { get; set; }

        public List<Education> Educations { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Personal>(this);
    }

    // Simple class for non-complicated data structure
    public class SocialMedia
    {
        public string Name { get; set; }
        public string URL { get; set; }
    }

    public class AboutMe
    {
        public string Subtitle { get; set; }
        public string Body { get; set; }
    }

    public class ProfessionalSkill
    {
        public string Category { get; set; }
        public List<string> Skills { get; set; }
    }
}
