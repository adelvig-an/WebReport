namespace Model
{
    public class Contract
    {
        public int Id { get; set; }
        public string Number { get; set; } = null!; //Номер договора
        public DateTime ContractDate { get; set; } //Дата договора
    }
}
