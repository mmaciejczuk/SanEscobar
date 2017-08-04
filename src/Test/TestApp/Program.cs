using SanEscobar.Domain.Core;
using SanEscobar.Infrastructure.Repositories;
using System;
using System.Linq;

namespace TestApp
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
        }
    }
}