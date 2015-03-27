using System;
using Xunit;
using FakeItEasy;
using Assert;
using TeamsController;
using UnityEngine;

namespace ense475_project
{
    public class TeamsControllerTests
    {
        [Fact]
        public void WhenAddingNetworkPlayar_AndNetworkIsClient_PlayerShouldNotBeAdded() 
        {
            //arrange
            var sut = new TeamsController();
            var networkPlayer = A.Fake<NetworkPlayer>();
            var userName = "username";
            var uid = Guid.NewGuid();

            //act
            sut.AddNetworkPlayer(networkPlayer, userName, uid);

            //assert
            A.CallTo(networkPlayer).MustHaveHappened();
        }



    }
}
