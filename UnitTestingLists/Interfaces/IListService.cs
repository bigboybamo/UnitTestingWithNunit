using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingLists.Interfaces
{
    public interface IListService
    {
        void Add(string item);
        void Remove(string item);

        void Edit(string oldItem,  string newItem);

        List<string> GetItems();

    }
}
