using SwimmingCompetition.domain;
using log4net;
using System.Data.SQLite;

namespace SwimmingCompetition.repository;

public class RepoBDParticipantTask:RepoParticipantTask
{
    String connectionString;
    private static ILog log;
    
    
    public RepoBDParticipantTask(string connectionString)
    {
        this.connectionString = connectionString;
        log = LogManager.GetLogger("RepoBDParticipantTask");
    }


    public bool ifExist(ParticipantTask pt)
    {
        log.Info("Intru in IfExistTask - clasa RepoBDParticipantTask!");
        bool find = false;
        try
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                SQLiteCommand selectCommand = new SQLiteCommand("SELECT * FROM participantTask WHERE idParticipant=@idParticipant AND idTask=@idTask;", conn);
                selectCommand.Parameters.AddWithValue("@idParticipant", pt.idParticipant);
                selectCommand.Parameters.AddWithValue("@idTask", pt.idTask);
                SQLiteDataReader reader = selectCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        find = true;
                    }
                }
                reader.Close();
                conn.Close();
            }
        } catch(Exception ex) {
            log.Error(ex.Message);
        }
        log.Info("Am gasit: " + find);
        return find;
    }


    public List<ParticipantTask> findAllParticipants(int idTask) {
        log.Info("Intru in FindAll - clasa RepoBDParticipantTask!");
        List<ParticipantTask> lista = new List<ParticipantTask>();
        try
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                SQLiteCommand selectCommand = new SQLiteCommand("SELECT * FROM participantTask WHERE idTask=@idTask", conn);
                selectCommand.Parameters.AddWithValue("@idTask", idTask);
                SQLiteDataReader reader = selectCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int idParticipantTask = Convert.ToInt32(reader["id"]);
                        int idParticipant = Convert.ToInt32(reader["idParticipant"]);
                        int idTask1 = Convert.ToInt32(reader["idTask"]);
                        ParticipantTask pt = new ParticipantTask(idParticipant, idTask1);
                        pt.id = idParticipantTask;
                        lista.Add(pt);
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


    public List<ParticipantTask> findAllTasks(int idParticipant)
    {
        log.Info("Intru in FindAll - clasa RepoBDParticipantTask!");
        List<ParticipantTask> lista = new List<ParticipantTask>();
        try
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                SQLiteCommand selectCommand = new SQLiteCommand("SELECT * FROM participantTask WHERE idParticipant=@idParticipant", conn);
                selectCommand.Parameters.AddWithValue("@idParticipant", idParticipant);
                SQLiteDataReader reader = selectCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int idParticipantTask = Convert.ToInt32(reader["id"]);
                        int idParticipant1 = Convert.ToInt32(reader["idParticipant"]);
                        int idTask = Convert.ToInt32(reader["idTask"]);
                        ParticipantTask pt = new ParticipantTask(idParticipant1, idTask);
                        pt.id = idParticipantTask;
                        lista.Add(pt);
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
    

    public ParticipantTask findOne(int id)
    {
        log.Info("Intru in FindOne - clasa RepoBDParticipantTask!");
        ParticipantTask pt = null;
        try
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                SQLiteCommand selectCommand = new SQLiteCommand("SELECT * FROM participantTask WHERE id=@id;", conn);
                selectCommand.Parameters.AddWithValue("@id", id);
                SQLiteDataReader reader = selectCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int idParticipantTask = Convert.ToInt32(reader["id"]);
                        int idParticipant = Convert.ToInt32(reader["idParticipant"]);
                        int idTask = Convert.ToInt32(reader["idTask"]);
                        pt = new ParticipantTask(idParticipant, idTask);
                        pt.id = idParticipantTask;
                    }
                }
                reader.Close();
                conn.Close();
            }
        } catch(Exception ex) {
            log.Error(ex.Message);
        }
        log.Info("Am gasit: " + pt);
        return pt;
    }


    public List<ParticipantTask> findAll()
    {
        log.Info("Intru in FindAll - clasa RepoBDParticipantTask!");
        List<ParticipantTask> lista = new List<ParticipantTask>();
        try
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                SQLiteCommand selectCommand = new SQLiteCommand("SELECT * FROM participantTask", conn);
                SQLiteDataReader reader = selectCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int idParticipantTask = Convert.ToInt32(reader["id"]);
                        int idParticipant = Convert.ToInt32(reader["idParticipant"]);
                        int idTask = Convert.ToInt32(reader["idTask"]);
                        ParticipantTask pt = new ParticipantTask(idParticipant, idTask);
                        pt.id = idParticipantTask;
                        lista.Add(pt);
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


    public void add(ParticipantTask pt)
    {
        log.Info("Intru in Add - clasa RepoBDParticipantTask!");
        try
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                SQLiteCommand insertCommand = new SQLiteCommand("INSERT INTO participantTask(id, idParticipant, idTask) VALUES" + "(@id, @idParticipant, @idTask);", conn);
                insertCommand.Parameters.AddWithValue("@id", pt.id);
                insertCommand.Parameters.AddWithValue("@idParticipant", pt.idParticipant);
                insertCommand.Parameters.AddWithValue("@idTask", pt.idTask);
                insertCommand.ExecuteNonQuery();

                conn.Close();
            }
        }
        catch (Exception ex){
            log.Error(ex.Message);
        }
        log.Info("Am adaugat ParticipantTaskul " + pt + " in baza de date");
    }


    public void delete(int id)
    {
        log.Info("Intru in Delete - clasa RepoBDParticipantTask!");
        try
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                SQLiteCommand deleteCommand = new SQLiteCommand("DELETE FROM participantTask WHERE id=@id;", conn);
                deleteCommand.Parameters.AddWithValue("@id", id);
                deleteCommand.ExecuteNonQuery();

                conn.Close();
            }
        }
        catch (Exception ex) {
            log.Error(ex.Message);
        }
        log.Info("Am sters ParticipantTaskul cu id ul " + id);
    }
}