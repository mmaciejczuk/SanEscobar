using System.Collections.Generic;

namespace SanEscobar.Domain.Core
{
    public class Board
    {
        private List<RoleType> _roles;

        private int _colonists;

        private int _victoryPoints;

        public List<RoleType> Roles
        {
            get { return _roles; }
        }

        public Board(List<Player> players)
        {
            var noOfPlayers = players.Count;

            InitializeRoleList(noOfPlayers);
            SetColonistsLimit(noOfPlayers);
            SetVictoryPointsLimit(noOfPlayers);
        }

        private void SetColonistsLimit(int noOfPlayers)
        {
            switch (noOfPlayers)
            {
                case 3:
                    _colonists = 55;
                    break;
                case 4:
                    _colonists = 75;
                    break;
                case 5:
                    _colonists = 95;
                    break;
            }
        }

        private void SetVictoryPointsLimit(int noOfPlayers)
        {
            switch (noOfPlayers)
            {
                case 3:
                    _victoryPoints = 75;
                    break;
                case 4:
                    _victoryPoints = 100;
                    break;
                case 5:
                    _victoryPoints = 122;
                    break;
            }
        }

        private void InitializeRoleList(int noOfPlayers)
        {
            switch (noOfPlayers)
            {
                case 3:
                    _roles = new List<RoleType>(6);
                    SetStandardRoles(Roles);
                    break;
                case 4:
                    _roles = new List<RoleType>(7);
                    SetStandardRoles(Roles);
                    Roles.Add(RoleType.Prospector);
                    break;
                case 5:
                    _roles = new List<RoleType>(8);
                    SetStandardRoles(Roles);
                    Roles.Add(RoleType.Prospector);
                    Roles.Add(RoleType.Prospector);
                    break;
            }
        }

        private void SetStandardRoles(List<RoleType> roles)
        {
            roles.Add(RoleType.Builder);
            roles.Add(RoleType.Settler);
            roles.Add(RoleType.Mayor);
            roles.Add(RoleType.Craftsman);
            roles.Add(RoleType.Trader);
            roles.Add(RoleType.Captain);
        }
    }
}