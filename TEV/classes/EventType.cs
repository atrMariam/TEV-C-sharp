using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEV.classes
{
    public class EventType
    {
        public long Id {  get; set; }
        public string Name { get; set; }

        public long Category_id { get; set; }

        static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        static string databasePath = Path.Combine(desktopPath, "TEV/database.db");
        static string connectionString = $"Data Source=\"{databasePath}\";Version=3;";

        public DataTable Select()
        {
            SQLiteConnection con = new SQLiteConnection(connectionString);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM event_types";
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public bool Insert(EventType t)
        {
            //creating a default return type and etting its value to false
            bool isSuccess = false;
            SQLiteConnection con = new SQLiteConnection(connectionString);
            try
            {
                string sql = @"INSERT INTO event_types (name,category_id) VALUES (@name,@category_id)";
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", t.Name);
                cmd.Parameters.AddWithValue("@category_id", t.Category_id);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                isSuccess = rows > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }

        public bool Update(EventType t)
        {
            //creating a default return type and etting its value to false
            bool isSuccess = false;
            SQLiteConnection con = new SQLiteConnection(connectionString);
            try
            {
                string sql = @"UPDATE event_types SET name=@name, category_id=@category_id
                WHERE id=@id";
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", t.Id);
                cmd.Parameters.AddWithValue("@name", t.Name);
                cmd.Parameters.AddWithValue("@category_id", t.Category_id);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                isSuccess = rows > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }

        public bool Delete(EventType t)
        {
            //creating a default return type and etting its value to false
            bool isSuccess = false;
            SQLiteConnection con = new SQLiteConnection(connectionString);
            try
            {
                string sql = "DELETE FROM event_types WHERE id=@id";
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", t.Id);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                isSuccess = rows > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }
    }
}
