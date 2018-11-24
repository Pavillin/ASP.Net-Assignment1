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
    public class teamsControllerTest
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
                new team { teamid=100, name="Team One", region="NA", wins=10, losses=4},
                new team { teamid=200, name="Team Two", region="EU", wins=9, losses=5},
                new team { teamid=300, name="Team Three", region="OCE", wins=6, losses=6}
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

        [TestMethod]
        public void IndexReturnsTeams()
        {
            //act
            var actual = (List<team>)((ViewResult)controller.Index()).Model;
            //assert
            CollectionAssert.AreEqual(teams.ToList(), actual);
        }

        [TestMethod]
        public void DetailsNoId()
        {
            //act
            var result = (ViewResult)controller.Details(null);

            //assert
            Assert.AreEqual("Error", result.ViewName);
        }

        [TestMethod]
        public void DetailsInvalidId()
        {
            //act
            var result = (ViewResult)controller.Details(67830);

            //assert
            Assert.AreEqual("Error", result.ViewName);
        }

        [TestMethod]
        public void DetailsValidId()
        {
            //act - cast the model as an team object
            team actual = (team)((ViewResult)controller.Details(100)).Model;

            //assert - is this the first album in our mock array
            Assert.AreEqual(teams[0], actual);
        }

        [TestMethod]
        public void DetailsViewLoads()
        {
            //act
            ViewResult result = (ViewResult)controller.Details(100);
            //assert
            Assert.AreEqual("Details", result.ViewName);
        }
    }
}
