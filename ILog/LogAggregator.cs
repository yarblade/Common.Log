using System;

namespace ILog
{
	public class LogAggregator : ILog
	{
		private readonly ILog[] _logs;

		public LogAggregator(ILog[] logs)
		{
			_logs = logs;
		}

		public void Debug(string message)
		{
			Write(x => x.Debug(message));
		}

		public void Debug(string format, params object[] args)
		{
			Write(x => x.Debug(format, args));
		}

		public void Info(string message)
		{
			Write(x => x.Info(message));
		}

		public void Info(string format, params object[] args)
		{
			Write(x => x.Info(format, args));
		}

		public void Warn(string message)
		{
			Write(x => x.Warn(message));
		}

		public void Warn(string format, params object[] args)
		{
			Write(x => x.Warn(format, args));
		}

		public void Error(string message)
		{
			Write(x => x.Error(message));
		}

		public void Error(string format, params object[] args)
		{
			Write(x => x.Error(format, args));
		}

		public void Fatal(string message)
		{
			Write(x => x.Fatal(message));
		}

		public void Fatal(string format, params object[] args)
		{
			Write(x => x.Fatal(format, args));
		}

		private void Write(Action<ILog> action)
		{
			foreach (var log in _logs)
			{
				action(log);
			}
		}
	}
}