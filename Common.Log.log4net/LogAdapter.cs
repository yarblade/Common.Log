namespace Common.Log.log4net
{
	public class LogAdapter : Common.Log.ILog
	{
		private readonly global::log4net.ILog _log;

		public LogAdapter(global::log4net.ILog log)
		{
			_log = log;
		}

		public void Debug(string message)
		{
			_log.Debug(message);
		}

		public void Debug(string format, params object[] args)
		{
			_log.DebugFormat(format, args);
		}

		public void Info(string message)
		{
			_log.Info(message);
		}

		public void Info(string format, params object[] args)
		{
			_log.InfoFormat(format, args);
		}

		public void Warn(string message)
		{
			_log.Warn(message);
		}

		public void Warn(string format, params object[] args)
		{
			_log.WarnFormat(format, args);
		}

		public void Error(string message)
		{
			_log.Error(message);
		}

		public void Error(string format, params object[] args)
		{
			_log.ErrorFormat(format, args);
		}

		public void Fatal(string message)
		{
			_log.Fatal(message);
		}

		public void Fatal(string format, params object[] args)
		{
			_log.FatalFormat(format, args);
		}
	}
}