using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Укажите логин")]
        public string Login { get; set; } = null!;
        [Required(ErrorMessage ="Укажите пароль")]
        public string Password { get; set; } = null!;
    }
}
