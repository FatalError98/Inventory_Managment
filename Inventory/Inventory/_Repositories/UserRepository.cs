﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//To Use SQl
using System.Data;
using System.Data.SqlClient;
//refrense to Models
using Inventory.Models;

namespace Inventory._Repositories
{
    public class UserRepository : BaseRepository, IUsersRepository
    {

        //Constructor
        public UserRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        //Methods
        public void Add(UserModel userModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into Users values (@userName, @Password, @userRole)";
                command.Parameters.Add("@userName", SqlDbType.VarChar).Value = userModel.Name;
                command.Parameters.Add("@Password", SqlDbType.VarChar).Value = userModel.Password;
                command.Parameters.Add("@userRole", SqlDbType.VarChar).Value = userModel.Role;
                command.ExecuteNonQuery();
            }
        }
        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from Users where UserId = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }
        public  IEnumerable<UserModel> GetAll()
        {
            var userList = new List<UserModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * FROM Users order by UserId desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new UserModel();
                        userModel.Id = (int)reader[0];
                        userModel.Name = reader[1].ToString();
                        userModel.Password = reader[2].ToString();
                        userModel.Role = reader[3].ToString();
                        userList.Add(userModel);
                    }
                }
                return userList;
            }
        }

        public  IEnumerable<UserModel> GetByvalue(string value)
        {
            var userList = new List<UserModel>();

            int userId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string userName = value;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * FROM Users 
                                        where UserId=@id or Username like @name+'%'
                                        order by UserId desc";
                command.Parameters.Add("@id", SqlDbType.Int).Value = userId;
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = userName;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new UserModel();
                        userModel.Id = (int)reader[0];
                        userModel.Name = reader[1].ToString();
                        userModel.Password = reader[2].ToString();
                        userModel.Role = reader[3].ToString();
                        userList.Add(userModel);
                    }
                }
                return userList;
            }
        }

        public void Update(UserModel userModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "update Users set UserName = @username, UserPassword = @password, UserRole = @userrole where UserId =@id";
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = userModel.Name;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = userModel.Password;
                command.Parameters.Add("@userrole", SqlDbType.VarChar).Value = userModel.Role;
                command.Parameters.Add("@id", SqlDbType.Int).Value = userModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public bool GetByUserAndPassword(string name, string password)
        {
            var userList = new List<UserModel>();
            bool isLogin;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * FROM Users 
                                        where UserName = @name And UserPassword = @password";
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userModel = new UserModel();
                        userModel.Id = (int)reader[0];
                        userModel.Name = reader[1].ToString();
                        userModel.Password = reader[2].ToString();
                        userModel.Role = reader[3].ToString();
                        userList.Add(userModel);
                        
                    }
                    if (userList.Count > 0)
                    {
                        isLogin = true;
                    }                       
                    else
                        isLogin = false;
                }
                return isLogin;
            }
        }
    }
}
