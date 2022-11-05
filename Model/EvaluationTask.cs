using System.ComponentModel;

namespace Model
{
    public class EvaluationTask
    {
        public int Id { get; set; }
        [DisplayName("Номер заявки")]
        public int Number { get; set; }
        [DisplayName("Дата заявки")]
        public DateTime DateApplication { get; set; }
        [DisplayName("Тип стоимости")]
        public TargetType Target { get; set; }
        [DisplayName("Предполагаемое использование результатов оценки")]
        public string IntendedUse { get; set; } = null!;
        [DisplayName("Тип заказчика")]
        public virtual Customer Customer { get; set; } = null!;

        //Временно закоментировал
        //Думаю где будет логичнее использование свойств осмотра
        //Взможнна другая зависимость объектов

        //public DateTime InspectionDate { get; set; }
        //public string InspectionFeaures { get; set; }
        //public Report Report { get; set; }
        //public Contract Contract { get; set; }
    }
}
