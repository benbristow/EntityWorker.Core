using System;

namespace EntityWorker.Core.SQLite
{
	public enum SQLiteExecuteType
	{
		None = 0,
		Default = 1,
		NonQuery = 1,
		Scalar = 2,
		Reader = 3
	}
}