using Day2_Xamarin_ITI.DB;
using Day2_Xamarin_ITI.iOS.DB;
using Foundation;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDb))]

namespace Day2_Xamarin_ITI.iOS.DB
{

    public class SQLiteDb : ISQLiteDb
    {

        SQLiteAsyncConnection ISQLiteDb.GetConnection()
        {
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "MySQLite.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}