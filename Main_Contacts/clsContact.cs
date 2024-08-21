using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;
using System.IO;

namespace Main_Contacts
{
    

    public class clsContact
    {
        static  string ConnectionString = "Server=.;Database=Contacts;User Id=sa;Password=sa123456;";
        public int ContactID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public int CountryID { set; get; }
        public string Adress { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }

        public byte[] Image { set; get; }

        public MemoryStream streamImage = new MemoryStream();

        public  void GetContact(int ID)
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            connection.Open();
            string Query = "select * from Contacts where ContactID=@ID";
            SqlCommand cmd = new SqlCommand(Query,connection);
            cmd.Parameters.AddWithValue("@ID", ID);
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                
                while (reader.Read())
                {
                    this.ContactID = (int)reader["ContactID"];
                    this.FirstName = (string)reader["FirstName"];
                    this.LastName = (string)reader["LastName"];
                    this.Phone = (string)reader["Phone"];
                    this.Email = (string)reader["Email"];
                    this.Adress = (string)reader["Address"];
                    this.CountryID = (int)reader["CountryID"];
                    if (!Convert.IsDBNull(reader["Image"]))
                        this.Image = (byte[])reader["Image"];
                    connection.Close();
                    reader.Close();
                    break;
                }
            }
            catch
            {
                connection.Close();
                reader.Close() ;
                return;
            }
             
        }

        public static int GetContactID(string FullName)
        {
            var FirstLastName = FullName.Split(' ');
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            int ID=0;
            string Query = "select * from Contacts where FirstName=@fName and LastName=@lname";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@fName", FirstLastName[0]);
            cmd.Parameters.AddWithValue("@lname", FirstLastName[1]);

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    ID = (int)reader["ContactID"];
                    connection.Close();
                    reader.Close();
                    break;
                    
                }
                return ID;
            }
            catch
            {
                connection.Close();
                return 0;
            }

        }

        public int AddNewContact()
        {
            SqlConnection connection= new SqlConnection(ConnectionString);
            connection.Open();
            string Query = "INSERT INTO Contacts (FirstName,LastName,Email,Phone,Address,Image,CountryID) VALUES" +
                " (@FirstName,@LastName,@Email,@Phone,@Address,@Image,@CountryID);" +
                "select SCOPE_IDENTITY();";
            SqlCommand cmd =new SqlCommand(Query,connection);
            cmd.Parameters.AddWithValue("@FirstName", this.FirstName);
            cmd.Parameters.AddWithValue("@LastName",this.LastName);
            cmd.Parameters.AddWithValue("@Email", this.Email);
            cmd.Parameters.AddWithValue("@Phone", this.Phone);
            cmd.Parameters.AddWithValue("@Address", this.Adress);
            cmd.Parameters.AddWithValue("@Image", this.streamImage.GetBuffer());
            cmd.Parameters.AddWithValue("@CountryID", this.CountryID);
            try
            {
                object roweffected=cmd.ExecuteScalar();
                connection.Close();
                if (roweffected != null&&int.TryParse(roweffected.ToString(),out int ID))
                    return ID;
                else
                    return -1;
            }
            catch
            {
                connection.Close();
                return -1;
            }
        }

        public static List<string> GetNameofCountries()
        {
            SqlConnection connection= new SqlConnection(ConnectionString);
            var CountriesName=new List<string>();
            connection.Open();
            string Query = "select * from Countries";
            SqlCommand command =new SqlCommand(Query,connection);

            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                    CountriesName.Add((string)reader["CountryName"]);
                reader.Close();
            }
            catch
            {
                connection.Close();
                return CountriesName;
            }
            connection.Close();
            return CountriesName;
            
        }

        public static int GetCountryIDWithName(string Name)
        {
            SqlConnection connection= new SqlConnection(ConnectionString);
            connection.Open();
            string Query = "Select CountryID from Countries where CountryName=@name";
            SqlCommand command=new SqlCommand(Query,connection);
            command.Parameters.AddWithValue("@name", Name);
            try
            {
                object Value=command.ExecuteScalar();
                if(Value != null)
                {
                    connection.Close();
                    return Convert.ToInt32(Value);
                }
                return 0;
            }
            catch
            {
                return 0;
            }
        }

        public static string GetCountryNameWithID(int ID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            
            string Query = "Select CountryName from Countries where CountryID=@name";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@name", ID);
            try
            {
                object Value = command.ExecuteScalar();
                if (Value != null)
                {
                    connection.Close();
                    return Value.ToString();
                }
                return "";
            }
            catch
            {
                return "";
            }
        }

        public static bool IsFound(int ID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string Query = "SELECT CASE WHEN EXISTS" +
                "(SELECT *FROM Contacts WHERE ContactID =@ID)" +
                "THEN CAST(1 AS BIT)" +
                "ELSE CAST(0 AS BIT) END";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@ID", ID);
            try
            {
                object Result=cmd.ExecuteScalar();

                if (Convert.ToInt32(Result)==1)
                {
                    connection.Close();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsFound(string FullName)
        {
            var FirstLastName = FullName.Split(' ');
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string Query = "SELECT CASE WHEN EXISTS" +
                "(SELECT *FROM Contacts WHERE FirstName=@FirstName and LastName=@LastName)" +
                "THEN CAST(1 AS BIT)" +
                "ELSE CAST(0 AS BIT) END";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@FirstName", FirstLastName[0]);
            cmd.Parameters.AddWithValue("@LastName", FirstLastName[1]);
            try
            {
                object Result = cmd.ExecuteScalar();

                if (Convert.ToInt32(Result) == 1)
                {
                    connection.Close();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public void Delete()
        {
            SqlConnection connection= new SqlConnection(ConnectionString);
            connection.Open();
            string Query = "DELETE FROM Contacts WHERE ContactID=@conID";
            SqlCommand cmd=new SqlCommand(Query,connection);
            cmd.Parameters.AddWithValue("@conID", this.ContactID);
            try
            {
                byte RowEffected = (byte)cmd.ExecuteNonQuery();

                if (RowEffected != 0) 
                {
                    connection.Close();
                    return;
                }
                connection.Close();
                return ;
            }
            catch 
            {
                connection.Close() ;
                return ; 
            }
        }

        public bool IsEmpty()
        {
            if (this.ContactID == 0 || this.FirstName == null)
                return true;
            return false;
        }

        public bool Update()
        {
            SqlConnection connection= new SqlConnection(ConnectionString);
            connection.Open();
            string Query = "UPDATE Contacts SET " +
                "FirstName = @FirstName,LastName = @LastName, Email = @Email,Phone = @Phone ," +
                "Address = @Address,Image = @Image ,CountryID = @CountryID WHERE ContactID=@ID";
            SqlCommand command=new SqlCommand(Query,connection);
            command.Parameters.AddWithValue("@ID",this.ContactID);
            command.Parameters.AddWithValue("@FirstName", this.FirstName);
            command.Parameters.AddWithValue("@LastName", this.LastName);
            command.Parameters.AddWithValue("@Email", this.Email);
            command.Parameters.AddWithValue("@Address", this.Adress);
            command.Parameters.AddWithValue("@Phone", this.Phone);
            command.Parameters.AddWithValue("@CountryID", this.CountryID);
            command.Parameters.AddWithValue("@Image", this.streamImage.GetBuffer());
            try
            {
                int roweffected = command.ExecuteNonQuery();
                connection.Close();
                if (roweffected >0)
                    return true;
                else
                    return false;
            }
            catch
            {
                connection.Close();
                return false;
            }

        }

        public static List<clsContact> GetContacts()
        {
            SqlConnection connection=new SqlConnection(ConnectionString);
            connection.Open();
            string Query = "select * from Contacts";
            var Contacts=new List<clsContact>();
            clsContact contact=new clsContact();
            SqlCommand command= new SqlCommand(Query,connection);
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                
                while(reader.Read())
                {
                    contact.FirstName = (string)reader["FirstName"];
                    contact.ContactID = (int)reader["ContactID"];
                    contact.LastName = (string)reader["LastName"];
                    contact.Adress = (string)reader["Address"];
                    contact.Email = (string)reader["Email"];
                    contact.Phone = (string)reader["Phone"];
                    contact.CountryID = (int)reader["CountryID"];
                    if (Convert.IsDBNull(reader["Image"]))
                        Contacts.Add(contact);
                    else
                    {
                        contact.Image = (byte[])reader["Image"];
                        Contacts.Add(contact);
                    }
                    contact = new clsContact();
                }
                connection.Close();
                reader.Close();
                return Contacts;
            }
            catch 
            {
                connection.Close();
                return null; 
            }
        }
    }
}
