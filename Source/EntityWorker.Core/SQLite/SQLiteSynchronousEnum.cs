using System;

namespace EntityWorker.Core.SQLite
{
	internal enum SQLiteSynchronousEnum
	{
		Default = -1,
		Off = 0,
		Normal = 1,
		Full = 2
	}
}