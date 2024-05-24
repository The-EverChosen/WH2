
using Microsoft.Data.SqlClient;
using WH2.ViewModel;

namespace WH2;

public class SQL
{   // Adresse der Datenbank gespeichert in strings
    public string dataSource { get;  protected set; } 
    public string dataBaseName { get; protected set; } 
    public SqlConnection connection { get; protected set; }
    public string connectionString { get; protected set; }
  
    
    /// <summary>
    /// Kontruktor die meine Eigenschaften festlegt
    /// </summary>
    /// <param name="playername">Name des Spielers</param>
    /// <param name="password">Password des Spielers</param>
    public SQL(string playername,string password)  // Er bekommt Name und passwort und kontruiert daraus einen anmeldestring dings bums                         
	{
        this.dataSource = @"localhost\SQLEXPRESS";
        this.dataBaseName = @"Warhammer";
        this.connectionString = SetConnectionString(playername, password);
        this.connection = new SqlConnection(connectionString);    //Inhalt des Kunstrokotr
    }

    public string name(string name)
    {
        return name;
    } 
    
    //Methode zum bauen der Datenbankverbindung mit Playername und password
    public string SetConnectionString(string playername, string password)
    {
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        try
        {

            builder.DataSource = dataSource;
            builder.InitialCatalog = dataBaseName;
            builder.UserID = playername;                // bekommen wir von der eingabe von Seite Anmeldung
            builder.Password = password;                // bekommen wir von der eingabe von SEite Anmeldung
            builder.TrustServerCertificate = true;
            return builder.ConnectionString;

        }
        catch (Exception)
        {

          return EingabeViewModel.RückGabeBeiFalscherAnmeldung();
        }
        
        
    }
    public bool Login(SqlConnection connection) 
    { bool isAccessSuccess = false;
        try                                             //ExcaptionHandling, damit bei einer falschen anmeldung nichts kaputt geht
        { connection.Open();
        isAccessSuccess = true;
        }

        catch 
        { 
        isAccessSuccess = false;
        }
        return isAccessSuccess; 
    
    
    }
}