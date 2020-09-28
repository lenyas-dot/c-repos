using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersApp
{
    delegate bool IsFind<TItem>(TItem item);

    class HumanCollection<THuman>
    {
        private List<THuman> _humans;

        public HumanCollection()
        {
            _humans = new List<THuman>();
        }

        public void Add(THuman human)
        {
            _humans.Add(human);
        }

        public bool Exist(IsFind<THuman> isFind)
        {
            foreach (THuman item in _humans)
            {
                bool compare = isFind.Invoke(item);
                if (compare)
                {
                    return true;
                }
            }
            return false;
        }

     
    }
}
