using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Checkers.Models
{
    public class mMove
    {
        int idTable;
        int idGame;
        int idPlayer;
        mPawn PawnPre;
        mPawn PawnPost;
        mPawn PawnDown;
        Boolean hasNextMove;
        Boolean moveAllowed;
        
        public mMove(int idTable, int idGame, int idPlayer, mPawn Pawn, int postColumn, int postRow)
        {
            this.idTable = idTable;
            this.idGame = idGame;
            this.idPlayer = idPlayer;
            PawnPre=Pawn;
            PawnPost=new mPawn(PawnPre.getId(),postColumn,postRow,PawnPre.getColor());
        }

        public String checkMove()
        {
            return "Move successful";
        }
    }
}