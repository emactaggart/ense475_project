using System;
using Xunit;
using FakeItEasy;
using UnityEngine;
using System.Collections.ObjectModel;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoFakeItEasy;

namespace ense475_project
{
    public class TeamsControllerTests
    {
        //static private Fixture fixture = new Fixture();
        //static private MatchController _matchController = fixture.Create<MatchController>();
        //static private CaptureController _captureController = fixture.Create<CaptureController>();
        //static private SpawnController _spawnController = fixture.Create<SpawnController>();
        //static private List<NetworkPlayer> _userNetworkPlayers = fixture.CreateMany<NetworkPlayer>().ToList();
        //static private List<UserModel> _userModels = fixture.CreateMany<UserModel>().ToList();
        //static private UserController _userController = fixture.Create<UserController>();
        //static private TeamMenuManager _teamMenuManager = fixture.Create<TeamMenuManager>();
        //static private WeaponContainer _weaponContainer = fixture.Create<WeaponContainer>();
        //static private double _nextPing = fixture.Create<double>();
        //static private TeamsControllerMock sut = new TeamsControllerMock(
        //        _matchController
        //        , _captureController
        //        , _spawnController
        //        , _userNetworkPlayers
        //        , _userModels
        //        , _userController
        //        , _teamMenuManager
        //        , _weaponContainer
        //        , _nextPing);

        public class WhenAddingNetworkPlayer {
            [Fact]              //similar to JUnit testCase attribute
            public void AndNetworkIsClient_PlayerShouldNotBeAdded() 
            {
                //arrange
                var fixture = new Fixture();
                //var networkPlayer = fixture.Create<NetworkPlayer>();
                var sut = fixture.Create<TeamsController>();

                //var userName = "username";
                //var uid = Guid.NewGuid();
                
                //act
                //sut.AddNetworkPlayer(A<NetworkPlayer>._, userName, uid);     //System Under Test (sut)

                //assert
                //within the AddNetworkPlayer method we only have access to the 
                //faked _userNetworkPlayers and _userModels, everything else is either 
                //created inside the method, hidden through inheritance, or 
                //A.CallTo(() => _userNetworkPlayers.Add(networkPlayer)).MustNotHaveHappened(); 
                //A.CallTo(() => _userModels.Add(A<UserModel>._)).MustNotHaveHappened();
            }

        }
    }

    /// <summary>
    /// TeamsControllerMock is used to inject faked objects into so they
    /// can be asserted against.
    /// Note, it does not change any of the functionality inherited from the 
    /// original TeamsController.
    /// Also note, this may not be required given better use of depend
    /// </summary>
    //public class TeamsControllerMock : TeamsController
    //{
    //    private MatchController _matchController;
    //    private CaptureController _captureController;
    //    private SpawnController _spawnController;
    //    private List<NetworkPlayer> _userNetworkPlayers;
    //    private List<UserModel> _userModels;
    //    private UserController _userController;
    //    private TeamMenuManager _teamMenuManager;
    //    private WeaponContainer _weaponContainer;
    //    private double _nextPing;

    //    /// <summary>
    //    /// This constructor allows us to inject faked objects into
    //    /// the inherited TeamsController methods without modifying 
    //    /// the original TeamsController itself
    //    /// </summary>
    //    public TeamsControllerMock(MatchController _matchController
    //            , CaptureController _captureController
    //            , SpawnController _spawnController
    //            , List<NetworkPlayer> _userNetworkPlayers
    //            , List<UserModel> _userModels
    //            , UserController _userController
    //            , TeamMenuManager _teamMenuManager
    //            , WeaponContainer _weaponContainer
    //            , double _nextPing)
    //    {
    //        this._matchController = _matchController;
    //        this._captureController = _captureController;
    //        this._spawnController = _spawnController;
    //        this._userNetworkPlayers = _userNetworkPlayers;
    //        this._userModels = _userModels;
    //        this._userController = _userController;
    //        this._teamMenuManager = _teamMenuManager;
    //        this._nextPing = _nextPing;
    //        this._weaponContainer = _weaponContainer;
    //    }
    //}
}
