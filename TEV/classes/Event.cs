using System;
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
        public long Id { get; set; }
        public string Category { get; set; }
        public string Code { get; set; }
        public string Reference {get; set;}
        public string Source {get; set;}
        public DateTime Occurrence_date {get; set;}
        public DateTime Notification_date {get; set;}
        public string Event_type {get; set;}
        public string Location {get; set;}
        public string Involved_traffic {get; set;}
        public string Description {get; set;}
        public string Event_cause {get; set;}
        public string Frequency {get; set;}
        public string Severity {get; set;}
        public string Security_recommendation {get; set;}
        public string Classe { get; set; }
        public string Event_status {get; set;}
        public string Color {get; set;}
        public string Flight_phase {get; set;}
        public string Altitude {get; set;}
        public DateTime Report_elaboration_date {get; set;}
        public DateTime Report_reception_date {get; set;}
        public DateTime Last_elm_reception_date {get; set;}
        public DateTime Recommendations_release_date {get; set;}
        public DateTime Evidence_reception_date {get; set;}
        
        static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        static string databasePath = Path.Combine(desktopPath, "TEV/database.db");
        static string connectionString = $"Data Source=\"{databasePath}\";Version=3;";

        public DataTable select()
        {
            SQLiteConnection con = new SQLiteConnection(connectionString);
            DataTable dt = new DataTable();
            try
            {
                string sql = @"SELECT e.Id as Id, e.Code, e.Reference, e.Source, e.Notification_date, e.Location, e.Involved_traffic, e.Description,
                    t.name AS Type, 
                    c.name AS Categorie
                    FROM events e
                    LEFT JOIN categories c ON e.Category_id = c.id
                    LEFT JOIN event_types t ON e.Event_type_id = t.id";

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
        public Event GetEventById(long eventId)
        {
            Event eventObj = new Event();
            Helper helper = new Helper();

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                string sql = @"SELECT 
                    e.Id,Code,c.name AS Category,Reference,Source,Occurrence_date,Notification_date,t.name as Event_type,e.Location,Involved_traffic,Description,ca.text AS Event_cause,Frequency,Severity,Security_recommendation,Classe,s.name AS Event_status,e.color as Color,Flight_phase,Altitude,Report_elaboration_date,Report_reception_date,Last_elm_reception_date,Recommendations_release_date,Evidence_reception_date
                    FROM events e
                    LEFT JOIN categories c ON e.Category_id = c.id
                    LEFT JOIN event_types t ON e.Event_type_id = t.id
                    LEFT JOIN event_causes ca ON e.Event_cause_id = ca.id
                    LEFT JOIN event_statuses s ON e.Event_status_id = s.id
                    WHERE e.Id = @eventId";
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.Parameters.AddWithValue("@eventId", eventId);
                con.Open();

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        helper.FillObjectFromReader(reader, eventObj);
                    }
                }
            }

            return eventObj;
        }
        
        public List<string> selectCategoryByEventId(String eventId)
        {
            List<string> categories = new List<string>();
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    string sql = "SELECT c.name AS category FROM events e LEFT JOIN categories c ON e.Category_id = c.id WHERE e.Id=@eventId";
                    SQLiteCommand cmd = new SQLiteCommand(sql, con);
                    cmd.Parameters.AddWithValue("@eventId", eventId);
                    con.Open();
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categories.Add(reader.GetString(reader.GetOrdinal("category")));
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
        public Category getEventCategoryAndVisibility(string category)
        {
            Category eventFormVisibility = new Category();
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

        public bool InsertEvent(Event e){

            //creating a default return type and etting its value to false
            bool isSuccess = false;
            SQLiteConnection con = new SQLiteConnection(connectionString);
            try
            {
                string sql = @"INSERT INTO events (
                    Category_id,
                    Code,
                    Reference,
                    Source,
                    Occurrence_date,
                    Notification_date,
                    Event_type_id,
                    Location,
                    Involved_traffic,
                    Description,
                    Event_cause_id,
                    Frequency,
                    Severity,
                    Classe,
                    Security_recommendation,
                    Event_status_id,
                    Color,
                    Flight_phase,
                    Altitude,
                    Report_elaboration_date,
                    Report_reception_date,
                    Last_elm_reception_date,
                    Recommendations_release_date,
                    Evidence_reception_date
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
                cmd.Parameters.AddWithValue("@categoryname", e.Category);
                cmd.Parameters.AddWithValue("@code", e.Code);
                cmd.Parameters.AddWithValue("@reference", e.Reference);
                cmd.Parameters.AddWithValue("@source", e.Source);
                cmd.Parameters.AddWithValue("@occurrence_date", e.Occurrence_date);
                cmd.Parameters.AddWithValue("@notification_date", e.Notification_date);
                cmd.Parameters.AddWithValue("@type", e.Event_type);
                cmd.Parameters.AddWithValue("@location", e.Location);
                cmd.Parameters.AddWithValue("@traffic", e.Involved_traffic);
                cmd.Parameters.AddWithValue("@description", e.Description);
                cmd.Parameters.AddWithValue("@cause", e.Event_cause);
                cmd.Parameters.AddWithValue("@frequency", e.Frequency);
                cmd.Parameters.AddWithValue("@severity", e.Severity);
                cmd.Parameters.AddWithValue("@classe", $"{e.Severity} {e.Frequency}");
                cmd.Parameters.AddWithValue("@security_recommendation", e.Security_recommendation);
                cmd.Parameters.AddWithValue("@color", e.Color);
                cmd.Parameters.AddWithValue("@flight_phase", e.Flight_phase);
                cmd.Parameters.AddWithValue("@altitude", e.Altitude);
                cmd.Parameters.AddWithValue("@report_elaboration_date", e.Report_elaboration_date);
                cmd.Parameters.AddWithValue("@report_reception_date", e.Report_reception_date);
                cmd.Parameters.AddWithValue("@last_elm_reception_date", e.Last_elm_reception_date);
                cmd.Parameters.AddWithValue("@recommendations_release_date", e.Recommendations_release_date);
                cmd.Parameters.AddWithValue("@evidence_reception_date", e.Evidence_reception_date);
                cmd.Parameters.AddWithValue("@status", e.Event_status);

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
        public bool UpdateEvent(Event e)
        {
            //creating a default return type and etting its value to false
            bool isSuccess = false;
            SQLiteConnection con = new SQLiteConnection(connectionString);
            try
            {
                string sql = @"UPDATE events SET
                    Category_id=(SELECT id FROM categories WHERE name=@categoryname), -- category_id,
                    Code=@code,
                    Reference=@reference,
                    Source=@source,
                    Occurrence_date=@occurrence_date,
                    Notification_date=@notification_date,
                    Event_type_id=(SELECT id FROM event_types WHERE name=@type),
                    Location=@location,
                    Involved_traffic=@traffic,
                    Description=@description,
                    Event_cause_id=(SELECT id FROM event_causes WHERE text=@cause),
                    Frequency=@frequency,
                    Severity=@severity,
                    Classe=@classe,
                    Security_recommendation=@security_recommendation,
                    Event_status_id=(SELECT id FROM event_statuses WHERE name=@status),
                    Color=@color,
                    Flight_phase=@flight_phase,
                    Altitude=@altitude,
                    Report_elaboration_date=@report_elaboration_date,
                    Report_reception_date=@report_reception_date,
                    Last_elm_reception_date=@last_elm_reception_date,
                    Recommendations_release_date=@recommendations_release_date,
                    Evidence_reception_date=@evidence_reception_date,
                    Updated_at=CURRENT_TIMESTAMP
                    WHERE id=@eventId";
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.Parameters.AddWithValue("@eventId", e.Id);
                cmd.Parameters.AddWithValue("@categoryname", e.Category);
                cmd.Parameters.AddWithValue("@code", e.Code);
                cmd.Parameters.AddWithValue("@reference", e.Reference);
                cmd.Parameters.AddWithValue("@source", e.Source);
                cmd.Parameters.AddWithValue("@occurrence_date", e.Occurrence_date);
                cmd.Parameters.AddWithValue("@notification_date", e.Notification_date);
                cmd.Parameters.AddWithValue("@type", e.Event_type);
                cmd.Parameters.AddWithValue("@location", e.Location);
                cmd.Parameters.AddWithValue("@traffic", e.Involved_traffic);
                cmd.Parameters.AddWithValue("@description", e.Description);
                cmd.Parameters.AddWithValue("@cause", e.Event_cause);
                cmd.Parameters.AddWithValue("@frequency", e.Frequency);
                cmd.Parameters.AddWithValue("@severity", e.Severity);
                cmd.Parameters.AddWithValue("@classe", $"{e.Severity} {e.Frequency}");
                cmd.Parameters.AddWithValue("@security_recommendation", e.Security_recommendation);
                cmd.Parameters.AddWithValue("@color", e.Color);
                cmd.Parameters.AddWithValue("@flight_phase", e.Flight_phase);
                cmd.Parameters.AddWithValue("@altitude", e.Altitude);
                cmd.Parameters.AddWithValue("@report_elaboration_date", e.Report_elaboration_date);
                cmd.Parameters.AddWithValue("@report_reception_date", e.Report_reception_date);
                cmd.Parameters.AddWithValue("@last_elm_reception_date", e.Last_elm_reception_date);
                cmd.Parameters.AddWithValue("@recommendations_release_date", e.Recommendations_release_date);
                cmd.Parameters.AddWithValue("@evidence_reception_date", e.Evidence_reception_date);
                cmd.Parameters.AddWithValue("@status", e.Event_status);

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
        public bool DeleteEvent(Event e)
        {
            //creating a default return type and etting its value to false
            bool isSuccess = false;
            SQLiteConnection con = new SQLiteConnection(connectionString);
            try
            {
                string sql = "DELETE FROM events WHERE Id=@id";
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", e.Id);
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
