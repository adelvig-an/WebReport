namespace Model
{
    public class EvaluationTask
    {
        public int Id { get; set; }
        public TargetType Target { get; set; }
        public string IntendedUse { get; set; }
        public DateTime InspectionDate { get; set; }
        public string InspectionFeaures { get; set; }
        public Report Report { get; set; }
        public Contract Contract { get; set; }
    }
}
