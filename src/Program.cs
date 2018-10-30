using LiteNetLib;
using System;
using System.Diagnostics;
using System.Threading;

namespace Server
{
	class ServerLogic
	{

		private const int tickRate = 30;
		public const int tickTime = 1000 / tickRate;

		public static NetManager server;

		public static void Start()
		{
			server = new NetManager(new Server());
		}

		public static void Run()
		{

			Log("Running at {0}", tickRate);

			Stopwatch watch = new Stopwatch();

			int delta = 0;

			while(true)
			{
				watch.Reset();

					server.PollEvents();
					Game.Update(delta);

				watch.Stop();

				delta = tickTime - (int)watch.ElapsedMilliseconds;
				if (delta <= 0)
					continue;

				Thread.Sleep(delta);

			}

		}

		private static void Log(string msg)
		{
			Console.WriteLine("[Server] " + msg);
		}

		private static void Log(string msg, params object[] objs)
		{
			Console.WriteLine("[Server] " + msg, objs);
		}

	}

	class Program
	{
		static void Main(string[] args)
		{

			ServerLogic.Start();
			ServerLogic.Run();

		}
	}

}
