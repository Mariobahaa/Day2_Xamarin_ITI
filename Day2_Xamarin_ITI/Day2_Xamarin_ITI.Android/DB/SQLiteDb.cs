using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Day2_Xamarin_ITI.DB;
using Day2_Xamarin_ITI.Droid.DB;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDb))]
namespace Day2_Xamarin_ITI.Droid.DB
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