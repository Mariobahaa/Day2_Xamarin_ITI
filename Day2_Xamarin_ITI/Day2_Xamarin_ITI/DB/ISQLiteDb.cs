using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day2_Xamarin_ITI.DB
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
