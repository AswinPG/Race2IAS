
using System;

using System.IO;

using Foundation;
using Race2IAS.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileAccessHelper))]

namespace Race2IAS.iOS

{
    public class FileAccessHelper : IFileAccessHelper

    {
        string filepath;
	    public string GetLocalFilePath (string filename)

	    {

		    string docFolder = Environment.GetFolderPath (Environment.SpecialFolder.Personal);

		    string libFolder = Path.Combine (docFolder, "..", "Library", "Databases");



		    if (!Directory.Exists (libFolder)) {

			    Directory.CreateDirectory (libFolder);

		    }



		    string dbPath = Path.Combine (libFolder, (filename + ".db"));

            filepath = filename;

		    CopyDatabaseIfNotExists (dbPath,filepath);



		    return dbPath;
                //Checking
	    }



	    private static void CopyDatabaseIfNotExists (string dbPath, string filepath)

	    {

		    if (!File.Exists (dbPath)) {

			    var existingDb = NSBundle.MainBundle.PathForResource (filepath, "db");

			    File.Copy (existingDb, dbPath);

		    }

	    }

    }

}