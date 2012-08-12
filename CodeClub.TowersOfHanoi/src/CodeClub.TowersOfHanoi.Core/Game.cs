using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeClub.TowersOfHanoi.Core
{
    public class Game
    {
        #region Properties

        /// <summary>
        /// Keep track of the <c>GameMove</c>s that were made during <c>Play</c>.
        /// </summary>
        public Queue<GameMove> Moves { get; set; }

        /// <summary>
        /// Keep track of the current state of the game.  This will be used to
        /// compare against the goal of <c>Play</c>.
        /// </summary>
        public GameState CurrentState { get; set; }

        /// <summary>
        /// An implementation of <c>IGameEvaluator</c> that determines if <c>Play</c>
        /// completed the game within the optimal number of steps.
        /// </summary>
        public IGameEvaluator Evaluator { get; set; }

        #endregion


        #region Constructors

        public Game()
        {
            Moves = new Queue<GameMove>();
            CurrentState = new GameState();
        }

        #endregion


        #region Methods

        /// <summary>
        /// Play the Towers of Hanoi game.
        /// </summary>
        /// <param name="goal">The <c>GameState</c> that represents the end of the game (i.e. how we know
        /// we've won).</param>
        public void Play(GameState goal)
        {
        }

        #endregion
    }
}
