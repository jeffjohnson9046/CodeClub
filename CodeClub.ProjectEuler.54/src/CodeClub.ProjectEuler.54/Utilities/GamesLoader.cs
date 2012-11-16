using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using CodeClub.ProjectEuler._54.Entities;

namespace CodeClub.ProjectEuler._54.Utilities
{
    public class GamesLoader
    {
        /// <summary>
        /// Load the text file that contains all hands for each player and creates a <c>Game</c> for each row
        /// in the file.
        /// </summary>
        /// <remarks>
        /// <para>
        /// A single row in the text file contains 10 2-character "card codes" of suit/value separated by a space.  
        /// Card codes look like this: 
        /// 
        ///     5H is Five of Hearts
        ///     TS is 10 of Spades
        ///     KD is King of diamonds
        /// 
        /// The first 5 "card codes" are the cards dealt to the first player, the remaining "card codes" represent 
        /// scards dealt to the second player.
        /// </para>
        /// <para></para>
        /// The path to the text file is read from the <c>filePath</c> value in the 
        /// <c>appSettings</c> section of the app.config.
        /// </remarks>
        public static List<Game> LoadGames()
        {
            var games = new List<Game>();
            var handBuilder = new HandBuilder();
            string[] rounds = File.ReadAllLines(ConfigurationManager.AppSettings["filePath"]);

            foreach (var round in rounds)
            {
                var cardCodes = round.Split(' ');
                var cardsDealtToPlayers = cardCodes.Select(code => new Card(code[CardCodePositions.VALUE], code[CardCodePositions.SUIT]))
                                                   .ToList();

                var player1Cards = cardsDealtToPlayers.Take(5)
                                                      .ToList();

                var player2Cards = cardsDealtToPlayers.Skip(5)
                                                      .Take(5)
                                                      .ToList();

                games.Add(new Game(player1Cards, player2Cards, handBuilder));
            }

            return games;
        }
    }
}
