using LiteNetLib.Utils;

namespace Server
{
	public class Packets
	{

		private static NetDataWriter w = new NetDataWriter();

		/*
		 * Create a packet which indicates a protocol violation from clients.
		 */
		public static byte[] CreateProtocolError(string msg)
		{
			w.Reset();
			w.Put((byte)90);
			w.Put(msg);
			return w.CopyData();
		}
	}
}