using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Exe029__DB4_.AccessDB
{
    class ClsDB
    {
        string strConnection = Properties.Settings.Default.ConnectionString;

        OleDbConnection conn = null;

        private int codUser;
        private int pass;
        private string nameUser;

        public int CodUser { get => codUser; set => codUser = value; }
        public int Pass { get => pass; set => pass = value; }
        public string NameUser { get => nameUser; set => nameUser = value; }

        public ClsDB()
        {
            conn = new OleDbConnection(strConnection);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when openng the file: " + ex.ToString(), "ATENTION!");
            }
        }

        public int Register()
        {
            OleDbCommand coman = new OleDbCommand();

            coman.CommandType = CommandType.Text;

            coman.Parameters.Add("@varCod", oleDbType: OleDbType.Integer).Value = codUser;
            coman.Parameters.Add("@varPass", oleDbType: OleDbType.Integer).Value = pass;
            coman.Parameters.Add("@varName", oleDbType: OleDbType.VarChar, 50).Value = nameUser;

            coman.CommandText = "Insert into User values (@varCod, @varPass, @varName)";

            coman.Connection = conn;

            int status = coman.ExecuteNonQuery();

            conn.Close();
            return status;
        }

        public DataTable DataCheck(byte typeQuery, int intcode, string strname)
        {
            OleDbCommand coman = new OleDbCommand();
            string strSQL = "Select * from User";

            if(typeQuery == 2)
            {
                coman.Parameters.Add("@varCod", oleDbType: OleDbType.Integer).Value = intcode;
                strSQL += " where CodUser = @varCod";
            }
            else if(typeQuery == 3)
            {
                coman.Parameters.Add("@varName", oleDbType: OleDbType.VarChar, 50).Value = "%" + strname + "%";
                strSQL += " where NameUser like @varName";
            }
            strSQL += " order by CodUser";

            coman.CommandType = CommandType.Text;
            coman.CommandText = strSQL;

            coman.Connection = conn;
            DataSet myDataset = new DataSet();

            OleDbDataAdapter myAdapter = new OleDbDataAdapter(coman);
            myAdapter.Fill(myDataset, "UserDataSet");
            conn.Close();
            return myDataset.Tables["UserDataSet"];
        }

        public int Edit()
        {
            OleDbCommand coman = new OleDbCommand();

            coman.CommandType = CommandType.Text;

            coman.Parameters.Add("@varPass", oleDbType: OleDbType.Integer).Value = pass;
            coman.Parameters.Add("@varName", oleDbType: OleDbType.VarChar, 50).Value = nameUser;
            coman.Parameters.Add("@varCod", oleDbType: OleDbType.Integer).Value = codUser;

            coman.CommandText = "Update User set Password = @varPass, NameUser = @varName where CodUsuer = @varCod";

            coman.Connection = conn;

            int status = coman.ExecuteNonQuery();
            
            conn.Close();
            return status;
        }

        public int Delete()
        {
            OleDbCommand coman = new OleDbCommand();

            coman.CommandType = CommandType.Text;

            coman.Parameters.Add("@varCod", oleDbType: OleDbType.Integer).Value = codUser;

            coman.CommandText = "Delete from User where CodUser = @varCod";
            coman.Connection = conn;

            int status = coman.ExecuteNonQuery();

            conn.Close();
            return status;
        }

        
    }
}
