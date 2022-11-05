namespace Model
{
    public class Customer
    {
        public int Id { get; set; }
        public CustomerType Customers { get; set; }
        public virtual PrivatePerson PrivatePerson { get; set; } = null!;
        public virtual Organization Organization { get; set; } = null!;
    }
}
