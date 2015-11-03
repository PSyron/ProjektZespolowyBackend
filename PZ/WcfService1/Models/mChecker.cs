using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Checkers.Models
{
    /// <summary>
    /// Model odpowiedzialna za stan planszy(pozycje pionkow).
    /// </summary>
    public class mChecker
    {
        int CheckerId;
        List<mPawn> checkers;
    }
}