using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Checkers.Models
{
    public class mLog
    {
        int idTable;
        int idGame;
        int idPlayer;
        int idPawnMoved;
        int idPawnOut;
        int preColumn;
        int postColumn;
        int preRow;
        int postRow;
        
        public mLog(int idTable, int idGame, int idPlayer, int preColumn, int postColumn, int preRow, int postRow, int idPawnOut, int idPawnMoved)
        {
            this.idTable = idTable;
            this.idGame = idGame;
            this.idPlayer = idPlayer;
            this.preColumn = preColumn;
            this.postColumn = postColumn;
            this.preRow = preRow;
            this.postRow = postRow;
        }

        public void saveLog()
        {

        }
    }
}