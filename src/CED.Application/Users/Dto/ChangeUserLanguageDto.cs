using System.ComponentModel.DataAnnotations;

namespace CED.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}