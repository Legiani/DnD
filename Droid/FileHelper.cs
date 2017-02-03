using Xamarin.Forms;
using System.IO;
using DnD.Droid;

[assembly: Dependency(typeof(FileHelper))]
namespace DnD.Droid
{

		public class FileHelper : IFileHelper
		{
			public string GetLocalFilePath(string filename)
			{
				string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
				return Path.Combine(path, filename);
			}
		}

}
