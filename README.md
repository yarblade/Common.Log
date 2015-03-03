# Common.Log
Common.Log contains a simple interface ILog for logging.
```C#
public interface ILog
{
	void Debug(string message);
	void Debug(string format, params object[] args);

	void Info(string message);
	void Info(string format, params object[] args);

	void Warn(string message);
	void Warn(string format, params object[] args);
	
	void Error(string message);
	void Error(string format, params object[] args);
	
	void Fatal(string message);
	void Fatal(string format, params object[] args);
}
```

# Common.Log.log4net
Common.Log.log4net contains Common.Log adapter for log4net.
