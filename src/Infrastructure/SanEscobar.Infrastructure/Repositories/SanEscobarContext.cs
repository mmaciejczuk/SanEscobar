using Microsoft.EntityFrameworkCore;
using SanEscobar.Domain.Core;
using SanEscobar.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanEscobar.Infrastructure.Repositories
{
    public class SanEscobarContext : DbContext, ISanEscobarContext
    {
        //public DbSet<Board> Boards { get; set; }
        //public DbSet<CargoShip> CargoShips { get; set; }
        //public DbSet<TradingHouse> TradingHouses { get; set; }
        //public DbSet<CityHall> CityHalls { get; set; }
        //public DbSet<CustomsHouse> CustomsHouses { get; set; }
        //public DbSet<Fortress> Fortresses { get; set; }
        //public DbSet<GuildHall> GuildHalls { get; set; }
        //public DbSet<LargeBuildingTile> LargeBuildingTiles { get; set; }
        //public DbSet<Residence> Residences { get; set; }
        //public DbSet<CoffeeRoaster> CoffeeRoasters { get; set; }
        //public DbSet<LargeIndigoPlant> LargeIndigoPlants { get; set; }
        //public DbSet<LargeSugarMill> LargeSugarMills { get; set; }
        //public DbSet<ProductionBuildingTile> ProductionBuildingTiles { get; set; }
        //public DbSet<SmallIndigoPlant> SmallIndigoPlants { get; set; }
        //public DbSet<SmallSugarMill> SmallSugarMills { get; set; }
        //public DbSet<TobaccoStorage> TobaccoStorages { get; set; }
        ////abstracts
        ////public DbSet<SpecialBuildingTitle> SpecialBuildingTitles { get; set; }
        ////public DbSet<BuildingTile> BuildingTiles { get; set; }
        ////enums
        ////public DbSet<GoodType> GoodTypes { get; set; }
        ////public DbSet<RoleType> RoleTypes { get; set; }
        //public DbSet<IslandTile> IslandTiles { get; set; }
        //public DbSet<Plantation> Plantations { get; set; }
        //public DbSet<Quarry> Quarrys { get; set; }
        public DbSet<Player> Players { get; set; }
        //public DbSet<Game> Games { get; set; }
        //public DbSet<PlayerBoard> PlayerBoards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SanEscobarDB;Integrated Security=True");        
        }
    }
}