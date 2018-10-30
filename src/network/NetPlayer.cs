using System;
using LiteNetLib;

namespace Server
{
	class NetPlayer
	{
		private NetPeer peer;
		private string name;
		private Guid uid;

		public NetPlayer(NetPeer peer, string name, Guid uid)
		{
			this.peer = peer;
			this.name = name;
			this.uid = uid;
		}
	}
}
