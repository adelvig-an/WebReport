namespace Model
{
    public class PrivatePerson : Person
    {
        public string Serial { get; set; } = null!; //Серия документа
        public string Number { get; set; } = null!; //Номер документа
        public string Division { get; set; } = null!; //Кем выдан документ
        public string DivisionCode { get; set; } = null!; //Код подразделения
        public DateTime DivisionDate { get; set; } //Дата выдачи
        //public virtual Address AddressRegistration { get; set; }
        //public virtual Address AddressActual { get; set; }
    }
}
