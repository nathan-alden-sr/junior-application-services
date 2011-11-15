namespace Junior.ApplicationServices
{
	/// <summary>
	/// Determines whether email messages are sent synchronously or asynchronously.
	/// </summary>
	public enum EmailSenderSynchronization
	{
		/// <summary>
		/// Email messages are sent synchronously.
		/// </summary>
		Synchronous,
		/// <summary>
		/// Email messages are sent asynchronously.
		/// </summary>
		Asynchronous
	}
}