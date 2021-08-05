using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Affordit_Automation.Utils
{
	public class PropertyReader
	{
		private static Lazy<PropertyReader> _instance = new Lazy<PropertyReader>(true);

		public static PropertyReader Instance { get { return _instance.Value; } }

		readonly Dictionary<string, string> _properties = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);

		public string this[string key]
		{
			get
			{
				string value;
				_properties.TryGetValue(key, out value);
				return value;
			}
		}

		public T Get<T>(string key)
		{
			string value = _properties[key];

			if (typeof(T).IsEnum)
				return (T)Enum.Parse(typeof(T), value);

			return (T)Convert.ChangeType(value, typeof(T));
		}

		public PropertyReader()
		{
			ReadProperties(Path.Combine(GetPath(), @"Config\ApplicationProperties.properties"));
		}

		private void ReadProperties(string file)
		{
			string[] lines = File.ReadAllLines(file);
			foreach (string line in lines)
			{
				if (String.IsNullOrWhiteSpace(line) || line.StartsWith("#"))
					continue;

				string[] parts = line.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries).Select(i => i.Trim()).ToArray();
				_properties[parts[0]] = parts[1];
			}
		}

		public string GetPath()
		{
			string workingDirectory = Environment.CurrentDirectory;
			string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
			projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
			return projectDirectory;
		}

	}
}