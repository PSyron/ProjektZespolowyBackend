using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Checkers.Models
{
    public class mGame
    {
        int idGame;
        int idPlayer1;
        int idPlayer2;
        int player1Points=0;
        int player2Points=0;
        int Scorelimit = 2;
        

        public mGame(int idGame, int idPlayer1, int idPlayer2)
        {
            this.idGame = idGame;
            this.idPlayer1 = idPlayer1;
            this.idPlayer2 = idPlayer2;
        }

        public String playerWin(int idPlayer)
        {
            if (idPlayer == idPlayer1) {
                player1Points++;
                return "Player 1 wins";
            }
            else if (idPlayer == idPlayer2) { 
                player2Points++;
                return "Player 2 wins";
            }
            else return "This player doesn't belong to this game";                
        }

        public void changeScoreLimit(int Scorelimit)
        {
            this.Scorelimit = Scorelimit;
        }


    }
}