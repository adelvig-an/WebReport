namespace Model
{
    public class EvaluationTask
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime DateApplication { get; set; }
        public TargetType Target { get; set; }
        public string IntendedUse { get; set; }

        //Временно закоментировал
        //Думаю где будет логичнее использование свойств осмотра
        //Взможнна другая зависимость объектов

        //public DateTime InspectionDate { get; set; }
        //public string InspectionFeaures { get; set; }
        //public Report Report { get; set; }
        //public Contract Contract { get; set; }
    }
}
