using System;
using System.Collections.Generic;
using System.Text;
using SanEscobar.Domain.Core;
using ServiceStack.Redis;
using System.Threading.Tasks;
using SanEscobar.Domain.Core.Repositories;
using AutoMapper;

namespace SanEscobar.Infrastructure.Services
{
    public class RedisService : IRedisService
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IMapper _mapper;
        private readonly IRedisClient _redisClient;

        public RedisService(IPlayerRepository playerRepository, IMapper mapper, IRedisClient redisClient)
        {
            _playerRepository = playerRepository;
            _mapper = mapper;
            _redisClient = redisClient;
        }

        public string AddPlayer(string gameId, Player player)
        {
            string lastId;
            try
            {
                using (IRedisClient client = new RedisClient())
                {
                    var playerClient = client.As<Player>();
                    var storedPlayer = playerClient.Store(player);
                    lastId = storedPlayer.Id;
                    return lastId;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Player GetPlayer(string playerId)
        {
            string lastId;
            try
            {
                using (IRedisClient client = new RedisClient())
                {
                    var playerClient = client.As<Player>();
                    var player = playerClient.GetById(playerId);
                    return player;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool DeletePlayer(string playerId)
        {
            try
            {
                using (IRedisClient client = new RedisClient())
                {
                    var playerClient = client.As<Player>();
                    playerClient.DeleteById(playerId);
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        Player IRedisService.GetPlayer(string playerId)
        {
            throw new NotImplementedException();
        }

        // GENERIC
        public T AddObject<T>(T obj) where T : class
        {
            try
            {
                using (IRedisClient client = new RedisClient())
                {
                    var objectClient = client.As<T>();
                    var storedObject = objectClient.Store(obj);
                    return storedObject;
                }
            }
            catch (Exception ex)
            {
                //return default(T);
                return null;
            }
        }

        public T GetObject<T>(string playerId) where T : class
        {
            string lastId;
            try
            {
                using (IRedisClient client = new RedisClient())
                {
                    var playerClient = client.As<T>();
                    var player = playerClient.GetById(playerId);
                    return player;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
