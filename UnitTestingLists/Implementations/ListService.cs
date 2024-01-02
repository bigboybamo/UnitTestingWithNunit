using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingLists.Interfaces;

namespace UnitTestingLists.Implementations
{
    public class ListService : IListService
    {
        private static List<string> _list;
        public ListService()
        {
            _list = new List<string> {"Apple", "Orange", "Pear", "Watermelon", "Lemon","Lime" };
        } 
        public void Add(string item)
        {
            _list.Add(item);
        }

        public void Edit(string oldItem, string newItem)
        {
            if (_list?.Count > 0 && _list.Contains(oldItem)){
                int indexToRemove = _list.IndexOf(oldItem);
                _list[indexToRemove] = newItem;
            }
        }

        public List<string> GetItems()
        {
            return _list;
        }

        public void Remove(string item)
        {
            _list.Remove(item);
        }
    }
}
