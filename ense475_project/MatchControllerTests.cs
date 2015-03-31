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

        static private Fixture fixture = new Fixture();
        private TeamsController _teamsController = fixture.Create<TeamsController>();
        private SpawnController _spawnController = fixture.Create<SpawnController>();
        private MatchRoundMenuManager _matchRoundMenuManager = fixture.Create<MatchRoundMenuManage>();
        private HUDController _hudController = fixture.Create<HUDController>();
        private MatchModel _matchModel = fixture.Create<MatchModel>();
        private CaptureController _captureController = fixture.Create<CaptureController>();
        private UserController _userController = fixture.Create<UserController>();
        private GameState _currentState = fixture.Create<GameState>();
        private GameState _previousState = fixture.Create<GameState>();
        private double _countdownTime = fixture.Create<double>();
        private Team _roundWinner = fixture.Create<Team>();
        private Team _matchWinner = fixture.Create<Team>();
        private bool _startMatchFlag = fixture.Create<bool>();
        private bool _allPlayersDead = fixture.Create<bool>();
        private bool _areaCaptured = fixture.Create<bool>();

        static private MatchControllerMock sut = new MatchControllerMock(
            _teamController
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
                this._areaCapture = _areaCaptured;
            }
        }
    }
}
