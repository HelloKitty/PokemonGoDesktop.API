using Google.Protobuf;
using Networking.Envelopes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonGoDesktop.API.Proto.Services
{
	/// <summary>
	/// Service that parses <see cref="ResponseEnvelope"/>s.
	/// See doc for what a ResponseEnvelope is in this context.
	/// </summary>
	public interface IResponseEnvelopeParserService
	{
		/// <summary>
		/// Parses the provided <see cref="ResponseEnvelope"/> for a single <typeparamref name="TResponseMessageType"/>.
		/// </summary>
		/// <typeparam name="TResponseMessageType">Response payload type.</typeparam>
		/// <param name="responseEnvelope">Provided Response envelope.</param>
		/// <returns>An instance of <typeparamref name="TResponseMessageType"/> or null if none contained.</returns>
		TResponseMessageType ParseOne<TResponseMessageType>(ResponseEnvelope responseEnvelope)
			where TResponseMessageType : IRequestMessage, IMessage<TResponseMessageType>, IMessage;

		/// <summary>
		/// Parses the provided <see cref="ResponseEnvelope"/> for all <typeparamref name="TResponseMessageType"/>s.
		/// </summary>
		/// <typeparam name="TResponseMessageType">Response payload type.</typeparam>
		/// <param name="responseEnvelope">Provided Response envelope.</param>
		/// <returns>A collection of <typeparamref name="TResponseMessageType"/> or null if none contained.</returns>
		IEnumerable<TResponseMessageType> ParseAll<TResponseMessageType>(ResponseEnvelope responseEnvelope)
			where TResponseMessageType : IRequestMessage, IMessage<TResponseMessageType>, IMessage;
	}
}
