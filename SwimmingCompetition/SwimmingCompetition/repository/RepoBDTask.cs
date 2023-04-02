using SwimmingCompetition.domain;
using log4net;
using System.Data.SQLite;

namespace SwimmingCompetition.repository;

public class RepoBDTask:RepoTask
{
    String connectionString;
    private static ILog log;
    
    
    public RepoBDTask(string connectionString)
    {
        this.connectionString = connectionString;
        log = LogManager.GetLogger("RepoBDTask");
    }

    
    private Utility.enumDistance convertDistanceToEnum(int distance)
    {
        return distance switch
        {
            50 => Utility.enumDistance.A,
            200 => Utility.enumDistance.B,
            800 => Utility.enumDistance.C,
            _ => Utility.enumDistance.D
        };
    }

    private int convertEnumToDistance(Utility.enumDistance distance)
    {
        return distance switch
        {
            Utility.enumDistance.A => 50,
            Utility.enumDistance.B => 200,
            Utility.enumDistance.C => 800,
            _ => 1500
        };
    }

    private Utility.enumStyle convertStyleToEnum(string style)
    {
        return style switch
        {
            "MIXT" => Utility.enumStyle.MIXT,
            "BUTTERFLY" => Utility.enumStyle.BUTTERFLY,
            "BACKSTROKE" => Utility.enumStyle.BACKSTROKE,
            _ => Utility.enumStyle.FREESTYLE
        };
    }

    private string convertEnmuToStyle(Utility.enumStyle style)
    {
        return style switch
        {
            Utility.enumStyle.FREESTYLE => "FREESTYLE",
            Utility.enumStyle.MIXT => "MIXT",
            Utility.enumStyle.BACKSTROKE => "BACKSTROKE",
            _ => "BUTTERFLY"
        };
    }


    public int ifExistTask(MyTask t)
    {
        log.Info("Intru in IfExistTask - clasa RepoBDTask!");
        int id = -1;
        try
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                SQLiteCommand selectCommand = new SQLiteCommand("SELECT * FROM tasks WHERE style=@style AND distance=@distance;", conn);
                selectCommand.Parameters.AddWithValue("@style", convertEnmuToStyle(t.style));
                selectCommand.Parameters.AddWithValue("@distance", convertEnumToDistance(t.distance));
                SQLiteDataReader reader = selectCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader["id"]);
                    }
                }
                reader.Close();
                conn.Close();
            }
        } catch(Exception ex) {
            log.Error(ex.Message);
        }
        log.Info("Am gasit: " + id);
        return id;
    }
    
    public MyTask findOne(int id)
    {
        log.Info("Intru in FindOne - clasa RepoBDTask!");
        MyTask t = null;
        try
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                SQLiteCommand selectCommand = new SQLiteCommand("SELECT * FROM tasks WHERE id=@id;", conn);
                selectCommand.Parameters.AddWithValue("@id", id);
                SQLiteDataReader reader = selectCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int idTask = Convert.ToInt32(reader["id"]);
                        Utility.enumStyle style = convertStyleToEnum(Convert.ToString(reader["style"]));
                        Utility.enumDistance distance = convertDistanceToEnum(Convert.ToInt32(reader["distance"]));
                        t = new MyTask(distance, style);
                        t.id = idTask;
                    }
                }
                reader.Close();
                conn.Close();
            }
        } catch(Exception ex) {
            log.Error(ex.Message);
        }
        log.Info("Am gasit: " + t);
        return t;
    }

    public List<MyTask> findAll()
    {
        log.Info("Intru in FindAll - clasa RepoBDTask!");
        List<MyTask> lista = new List<MyTask>();
        try
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                SQLiteCommand selectCommand = new SQLiteCommand("SELECT * FROM tasks", conn);
                SQLiteDataReader reader = selectCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int idTask = Convert.ToInt32(reader["id"]);
                        Utility.enumStyle style = convertStyleToEnum(Convert.ToString(reader["style"]));
                        Utility.enumDistance distance = convertDistanceToEnum(Convert.ToInt32(reader["distance"]));
                        MyTask t = new MyTask(distance, style);
                        t.id = idTask;
                        lista.Add(t);
                    }
                }
                reader.Close();
                conn.Close();
            }
        } catch(Exception ex) {
            log.Error(ex.Message);
        }
        log.Info("Am gasit: " + lista);
        return lista;
    }

    public void add(MyTask t)
    {
        log.Info("Intru in Add - clasa RepoBDTask!");
        try
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO tasks(id, distance, style) VALUES" + "(@id, @distance, @style);", conn);
                insertCommand.Parameters.AddWithValue("@id", t.id);
                insertCommand.Parameters.AddWithValue("@distance", convertEnumToDistance(t.distance));
                insertCommand.Parameters.AddWithValue("@style", convertEnmuToStyle(t.style));
                insertCommand.ExecuteNonQuery();

                conn.Close();
            }
        }
        catch (Exception ex){
            log.Error(ex.Message);
        }
        log.Info("Am adaugat taskul " + t + " in baza de date");
    }

    public void delete(int id)
    {
        log.Info("Intru in Delete - clasa RepoBDTask!");
        try
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                SQLiteCommand deleteCommand = new SQLiteCommand("DELETE FROM tasks WHERE id=@id;", conn);
                deleteCommand.Parameters.AddWithValue("@id", id);
                deleteCommand.ExecuteNonQuery();

                conn.Close();
            }
        }
        catch (Exception ex) {
            log.Error(ex.Message);
        }
        log.Info("Am sters taskul cu id ul " + id);
    }
}