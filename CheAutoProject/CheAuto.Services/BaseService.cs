using System;
using System.Collections.Generic;
using AutoMapper;
using System.Linq;
using System.Linq.Expressions;
using CheAuto.Models;
using CheAuto.Services.Interfaces;
using Remotion.Linq.Clauses.ResultOperators;

namespace CheAuto.Services
{
    public abstract class BaseService<T, TReadDto, TUpdateDto> : IBaseService<TReadDto, TUpdateDto> where T : class
    {
        protected AppDbContext Context;
        
        protected BaseService(AppDbContext context)
        {
            Context = context;
        }
        public TUpdateDto Create(TUpdateDto model)
        {
            var dbModel = Mapper.Map<TUpdateDto, T>(model);
            Context.Set<T>().Add(dbModel);
            Context.SaveChanges();

            return model;
        }

        public TUpdateDto Update(Guid id, TUpdateDto model)
        {
            var oldDbModel = Context.Set<T>().Find(id);
            Context.Set<T>().Remove(oldDbModel);
            var newDbModel = Mapper.Map<TUpdateDto, T>(model);
            Context.Set<T>().Add(newDbModel);
            Context.SaveChanges();
            return model;
        }

        public abstract List<TReadDto> GetList();

        public TReadDto GetById(Guid id)
        {
            var dbModel = Context.Set<T>().Find(id);
            var result = Mapper.Map<T, TReadDto>(dbModel);
            return result;
        }

        public void Delete(Guid id)
        {
            var dbModel = Context.Set<T>().Find(id);
            Context.Set<T>().Remove(dbModel);
            Context.SaveChanges();
        }
    }
}
