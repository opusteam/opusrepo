using OPUS.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPUS.Domain.Services
{
    public interface IGenericService<TEntity> where TEntity : class
    {
         List<TEntity> GetAll();
         string Add(TEntity T);
         string Delete(TEntity T);
         void Update(TEntity T);
    }
}