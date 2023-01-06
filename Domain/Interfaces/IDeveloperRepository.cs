using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IDeveloperRepository: IGenericRepository<Developer>
    {
        public IEnumerable<Developer> GetPopularDevelopers(int count);
    }
}
