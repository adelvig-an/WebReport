using System.ComponentModel.DataAnnotations;

namespace Model
{
    public enum CustomerType
    {
        [Display(Name = "Частное лицо")]
        PrivatePerson = 0,
        [Display(Name = "Организация")]
        Organization = 1
    }
}
