using System;

namespace Rhino.Raft
{

	/// <summary>
	/// abstraction for transport between Raft nodes.
	/// </summary>
	public interface ITransport
	{
		TimeSpan HeartbeatTimeout { get; set; }

		void Send<T>(string dest, T message);

		void Register<T>(IHandler<T> messageHandler);

		void Unregister<T>(IHandler<T> messageHandler);
	}

}