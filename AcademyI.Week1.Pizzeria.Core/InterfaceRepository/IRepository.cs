using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyI.Week1.Pizzeria.Core.InterfaceRepository
{
    public interface IRepository<T>
    {
        public List<T> Fetch();
    }
}
