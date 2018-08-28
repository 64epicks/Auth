using System;
using Services;
using System.Threading;

namespace WebBackend
{
    class Program
    {
        public static int Main(string[] args)
        {
            HttpServer TokenServer;
            if (args.GetLength(0) > 0)
            {
                TokenServer = new TokenHttpServer(Convert.ToInt16(args[0]));
            }
            else
            {
                TokenServer = new TokenHttpServer(8080);
            }
            Thread thread = new Thread(new ThreadStart(TokenServer.listen));
            thread.Start();
            HttpServer ContentServer;
            if (args.GetLength(0) > 0)
            {
                ContentServer = new UserContentServer(Convert.ToInt16(args[0]));
            }
            else
            {
                ContentServer = new UserContentServer(5050);
            }
            Thread threadCon = new Thread(new ThreadStart(ContentServer.listen));
            threadCon.Start();
            return 0;
        }
    }
}
