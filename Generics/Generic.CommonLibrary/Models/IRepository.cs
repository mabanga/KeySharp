
using System.Collections.Generic;

namespace Generic.CommonLibrary.Models
{
    public  interface IRepository<T, TKey>
    {
        List<T> GetItems();
        T GetItem(TKey key);
        List<Person> AddItem(T item);
        void UpdateItem(TKey key);
        void DeleteItem(TKey key);
    }
}
