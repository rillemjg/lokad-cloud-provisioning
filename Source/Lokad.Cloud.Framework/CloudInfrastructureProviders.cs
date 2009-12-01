﻿#region Copyright (c) Lokad 2009
// This code is released under the terms of the new BSD licence.
// URL: http://www.lokad.com/
#endregion

using Lokad.Cloud.Diagnostics;

namespace Lokad.Cloud
{
	/// <summary>IoC argument for <see cref="CloudService"/> and other
	/// cloud abstractions.</summary>
	/// <remarks>This argument will be populated through Inversion Of Control (IoC)
	/// by the Lokad.Cloud framework itself. This class is placed in the
	/// <c>Lokad.Cloud.Framework</c> for convenience while inheriting a
	/// <see cref="CloudService"/>.</remarks>
	public class CloudInfrastructureProviders
	{
		/// <summary>Abstracts the Blob Storage.</summary>
		public IBlobStorageProvider BlobStorage { get; private set; }

		/// <summary>Abstracts the Queue Storage.</summary>
		public IQueueStorageProvider QueueStorage { get; private set; }

		/// <summary>Error Logger</summary>
		public ILog Log { get; private set; }

		/// <summary>IoC constructor.</summary>
		public CloudInfrastructureProviders(
			IBlobStorageProvider blobStorage, 
			IQueueStorageProvider queueStorage,
			ILog log)
		{
			BlobStorage = blobStorage;
			QueueStorage = queueStorage;
			Log = log;
		}
	}
}