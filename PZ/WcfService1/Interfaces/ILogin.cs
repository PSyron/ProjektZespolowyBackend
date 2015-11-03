using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Checkers.Interfaces
{

    [ServiceContract]
    public interface ILogin
    {
        [OperationContract]
        [WebGet(UriTemplate = "session/{session}", ResponseFormat = WebMessageFormat.Json)]
        LoginResponse session(String session);

        [OperationContract]
        [WebGet(UriTemplate = "login/{login}/{password}", ResponseFormat = WebMessageFormat.Json)]
        LoginResponse logIn(String login, String password);


        [OperationContract]
        [WebGet(UriTemplate = "test", ResponseFormat = WebMessageFormat.Json)]
        LoginResponse test();
        [OperationContract]
        [WebGet(UriTemplate = "test2", ResponseFormat = WebMessageFormat.Json)]
        LoginResponse test2();
        }

        [DataContract]
        public class RequestLogin
        {
            [DataMember]
            public String Login { get; set; }
            [DataMember]
            public Boolean Password { get; set; }
        }
        [DataContract]
        public class RequestLog
        {
            [DataMember]
            public String Login { get; set; }
        }
        [DataContract]
        public class RequestSession
        {
            [DataMember]
            public String Session { get; set; }
            [DataMember]
            public Boolean Authorized { get; set; }
        }
        [DataContract]
        public class LoginResponse
        {
            [DataMember]
            public String Session { get; set; }
            [DataMember]
            public Boolean Authorized { get; set; }
        }
    }

