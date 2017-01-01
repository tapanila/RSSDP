﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rssdp
{
	/// <summary>
	/// Implementation of <see cref="ISsdpLogger"/> that writes to the .Net tracing system on platforms that support it, or <see cref="System.Diagnostics.Debug"/> on those that don't.
	/// </summary>
	public class SsdpTraceLogger : ISsdpLogger
	{
		/// <summary>
		/// Records a regular log message.
		/// </summary>
		/// <param name="message">The text to be logged.</param>
		public void LogInfo(string message)
		{
			throw PCL.StubException;
		}

		/// <summary>
		/// Records a frequent or large log message usually only required when trying to trace a problem.
		/// </summary>
		/// <param name="message">The text to be logged.</param>
		public void LogVerbose(string message)
		{
			throw PCL.StubException;
		}

		/// <summary>
		/// Records an important message, but one that may not neccesarily be an error.
		/// </summary>
		/// <param name="message">The text to be logged.</param>
		public void LogWarning(string message)
		{
			throw PCL.StubException;
		}

		/// <summary>
		/// Records a message that represents an error.
		/// </summary>
		/// <param name="message">The text to be logged.</param>
		public void LogError(string message)
		{
			throw PCL.StubException;
		}
	}
}