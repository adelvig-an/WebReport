using Model;

namespace BussinesLayer.Interface
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(); // получение всех объектов
        public T GetById(int id); // получение одного объекта по id
        void SaveUpdate(T item); // сохранение и обновление объекта
        void Delete(T item); // удаление объекта по id
    }
}
