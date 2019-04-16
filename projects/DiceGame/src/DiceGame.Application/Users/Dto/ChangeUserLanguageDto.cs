using System.ComponentModel.DataAnnotations;

namespace DiceGame.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}