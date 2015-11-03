using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Checkers.Models
{
    public class mTable
    {
        int idTable;

        List<mUser> players;
        List<mUser> spectators;
    }
}