using System;
using System.Linq.Expressions;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;

using Ploeh.AutoFixture;



namespace Common.Log.UnitTests
{
	[TestClass]
	public class LogAggregatorTests
	{
		private IFixture _fixture;
		private Mock<Common.Log.ILog> _log1;
		private Mock<Common.Log.ILog> _log2;
		private LogAggregator _logAggregator;

		[TestInitialize]
		public void TestInit()
		{
			_fixture = new Fixture();
			_log1 = new Mock<Common.Log.ILog>(MockBehavior.Strict);
			_log2 = new Mock<Common.Log.ILog>(MockBehavior.Strict);

			_logAggregator = new LogAggregator(new[] {_log1.Object, _log2.Object});
		}

		[TestMethod]
		public void DebugTest()
		{
			var message = _fixture.Create<string>();
			
			TestImpl(x => x.Debug(message));
			TestImpl(x => x.Debug(message, _log1, _log2, _logAggregator, _fixture));
		}

		[TestMethod]
		public void InfoTest()
		{
			var message = _fixture.Create<string>();

			TestImpl(x => x.Info(message));
			TestImpl(x => x.Info(message, _log1, _log2, _logAggregator, _fixture));
		}

		[TestMethod]
		public void WarnTest()
		{
			var message = _fixture.Create<string>();

			TestImpl(x => x.Warn(message));
			TestImpl(x => x.Warn(message, _log1, _log2, _logAggregator, _fixture));
		}

		[TestMethod]
		public void ErrorTest()
		{
			var message = _fixture.Create<string>();

			TestImpl(x => x.Error(message));
			TestImpl(x => x.Error(message, _log1, _log2, _logAggregator, _fixture));
		}

		[TestMethod]
		public void FatalTest()
		{
			var message = _fixture.Create<string>();

			TestImpl(x => x.Fatal(message));
			TestImpl(x => x.Fatal(message, _log1, _log2, _logAggregator, _fixture));
		}

		private void TestImpl(Expression<Action<Common.Log.ILog>> expression)
		{
			_log1.Setup(expression);
			_log2.Setup(expression);

			expression.Compile().Invoke(_logAggregator);
			
			_log1.Verify(expression, Times.Once);
			_log2.Verify(expression, Times.Once);
		}
	}
}