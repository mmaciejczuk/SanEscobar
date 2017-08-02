﻿using SanEscobar.Domain.Core2;
using System;
using SanEscobar.Infrastructure.Repositories;
using System.Linq;

namespace RedisCache
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SanEscobarContext())
            {

                db.Database.EnsureCreated();

                var playerOne = new Player()
                {
                    ConnectionId = "ConOne",
                    Id = Guid.NewGuid().ToString(),
                    Name = "PlayerOne",
                    Hash = "HashOne",
                    Group = "GroupOne",
                    IsPlaying = true,
                };

                var playerTwo = new Player()
                {
                    ConnectionId = "ConTwo",
                    Id = Guid.NewGuid().ToString(),
                    Name = "PlayerTwo",
                    Hash = "HashTwo",
                    Group = "GroupTwo",
                    IsPlaying = true,
                };

                db.Players.Add(playerOne);
                db.Players.Add(playerTwo);
                db.SaveChanges();

                var players = db.Players.OrderBy(b => b.Name).ToList();
                Console.WriteLine(players.Count);
            }


            //using (var db = new SanEscobarContext())
            //{

            //}

            //PlayerService playerService = new PlayerService();
            //var playerOneId = playerService.AddPlayer("gameOneId", playerOne);
            //var playerTwoId = playerService.AddPlayer("gameOneId", playerTwo);

            //Player p1 = playerService.GetPlayer(playerOneId);
            //Player p2 = playerService.GetPlayer(playerTwoId);

            //Console.WriteLine(p1.Id);
            //Console.WriteLine(p2.Id);
            //Console.ReadKey();
            //playerService.DeletePlayer(playerOneId);
            //playerService.DeletePlayer(playerTwoId);
            //Console.ReadKey();


        }
    }    
}

    
   