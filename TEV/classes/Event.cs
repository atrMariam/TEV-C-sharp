﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEV.classes
{
    public class Event
    {
        public int Id { get; set; }
        public string category { get; set; }
        public string code { get; set; }
        public string reference {get; set;}
        public string source {get; set;}
        public DateTime occurrence_date {get; set;}
        public DateTime notification_date {get; set;}
        public string eventType {get; set;}
        public string location {get; set;}
        public string involved_traffic {get; set;}
        public string description {get; set;}
        public string event_cause {get; set;}
        public string frequency {get; set;}
        public string severity {get; set;}
        public string security_recommendation {get; set;}
        public string event_status {get; set;}
        public string color {get; set;}
        public string flight_phase {get; set;}
        public string altitude {get; set;}
        public DateTime report_elaboration_date {get; set;}
        public DateTime report_reception_date {get; set;}
        public DateTime last_elm_reception_date {get; set;}
        public DateTime recommendations_release_date {get; set;}
        public DateTime evidence_reception_date {get; set;}

        static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        static string databasePath = Path.Combine(desktopPath, "TEV/database.db");
        static string connectionString = $"Data Source=\"{databasePath}\";Version=3;";

        public DataTable select()
        {
            SQLiteConnection con = new SQLiteConnection(connectionString);
            DataTable dt = new DataTable();
            try
            {
                string sql = @"SELECT e.code, e.reference, e.source, e.notification_date, e.location, e.involved_traffic, e.description,
                    t.name AS type, 
                    c.name AS categorie
                    FROM events e
                    JOIN categories c ON e.category_id = c.id
                    JOIN event_types t ON e.event_type_id = t.id";

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
        public List<string> selectEventTypes(String selectedEventCategory)
        {
            List<string> list = new List<string>();
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    string sql = "SELECT name FROM event_types WHERE category_id = (SELECT id FROM categories WHERE name=@name)";
                    SQLiteCommand cmd = new SQLiteCommand(sql, con);
                    cmd.Parameters.AddWithValue("@name", selectedEventCategory);
                    con.Open();
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(reader.GetString(reader.GetOrdinal("name")));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading event types: " + ex.Message);
            }
            return list;
        }
        public List<string> selectEventCauses()
        {
            List<string> list = new List<string>();
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    string sql = "SELECT text FROM event_causes";
                    SQLiteCommand cmd = new SQLiteCommand(sql, con);
                    con.Open();
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(reader.GetString(reader.GetOrdinal("text")));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading event causes: " + ex.Message);
            }
            return list;
        }
        public List<string> selectEventStatus()
        {
            List<string> list = new List<string>();
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    string sql = "SELECT name FROM event_statuses";
                    SQLiteCommand cmd = new SQLiteCommand(sql, con);
                    con.Open();
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(reader.GetString(reader.GetOrdinal("name")));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading event status: " + ex.Message);
            }
            return list;
        }

        public EventFormVisibility getEventCategoriesAndVisibility(string category)
        {
            EventFormVisibility eventFormVisibility = new EventFormVisibility();
            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                string sql = "SELECT * FROM categories WHERE name=@category";
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.Parameters.AddWithValue("@category", category);
                con.Open();
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        eventFormVisibility.show_code = reader.GetBoolean(reader.GetOrdinal("show_code"));
                        eventFormVisibility.show_reference = reader.GetBoolean(reader.GetOrdinal("show_reference"));
                        eventFormVisibility.show_source = reader.GetBoolean(reader.GetOrdinal("show_source"));
                        eventFormVisibility.show_occurrence_date = reader.GetBoolean(reader.GetOrdinal("show_occurrence_date"));
                        eventFormVisibility.show_notification_date = reader.GetBoolean(reader.GetOrdinal("show_notification_date"));
                        eventFormVisibility.show_eventType = reader.GetBoolean(reader.GetOrdinal("show_eventType"));
                        eventFormVisibility.show_location = reader.GetBoolean(reader.GetOrdinal("show_location"));
                        eventFormVisibility.show_involved_traffic = reader.GetBoolean(reader.GetOrdinal("show_involved_traffic"));
                        eventFormVisibility.show_description = reader.GetBoolean(reader.GetOrdinal("show_description"));
                        eventFormVisibility.show_event_cause = reader.GetBoolean(reader.GetOrdinal("show_event_cause"));
                        eventFormVisibility.show_frequency = reader.GetBoolean(reader.GetOrdinal("show_frequency"));
                        eventFormVisibility.show_severity = reader.GetBoolean(reader.GetOrdinal("show_severity"));
                        //eventFormVisibility.show_classe = reader.GetBoolean(reader.GetOrdinal(""));
                        eventFormVisibility.show_security_recommendation = reader.GetBoolean(reader.GetOrdinal("show_security_recommendation"));
                        eventFormVisibility.show_event_status = reader.GetBoolean(reader.GetOrdinal("show_event_status"));
                        eventFormVisibility.show_color = reader.GetBoolean(reader.GetOrdinal("show_color"));
                        eventFormVisibility.show_flight_phase = reader.GetBoolean(reader.GetOrdinal("show_flight_phase"));
                        eventFormVisibility.show_altitude = reader.GetBoolean(reader.GetOrdinal("show_altitude"));
                        eventFormVisibility.show_report_elaboration_date = reader.GetBoolean(reader.GetOrdinal("show_report_elaboration_date"));
                        eventFormVisibility.show_report_reception_date = reader.GetBoolean(reader.GetOrdinal("show_report_reception_date"));
                        eventFormVisibility.show_last_elm_reception_date = reader.GetBoolean(reader.GetOrdinal("show_last_elm_reception_date"));
                        eventFormVisibility.show_recommendations_release_date = reader.GetBoolean(reader.GetOrdinal("show_recommendations_release_date"));
                        eventFormVisibility.show_evidence_reception_date = reader.GetBoolean(reader.GetOrdinal("show_evidence_reception_date"));
                    }
                }
            }
            return eventFormVisibility;
        }

        public Boolean InsertEvent(Event e){

            //creating a default return type and etting its value to false
            bool isSuccess = false;
            SQLiteConnection con = new SQLiteConnection(connectionString);
            try
            {
                string sql = @"INSERT INTO events (
                    category_id,
                    code,
                    reference,
                    source,
                    occurrence_date,
                    notification_date,
                    event_type_id,
                    location,
                    involved_traffic,
                    description,
                    event_cause_id,
                    frequency,
                    severity,
                    classe,
                    security_recommendation,
                    event_status_id,
                    color,
                    flight_phase,
                    altitude,
                    report_elaboration_date,
                    report_reception_date,
                    last_elm_reception_date,
                    recommendations_release_date,
                    evidence_reception_date
                ) VALUES (
                    (SELECT id FROM categories WHERE name=@categoryname), -- category_id
                    @code, -- Example code
                    @reference, -- Example reference
                    @source, -- Example source
                    @occurrence_date, -- Example occurrence_date
                    @notification_date, -- Example notification_date
                    (SELECT id FROM event_types WHERE name=@type), -- Example event_type_id
                    @location, -- Example location
                    @traffic, -- Example involved_traffic
                    @description, -- Example description
                    (SELECT id FROM event_causes WHERE text=@cause), -- Example event_cause_id
                    @frequency, -- Example frequency
                    @severity, -- Example severity
                    @classe, -- Example classe
                    @security_recommendation, -- Example security_recommendation
                    (SELECT id FROM event_statuses WHERE name=@status), -- Example event_status_id
                    @color, -- Example color
                    @flight_phase, -- Example flight_phase
                    @altitude, -- Example altitude
                    @report_elaboration_date, -- Example report_elaboration_date
                    @report_reception_date, -- Example report_reception_date
                    @last_elm_reception_date, -- Example last_elm_reception_date
                    @recommendations_release_date, -- Example recommendations_release_date
                    @evidence_reception_date -- Example evidence_reception_date
                )";
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.Parameters.AddWithValue("@categoryname", e.category);
                cmd.Parameters.AddWithValue("@code", e.code);
                cmd.Parameters.AddWithValue("@reference", e.reference);
                cmd.Parameters.AddWithValue("@source", e.source);
                cmd.Parameters.AddWithValue("@occurrence_date", e.occurrence_date);
                cmd.Parameters.AddWithValue("@notification_date", e.notification_date);
                cmd.Parameters.AddWithValue("@type", e.eventType);
                cmd.Parameters.AddWithValue("@location", e.location);
                cmd.Parameters.AddWithValue("@traffic", e.involved_traffic);
                cmd.Parameters.AddWithValue("@description", e.description);
                cmd.Parameters.AddWithValue("@cause", e.event_cause);
                cmd.Parameters.AddWithValue("@frequency", e.frequency);
                cmd.Parameters.AddWithValue("@severity", e.severity);
                cmd.Parameters.AddWithValue("@classe", $"{e.severity} {e.frequency}");
                cmd.Parameters.AddWithValue("@security_recommendation", e.security_recommendation);
                cmd.Parameters.AddWithValue("@color", e.color);
                cmd.Parameters.AddWithValue("@flight_phase", e.flight_phase);
                cmd.Parameters.AddWithValue("@altitude", e.altitude);
                cmd.Parameters.AddWithValue("@report_elaboration_date", e.report_elaboration_date);
                cmd.Parameters.AddWithValue("@report_reception_date", e.report_reception_date);
                cmd.Parameters.AddWithValue("@last_elm_reception_date", e.last_elm_reception_date);
                cmd.Parameters.AddWithValue("@recommendations_release_date", e.recommendations_release_date);
                cmd.Parameters.AddWithValue("@evidence_reception_date", e.evidence_reception_date);
                cmd.Parameters.AddWithValue("@status", e.event_status);

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