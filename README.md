# ILog
ILog is a simple interface for logging.
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

# ILog.log4net
Ilog adapter for log4net.
