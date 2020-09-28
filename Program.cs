using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanCollection<User> collection = new HumanCollection<User>();
            collection.Add(new User()
            {
                Id = 1,
                FullName = "Иван"
            });
            collection.Add(new User()
            {
                Id = 2,
                FullName = "Антон"
            });

            bool antonExist = collection.Exist(x => x.FullName == "Антон");

            bool idExist = collection.Exist(x => x.Id == 2);

        }

      
    }
}
