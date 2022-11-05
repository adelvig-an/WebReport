namespace Model
{
    public class Director : Person
    {
        public string Position { get; set; } = null!;  // Должность руководителя
        public PowerOfAttorneyType PowerOfAttorney { get; set; } //Действующий на основании (Устав, Доверенность, Закон)
        public string PowerOfAttorneyNumber { get; set; } = null!;  //Номер доверенности
        public DateTime PowerOfAttorneyFirstDate { get; set; } //Дата доверения
        public DateTime PowerOfAttorneyBeforeDate { get; set; } //Дата "действует до"
    }
}
