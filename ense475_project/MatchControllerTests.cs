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
    public class MatchControllerTests
    {
        private static Fixture fixture = new Fixture();
        private static TeamsController _teamsController = fixture.Create<TeamsController>();
        private static SpawnController _spawnController = fixture.Create<SpawnController>();
        private static MatchRoundMenuManager _matchRoundMenuManager = fixture.Create<MatchRoundMenuManager>();
        private static HUDController _hudController = fixture.Create<HUDController>();
        private static MatchModel _matchModel = fixture.Create<MatchModel>();
        private static CaptureController _captureController = fixture.Create<CaptureController>();
        private static UserController _userController = fixture.Create<UserController>();
        private static GameState _currentState = fixture.Create<GameState>();
        private static GameState _previousState = fixture.Create<GameState>();
        private static double _countdownTime = fixture.Create<double>();
        private static Team _roundWinner = fixture.Create<Team>();
        private static Team _matchWinner = fixture.Create<Team>();
        private static bool _startMatchFlag = fixture.Create<bool>();
        private static bool _allPlayersDead = fixture.Create<bool>();
        private static bool _areaCaptured = fixture.Create<bool>();

        static private MatchControllerMock sut = new MatchControllerMock(
            _teamsController
            , _spawnController
            , _matchRoundMenuManager
            , _hudController
            , _matchModel
            , _captureController
            , _userController
            , _currentState
            , _previousState
            , _countdownTime
            , _roundWinner
            , _matchWinner
            , _startMatchFlag
            , _allPlayersDead
            , _areaCaptured);


        //Tests go here
        public class OnStartMatch
        {
            [Fact]
            public void ItShouldStartMatch()
            {
                //arrange
                //act
                sut.StartMatch();

                //assert
                A.CallTo(() => _currentState).MustHaveHappened();
            }
        }

        public class OnAllPlayersDead
        {
            [Fact]
            public void TeamWins()
            {
                //arrange
                Team team = fixture.Create<Team>();
                
                //act
                sut.AllPlayersDead(team);

                //assert
                A.CallTo(() => _roundWinner).MustHaveHappened();
            }
        }

        public class OnCaptureArea
        {
            [Fact]
            public void RoundWinnerShouldBeSet()
            {
                //arrange
                Team team = fixture.Create<Team>();

                //act
                sut.CapturedArea();

                //assert
                A.CallTo(() => _areaCaptured).MustHaveHappened();
                A.CallTo(() => _roundWinner).MustHaveHappened();
            }
        }
    }

    /// <summary>
    /// MatchControllerMock is used to inject fake objects to be asserted
    /// against. Has no impacts on original functionality of MatchController
    /// </summary>
    public class MatchControllerMock : MatchController
    {
        private TeamsController _teamsController;
        private SpawnController _spawnController;
        private MatchRoundMenuManager _matchRoundMenuManager;
        private HUDController _hudController;
        private MatchModel _matchModel;
        private CaptureController _captureController;
        private UserController _userController;
        private GameState _currentState = GameState.None;
        private GameState _previousState = GameState.None;
        private double _countdownTime;
        private Team _roundWinner;
        private Team _matchWinner;
        private bool _startMatchFlag = false;
        private bool _allPlayersDead = false;
        private bool _areaCaptured = false;

        /// <summary>
        /// This constructor allows us to inject faked objects into
        /// the inherited TeamsController methods without modifying 
        /// the original MatchController itself
        /// </summary>
        public MatchControllerMock(
                TeamsController _teamsController
                , SpawnController _spawnController
                , MatchRoundMenuManager _matchRoundMenuManager
                , HUDController _hudController
                , MatchModel _matchModel
                , CaptureController _captureController
                , UserController _userController
                , GameState _currentState
                , GameState _previousState
                , double _countdownTime
                , Team _roundWinner
                , Team _matchWinner
                , bool _startMatchFlag
                , bool _allPlayersDead
                , bool _areaCaptured)
        {
            this._teamsController = _teamsController;
            this._spawnController = _spawnController;
            this._matchRoundMenuManager = _matchRoundMenuManager;
            this._hudController = _hudController;
            this._matchModel = _matchModel;
            this._captureController = _captureController;
            this._userController = _userController;
            this._currentState = _currentState;
            this._previousState = _previousState;
            this._roundWinner = _roundWinner;
            this._matchWinner = _matchWinner;
            this._startMatchFlag = _startMatchFlag;
            this._allPlayersDead = _allPlayersDead;
            this._areaCaptured = _areaCaptured;
        }
    }
}
