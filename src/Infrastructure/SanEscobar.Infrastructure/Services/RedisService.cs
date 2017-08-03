using System;
using System.Collections.Generic;
using System.Text;
using SanEscobar.Domain.Core2;
using ServiceStack.Redis;

namespace SanEscobar.Infrastructure.Services
{
    public class RedisService : IRedisService
    {
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
    }
}
