using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RocketLeagueStats.Controllers;
using RocketLeagueStats.Models;

namespace RocketLeagueStats.Tests.Controllers
{
    [TestClass]
    public class teamsControllerTests
    {
        Mock<ITeamsMock> mock;
        List<team> teams;
        teamsController controller;

        [TestInitialize]
        public void TestInitialize()
        {
            //arrange mock data for all unit tests
            mock = new Mock<ITeamsMock>();

            teams = new List<team>
            {
                new team {teamid = 100, name="Team One", region="NA", wins=10, losses=3},
                new team {teamid = 200, name="Team Two", region="EU", wins=7, losses=4},
                new team {teamid = 300, name="Team Three", region="OCE", wins=4, losses=5},
                //new team { AlbumId = 100, Title = "One Hundred", Price = 6.99m, Artist = new Artist{
                //    ArtistId = 4000, Name = "Some One" }
                //},
                //new team { AlbumId = 200, Title = "Two Hundred", Price = 7.99m, Artist = new Artist{
                //    ArtistId = 4001, Name = "Some Else" }
                //},
                //new team { AlbumId = 300, Title = "Three Hundred", Price = 8.99m, Artist = new Artist{
                //    ArtistId = 4002, Name = "Some Other Than Else" }
                //}
            };
            //populate interface from mock data
            mock.Setup(mock => mock.teams).Returns(teams.AsQueryable());
            controller = new teamsController(mock.Object);
        }

        [TestMethod]
        public void IndexReturnsView()
        {
            //act
            ViewResult result = controller.Index() as ViewResult;

            //assert
            Assert.AreEqual("Index", result.ViewName);
        }
    }
}
