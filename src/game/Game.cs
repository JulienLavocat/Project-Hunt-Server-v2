namespace Server
{
	public class Game
	{

		public static long time = 0;

		public static void Update(int delta)
		{

			time += delta;

		}

		public static void Log(string msg, params object[] objs)
		{
			System.Console.WriteLine(msg, objs);
		}

	}
}