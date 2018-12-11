﻿using AlphaOmega.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaOmega.ApplicationCore.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(int id);
        IEnumerable<T> ListAll();
        T Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void Delete(T entity);
    }
}
