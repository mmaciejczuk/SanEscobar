using SanEscobar.Domain.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RedisCache
{
    class Program
    {
        static void Main(string[] args)
        {
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

            PlayerService playerService = new PlayerService();
            var playerOneId = playerService.AddPlayer("gameOneId", playerOne);
            var playerTwoId  = playerService.AddPlayer("gameOneId", playerTwo);

            Player p1 = playerService.GetPlayer(playerOneId);
            Player p2 = playerService.GetPlayer(playerTwoId);

            Console.WriteLine(p1.Id);
            Console.WriteLine(p2.Id);
            Console.ReadKey();
            playerService.DeletePlayer(playerOneId);
            playerService.DeletePlayer(playerTwoId);
            Console.ReadKey();
        }
    }    
}

    
   