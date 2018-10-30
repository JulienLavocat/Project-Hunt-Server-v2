using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using LiteNetLib;

namespace Server
{
	class Server : INetEventListener
	{

		public static Dictionary<int, NetPlayer> players = new Dictionary<int, NetPlayer>();

		public void OnConnectionRequest(ConnectionRequest rq)
		{
			try
			{
				string name = rq.Data.GetString(rq.Data.GetInt());
				Guid uid	= new Guid(rq.Data.GetRemainingBytes());

				//TODO Check validaty

				NetPeer peer = rq.Accept();
				players.Add(peer.Id, new NetPlayer(peer, name, uid));

			} catch(Exception e)
			{
				rq.Reject(Packets.CreateProtocolError("Invalid connection request."));
			}
		}

		public void OnNetworkError(IPEndPoint endPoint, SocketError socketError)
		{
		}
		public void OnNetworkLatencyUpdate(NetPeer peer, int latency)
		{
		}
		public void OnNetworkReceiveUnconnected(IPEndPoint remoteEndPoint, NetPacketReader reader, UnconnectedMessageType messageType)
		{
		}

		public void OnPeerConnected(NetPeer peer)
		{

		}

		public void OnNetworkReceive(NetPeer peer, NetPacketReader data, DeliveryMethod deliveryMethod)
		{
			try
			{

				switch(data.GetByte())
				{

				}

			}
			catch (Exception e) { }
		}

		public void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo)
		{
			
		}

	}
}
