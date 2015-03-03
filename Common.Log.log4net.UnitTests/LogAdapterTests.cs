using System;
using System.Linq.Expressions;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;

using Ploeh.AutoFixture;



namespace Common.Log.log4net.UnitTests
{
	[TestClass]
	public class LogAdapterTests
	{
		private IFixture _fixture;
		private Mock<global::log4net.ILog> _log;
		private LogAdapter _logAdapter;

		[TestInitialize]
		public void TestInit()
		{
			_fixture = new Fixture();
			_log = new Mock<global::log4net.ILog>(MockBehavior.Strict);

			_logAdapter = new LogAdapter(_log.Object);
		}

		[TestMethod]
		public void DebugTest()
		{
			var message = _fixture.Create<string>();
			var obj = new object();

			TestImpl(x => x.Debug(message), x => x.Debug(message));
			TestImpl(x => x.Debug(message, _log, _logAdapter, _fixture, obj), x => x.DebugFormat(message, _log, _logAdapter, _fixture, obj));
		}

		[TestMethod]
		public void InfoTest()
		{
			var message = _fixture.Create<string>();
			var obj = new object();

			TestImpl(x => x.Info(message), x => x.Info(message));
			TestImpl(x => x.Info(message, _log, _logAdapter, _fixture, obj), x => x.InfoFormat(message, _log, _logAdapter, _fixture, obj));
		}

		[TestMethod]
		public void WarnTest()
		{
			var message = _fixture.Create<string>();
			var obj = new object();

			TestImpl(x => x.Warn(message), x => x.Warn(message));
			TestImpl(x => x.Warn(message, _log, _logAdapter, _fixture, obj), x => x.WarnFormat(message, _log, _logAdapter, _fixture, obj));
		}

		[TestMethod]
		public void ErrorTest()
		{
			var message = _fixture.Create<string>();
			var obj = new object();

			TestImpl(x => x.Error(message), x => x.Error(message));
			TestImpl(x => x.Error(message, _log, _logAdapter, _fixture, obj), x => x.ErrorFormat(message, _log, _logAdapter, _fixture, obj));
		}

		[TestMethod]
		public void FatalTest()
		{
			var message = _fixture.Create<string>();
			var obj = new object();

			TestImpl(x => x.Fatal(message), x => x.Fatal(message));
			TestImpl(x => x.Fatal(message, _log, _logAdapter, _fixture, obj), x => x.FatalFormat(message, _log, _logAdapter, _fixture, obj));
		}

		private void TestImpl(Action<LogAdapter> action, Expression<Action<global::log4net.ILog>> expression)
		{
			_log.Setup(expression);

			action(_logAdapter);

			_log.Verify(expression, Times.Once);
		}
	}
}
