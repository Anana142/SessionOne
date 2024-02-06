using Chempionat.DataBaseFolder;

namespace Chempionat.Tools
{
	public static class DataBase
	{
		private static User04Context instanse1;

		
		public static User04Context instanse
		{
			get
			{

				if (instanse1 == null)
					instanse1 = new User04Context();
				return instanse1;

			}
			set => instanse1 = value;
		}
	}
}
