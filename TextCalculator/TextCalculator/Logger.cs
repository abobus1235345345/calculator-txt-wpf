using System;
using System.IO;

class Logger
{
    private readonly string logFileName;

    public Logger()
    {
        logFileName = $"log_{DateTime.Now.ToString("yyyy-MM-dd")}.txt";

        if (!File.Exists(logFileName))
        {
            using (StreamWriter sw = File.CreateText(logFileName))
            {
                sw.WriteLine($"Log file created on {DateTime.Now.ToString()}");
            }
        }
    }

    public void Log(string message)
    {
        using (StreamWriter sw = File.AppendText(logFileName))
        {
            sw.WriteLine($"[{DateTime.Now.ToString()}] {message}");
        }
    }

    public void LogAction(string action)
    {
        Log($"Action: {action}");
    }

    public void LogConcatenationAction(int times)
    {
        Log($"Concatenation action performed {times} times");
    }

    public void LogApplicationClose()
    {
        Log("Application closed");
    }
}

