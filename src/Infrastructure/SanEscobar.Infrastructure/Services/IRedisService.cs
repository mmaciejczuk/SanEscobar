using SanEscobar.Domain.Core;
using SanEscobar.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanEscobar.Infrastructure.Services
{
    public interface IRedisService
    {
        bool Add<T>(T obj) where T : class;
        T Get<T>(string id) where T : class;
        IList<T> GetAll<T>() where T : class;
        bool Delete<T>(string id) where T : class;
    }
}
