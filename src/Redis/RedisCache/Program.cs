using SanEscobar.Domain.Core;
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

                var playerOne = Player.Create("ConOne", "PlayerOne", "GroupOne");
                var playerTwo = Player.Create("ConTwo", "PlayerTwo", "GroupTwo");

                db.Players.Add(playerOne);
                db.Players.Add(playerTwo);
                db.SaveChanges();

                var players = db.Players.OrderBy(b => b.Name).ToList();
                Console.WriteLine(players.Count);
                Console.ReadKey();
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

    
   