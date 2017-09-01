using System;
using SanEscobar.Domain.Core;
using ServiceStack.Redis;
using SanEscobar.Domain.Core.Repositories;
using AutoMapper;
using SanEscobar.Infrastructure.DTO;
using System.Collections.Generic;

namespace SanEscobar.Infrastructure.Services
{
    public static class RedisService
    {
        public static bool Add<T>(T obj) where T : class
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
                return false;
            }
        }

        public static T Get<T>(string id) where T : class
        {
            try
            {
                using (IRedisClient client = new RedisClient())
                {
                    var playerClient = client.As<T>();
                    var player = playerClient.GetById(id);
                    return player;
                }
            }

            catch (Exception ex)
            {
                return null;
            }
        }

        public static IList<T> GetAll<T>() where T : class
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

        public static bool Delete<T>(string id) where T : class
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
