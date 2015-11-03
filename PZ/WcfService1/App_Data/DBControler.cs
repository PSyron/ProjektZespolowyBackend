using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Checkers.Models;
using System.Data;
namespace Checkers.App_Data
{
    static class DBControler
    {
        static App_Data.PZTableAdapters.TableAdapterManager tAM = new App_Data.PZTableAdapters.TableAdapterManager();
        static App_Data.PZTableAdapters.tUsersTableAdapter Uta = new App_Data.PZTableAdapters.tUsersTableAdapter();

        public static mUser logIn(String session)
        {
            if (Uta.CheckSession(session) == null || (int)Uta.CheckSession(session) == 0) return null;
            return new mUser(session, (int)Uta.SessionUserId(session));
        }

        public static mUser logIn(String login, String password)
        {
            int userID = -1;
            var userid = Uta.UserLogIn(login, password);
            if (userid == null) return null;
            mUser user = new mUser(login, password, (int)userid);
            user.authorize();
            Guid g = Guid.NewGuid();
            user.setSession(g + "");
            Uta.NewSession(user.getSession(), (int)userID);
            return user;
        }

        public static int register(String name, String surname, String login, String password)
        {
            mUser user=new mUser(name, surname, login, password);

            return -1;
        }
     
        }
}