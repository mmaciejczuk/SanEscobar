using System;
using SanEscobar.Domain.Core;
using ServiceStack.Redis;
using SanEscobar.Domain.Core.Repositories;
using AutoMapper;
using SanEscobar.Infrastructure.DTO;
using System.Collections.Generic;

namespace SanEscobar.Infrastructure.Services
{
    public class RedisService : IRedisService
    {
        public bool Add<T>(T obj) where T : class
        {
            try
            {
                using (IRedisClient client = new RedisClient())
                {
                    var objectClient = client.As<T>();
                    var storedObject = objectClient.Store(obj);
                    return true;
                }
            }
            catch (Exception ex)
            {
                //return default(T);
                return false;
            }
        }

        public T Get<T>(string id) where T : class
        {
            try
            {
                using (IRedisClient client = new RedisClient())
                {
                    if (id == null)
                    {
                        var playerClient = client.As<T>();
                        var player = playerClient.GetById(id);
                        return player;
                    }
                    else
                    {
                        var playerClient = client.As<T>();
                        var player = playerClient.GetById(id);
                        return player;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IList<T> GetAll<T>() where T : class
        {
            try
            {
                using (IRedisClient client = new RedisClient())
                {
                    var playerClient = client.As<T>();
                    var player = playerClient.GetAll();
                    return player;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Delete<T>(string id) where T : class
        {
            try
            {
                using (IRedisClient client = new RedisClient())
                {
                    var playerClient = client.As<T>();
                    playerClient.DeleteById(id);
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
