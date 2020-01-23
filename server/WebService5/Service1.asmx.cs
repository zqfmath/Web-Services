using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using MySql.Data.MySqlClient;// to load this namespace, MySql.Data.dll is needed.
using System.Data;

namespace WebService5
{
    /// <summary>
    
    /// </summary>
    [WebService(Namespace = "http://functional.com")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {
        
        private string source = "server=localhost;user id=root;password=mxd123;database=zqf";
       // The class which is used to connect mysql
        private MySqlConnection conn;
        //static variable, which can be used through out the process.
        private static int key = 0;
        //storage Users' identity information 
        private static String UserID;
        private static String Password;

        //Private method by which server can insert or delete data from mysql databases
        private void MysqlInsert_Delete(String sql)
        {

            try
            {
                //creae MySqlConnection object;
                conn = new MySqlConnection(source);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;

            }

        }
        //Private method by which server can query data from mysql databases
        private DataTable MySqlQuery(String sql)
        {


            //  string source = "server=localhost;user id=root;password=mxd123;database=zqf";
            DataTable dt = new DataTable();

            try
            {
                conn = new MySqlConnection(source);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return dt;
        }
        //This method check whether users had registered or not, and give respond. if Yes, storage users' userid and password in order to authorize users.
        [WebMethod]
        public int Login(String ID, String word) 
        {
           
            String str = "select * from register where UserID ='" + ID + "' and Password='" + word + "';";

            DataTable dt = MySqlQuery(str);
            if (dt.Rows.Count == 1&&ID!=""&&word!="")
            {
                key = 1;
                UserID = ID;
                Password = word;
            }
            
            return key;
           
           
        }
        //register a new account,and authorize users. If the ID has been occupied, return 0.
        [WebMethod]
        public int Register(String ID, String word) 
        {
           String str1 = "select * from register where UserID ='" + ID+"';";

            DataTable dt = MySqlQuery(str1);
            int num = dt.Rows.Count;
            if (num == 1||ID==""||word=="")
            {
                return 0;
            }
            else
            {
                String str2 = "insert into register values('" + ID + "','" + word + "');";
                MysqlInsert_Delete(str2);
                UserID = ID;
                Password = word;
                key = 1;
                return key;
                
            }
        }

      

//if tbe users have been authorized, return users' ID.
        [WebMethod]
        public String Name()
        {
            if (key == 1)
            {
                return UserID;

            }
            else
            {
                return "";
            }
        }
        //return the list of all users.
        [WebMethod]
        public DataTable GetName()
        {
            DataTable dt = new DataTable();
            if (key == 1)
            {
                String str = "select UserID from register;";
               dt = MySqlQuery(str);
            }
            return dt;
            
        }

        //return the list of all playlists.
        [WebMethod]
        public DataTable GetList(String ID)
        {
            DataTable dt = new DataTable();
            if (key == 1)
            {
                String str = "select * from list where nickname='"+ID+"';";
                dt = MySqlQuery(str);
            }
            return dt;

        }
        //return the list of tracks in certurn playlist.
        [WebMethod]
        public DataTable GetTrack(String playlist)
        {
            DataTable dt = new DataTable();
            if (key == 1)
            {
                String str1 = "select title,artist,album,genre from track where playlist='" + playlist + "';";
                String str2 = "select title,artist,album,genre from track where playlist='" + playlist + "' and public='Y';";
                String str = "select * from list where nickname='"+UserID+"' and playlist='"+playlist+"';";
                DataTable dt_test = MySqlQuery(str);
                if (dt_test.Rows.Count == 0)
                {
                    dt = MySqlQuery(str2);
                }
                else
                {
                    dt = MySqlQuery(str1);
                }
            }
            return dt;


        }

        // Add a score of playlist into databases
        [WebMethod]
        public int AddScore(String playlist, String nickname, int score)
        {
            if (key == 1)
            {
                String str1 = "select * from playlist_score where playlist='" + playlist + "' and nickname='" + nickname + "' and scoring_person='" + UserID + "';";
                DataTable dt = MySqlQuery(str1);
                if (dt.Rows.Count == 0)
                {
                    String str2 = "insert into playlist_score values('" + playlist + "','" + nickname + "','" + UserID + "'," + score.ToString() + ");";
                    MysqlInsert_Delete(str2);
                    return 1;
                }
                else 
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

      //Add a track into databases
        [WebMethod]
        public int AddTrack(String title, String artist, String album,String genre,String playlist,String Public)
        {
            if (key == 1)
            {
                String str1 = "select * from track where title='" + title + "' and artist='" + artist + "' and playlist='" + playlist + "';";
                DataTable dt = MySqlQuery(str1);
                if (dt.Rows.Count == 0)
                {
                    String str2 = "insert into track values('" + title + "','" + artist + "','" + album + "','" + genre + "','" + playlist + "','" + Public + "');";
                    MysqlInsert_Delete(str2);
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        //return all the mark the authorized users made 
        [WebMethod]
        public DataTable Mymarks()
        {
            DataTable dt = new DataTable();
            if (key == 1)
            {
                String str = "select playlist,nickname,score from playlist_score where scoring_person='"+UserID+"';";
                dt = MySqlQuery(str);
            }
            return dt;

        }

        //add a new playlist
        [WebMethod]
        public int AddList(String playlist)
        {
            String nickname = UserID;
            if (key == 1)
            {
                String str1 = "select * from list where playlist='" + playlist + "' and nickname='" + nickname + "';";
                DataTable dt = MySqlQuery(str1);
                if (dt.Rows.Count == 0)
                {
                    String str2 = "insert into list values('" + playlist + "','" + nickname + "');";
                    MysqlInsert_Delete(str2);
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        //elete one whole playlist
 
        [WebMethod]
        public int DeleteList(String playlist)
        {
            String nickname = UserID;
            if (key == 1)
            {
                String str1 = "select * from list where playlist='" + playlist + "' and nickname='" + nickname + "';";
                DataTable dt = MySqlQuery(str1);
                if (dt.Rows.Count != 0)
                {
                    String str2 = "delete from list where playlist='" + playlist + "' and nickname='" + nickname + "';";
                    MysqlInsert_Delete(str2);
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        [WebMethod]
        //delete one track
        public int DeleteTrack(String title, String artist, String playlist)
        {
           
            if (key == 1)
            {
                String str1 = "select * from track where title='" + title + "' and artist='" + artist + "' and playlist='" + playlist + "';";
                DataTable dt = MySqlQuery(str1);
                if (dt.Rows.Count != 0)
                {
                    String str2 = "delete from track where title='" + title + "' and artist='" + artist + "' and playlist='" + playlist + "';";
                    MysqlInsert_Delete(str2);
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

       //return the ranking list of playlist.
        [WebMethod]

        public DataTable RankList()
        {
            DataTable dt = new DataTable();
            if (key == 1)
            {
                String str = "select playlist,AVG(score) as rank from playlist_score group by playlist order by AVG(score) desc;";
                dt = MySqlQuery(str);
            }
            return dt;
        }

          //return the ranking list of tracks
        [WebMethod]
        public DataTable RankTrack()
        {
            DataTable dt = new DataTable();
            if (key == 1)
            {
                String str = "select title,count(playlist) as rank from track group by title order by count(playlist) desc;";
                dt = MySqlQuery(str);
            }
            return dt;
        }
       //return TOP 3 of playlists
        [WebMethod]
        public DataTable RankListTop3()
        {
            DataTable dt = new DataTable();
            if (key == 1)
            {
                String str = "select playlist,AVG(score) as rank from playlist_score group by playlist order by AVG(score) desc limit 3;";
                dt = MySqlQuery(str);
            }
            return dt;
        }
      
        //return TOP 3 of tracks
        [WebMethod]
        public DataTable RankTrackTop3()
        {
            DataTable dt = new DataTable();
            if (key == 1)
            {
                String str = "select title,count(playlist) as rank from track group by title order by count(playlist) desc limit 3;";
                dt = MySqlQuery(str);
            }
            return dt;
        }

        //Log off and clear the local data.
        [WebMethod]
        public void Logoff()
        {
        key=0;
        UserID="";
        Password = "";
        }

    }
}