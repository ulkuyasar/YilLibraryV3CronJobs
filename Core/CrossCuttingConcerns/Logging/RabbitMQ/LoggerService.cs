using Core.DataAccess.RabitMQ;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Logging.RabbitMQ
{
	public class LoggerService
	{
		public LoggerService()
		{
		}
		public static bool IsInfoEnabled => true;
		public static bool IsDebugEnabled => true;
		public static bool IsWarnEnabled => true;
		public static bool IsFatalEnabled => true;
		public static bool IsErrorEnabled => true;
		public static void Info(object logMessage)
		{
			if (IsInfoEnabled)
				publishRabitMQ("Info", logMessage);
		}

		public static void Debug(object logMessage)
		{
			if (IsDebugEnabled)
				publishRabitMQ("Debug", logMessage);
		}

		public static void Warn(object logMessage)
		{
			if (IsWarnEnabled)
				publishRabitMQ("Warn", logMessage);
		}

		public static void Error(object logMessage)
		{
			if (IsErrorEnabled)
				publishRabitMQ("Error", logMessage);
		}

		public static void Fatal(object logMessage)
		{
			if (IsFatalEnabled)
				publishRabitMQ("Fatal", logMessage);
		}

		private static void publishRabitMQ(string level, object logMessage)
		{
			string logStr = mesajiCustimizeEt(level, logMessage);
			YYRabbitPublich.Instance.Publish("Loging", logStr);
		}

		private static string mesajiCustimizeEt(string level, object mesaj)
		{
			string str = string.Format("{0} - {1} - {2}", level, System.DateTime.Now, mesaj);
			return str;
		}
	}
}
