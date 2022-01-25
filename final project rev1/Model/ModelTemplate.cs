using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace final_project_rev1.Model
{
    class ModelTemplate
    {
        private static SqlConnection conn;
        private SqlCommand command;
        private bool result;

        public static SqlConnection GetConnection()
        {

            conn = new SqlConnection();
            conn.ConnectionString = "Data Source = ENCODE;" +
                                    "Initial Catalog = App_Wifi_New1;" +
                                    "Integrated Security = true";
            return conn;
        }

        public ModelTemplate()
        {
            GetConnection();
        }
        /*
        public void CekKoneksi()
        {
            GetConnection();
            //error handling
            try
            {
                conn.Open();
                MessageBox.Show("Connection Succes");
            }
            catch (SqlException se)
            {
                MessageBox.Show("Connection Failed" + se);
            }
        }
        */
        public DataSet Select(string tabel, string kondisi)
        {
            DataSet ds = new DataSet();

            try
            {
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                if (kondisi == null)
                {
                    command.CommandText = "SELECT * FROM " + tabel;
                }
                else
                {
                    command.CommandText = "SELECT * FROM " + tabel + " WHERE " + kondisi;
                }
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, tabel);
            }
            catch (SqlException)
            {
                ds = null;
            }
            conn.Close();
            return ds;
        }

        //template select data (counting, top, grouping dll)
        public DataSet SelectData(string query, string tabel)
        {
            DataSet ds = new DataSet();

            try
            {
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, tabel);
            }
            catch (SqlException)
            {
                ds = null;
            }
            conn.Close();
            return ds;
        }

        //template insert data
        public Boolean Insert(string tabel, string data)
        {
            result = false;
            try
            {
                string query = "INSERT INTO " + tabel + " VALUES (" + data + ")";
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = query;
                command.ExecuteNonQuery();
                result = true;
            }
            catch (SqlException)
            {
                result = false;
            }
            conn.Close();
            return result;
        }

        // update pengguna
        public Boolean Update(string tabel, string data, string kondisi)
        {
            result = false;
            try
            {
                string query = "UPDATE " + tabel + " SET " + data + " WHERE " + kondisi;
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = query;
                command.ExecuteNonQuery();
                result = true;
            }
            catch (SqlException)
            {
                result = false;
            }
            conn.Close();
            return result;
        }

    }
}

