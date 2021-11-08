using System.ComponentModel.DataAnnotations;

namespace impulso.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}