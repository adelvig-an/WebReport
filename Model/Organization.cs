namespace Model
{
    public class Organization
    {
        public int Id { get; set; }
        public string NameFullOpf { get; set; } = null!; //Полное наименование с ОПФ
        public string NameShortOpf { get; set; } = null!; //Сокращенное наименование с ОПФ
        public string NameFull { get; set; } = null!; //полное наименование без ОПФ
        public string NameShort { get; set; } = null!; //краткое наименование без ОПФ
        public string FullOpf { get; set; } = null!; //Полное название ОПФ
        public string ShortOpf { get; set; } = null!; //Сокращенное ОПФ
        public string Ogrn { get; set; } = null!; //ОГРН
        public DateTime OgrnDate { get; set; } //Дата регистрации
        public string Inn { get; set; } = null!; //ИНН
        public string Kpp { get; set; } = null!; //КПП

        public string Bank { get; set; } = null!; //Название банка
        public string Bik { get; set; } = null!; //БИК Банка
        public string PayAccount { get; set; } = null!; //Расчетный счет
        public string CorrAccount { get; set; } = null!; //Корреспондентский счет
        public virtual Director Director { get; set; } = null!;
        //public virtual Address AddressRegistration { get; set; }
        //public virtual Address AddressActual { get; set; }
    }
}
