using Google.Protobuf;
using Networking.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonGoDesktop.API.Proto.Services
{
	/// <summary>
	/// Service that generates generates <see cref="Request"/>s.
	/// See doc for what a Request is in this context.
	/// </summary>
	public interface IRequestBuilderService
	{
		/// <summary>
		/// Builds a serializable <see cref="Request"/> message with the provided 
		/// <typeparamref name="TRequestMessageType"/>.
		/// </summary>
		/// <typeparam name="TRequestMessageType"></typeparam>
		/// <param name="messageInstance"></param>
		/// <returns></returns>
		Request Build<TRequestMessageType>(TRequestMessageType messageInstance)
			where TRequestMessageType : IRequestMessage, IMessage<TRequestMessageType>, IMessage;

		//TODO: Use code generation to map payloads to valid types (I don't think always 1:1)
		/// <summary>
		/// Builds a serializable <see cref="Request"/> message with the provided 
		/// <typeparamref name="TRequestMessageType"/>.
		/// </summary>
		/// <typeparam name="TRequestMessageType"></typeparam>
		/// <param name="messageInstance">Inner contained payload of the <see cref="Request"/>.</param>
		/// <param name="requestType"><see cref="RequestType"/> enum value to put in the message.</param>
		/// <returns></returns>
		Request Build<TRequestMessageType>(RequestType requestType, TRequestMessageType messageInstance)
			where TRequestMessageType : IRequestMessage, IMessage<TRequestMessageType>, IMessage;
	}
}
