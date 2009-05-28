﻿#region Copyright (c) Lokad 2009
// This code is released under the terms of the new BSD licence.
// URL: http://www.lokad.com/
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lokad.Cloud.Framework
{
	/// <summary>Strongly-type queue service (inheritors are instanciated by
	/// reflection on the cloud).</summary>
	/// <typeparam name="T">Message type</typeparam>
	/// <remarks>
	/// <para>The implementation is not constrained by the 8kb limit for <c>T</c> instances.
	/// If the intances are larger, the framework will wrap them into the cloud storage.</para>
	/// <para>Whenever possible, we suggest to design the service logic to be idempotent
	/// in order to make the service reliable and ultimately consistent.</para>
	/// </remarks>
	public abstract class QueueService<T> : CloudService
	{
		/// <summary>Method called by the <c>Lokad.Cloud</c> framework when messages are
		/// available for processing.</summary>
		/// <param name="messages">Messages to be processed.</param>
		/// <remarks>
		/// We suggest to make messages deleted asap through the <see cref="Delete"/>
		/// method. Otherwise, messages will be automatically deleted when the method
		/// returns (except if an exception is thrown obviously).
		/// </remarks>
		public abstract void Start(IEnumerable<T> messages);

		public IEnumerable<T> GetMore(int count)
		{
			throw new NotImplementedException();
		}

		public void Delete(IEnumerable<T> messages)
		{
			throw new NotImplementedException();
		}
	}
}