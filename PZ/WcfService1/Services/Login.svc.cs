using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Checkers.App_Data;
using Checkers.Models;
using Checkers.Interfaces;
namespace Checkers.Services
{
    public class Login : ILogin
    {
        public LoginResponse session(string session)
        {
            Boolean authorized = false;
            if (DBControler.logIn(session).isAuthorized() == true) authorized = true;

            return new LoginResponse
            {
                Session = session,
                Authorized = authorized
            };
        
        }     
        
        public LoginResponse logIn(string login, string password)
        {
            String session = "";
            Boolean authorized = false;
            mUser user = DBControler.logIn(login, password);
            if (user != null)
            {
                session = user.getSession();
                authorized = user.isAuthorized();
            }
            return new LoginResponse
            {
                Session = session,
                Authorized = authorized
            };
        }

        public LoginResponse test2()
        {
            return new LoginResponse
            {
                Session = "lol",
                Authorized = true
            };
        }

        public LoginResponse test()
        {
            String session = "";
            Boolean authorized = false;
            String login = "tomasz.kluza";
            String password = "tk321";
            mUser user = DBControler.logIn(login, password);
            if (user != null) session = user.getSession();
            authorized = user.isAuthorized();
            return new LoginResponse
            {
                Session = session,
                Authorized = authorized
            };
        }
    }


    /*{
        public LoginResponse session(String session)
        {
            if (DBControler.logIn(session) == true) return new LoginResponse(session, true);            
            return new LoginResponse(session, false);
        }
        public LoginResponse logIn(String login,String password)
        {
            mUser user = DBControler.logIn(login, password);
            if (user == null) return new LoginResponse("", false);
            return new LoginResponse(user.getSession(), true);
        } 
        
    }
     */
}