using SwimmingCompetition.domain;
using log4net;
using System.Data.SQLite;
using System.Diagnostics;

namespace SwimmingCompetition.repository;

public class RepoBDAccount:RepoAccount
{
    String connectionString;
    private static ILog log;

    public RepoBDAccount(string connectionString)
    {
        this.connectionString = connectionString;
        log = LogManager.GetLogger("RepoBDAccount");
    }
    

    public int ifExistAccount(Account ac)
    {
        log.Info("Intru in IfExistAccount - clasa RepoBDAccount!");
        int id = -1;
        try
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                SQLiteCommand selectCommand = new SQLiteCommand("SELECT * FROM accountTable WHERE username=@username AND password=@password;", conn);
                selectCommand.Parameters.AddWithValue("@username", ac.username);
                selectCommand.Parameters.AddWithValue("@password", ac.password);
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


    public Account findOne(int id)
    {
        log.Info("Intru in FindOne - clasa RepoBDAccount!");
        Account a = null;
        try
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                SQLiteCommand selectCommand = new SQLiteCommand("SELECT * FROM accountTable WHERE id=@id;", conn);
                selectCommand.Parameters.AddWithValue("@id", id);
                SQLiteDataReader reader = selectCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int idAcc = Convert.ToInt32(reader["id"]);
                        string username = Convert.ToString(reader["username"]);
                        string password = Convert.ToString(reader["password"]);
                        a = new Account(username, password);
                        a.id = idAcc;
                    }
                }
                reader.Close();
                conn.Close();
            }
        } catch(Exception ex) {
            log.Error(ex.Message);
        }
        log.Info("Am gasit: " + a);
        return a;
    }


    public List<Account> findAll()
    {
        log.Info("Intru in FindAll - clasa RepoBDAccount!");
        List<Account> lista = new List<Account>();
        try
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                SQLiteCommand selectCommand = new SQLiteCommand("SELECT * FROM accountTable", conn);
                SQLiteDataReader reader = selectCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        string username = Convert.ToString(reader["username"]);
                        string password = Convert.ToString(reader["password"]);
                        Account a = new Account(username, password);
                        a.id = id;
                        lista.Add(a);
                    }
                }
                reader.Close();
                conn.Close();
            }
        } catch(Exception ex) {
            log.Error(ex.Message);
            MessageBox.Show(ex.Message);
        }
        log.Info("Am gasit: " + lista);
        return lista;
    }


    public void add(Account ac)
    {
        log.Info("Intru in Add - clasa RepoBDAccount!");
        try
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                SQLiteCommand insertCommand =
                    new SQLiteCommand(
                        "INSERT INTO accountTable(id, username, password) VALUES" +
                        "(@id, @usernume, @password);", conn);
                insertCommand.Parameters.AddWithValue("@id", ac.id);
                insertCommand.Parameters.AddWithValue("@usernume", ac.username);
                insertCommand.Parameters.AddWithValue("@password", ac.password);
                insertCommand.ExecuteNonQuery();

                conn.Close();
            }
        }
        catch (Exception ex){
            log.Error(ex.Message);
        }
        log.Info("Am adaugat utilizatorul " + ac + " in baza de date");
    }


    public void delete(int id)
    {
        log.Info("Intru in Delete - clasa RepoBDAccount!");
        try
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                SQLiteCommand deleteCommand = new SQLiteCommand("DELETE FROM accountTable WHERE id=@id;", conn);
                deleteCommand.Parameters.AddWithValue("@id", id);
                deleteCommand.ExecuteNonQuery();

                conn.Close();
            }
        }
        catch (Exception ex) {
            log.Error(ex.Message);
        }
        log.Info("Am sters contul cu id ul " + id);
    }
}