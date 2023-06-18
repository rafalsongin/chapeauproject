﻿using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Runtime.CompilerServices;

namespace ChapeauDAL
{
    public abstract class BaseDao
    {
        private SqlDataAdapter adapter;
        protected SqlConnection conn;

        public BaseDao()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ChapeauDatabase"].ConnectionString);
            adapter = new SqlDataAdapter();
        }

        protected SqlConnection OpenConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                {
                    conn.Open();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return conn;
        }

        private void CloseConnection()
        {
            conn.Close();
        }

        /* For Insert/Update/Delete Queries */
        protected void ExecuteEditQuery(string query, SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        /* For Select Queries with sql parameters */ //this one returns based on an id or smth like that
        protected DataTable ExecuteSelectQueryWithParameters(string query, params SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();
            DataTable dataTable;
            DataSet dataSet = new DataSet();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                command.ExecuteNonQuery();
                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }

            return dataTable;
        }

        protected DataTable ExecuteSelectQuery(string query)      //this returns without the need of a parameter, e.g. table id
        {
            SqlCommand command = new SqlCommand();
            DataTable dataTable;
            DataSet dataSet = new DataSet();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.ExecuteNonQuery();
                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }

            return dataTable;
        }
    }
}