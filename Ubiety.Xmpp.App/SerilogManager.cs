﻿using System;
using Serilog;
using Ubiety.Xmpp.Core.Logging;

namespace Ubiety.Xmpp.App
{
    public class SerilogManager : ILogManager
    {
        public ILog GetLogger(string name)
        {
            return new SerilogLogger(name);
        }

        private class SerilogLogger : ILog
        {
            private readonly string _name;

            public SerilogLogger(string name)
            {
                _name = name;
                Serilog.Log.Logger = new LoggerConfiguration().MinimumLevel.Debug().WriteTo.Console().CreateLogger();
            }
            
            public void Log(LogLevel level, object message)
            {
                Log(level, message.ToString());
            }

            public void Log(LogLevel level, Exception exception, object message)
            {
                LogException(level, exception, message.ToString());
            }

            private void Log(LogLevel level, string message)
            {
                var msg = $"{_name} :: {message}";
                switch (level)
                {
                    case LogLevel.Critical:
                        Serilog.Log.Fatal(msg);
                        break;
                    case LogLevel.Error:
                        Serilog.Log.Error(msg);
                        break;
                    case LogLevel.Warning:
                        Serilog.Log.Warning(msg);
                        break;
                    case LogLevel.Information:
                        Serilog.Log.Information(msg);
                        break;
                    case LogLevel.Debug:
                        Serilog.Log.Debug(msg);
                        break;
                }
            }

            private void LogException(LogLevel level, Exception exception, string message)
            {
                var msg = $"{_name} :: {message}";
                switch (level)
                {
                    case LogLevel.Critical:
                        Serilog.Log.Fatal(exception, msg);
                        break;
                    case LogLevel.Error:
                        Serilog.Log.Error(exception, msg);
                        break;
                    case LogLevel.Warning:
                        Serilog.Log.Warning(exception, msg);
                        break;
                    case LogLevel.Information:
                        Serilog.Log.Information(exception, msg);
                        break;
                    case LogLevel.Debug:
                        Serilog.Log.Debug(exception, msg);
                        break;
                }
            }
        }
    }
}