using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SanEscobar.Domain.Core.UnitTests
{
    [TestClass]
    public class CityHallUnitTest
    {
        [TestMethod]
        public void CalculateEndGameBonus_Unocupplied()
        {
            //Arrange
            var cityHall = new CityHall();
            cityHall.Occupation.Add(false);
            var playerBoard = new PlayerBoard(null);
            playerBoard.CitySpaces.Add(cityHall);
            //Act
            var result = cityHall.CalculateEndGameBonus(playerBoard);

            //Assert
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void CalculateEndGameBonus_Ocupplied()
        {
            //Arrange
            var cityHall = new CityHall();
            cityHall.Occupation.Add(true);

            var playerBoard = new PlayerBoard(null);
            playerBoard.CitySpaces.Add(cityHall);
            //Act
            var result = cityHall.CalculateEndGameBonus(playerBoard);

            //Assert
            Assert.AreEqual(result, 1);
        }
    }
}