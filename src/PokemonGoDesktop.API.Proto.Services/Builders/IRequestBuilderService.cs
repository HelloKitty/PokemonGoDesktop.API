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
		/// <typeparamref name="TPayloadType"/>.
		/// </summary>
		/// <typeparam name="TPayloadType"></typeparam>
		/// <param name="payloadType"></param>
		/// <returns></returns>
		Request Build<TPayloadType>(TPayloadType payloadType)
			where TPayloadType : IRequestMessage;

		//TODO: Use code generation to map payloads to valid types (I don't think always 1:1)
		/// <summary>
		/// Builds a serializable <see cref="Request"/> message with the provided 
		/// <typeparamref name="TPayloadType"/>.
		/// </summary>
		/// <typeparam name="TPayloadType"></typeparam>
		/// <param name="payloadType"></param>
		/// <returns></returns>
		Request Build<TPayloadType>(RequestType requestType, TPayloadType payloadType)
			where TPayloadType : IRequestMessage;
	}
}
