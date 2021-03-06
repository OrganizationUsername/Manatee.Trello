﻿using System;

namespace Manatee.Trello
{
	/// <summary>
	/// Defines methods required to log information, events, and errors generated throughout Manatee.Trello.
	/// </summary>
	public interface ILog
	{
		/// <summary>
		/// Writes a debug level log entry.
		/// </summary>
		/// <param name="message">The message or message format.</param>
		/// <param name="parameters">A list of parameters.</param>
		void Debug(string message, params object[] parameters);
		/// <summary>
		/// Writes an information level log entry.
		/// </summary>
		/// <param name="message">The message or message format.</param>
		/// <param name="parameters">A list of paramaters.</param>
		void Info(string message, params object[] parameters);
		/// <summary>
		/// Writes an error level log entry.
		/// </summary>
		/// <param name="e">The exception that will be or was thrown.</param>
		void Error(Exception e);
	}
}