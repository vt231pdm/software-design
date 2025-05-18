using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	public class FileLoggerAdapter : ILog
	{
		private readonly FileWriter _fileWriter;

		public FileLoggerAdapter(FileWriter fileWriter)
		{
			_fileWriter = fileWriter;
		}

		public void Log(string message)
		{
			_fileWriter.WriteLine("[INFO] " + message);
		}

		public void Warn(string message)
		{
			_fileWriter.WriteLine("[WARN] " + message);
		}

		public void Error(string message)
		{
			_fileWriter.WriteLine("[ERROR] " + message);
		}
	}

}
