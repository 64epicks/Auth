using System;
using WebBackend;
using SharpDB;
using System.IO;

namespace Services
{
    public class UserContentServer : HttpServer
    {
        DB db = new DB(Environment.CurrentDirectory);
        public UserContentServer(int port)
            : base(port)
        {
            if (!db.DatabaseExists("accounts")) db.CreateDatabase("accounts");
            db.EnterDatabase("accounts");
            if (!db.TableExists("accounts", "srvInfo")) db.CreateTable("srvInfo", "Key;Info");
            if (!db.TableExists("accounts", "users")) db.CreateTable("users", "Name;Email;Password;Salt");
        }
        #region RequestHandle
        public override void handleGETRequest(HttpProcessor p)
        {
            throw new NotImplementedException();
        }
        public override void handlePOSTRequest(HttpProcessor p, StreamReader inputData)
        {
            throw new NotImplementedException();
        }
        public override void handleOPTIONSRequest(HttpProcessor p)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
