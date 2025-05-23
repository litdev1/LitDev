﻿//#define SVB
#if SVB
using Microsoft.SmallVisualBasic.Library;
using Microsoft.SmallVisualBasic.Library.Internal;
using SBArray = Microsoft.SmallVisualBasic.Library.Array;
using SBShapes = Microsoft.SmallVisualBasic.Library.Shapes;
using SBFile = Microsoft.SmallVisualBasic.Library.File;
using SBMath = Microsoft.SmallVisualBasic.Library.Math;
using SBProgram = Microsoft.SmallVisualBasic.Library.Program;
using SBControls = Microsoft.SmallVisualBasic.Library.Controls;
using SBImageList = Microsoft.SmallVisualBasic.Library.ImageList;
using SBTextWindow = Microsoft.SmallVisualBasic.Library.TextWindow;
using SBCallback = Microsoft.SmallVisualBasic.Library.SmallVisualBasicCallback;
#else
using Microsoft.SmallBasic.Library;
using Microsoft.SmallBasic.Library.Internal;
using SBArray = Microsoft.SmallBasic.Library.Array;
using SBShapes = Microsoft.SmallBasic.Library.Shapes;
using SBFile = Microsoft.SmallBasic.Library.File;
using SBMath = Microsoft.SmallBasic.Library.Math;
using SBProgram = Microsoft.SmallBasic.Library.Program;
using SBControls = Microsoft.SmallBasic.Library.Controls;
using SBImageList = Microsoft.SmallBasic.Library.ImageList;
using SBTextWindow = Microsoft.SmallBasic.Library.TextWindow;
using SBCallback = Microsoft.SmallBasic.Library.SmallBasicCallback;
#endif

//The following Copyright applies to the LitDev Extension for Small Basic and files in the namespace LitDev.
//Copyright (C) <2011 - 2020> litdev@hotmail.co.uk
//This file is part of the LitDev Extension for Small Basic.

//LitDev Extension is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//LitDev Extension is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with menu.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using MySql.Data.MySqlClient;
using System.Windows;
using System.Reflection;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;
using System.IO;
using System.Windows.Forms.Integration;
using System.Windows.Forms;
using System.Windows.Input;
using LitDev.Engines;

namespace LitDev
{
    public class DataBase : IDisposable
    {
        public enum DBType
        {
            SQLite,
            MySql,
            SqlServer,
            OleDb,
            Odbc
        }
        public DBType dbType;
        public int id;
        public string database;
        public string name;
        public string dbConnection;
        public SQLiteConnection cnnSQLite;
        public SQLiteCommand commandSQLite;
        public SQLiteDataAdapter adapterSQLite;
        public Dictionary<DataTable, SQLiteCommand> commandSQLites;
        public Dictionary<DataTable, SQLiteDataAdapter> adapterSQLites;
        public MySqlConnection cnnMySql;
        public MySqlCommand commandMySql;
        public MySqlDataAdapter adapterMySql;
        public Dictionary<DataTable, MySqlCommand> commandMySqls;
        public Dictionary<DataTable, MySqlDataAdapter> adapterMySqls;
        public SqlConnection cnnSqlServer;
        public SqlCommand commandSqlServer;
        public SqlDataAdapter adapterSqlServer;
        public Dictionary<DataTable, SqlCommand> commandSqlServers;
        public Dictionary<DataTable, SqlDataAdapter> adapterSqlServers;
        public OleDbConnection cnnOleDb;
        public OleDbCommand commandOleDb;
        public OleDbDataAdapter adapterOleDb;
        public Dictionary<DataTable, OleDbCommand> commandOleDbs;
        public Dictionary<DataTable, OleDbDataAdapter> adapterOleDbs;
        public OdbcConnection cnnOdbc;
        public OdbcCommand commandOdbc;
        public OdbcDataAdapter adapterOdbc;
        public Dictionary<DataTable, OdbcCommand> commandOdbcs;
        public Dictionary<DataTable, OdbcDataAdapter> adapterOdbcs;

        public DataBase(string database, int id)
        {
            this.id = id;
            this.database = database;
            name = "DataBase" + id.ToString();
        }

        public void ConnectSQLite()
        {
            dbType = DBType.SQLite;
            dbConnection = "Data Source=" + database;
            if (LDDataBase.Connection != "") dbConnection = LDDataBase.Connection;
            cnnSQLite = new SQLiteConnection(dbConnection);
            cnnSQLite.Open();
            commandSQLite = new SQLiteCommand();
            commandSQLite.Connection = cnnSQLite;
            commandSQLites = new Dictionary<DataTable, SQLiteCommand>();
            adapterSQLites = new Dictionary<DataTable, SQLiteDataAdapter>();
        }

        public void ConnectMySql(string server, string user, string password)
        {
            dbType = DBType.MySql;
            dbConnection = "Server=" + server + ";Uid=" + user + ";Pwd=" + password + ";Database=" + database;
            if (LDDataBase.Connection != "") dbConnection = LDDataBase.Connection;
            cnnMySql = new MySqlConnection(dbConnection);
            cnnMySql.Open();
            commandMySql = new MySqlCommand();
            commandMySql.Connection = cnnMySql;
            commandMySqls = new Dictionary<DataTable, MySqlCommand>();
            adapterMySqls = new Dictionary<DataTable, MySqlDataAdapter>();
        }

        public void ConnectSqlServer(string server)
        {
            dbType = DBType.SqlServer;
            name = "DataBase" + id.ToString();
            dbConnection = "Server=" + server + ";Database=" + database + ";Integrated Security=SSPI";
            if (LDDataBase.Connection != "") dbConnection = LDDataBase.Connection;
            cnnSqlServer = new SqlConnection(dbConnection);
            cnnSqlServer.Open();
            commandSqlServer = new SqlCommand();
            commandSqlServer.Connection = cnnSqlServer;
            commandSqlServers = new Dictionary<DataTable, SqlCommand>();
            adapterSqlServers = new Dictionary<DataTable, SqlDataAdapter>();
        }

        public void ConnectOleDb(string provider, string server)
        {
            dbType = DBType.OleDb;
            name = "DataBase" + id.ToString();
            dbConnection = "Provider=" + provider + ";Data Source=" + server + ";Initial Catalog=" + database + ";Integrated Security=SSPI";
            if (LDDataBase.Connection != "") dbConnection = LDDataBase.Connection;
            cnnOleDb = new OleDbConnection(dbConnection);
            cnnOleDb.Open();
            commandOleDb = new OleDbCommand();
            commandOleDb.Connection = cnnOleDb;
            commandOleDbs = new Dictionary<DataTable, OleDbCommand>();
            adapterOleDbs = new Dictionary<DataTable, OleDbDataAdapter>();
        }

        public void ConnectOdbc(string driver, string server, Primitive port, string user, string password, string option)
        {
            dbType = DBType.Odbc;
            name = "DataBase" + id.ToString();
            dbConnection = "Driver=" + driver + ";Server=" + server + ";Port=" + port + ";DataBase=" + database + ";Uid=" + user + ";Pwd=" + password + ";option="+option;
            if (LDDataBase.Connection != "") dbConnection = LDDataBase.Connection;
            cnnOdbc = new OdbcConnection(dbConnection);
            cnnOdbc.Open();
            commandOdbc = new OdbcCommand();
            commandOdbc.Connection = cnnOdbc;
            commandOdbcs = new Dictionary<DataTable, OdbcCommand>();
            adapterOdbcs = new Dictionary<DataTable, OdbcDataAdapter>();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // free managed resources
                cnnSQLite.Dispose();
                commandSQLite.Dispose();
                foreach (var com in commandSQLites)
                {
                    com.Value.Dispose();
                }
                cnnMySql.Dispose();
                commandMySql.Dispose();
                foreach (var com in commandMySqls)
                {
                    com.Value.Dispose();
                }
                cnnSqlServer.Dispose();
                commandSqlServer.Dispose();
                foreach (var com in commandSqlServers)
                {
                    com.Value.Dispose();
                }
                cnnOleDb.Dispose();
                commandOleDb.Dispose();
                foreach (var com in commandOleDbs)
                {
                    com.Value.Dispose();
                }
                cnnOdbc.Dispose();
                commandOdbc.Dispose();
                foreach (var com in commandOdbcs)
                {
                    com.Value.Dispose();
                }
            }
            // free native resources if there are any.
        }
    }

    /// <summary>
    /// SQL Database with ListView control.
    /// ConnectSQLite for SQLite databases (see http://zetcode.com/db/sqlite for SQLite commands).
    /// ConnectMySQL for MySQL databases (see http://www.mysql.com for MySQL downloads and setup).
    /// ConnectSqlServer for SqlServer databases (see http://www.microsoft.com/en-us/server-cloud/products/sql-server-editions/sql-server-express.aspx for SqlServer downloads and setup).
    /// ConnectOleDb for Access OleDb databases.
    /// ConnectOdbc for Odbc databases.
    /// </summary>
#if SVB
    [SmallVisualBasicType]
#else
    [SmallBasicType]
#endif
    public static class LDDataBase
    {
        static LDDataBase()
        {
            Instance.Verify();
        }

        public static List<DataBase> dataBases = new List<DataBase>();

        /// <summary>
        /// Get a read only list of databases for use outside Small Basic.
        /// </summary>
        /// <returns>
        /// IReadOnlyList&lt;DataBase&gt;
        /// </returns>
        public static IReadOnlyList<DataBase> GetDB()
        {
            return dataBases.AsReadOnly();
        }

        private static void ExtractDll()
        {
            try
            {
                string filename = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\SQLite.Interop.dll";
                if (!System.IO.File.Exists(filename))
                {
                    Byte[] dll = (IntPtr.Size == 8) ? global::LitDev.Properties.Resources.SQLite_Interop64 : global::LitDev.Properties.Resources.SQLite_Interop32;
                    using (System.IO.FileStream fs = new System.IO.FileStream(filename, System.IO.FileMode.Create))
                    {
                        fs.Write(dll, 0, dll.Length);
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private static int NextID()
        {
            int id = 1;
            foreach (DataBase dataBase in dataBases)
            {
                if (dataBase.id >= id) id = dataBase.id + 1;
            }
            return id;
        }

        private static DataBase GetDataBase(string name, bool bShowErrors = true)
        {
            foreach (DataBase dataBase in dataBases)
            {
                if (dataBase.name == name || dataBase.database == name) return dataBase;
            }
            if (bShowErrors) Utilities.OnError(Utilities.GetCurrentMethod(), new Exception("DataBase not found"));
            return null;
        }

        private static DataTable GetDataTable(DataBase dataBase, string query, DataTable dataTable)
        {
            bool dummyDataTable = null == dataTable;
            if (dummyDataTable)
            {
                dataTable = new DataTable();
            }
            dataTable.Clear();
            switch (dataBase.dbType)
            {
                case DataBase.DBType.SQLite:
                    {
                        if (dummyDataTable)
                        {
                            dataBase.commandSQLite.CommandText = query;
                            dataBase.adapterSQLite = new SQLiteDataAdapter(dataBase.commandSQLite);
                            dataBase.adapterSQLite.Fill(dataTable);
                        }
                        else
                        {
                            dataBase.commandSQLites[dataTable] = new SQLiteCommand();
                            dataBase.commandSQLites[dataTable].Connection = dataBase.cnnSQLite;
                            dataBase.commandSQLites[dataTable].CommandText = query;
                            dataBase.adapterSQLites[dataTable] = new SQLiteDataAdapter(dataBase.commandSQLites[dataTable]);
                            dataBase.adapterSQLites[dataTable].Fill(dataTable);
                        }
                    }
                    break;
                case DataBase.DBType.MySql:
                    {
                        if (dummyDataTable)
                        {
                            dataBase.commandMySql.CommandText = query;
                            dataBase.adapterMySql = new MySqlDataAdapter(dataBase.commandMySql);
                            dataBase.adapterMySql.Fill(dataTable);
                        }
                        else
                        {
                            dataBase.commandMySqls[dataTable] = new MySqlCommand();
                            dataBase.commandMySqls[dataTable].Connection = dataBase.cnnMySql;
                            dataBase.commandMySqls[dataTable].CommandText = query;
                            dataBase.adapterMySqls[dataTable] = new MySqlDataAdapter(dataBase.commandMySqls[dataTable]);
                            dataBase.adapterMySqls[dataTable].Fill(dataTable);
                        }
                    }
                    break;
                case DataBase.DBType.SqlServer:
                    {
                        if (dummyDataTable)
                        {
                            dataBase.commandSqlServer.CommandText = query;
                            dataBase.adapterSqlServer = new SqlDataAdapter(dataBase.commandSqlServer);
                            dataBase.adapterSqlServer.Fill(dataTable);
                        }
                        else
                        {
                            dataBase.commandSqlServers[dataTable] = new SqlCommand();
                            dataBase.commandSqlServers[dataTable].Connection = dataBase.cnnSqlServer;
                            dataBase.commandSqlServers[dataTable].CommandText = query;
                            dataBase.adapterSqlServers[dataTable] = new SqlDataAdapter(dataBase.commandSqlServers[dataTable]);
                            dataBase.adapterSqlServers[dataTable].Fill(dataTable);
                        }
                    }
                    break;
                case DataBase.DBType.OleDb:
                    {
                        if (dummyDataTable)
                        {
                            dataBase.commandOleDb.CommandText = query;
                            dataBase.adapterOleDb = new OleDbDataAdapter(dataBase.commandOleDb);
                            dataBase.adapterOleDb.Fill(dataTable);
                        }
                        else
                        {
                            dataBase.commandOleDbs[dataTable] = new OleDbCommand();
                            dataBase.commandOleDbs[dataTable].Connection = dataBase.cnnOleDb;
                            dataBase.commandOleDbs[dataTable].CommandText = query;
                            dataBase.adapterOleDbs[dataTable] = new OleDbDataAdapter(dataBase.commandOleDbs[dataTable]);
                            dataBase.adapterOleDbs[dataTable].Fill(dataTable);
                        }
                    }
                    break;
                case DataBase.DBType.Odbc:
                    {
                        if (dummyDataTable)
                        {
                            dataBase.commandOdbc.CommandText = query;
                            dataBase.adapterOdbc = new OdbcDataAdapter(dataBase.commandOdbc);
                            dataBase.adapterOdbc.Fill(dataTable);
                        }
                        else
                        {
                            dataBase.commandOdbcs[dataTable] = new OdbcCommand();
                            dataBase.commandOdbcs[dataTable].Connection = dataBase.cnnOdbc;
                            dataBase.commandOdbcs[dataTable].CommandText = query;
                            dataBase.adapterOdbcs[dataTable] = new OdbcDataAdapter(dataBase.commandOdbcs[dataTable]);
                            dataBase.adapterOdbcs[dataTable].Fill(dataTable);
                        }
                    }
                    break;
            }
            return dataTable;
        }

        private static void UpdateDataTableBySQL(DataBase dataBase, DataGridView dataView)
        {
            try
            {
                DataTable dataTable = (DataTable)dataView.Tag;
                if (null == dataTable) return;

                string table = dataTable.TableName;
                string columns = "(";
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    columns += dataTable.Columns[i].ColumnName;
                    if (i < dataTable.Columns.Count - 1) columns += ",";
                }
                columns += ")";

                StringBuilder command = new StringBuilder();
                command.Append("BEGIN TRANSACTION;");
                command.Append("DELETE FROM " + table + ";");
                foreach (DataGridViewRow row in dataView.Rows)
                {
                    string rowCommand = "INSERT INTO " + table + columns + "VALUES(";
                    bool validRow = true;
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (null == row.Cells[i].Value)
                        {
                            validRow = false;
                            break;
                        }
                        rowCommand += "'" + row.Cells[i].Value.ToString() + "'";
                        if (i < row.Cells.Count - 1) rowCommand += ",";
                    }
                    rowCommand += ");";
                    if (validRow) command.Append(rowCommand);
                }
                command.Append("COMMIT;");

                Command(dataBase.name, command.ToString());
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private static void UpdateDataTable(DataBase dataBase, DataGridView dataView)
        {
            DataTable dataTable = (DataTable)dataView.Tag;
            if (null == dataTable) return;
            try
            {
                switch (dataBase.dbType)
                {
                    case DataBase.DBType.SQLite:
                        {
                            dataBase.commandSQLites[dataTable] = new SQLiteCommandBuilder(dataBase.adapterSQLites[dataTable]).GetUpdateCommand();
                            dataBase.adapterSQLites[dataTable].Update(dataTable);
                        }
                        break;
                    case DataBase.DBType.MySql:
                        {
                            dataBase.commandMySqls[dataTable] = new MySqlCommandBuilder(dataBase.adapterMySqls[dataTable]).GetUpdateCommand();
                            dataBase.adapterMySqls[dataTable].Update(dataTable);
                        }
                        break;
                    case DataBase.DBType.SqlServer:
                        {
                            dataBase.commandSqlServers[dataTable] = new SqlCommandBuilder(dataBase.adapterSqlServers[dataTable]).GetUpdateCommand();
                            dataBase.adapterSqlServers[dataTable].Update(dataTable);
                        }
                        break;
                    case DataBase.DBType.OleDb:
                        {
                            dataBase.commandOleDbs[dataTable] = new OleDbCommandBuilder(dataBase.adapterOleDbs[dataTable]).GetUpdateCommand();
                            dataBase.adapterOleDbs[dataTable].Update(dataTable);
                        }
                        break;
                    case DataBase.DBType.Odbc:
                        {
                            dataBase.commandOdbcs[dataTable] = new OdbcCommandBuilder(dataBase.adapterOdbcs[dataTable]).GetUpdateCommand();
                            dataBase.adapterOdbcs[dataTable].Update(dataTable);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                UpdateDataTableBySQL(dataBase, dataView);
            }
        }

        private static void Data2Grid(string shapeName, DataTable dataTable)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (_objectsMap.TryGetValue((string)shapeName, out obj))
                {
                    InvokeHelper ret = new InvokeHelper(delegate
                    {
                        try
                        {
                            System.Windows.Controls.ListView shape = (System.Windows.Controls.ListView)obj;
                            GridView gridView = new GridView();
                            shape.View = gridView;

                            Style style = new Style(typeof(System.Windows.Controls.ListViewItem));
                            style.Setters.Add(new Setter(System.Windows.Controls.ListViewItem.HorizontalContentAlignmentProperty, System.Windows.HorizontalAlignment.Stretch));
                            shape.ItemContainerStyle = style;

                            shape.Items.Clear();

                            int i = 0;
                            foreach (DataColumn column in dataTable.Columns)
                            {
                                GridViewColumn Col = new GridViewColumn();
                                GridViewColumnHeader header = new GridViewColumnHeader();
                                header.Content = column.Caption;
                                header.Tag = shape;
                                header.MouseDown += new MouseButtonEventHandler(LDControls._ListViewHeaderMouseButtonEvent);
                                Col.Header = header;
                                Col.Width = Double.NaN;
                                //Col.DisplayMemberBinding = new System.Windows.Data.Binding("col[" + i + "]");
                                DataTemplate dt = new DataTemplate();
                                dt.DataType = typeof(string);
                                FrameworkElementFactory fef = new FrameworkElementFactory(typeof(TextBlock));
                                fef.SetBinding(TextBlock.TextProperty, new System.Windows.Data.Binding("col[" + i + "]"));
                                fef.SetValue(TextBlock.HorizontalAlignmentProperty, System.Windows.HorizontalAlignment.Left);
                                dt.VisualTree = fef;
                                Col.CellTemplate = dt;
                                Col.CellTemplate.Seal();
                                i++;
                                gridView.Columns.Add(Col);
                            }

                            int columns = dataTable.Columns.Count;
                            foreach (DataRow row in dataTable.Rows)
                            {
                                LDControls.DataGridRow dataGridRow = new LDControls.DataGridRow();
                                dataGridRow.col = new string[columns];
                                for (i = 0; i < columns; i++)
                                {
                                    dataGridRow.col[i] = row.ItemArray[i].ToString();
                                }
                                shape.Items.Add(dataGridRow);
                            }

                            for (i = 0; i < columns; i++)
                            {
                                if (Double.IsNaN(((GridView)shape.View).Columns[i].Width))
                                {
                                    ((GridView)shape.View).Columns[i].Width = ((GridView)shape.View).Columns[i].ActualWidth;
                                }
                                ((GridView)shape.View).Columns[i].Width = Double.NaN;
                            }
                            shape.UpdateLayout();
                        }
                        catch (Exception ex)
                        {
                            Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        }
                    });
                    FastThread.Invoke(ret);
                }
                else
                {
                    Utilities.OnShapeError(Utilities.GetCurrentMethod(), shapeName);
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
        }

        private static string connection = "";

        [HideFromIntellisense]
        public static Primitive ConnectDataBase(Primitive server, Primitive user, Primitive password, Primitive database)
        {
            return ConnectMySQL(server, user, password, database);
        }

        [HideFromIntellisense]
        public static Primitive AddDataBase(Primitive fileName)
        {
            return ConnectSQLite(fileName);
        }

        [HideFromIntellisense]
        public static Primitive AddDataView(Primitive width, Primitive height)
        {
            return LDControls.AddDataView(width, height, "");
        }

        /// <summary>
        /// Over-ride an SQL database connection string (advanced use only).
        /// Set before connection to database, when this connection string will be used in place of the entered connection parameters.
        /// Default is "" (unused).
        /// </summary>
        public static Primitive Connection
        {
            get { return connection; }
            set { connection = value; }
        }

        /// <summary>
        /// Create or open an SQLite database.
        /// This must be called before any SQL methods.
        /// When a table is created it must have first column as "Id INTEGER PRIMARY KEY".
        /// </summary>
        /// <param name="fileName">The full path to the SQLite database file (usually with extension db).</param>
        /// <returns>A label to identify the database.</returns>
        public static Primitive ConnectSQLite(Primitive fileName)
        {
            try
            {
                ExtractDll();
                DataBase dataBase = GetDataBase(fileName, false);
                if (null == dataBase)
                {
                    dataBase = new DataBase(fileName, NextID());
                    dataBase.ConnectSQLite();
                }
                dataBases.Add(dataBase);
                return dataBase.name;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Connect to a MySQL database.
        /// This must be called before any SQL methods.
        /// The MySQL service must be running and database with credentials already created, if in doubt use SQLite.
        /// </summary>
        /// <param name="server">The MySQL server (e.g. "localhost").</param>
        /// <param name="user">The MySQL user name.</param>
        /// <param name="password">The MySQL user password.</param>
        /// <param name="database">The MySQL database name.</param>
        /// <returns>A label to identify the database.</returns>
        public static Primitive ConnectMySQL(Primitive server, Primitive user, Primitive password, Primitive database)
        {
            try
            {
                ExtractDll();
                DataBase dataBase = GetDataBase(database, false);
                if (null == dataBase)
                {
                    dataBase = new DataBase(database, NextID());
                    dataBase.ConnectMySql(server, user, password);
                }
                dataBases.Add(dataBase);
                return dataBase.name;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Connect to a SqlServer database.
        /// This must be called before any SQL methods.
        /// The SqlServer service must be running and database with credentials already created, if in doubt use SQLite.
        /// </summary>
        /// <param name="server">The SqlServer server (e.g. "(local)\SQLEXPRESS").</param>
        /// <param name="database">The SqlServer database name.</param>
        /// <returns>A label to identify the database.</returns>
        public static Primitive ConnectSqlServer(Primitive server, Primitive database)
        {
            try
            {
                ExtractDll();
                DataBase dataBase = GetDataBase(database, false);
                if (null == dataBase)
                {
                    dataBase = new DataBase(database, NextID());
                    dataBase.ConnectSqlServer(server);
                }
                dataBases.Add(dataBase);
                return dataBase.name;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Connect to an Access OleDb database.
        /// This must be called before any SQL methods.
        /// The Access OleDb service must be running and database with credentials already created, if in doubt use SQLite.
        /// </summary>
        /// <param name="provider">The OleDb provider (e.g. "SQLOLEDB").</param>
        /// <param name="server">The OleDb server (e.g. "localhost").</param>
        /// <param name="database">The OleDb database name.</param>
        /// <returns>A label to identify the database.</returns>
        public static Primitive ConnectOleDb(Primitive provider, Primitive server, Primitive database)
        {
            try
            {
                ExtractDll();
                DataBase dataBase = GetDataBase(database, false);
                if (null == dataBase)
                {
                    dataBase = new DataBase(database, NextID());
                    dataBase.ConnectOleDb(provider, server);
                }
                dataBases.Add(dataBase);
                return dataBase.name;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Connect to an Odbc driver connected database.
        /// This must be called before any SQL methods.
        /// The Odbc service must be running and database with credentials already created, if in doubt use SQLite.
        /// </summary>
        /// <param name="driver">The Odbc driver (e.g. "{MySQL ODBC 3.51 Driver}").</param>
        /// <param name="server">The Odbc server (e.g. "localhost").</param>
        /// <param name="port">The Odbc port number.</param>
        /// <param name="user">The Odbc user name.</param>
        /// <param name="password">The Odbc user password.</param>
        /// <param name="option">The Odbc option number to control the Odbc connection (e.g. 0 or 3).</param>
        /// <param name="database">The Odbc database name.</param>
        /// <returns>A label to identify the database.</returns>
        public static Primitive ConnectOdbc(Primitive driver, Primitive server, Primitive port, Primitive user, Primitive password, Primitive option, Primitive database)
        {
            try
            {
                ExtractDll();
                DataBase dataBase = GetDataBase(database, false);
                if (null == dataBase)
                {
                    dataBase = new DataBase(database, NextID());
                    dataBase.ConnectOdbc(driver, server, port, user, password, option);
                }
                dataBases.Add(dataBase);
                return dataBase.name;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return "";
        }

        /// <summary>
        /// Add a ListView to view database query results.
        /// This is a read only display of query results.
        /// </summary>
        /// <param name="width">The width of the ListView.</param>
        /// <param name="height">The height of the ListView.</param>
        /// <returns>The ListView control.</returns>
        public static Primitive AddListView(Primitive width, Primitive height)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Type ShapesType = typeof(Shapes);
            Canvas _mainCanvas;
            Dictionary<string, UIElement> _objectsMap;
            string shapeName;

            try
            {
                MethodInfo method = GraphicsWindowType.GetMethod("VerifyAccess", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
#if SVB
                method.Invoke(null, new object[] { false });
#else
                method.Invoke(null, new object[] { });
#endif

                method = ShapesType.GetMethod("GenerateNewName", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase);
#if SVB
                shapeName = method.Invoke(null, new object[] { "ListView", false }).ToString();
#else
                shapeName = method.Invoke(null, new object[] { "ListView" }).ToString();
#endif

                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                _mainCanvas = (Canvas)GraphicsWindowType.GetField("_mainCanvas", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        System.Windows.Controls.ListView shape = new System.Windows.Controls.ListView();
                        shape.SelectionChanged += new SelectionChangedEventHandler(LDControls._ListViewSelectionChangedEvent);
                        shape.PreviewMouseDown += new MouseButtonEventHandler(LDControls._ListViewMouseButtonEvent);
                        shape.Name = shapeName;
                        shape.Width = width;
                        shape.Height = height;

                        _objectsMap[shapeName] = shape;
                        _mainCanvas.Children.Add(shape);
                        return shapeName;
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "";
                    }
                });
                return FastThread.InvokeWithReturn(ret).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Perform an SQLite, MySQL, SqlServer. OleDb or Odbc command (not a query) on a database.
        /// If this database is viewed in a dataview then unsaved user changes will be lost when the dataview is updated following this operation. 
        /// </summary>
        /// <param name="database">The existing database label (see ConnectSQLite, ConnectMySQL, ConnectSqlServer, ConnectOleDb or ConnectOdbc).</param>
        /// <param name="command">The SQL Command.</param>
        /// <returns>The number of rows updated.</returns>
        public static Primitive Command(Primitive database, Primitive command)
        {
            int rowsUpdated = 0;
            try
            {
                DataBase dataBase = GetDataBase(database);
                if (null == dataBase) return rowsUpdated;
                switch (dataBase.dbType)
                {
                    case DataBase.DBType.SQLite:
                        {
                            dataBase.commandSQLite.CommandText = command;
                            rowsUpdated = dataBase.commandSQLite.ExecuteNonQuery();
                        }
                        break;
                    case DataBase.DBType.MySql:
                        {
                            dataBase.commandMySql.CommandText = command;
                            rowsUpdated = dataBase.commandMySql.ExecuteNonQuery();
                        }
                        break;
                    case DataBase.DBType.SqlServer:
                        {
                            dataBase.commandSqlServer.CommandText = command;
                            rowsUpdated = dataBase.commandSqlServer.ExecuteNonQuery();
                        }
                        break;
                    case DataBase.DBType.OleDb:
                        {
                            dataBase.commandOleDb.CommandText = command;
                            rowsUpdated = dataBase.commandOleDb.ExecuteNonQuery();
                        }
                        break;
                    case DataBase.DBType.Odbc:
                        {
                            dataBase.commandOdbc.CommandText = command;
                            rowsUpdated = dataBase.commandOdbc.ExecuteNonQuery();
                        }
                        break;
                }

                Type GraphicsWindowType = typeof(GraphicsWindow);
                Dictionary<string, UIElement> _objectsMap;
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                foreach (KeyValuePair<string, UIElement> kvp in _objectsMap)
                {
                    if (kvp.Value.GetType() == typeof(WindowsFormsHost))
                    {
                        WindowsFormsHost host = (WindowsFormsHost)kvp.Value;
                        if (null != host.Child && host.Child.GetType() == typeof(DataGridView))
                        {
                            DataGridView dataView = (DataGridView)host.Child;
                            if (null != dataView.Tag && dataView.Tag.GetType() == typeof(DataTable))
                            {
                                DataTable dataTable = (DataTable)dataView.Tag;
                                if (null != dataTable)
                                {
                                    string tableName = dataTable.TableName;
                                    string query = "SELECT * FROM " + tableName;
                                    GetDataTable(dataBase, query, dataTable);
                                    dataView.Refresh();

                                    //EditTable(database, dataTable.TableName, dataView.Name);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }

            return rowsUpdated;
        }

        /// <summary>
        /// Perform an SQLite, MySQL, SqlServer, OleDb or Odbc Query (not a command) on a database.
        /// </summary>
        /// <param name="database">The existing database label (see ConnectSQLite, ConnectMySQL, ConnectSqlServer, ConnectOleDb or ConnectOdbc).</param>
        /// <param name="query">The SQL Query.
        /// Example "SELECT * FROM myTable;".</param>
        /// <param name="listview">A ListView to populate with the query result or "" for none.</param>
        /// <param name="getRecords">Optionally return an array of results ("True" or "False").
        /// Remember large multi-dimensional arrays in Small Basic are slow.</param>
        /// <returns>Optional array of results or "".</returns>
        public static Primitive Query(Primitive database, Primitive query, Primitive listview, Primitive getRecords)
        {
            Primitive results = "";
            try
            {
                DataBase dataBase = GetDataBase(database);
                if (null == dataBase) return "";
                DataTable dataTable = GetDataTable(dataBase, query, null);
                if (listview != "") Data2Grid(listview, dataTable);
                if (getRecords)
                {
                    int columns = dataTable.Columns.Count;
                    int iRow = 1;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string result = "";
                        for (int i = 0; i < columns; i++)
                        {
                            result += Utilities.ArrayParse(dataTable.Columns[i].Caption) + "=" + Utilities.ArrayParse(row.ItemArray[i].ToString()) + ";";
                        }
                        results[iRow++] = Utilities.CreateArrayMap(result);
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            return results;
        }

        /// <summary>
        /// Display a database table for editing in a LDControls.DataView control.
        /// Using this method the database is bound to the dataview conrol, reflecting the database.
        /// </summary>
        /// <param name="database">The existing database label (see ConnectSQLite, ConnectMySQL, ConnectSqlServer, ConnectOleDb or ConnectOdbc).</param>
        /// <param name="table">The table name to view and edit.</param>
        /// <param name="dataview">A DataView control.</param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive EditTable(Primitive database, Primitive table, Primitive dataview)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)dataview, out obj)) return "FAILED";

                WindowsFormsHost host = (WindowsFormsHost)obj;
                DataGridView dataView = (DataGridView)host.Child;

                string query = "SELECT * FROM " + table;
                DataBase dataBase = GetDataBase(database);
                if (null == dataBase) return "FAILED";
                DataTable dataTable = new DataTable();
                dataTable.TableName = table;
                dataTable = GetDataTable(dataBase, query, dataTable);

                BindingSource SBind = new BindingSource();
                SBind.DataSource = dataTable;

                InvokeHelperWithReturn ret = new InvokeHelperWithReturn(delegate
                {
                    try
                    {
                        dataView.Columns.Clear();
                        dataView.Tag = dataTable;
                        dataView.DataSource = SBind;
                        dataView.Refresh();

                        return "SUCCESS";
                    }
                    catch (Exception ex)
                    {
                        Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                        return "FAILED";
                    }
                });
                return FastThread.InvokeWithReturn(ret).ToString();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Commit any changes made in a LDControls.DataView to the database.
        /// </summary>
        /// <param name="database">The existing database label (see ConnectSQLite, ConnectMySQL, ConnectSqlServer, ConnectOleDb or ConnectOdbc).</param>
        /// <param name="dataview">A DataView control.</param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive SaveTable(Primitive database, Primitive dataview)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                DataBase dataBase = GetDataBase(database);
                if (null == dataBase) return "FAILED";

                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)dataview, out obj)) return "FAILED";

                WindowsFormsHost host = (WindowsFormsHost)obj;
                DataGridView dataView = (DataGridView)host.Child;

                dataView.EndEdit();
                ((BindingSource)dataView.DataSource).EndEdit();
                UpdateDataTable(dataBase, dataView);

                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }

        /// <summary>
        /// Commit any changes made in a LDControls.DataView to the database.
        /// This is an alternative to SaveTable, where the data binding fails for some reason.
        /// This method may be slower than SaveTable, since it recreates the table line by line using SQL.
        /// </summary>
        /// <param name="database">The existing database label (see ConnectSQLite, ConnectMySQL, ConnectSqlServer, ConnectOleDb or ConnectOdbc).</param>
        /// <param name="dataview">A DataView control.</param>
        /// <returns>"SUCCESS" or "FAILED".</returns>
        public static Primitive SaveTableBySQL(Primitive database, Primitive dataview)
        {
            Type GraphicsWindowType = typeof(GraphicsWindow);
            Dictionary<string, UIElement> _objectsMap;
            UIElement obj;

            try
            {
                DataBase dataBase = GetDataBase(database);
                if (null == dataBase) return "FAILED";

                _objectsMap = (Dictionary<string, UIElement>)GraphicsWindowType.GetField("_objectsMap", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_objectsMap.TryGetValue((string)dataview, out obj)) return "FAILED";

                WindowsFormsHost host = (WindowsFormsHost)obj;
                DataGridView dataView = (DataGridView)host.Child;

                dataView.EndEdit();
                ((BindingSource)dataView.DataSource).EndEdit();
                UpdateDataTableBySQL(dataBase, dataView);

                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }
    }
}
