using System.ComponentModel;

namespace Model
{
    public enum PowerOfAttorneyType
    {
        [Description("Устава компании")]
        ArticlesOfAssociation = 0, //Устав компаниии
        [Description("Доверенности")]
        Attorney = 1, //Доверенность
        [Description("Законоательства")]
        Legislation = 2 //Законоательство
    }
}
