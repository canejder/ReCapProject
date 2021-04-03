using System;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI
{
    public interface IPostable<T> 
        where T: class, IEntity, new()
    {
        IActionResult Add(T entity);
        IActionResult Update(T entity);
        IActionResult Remove(T entity);
    }
}