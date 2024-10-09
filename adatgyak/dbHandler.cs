using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace adatgyak
{
    public class wasd
    {
        public int id { get; set; }
        public int prop1 { get; set; }
        public string prop2 { get; set; }
    }
    public class dbHandler
    {
        MySqlConnection con;
        string tName = "table1";
        public dbHandler()
        {
            string host = "localhost";
            string user = "root";
            string password = "";
            string db = "db";
            string conString = $"server={host};user={user};password={password};database={db}";
            con = new MySqlConnection(conString);
        }
        public List<wasd> Read()
        {
            List<wasd> list = new List<wasd>();
            try
            {
                con.Open();
                string query = $"select * from {tName}";
                MySqlCommand com = new MySqlCommand(query, con);
                MySqlDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    wasd wasd1 = new wasd();
                    wasd1.id = read.GetInt32(read.GetOrdinal("id"));
                    wasd1.prop1 = read.GetInt32(read.GetOrdinal("prop1"));
                    wasd1.prop2 = read.GetString(read.GetOrdinal("prop2"));
                    list.Add(wasd1);
                }
                read.Close();
                com.Dispose();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return list;
        }
        public void Delete(int id)
        {
            try
            {
                con.Open();
                string query = $"delete from {tName} where id = {id}";
                MySqlCommand com = new MySqlCommand(query, con);
                com.ExecuteNonQuery();
                com.Dispose();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void deleteAll()
        {
            try
            {
                con.Open();
                string query = $"delete from {tName}";
                MySqlCommand com = new MySqlCommand(query, con);
                com.ExecuteNonQuery();
                com.Dispose();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void Insert(wasd wasd1)
        {
            try
            {
                con.Open();
                string query = $"insert into {tName} (prop1, prop2) values ({wasd1.prop1},'{wasd1.prop2}')";
                MySqlCommand com = new MySqlCommand(query, con);
                com.ExecuteNonQuery();
                com.Dispose();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
