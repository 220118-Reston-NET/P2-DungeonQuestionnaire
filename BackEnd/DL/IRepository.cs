﻿using System.Data.SqlClient;

namespace DL
{
    public interface IRepository<T>
    {
        /// <summary>
        /// Add a Resource to Repository
        /// </summary>
        /// <param name="p_resource"></param>
        /// <returns></returns>
        T Add(T p_resource);
        /// <summary>
        /// Get all the Resources in a Database
        /// </summary>
        /// <returns></returns>
        List<T> GetAll();
        /// <summary>
        /// Updates the Resources in a Database
        /// </summary>
        /// <param name="p_resource"></param>
        /// <returns></returns>
        T Update(T p_resource);
        /// <summary>
        /// Deletes a Resource from the Database
        /// </summary>
        /// <param name="p_resource"></param>
        /// <returns></returns>
        T Delete(T p_resource);

    }

}