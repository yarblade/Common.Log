using JetBrains.Annotations;

namespace ILog
{
    public interface ILog
    {
		/// <summary>
        /// Writes message with level Debug to log.
        /// </summary>
        /// <param name="message">message body to be written</param>
        void Debug(string message);

        /// <summary>
        /// Writes message with level Debug to log. Message is being formatter prior to be written to log.
        /// </summary>
        /// <param name="format">Format string (the same as for String.Format)</param>
        /// <param name="args">zero or more arguments to be passed to Format() function call</param>
        [StringFormatMethod("format")]
        void Debug(string format, params object[] args);

		/// <summary>
        /// Writes message with level Info to log.
        /// </summary>
        /// <param name="message">message body to be written</param>
        void Info(string message);

        /// <summary>
        /// Writes message with level Info to log. Message is being formatter prior to be written to log.
        /// </summary>
        /// <param name="format">Format string (the same as for String.Format)</param>
        /// <param name="args">zero or more arguments to be passed to Format() function call</param>
		[StringFormatMethod("format")]
		void Info(string format, params object[] args);

        //  Warn level
        /// <summary>
        /// Writes message with level Warn to log.
        /// </summary>
        /// <param name="message">message body to be written</param>
        void Warn(string message);

        /// <summary>
        /// Writes message with level Warn to log. Message is being formatter prior to be written to log.
        /// </summary>
        /// <param name="format">Format string (the same as for String.Format)</param>
        /// <param name="args">zero or more arguments to be passed to Format() function call</param>
		[StringFormatMethod("format")]
		void Warn(string format, params object[] args);

        //  Error level
        /// <summary>
        /// Writes message with level Error to log.
        /// </summary>
        /// <param name="message">message body to be written</param>
        void Error(string message);

        /// <summary>
        /// Writes message with level Error to log. Message is being formatter prior to be written to log.
        /// </summary>
        /// <param name="format">Format string (the same as for String.Format)</param>
        /// <param name="args">zero or more arguments to be passed to Format() function call</param>
		[StringFormatMethod("format")]
		void Error(string format, params object[] args);

        /// <summary>
        /// Writes message with level Fatal to log.
        /// </summary>
        /// <param name="message">message body to be written</param>
        void Fatal(string message);

        /// <summary>
        /// Writes message with level Fatal to log. Message is being formatter prior to be written to log.
        /// </summary>
        /// <param name="format">Format string (the same as for String.Format)</param>
        /// <param name="args">zero or more arguments to be passed to Format() function call</param>
		[StringFormatMethod("format")]
		void Fatal(string format, params object[] args);
    }
}
