using SeriesList.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SeriesList.Core.Interfaces
{
    public interface ISerieService
    {
        Task<Serie> Add(Serie serie);
        Task<Serie> GetById(int id);
        Task<IEnumerable<Serie>> GetAll();
        Task<Serie> Update(int id, Serie serie);
        Task<Serie> Delete(int id);
    }
}
