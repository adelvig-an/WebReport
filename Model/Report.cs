namespace Model
{
    public class Report
    {
        public int Id { get; set; }
        public string Number { get; set; } = null!;
        public DateTime VulationDate { get; set; }
        public DateTime CompilationDate { get; set; }
    }
}
