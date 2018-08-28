using System;
using WebBackend;
using SharpDB;
using System.IO;
using Newtonsoft.Json;

namespace Services
{
    public class TokenHttpServer : HttpServer
    {
        DB db = new DB(Environment.CurrentDirectory);
        public TokenHttpServer(int port)
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
            if (!p.http_url.Equals("") && !p.http_url.Equals("/"))
            {
                if (p.http_url.Equals("/GetSalt"))
                {

                }
            }


            /*if (p.http_url.Equals("/Test.png"))
			{
				Stream fs = File.Open("../../Test.png", FileMode.Open);

				p.writeSuccess("image/png");
				fs.CopyTo(p.outputStream.BaseStream);
				p.outputStream.BaseStream.Flush();
			}

			Console.WriteLine("request: {0}", p.http_url);
			p.writeSuccess();
			p.outputStream.WriteLine("<html><body><h1>test server</h1>");
			p.outputStream.WriteLine("Current Time: " + DateTime.Now.ToString());
			p.outputStream.WriteLine("url : {0}", p.http_url);

			p.outputStream.WriteLine("<form method=post action=/form>");
			p.outputStream.WriteLine("<input type=text name=foo value=foovalue>");
			p.outputStream.WriteLine("<input type=submit name=bar value=barvalue>");
			p.outputStream.WriteLine("</form>");
            */
        }

        public override void handlePOSTRequest(HttpProcessor p, StreamReader inputData)
        {
            Console.WriteLine("POST request: {0}", p.http_url);
            /*string data = qrData(inputData.ReadToEnd());
			if(data ==  File.ReadAllLines("key.txt")[0]){
				data = "Access granted";
			}
			else{
				data = "Access denied";
				Console.WriteLine(sha256_hash(DateTime.Now.Minute + File.ReadAllLines("key.txt")[0]));
			}*/
            string requesttype = p.httpHeaders["Request-Type"].ToString();
            dynamic data = JsonConvert.DeserializeObject(inputData.ReadToEnd());
            if (requesttype == "CREATE")
            {

            }


            p.writeSuccess();
            p.outputStream.WriteLine();


        }
        public override void handleOPTIONSRequest(HttpProcessor p)
        {

            p.writeSuccess();
        }
        #endregion
    }
}
