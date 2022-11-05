namespace Model
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!; //Имя
        public string LastName { get; set; } = null!; //Фамилия
        public string Patronymic { get; set; } = null!; //Отчество
    }
}
