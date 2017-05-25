using System;
using System.Collections.Generic;

namespace SanEscobar.Domain.Core
{
    public class Board
    {
        private const string NO_OF_PLAYERS_EXCEPTION_MESSAGE = "Number of players must be between 3 and 5";

        private List<RoleType> _roles;

        public int Colonists { get; private set; }

        public int VictoryPoints { get; private set; }

        public List<RoleType> Roles => _roles;

        public List<CargoShip> CargoShips { get; private set; }

        public Board(List<Player> players)
        {
            var noOfPlayers = players.Count;

            InitializeRoleList(noOfPlayers);
            SetColonistsLimit(noOfPlayers);
            SetVictoryPointsLimit(noOfPlayers);
            SetCaptainShips(noOfPlayers);
        }

        private void SetColonistsLimit(int noOfPlayers)
        {
            switch (noOfPlayers)
            {
                case 3:
                    Colonists = 55;
                    break;
                case 4:
                    Colonists = 75;
                    break;
                case 5:
                    Colonists = 95;
                    break;
                default:
                    throw new ArgumentException(NO_OF_PLAYERS_EXCEPTION_MESSAGE);
            }
        }

        private void SetVictoryPointsLimit(int noOfPlayers)
        {
            switch (noOfPlayers)
            {
                case 3:
                    VictoryPoints = 75;
                    break;
                case 4:
                    VictoryPoints = 100;
                    break;
                case 5:
                    VictoryPoints = 122;
                    break;
                default:
                    throw new ArgumentException(NO_OF_PLAYERS_EXCEPTION_MESSAGE);
            }
        }

        private void InitializeRoleList(int noOfPlayers)
        {
            switch (noOfPlayers)
            {
                case 3:
                    _roles = new List<RoleType>(6);
                    SetStandardRoles();
                    break;
                case 4:
                    _roles = new List<RoleType>(7);
                    SetStandardRoles();
                    _roles.Add(RoleType.Prospector);
                    break;
                case 5:
                    _roles = new List<RoleType>(8);
                    SetStandardRoles();
                    _roles.Add(RoleType.Prospector);
                    _roles.Add(RoleType.Prospector);
                    break;
                default:
                    throw new ArgumentException(NO_OF_PLAYERS_EXCEPTION_MESSAGE);
            }
        }

        private void SetStandardRoles()
        {
            _roles.Add(RoleType.Builder);
            _roles.Add(RoleType.Settler);
            _roles.Add(RoleType.Mayor);
            _roles.Add(RoleType.Craftsman);
            _roles.Add(RoleType.Trader);
            _roles.Add(RoleType.Captain);
        }

        private void SetCaptainShips(int noOfPlayers)
        {
            CargoShips = new List<CargoShip>(3);
            switch (noOfPlayers)
            {
                case 3:
                    CargoShips.Add(new CargoShip(4));
                    CargoShips.Add(new CargoShip(5));
                    CargoShips.Add(new CargoShip(6));
                    break;
                case 4:
                    CargoShips.Add(new CargoShip(5));
                    CargoShips.Add(new CargoShip(6));
                    CargoShips.Add(new CargoShip(7));
                    break;
                case 5:
                    CargoShips.Add(new CargoShip(6));
                    CargoShips.Add(new CargoShip(7));
                    CargoShips.Add(new CargoShip(8));
                    break;
                default:
                    throw new ArgumentException(NO_OF_PLAYERS_EXCEPTION_MESSAGE);
            }
        }
    }
}