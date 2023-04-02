using SwimmingCompetition.domain;
using log4net;
using System.Data.SQLite;

namespace SwimmingCompetition.repository;

public class RepoBDParticipant:RepoParticipant
{
    String connectionString;
    private static ILog log;

    
    public RepoBDParticipant(string connectionString)
    {
        this.connectionString = connectionString;
        log = LogManager.GetLogger("RepoBDParticipant");
    }

    

    public int ifExistParticipant(Participant p)
    {
        log.Info("Intru in IfExistParticipant - clasa RepoBDParticipant!");
        int id = -1;
        try
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                SQLiteCommand selectCommand = new SQLiteCommand("SELECT * FROM participants WHERE name=@name AND age=@age;", conn);
                selectCommand.Parameters.AddWithValue("@name", p.name);
                selectCommand.Parameters.AddWithValue("@age", p.age);
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
    

    public Participant findOne(int id)
    {
        log.Info("Intru in FindOne - clasa RepoBDParticipant!");
        Participant p = null;
        try
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                SQLiteCommand selectCommand = new SQLiteCommand("SELECT * FROM participants WHERE id=@id;", conn);
                selectCommand.Parameters.AddWithValue("@id", id);
                SQLiteDataReader reader = selectCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int idParticipant = Convert.ToInt32(reader["id"]);
                        string name = Convert.ToString(reader["name"]);
                        int age = Convert.ToInt32(reader["age"]);
                        p = new Participant(name, age);
                        p.id = idParticipant;
                    }
                }
                reader.Close();
                conn.Close();
            }
        } catch(Exception ex) {
            log.Error(ex.Message);
        }
        log.Info("Am gasit: " + p);
        return p;
    }


    public List<Participant> findAll()
    {
        log.Info("Intru in FindAll - clasa RepoBDParticipant!");
        List<Participant> lista = new List<Participant>();
        try
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                SQLiteCommand selectCommand = new SQLiteCommand("SELECT * FROM participants", conn);
                SQLiteDataReader reader = selectCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        string name = Convert.ToString(reader["name"]);
                        int age = Convert.ToInt32(reader["age"]);
                        Participant p = new Participant(name, age);
                        p.id = id;
                        lista.Add(p);
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


    public void add(Participant p)
    {
        log.Info("Intru in Add - clasa RepoBDParticipant!");
        try
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO participants(id, name, age) VALUES" + "(@id, @name, @age);", conn);
                insertCommand.Parameters.AddWithValue("@id", p.id);
                insertCommand.Parameters.AddWithValue("@name", p.name);
                insertCommand.Parameters.AddWithValue("@age", p.age);
                insertCommand.ExecuteNonQuery();

                conn.Close();
            }
        }
        catch (Exception ex){
            log.Error(ex.Message);
        }
        log.Info("Am adaugat participantul " + p + " in baza de date");
    }


    public void delete(int id)
    {
        log.Info("Intru in Delete - clasa RepoBDParticipant!");
        try
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                SQLiteCommand deleteCommand = new SQLiteCommand("DELETE FROM participants WHERE id=@id;", conn);
                deleteCommand.Parameters.AddWithValue("@id", id);
                deleteCommand.ExecuteNonQuery();
                
                SQLiteCommand deleteCommand2 = new SQLiteCommand("DELETE FROM participantTask WHERE idParticipant=@id;", conn);
                deleteCommand2.Parameters.AddWithValue("@id", id);
                deleteCommand2.ExecuteNonQuery();

                conn.Close();
            }
        }
        catch (Exception ex) {
            log.Error(ex.Message);
        }
        log.Info("Am sters participantul cu id ul " + id);
    }
}