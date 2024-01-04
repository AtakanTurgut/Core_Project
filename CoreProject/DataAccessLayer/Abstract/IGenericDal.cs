﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T item);
        void Delete(T item);
        void Update(T item);

        List<T> GetList();
        T GetById(int id);

        List<T> GetListByFilter(Expression<Func<T, bool>> filter);
    }
}
