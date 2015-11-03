using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Checkers.Models;
using System.Data;
namespace Checkers.App_Data
{
    /// <summary>
    /// Tranzakcje z baza danych.
    /// Umieszczamy tutaj wszystkie table adaptery i metody zwiazane z wymiana/aktualizacja/usuwaniem/dodawaniem danych do db.
    /// </summary>
    static class DBControler
    {
        static App_Data.PZTableAdapters.TableAdapterManager tAM = new App_Data.PZTableAdapters.TableAdapterManager();
        static App_Data.PZTableAdapters.tUsersTableAdapter Uta = new App_Data.PZTableAdapters.tUsersTableAdapter();

        //Sprawdzenie prawidlowosci sesji
        public static mUser logIn(String session)
        {
            if (Uta.CheckSession(session) == null || (int)Uta.CheckSession(session) == 0) return null;
            mUser logedIn = new mUser(session, (int)Uta.SessionUserId(session));
            logedIn.authorize();
            return logedIn;
        }
        //Logowanie, uzyskanie nowej sesji
        public static mUser logIn(String login, String password)
        {
            var userid = Uta.UserLogIn(login, password);
            if (userid == null) return null;
            mUser user = new mUser(login, password, (int)userid);
            user.authorize();
            String guid = Guid.NewGuid()+"";
            user.setSession(guid);
            Uta.NewSession(guid, userid);
            return user;
        }
        //Rejestracja uzytkownika
        public static mUser register(String name, String surname, String login, String password)
        {
            //Mozna dodac jeszcze jakies warunki dotyczace hasla
            int userid = -1;
            if(Uta.LoginExists(login)==1) return null;
            mUser newUser=new mUser(name, surname, login, password);
            newUser.authorize();
            String guid = Guid.NewGuid() + "";
            newUser.setSession(guid);
            userid = Uta.NewUser(name, surname, login, password, guid);
            Uta.NewSession(guid, userid);
            return newUser;
        }
     
        }
}