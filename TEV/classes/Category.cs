using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TEV.classes
{
    public class Category
    {
        public int id;
        public string name { get; set; }
        public bool show_code { get; set; }
        public bool show_reference {get; set; }
        public bool show_source {get; set; }
        public bool show_occurrence_date {get; set; }
        public bool show_notification_date {get; set; }
        public bool show_eventType {get; set; }
        public bool show_location {get; set; }
        public bool show_involved_traffic {get; set; }
        public bool show_description {get; set; }
        public bool show_event_cause {get; set; }
        public bool show_frequency {get; set; }
        public bool show_severity {get; set; }
        public bool show_classe {get; set; }
        public bool show_security_recommendation {get; set; }
        public bool show_event_status {get; set; }
        public bool show_color {get; set; }
        public bool show_flight_phase {get; set; }
        public bool show_altitude {get; set; }
        public bool show_report_elaboration_date {get; set; }
        public bool show_report_reception_date {get; set; }
        public bool show_last_elm_reception_date {get; set; }
        public bool show_recommendations_release_date {get; set; }
        public bool show_evidence_reception_date { get; set; }

        static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        static string databasePath = Path.Combine(desktopPath, "TEV/database.db");
        static string connectionString = $"Data Source=\"{databasePath}\";Version=3;";

        public DataTable Select()
        {
            SQLiteConnection con = new SQLiteConnection(connectionString);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM categories";
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

        public Category getCategoryByName(string name)
        {
            Category category = new ();
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    string sql = "SELECT id,name FROM categories WHERE name=@name";
                    SQLiteCommand cmd = new SQLiteCommand(sql, con);
                    cmd.Parameters.AddWithValue("@name", name);

                    con.Open();
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            category.id = reader.GetInt32(reader.GetOrdinal("id"));
                            category.name = reader.GetString(reader.GetOrdinal("name"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading category: " + ex.Message);
            }
            return category;
        }

        public List<string> selectCategories()
        {
            List<string> categories = new List<string>();
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    string sql = "SELECT name FROM categories";
                    SQLiteCommand cmd = new SQLiteCommand(sql, con);
                    con.Open();
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categories.Add(reader.GetString(reader.GetOrdinal("name")));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
            return categories;
        }

        public bool Insert(Category c)
        {
            //creating a default return type and etting its value to false
            bool isSuccess = false;
            SQLiteConnection con = new SQLiteConnection(connectionString);
            try
            {
                string sql = @"INSERT INTO categories (name, show_code, show_reference, show_source, show_occurrence_date, show_notification_date, show_eventType, show_location, 
                show_involved_traffic, show_description, show_event_cause, show_frequency, show_severity, show_classe, show_security_recommendation, show_event_status, show_color, 
                show_flight_phase, show_altitude, show_report_elaboration_date, show_report_reception_date, show_last_elm_reception_date, show_recommendations_release_date, 
                show_evidence_reception_date) VALUES (@name, @show_code, @show_reference, @show_source, @show_occurrence_date, @show_notification_date, @show_eventType, @show_location, 
                @show_involved_traffic, @show_description, @show_event_cause, @show_frequency, @show_severity, @show_classe, @show_security_recommendation, @show_event_status, @show_color, 
                @show_flight_phase, @show_altitude, @show_report_elaboration_date, @show_report_reception_date, @show_last_elm_reception_date, @show_recommendations_release_date, 
                @show_evidence_reception_date)";
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", c.name);
                cmd.Parameters.AddWithValue("@show_code", c.show_code);
                cmd.Parameters.AddWithValue("@show_reference", c.show_reference);
                cmd.Parameters.AddWithValue("@show_source", c.show_source);
                cmd.Parameters.AddWithValue("@show_occurrence_date", c.show_occurrence_date);
                cmd.Parameters.AddWithValue("@show_notification_date", c.show_notification_date);
                cmd.Parameters.AddWithValue("@show_eventType", c.show_eventType);
                cmd.Parameters.AddWithValue("@show_location", c.show_location);
                cmd.Parameters.AddWithValue("@show_involved_traffic", c.show_involved_traffic);
                cmd.Parameters.AddWithValue("@show_description", c.show_description);
                cmd.Parameters.AddWithValue("@show_event_cause", c.show_event_cause);
                cmd.Parameters.AddWithValue("@show_frequency", c.show_frequency);
                cmd.Parameters.AddWithValue("@show_severity", c.show_severity);
                cmd.Parameters.AddWithValue("@show_classe", c.show_classe);
                cmd.Parameters.AddWithValue("@show_security_recommendation", c.show_security_recommendation);
                cmd.Parameters.AddWithValue("@show_event_status", c.show_event_status);
                cmd.Parameters.AddWithValue("@show_color", c.show_color);
                cmd.Parameters.AddWithValue("@show_flight_phase", c.show_flight_phase);
                cmd.Parameters.AddWithValue("@show_altitude", c.show_altitude);
                cmd.Parameters.AddWithValue("@show_report_elaboration_date", c.show_report_elaboration_date);
                cmd.Parameters.AddWithValue("@show_report_reception_date", c.show_report_reception_date);
                cmd.Parameters.AddWithValue("@show_last_elm_reception_date", c.show_last_elm_reception_date);
                cmd.Parameters.AddWithValue("@show_recommendations_release_date", c.show_recommendations_release_date);
                cmd.Parameters.AddWithValue("@show_evidence_reception_date", c.show_evidence_reception_date);
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

        public bool Update(Category c)
        {
            //creating a default return type and etting its value to false
            bool isSuccess = false;
            SQLiteConnection con = new SQLiteConnection(connectionString);
            try
            {
                string sql = @"UPDATE categories SET name=@name, show_code=@show_code, show_reference=@show_reference, show_source=@show_source, show_occurrence_date=@show_occurrence_date, 
                show_notification_date=@show_notification_date, show_eventType=@show_eventType, show_location=@show_location, show_involved_traffic=@show_involved_traffic, 
                show_description=@show_description, show_event_cause=@show_event_cause, show_frequency=@show_frequency, show_severity=@show_severity, show_classe=@show_classe, 
                show_security_recommendation=@show_security_recommendation, show_event_status=@show_event_status, show_color=@show_color, show_flight_phase=@show_flight_phase, 
                show_altitude=@show_altitude, show_report_elaboration_date=@show_report_elaboration_date, show_report_reception_date=@show_report_reception_date, 
                show_last_elm_reception_date=@show_last_elm_reception_date, show_recommendations_release_date=@show_recommendations_release_date, show_evidence_reception_date=@show_evidence_reception_date
                WHERE id=@id";
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", c.id);
                cmd.Parameters.AddWithValue("@name", c.name);
                cmd.Parameters.AddWithValue("@show_code", c.show_code);
                cmd.Parameters.AddWithValue("@show_reference", c.show_reference);
                cmd.Parameters.AddWithValue("@show_source", c.show_source);
                cmd.Parameters.AddWithValue("@show_occurrence_date", c.show_occurrence_date);
                cmd.Parameters.AddWithValue("@show_notification_date", c.show_notification_date);
                cmd.Parameters.AddWithValue("@show_eventType", c.show_eventType);
                cmd.Parameters.AddWithValue("@show_location", c.show_location);
                cmd.Parameters.AddWithValue("@show_involved_traffic", c.show_involved_traffic);
                cmd.Parameters.AddWithValue("@show_description", c.show_description);
                cmd.Parameters.AddWithValue("@show_event_cause", c.show_event_cause);
                cmd.Parameters.AddWithValue("@show_frequency", c.show_frequency);
                cmd.Parameters.AddWithValue("@show_severity", c.show_severity);
                cmd.Parameters.AddWithValue("@show_classe", c.show_classe);
                cmd.Parameters.AddWithValue("@show_security_recommendation", c.show_security_recommendation);
                cmd.Parameters.AddWithValue("@show_event_status", c.show_event_status);
                cmd.Parameters.AddWithValue("@show_color", c.show_color);
                cmd.Parameters.AddWithValue("@show_flight_phase", c.show_flight_phase);
                cmd.Parameters.AddWithValue("@show_altitude", c.show_altitude);
                cmd.Parameters.AddWithValue("@show_report_elaboration_date", c.show_report_elaboration_date);
                cmd.Parameters.AddWithValue("@show_report_reception_date", c.show_report_reception_date);
                cmd.Parameters.AddWithValue("@show_last_elm_reception_date", c.show_last_elm_reception_date);
                cmd.Parameters.AddWithValue("@show_recommendations_release_date", c.show_recommendations_release_date);
                cmd.Parameters.AddWithValue("@show_evidence_reception_date", c.show_evidence_reception_date);
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

        public bool Delete(Category c)
        {
            //creating a default return type and etting its value to false
            bool isSuccess = false;
            SQLiteConnection con = new SQLiteConnection(connectionString);
            try
            {
                string sql = "DELETE FROM categories WHERE id=@id";
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", c.id);
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