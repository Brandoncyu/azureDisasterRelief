﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace WOFClassLib
{ 
    /// <summary>
    /// This class performs the functions related to a player of the game.
    /// </summary>
    public class Player
    {
        
        private int totalMoney = 0; // private variable for TotalMoney property
        private int roundMoney = 0; // private variable for RoundMoney property

        /// <summary>
        /// The Player's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The total amount of money the player has accumulated during the game.
        /// </summary>
        public int TotalMoney
        {
            get { return totalMoney; }
        }

        /// <summary>
        /// The total amount of money the player has accumulated during the current round
        /// </summary>
        public int RoundMoney
        {
            get { return roundMoney; }
        }

        /// <summary>
        /// Creates a new instance of Player.
        /// </summary>
        /// <param name="name">The value for the Name property</param>
        public Player(string name = "Player")
        {
            Name = name;
            totalMoney = 0;
            roundMoney = 0;
        }

        /// <summary>
        ///  Guesses the letter. If the guess was correct, add spinAmount*letters to the player's Round money.
        /// </summary>
        /// <param name="guess">The character for the letter is being guessed</param>
        /// <param name="puzzle">the puzzle we are </param>
        /// <param name="spinAmount"></param>
        /// <returns>The number of letters matched</returns>
        public int GuessLetter(char guess, Puzzle puzzle, int spinAmount = 0)
        {
            // TODO: update to use puzzle method
            int numLetters = 0; //puzzle.Guess(guess);
            roundMoney += numLetters * spinAmount;
            return numLetters;
        }

        /// <summary>
        /// Attempt to solve the puzzle. If the guess was correct, add the player's Round money to their TotalMoney.
        /// </summary>
        /// <param name="guess"></param>
        /// <param name="puzzle"></param>
        /// <returns>true if the guess was correct.</returns>
        public bool SolvePuzzle(string guess, Puzzle puzzle)
        {
            // TODO: Update to use puzzle method
            bool isSolved = true; // puzzle.Solve(guess);
            if (isSolved)
            {
                totalMoney += RoundMoney;
            }
            return isSolved;
        }

        /// <summary>
        /// Initialzes the player state at the start of a new round
        /// </summary>
        public void NewRound()
        {
            roundMoney = 0;
        }

        /// <summary>
        /// Initializes the player state at the start of a new game.
        /// </summary>
        public void NewGame()
        {
            totalMoney = 0;
            roundMoney = 0;
        }

    }
}