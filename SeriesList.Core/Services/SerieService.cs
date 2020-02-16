using SeriesList.Core.Entities;
using SeriesList.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SeriesList.Core.Services
{
    public class SerieService : ISerieService
    {
        private IRepository _repository;

        public SerieService(IRepository repository)
        {
            _repository = repository;
        }

        public Task<Serie> Add(Serie serie)
        {
            throw new NotImplementedException();
        }

        public Task<Serie> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Serie>> GetAll()
        {
            return await _repository.GetAll<Serie>();
        }

        public Task<Serie> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Serie> Update(int id, Serie serie)
        {
            throw new NotImplementedException();
        }

        //public async Task<Serie> Add(Serie serie)
        //{
        //    Serie createdSerie = await _repository.Add(serie);
        //    await _repository.SaveChanges();
        //    return createdSerie;
        //}

        //public async Task<Serie> Delete(int id)
        //{
        //    var SerieToDelete = await _repository.GetById<Serie>(id);
        //    _repository.Remove(SerieToDelete);
        //    await _repository.SaveChanges();
        //    return SerieToDelete;
        //}

        //public async Task<Serie> GetById(int id)
        //{
        //    return await _repository.GetById<Serie>(id);
        //}

        //public async Task<IEnumerable<Serie>> GetAll()
        //{
        //    return await _repository.GetAll<Serie>();
        //}

        //public async Task<Serie> Update(int id, Serie serie)
        //{
        //    var SerieToUpdate = await _repository.GetById<Serie>(id);
        //    _repository.Update(serie);
        //    await _repository.SaveChanges();
        //    return SerieToUpdate;
        //}
    }
}
