using System;
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
    public class TransmissionRepository: BaseRepository, ITransmissionRepository
    {
        public TransmissionRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(TransmissionModel transmissionModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into Transmission values (@item, @quantity, @category, @department, @building, @date, @description, @consumable)";
                command.Parameters.Add("@item", SqlDbType.VarChar).Value = transmissionModel.ItemName;
                command.Parameters.Add("@quantity", SqlDbType.Int).Value = transmissionModel.Quantity;
                command.Parameters.Add("@category", SqlDbType.VarChar).Value = transmissionModel.Category;
                command.Parameters.Add("@department", SqlDbType.VarChar).Value = transmissionModel.Department;
                command.Parameters.Add("@building", SqlDbType.VarChar).Value = transmissionModel.Building;
                command.Parameters.Add("@date", SqlDbType.DateTime).Value = transmissionModel.Date;
                command.Parameters.Add("@description", SqlDbType.VarChar).Value = transmissionModel.Description;
                command.Parameters.Add("@consumable", SqlDbType.VarChar).Value = transmissionModel.Consumable;
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
                command.CommandText = "delete from Transmission where ID = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<TransmissionModel> GetAll()
        {
            var transmissionList = new List<TransmissionModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from Transmission order by ID desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var transmissionModel = new TransmissionModel();
                        transmissionModel.Id = (int)reader[0];
                        transmissionModel.ItemName = reader[1].ToString();
                        transmissionModel.Quantity = Convert.ToInt32(reader[2]);
                        transmissionModel.Category = reader[3].ToString();
                        transmissionModel.Department = reader[4].ToString();
                        transmissionModel.Building = reader[5].ToString();
                        transmissionModel.Date = (DateTime)reader[6];
                        transmissionModel.Description = reader[7].ToString();
                        transmissionModel.Consumable = reader[8].ToString();
                        transmissionList.Add(transmissionModel);
                    }
                }
                return transmissionList;
            }
        }
        public IEnumerable<TransmissionModel> GetByValue(string value)
        {
            var transmissionList = new List<TransmissionModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText =
                    @"Select * FROM Transmission where Item like @item+'%' or Category like @category+'%' or Building like @building+'%' or Department like @department+'%' order by ID desc";

                command.Parameters.Add("@item", SqlDbType.VarChar).Value = value;
                command.Parameters.Add("@building", SqlDbType.VarChar).Value = value;
                command.Parameters.Add("@department", SqlDbType.VarChar).Value = value;
                command.Parameters.Add("@category", SqlDbType.VarChar).Value = value;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var transmissionModel = new TransmissionModel();
                        transmissionModel.Id = (int)reader[0];
                        transmissionModel.ItemName = reader[1].ToString();
                        transmissionModel.Quantity = Convert.ToInt32(reader[2]);
                        transmissionModel.Category = reader[3].ToString();
                        transmissionModel.Department = reader[4].ToString();
                        transmissionModel.Building = reader[5].ToString();
                        transmissionModel.Date = (DateTime)reader[6];
                        transmissionModel.Description = reader[7].ToString();
                        transmissionModel.Consumable = reader[8].ToString();
                        transmissionList.Add(transmissionModel);
                    }
                }
                return transmissionList;
            }
        }

        public void Update(TransmissionModel transmissionModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE Transmission SET Item = @item, Quantity = @quantity, Category = @category, Department = @department, Building = @building, Date = @date, Description = @description , consumable = @consumable  WHERE ID = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = transmissionModel.Id;
                command.Parameters.Add("@item", SqlDbType.VarChar).Value = transmissionModel.ItemName;
                command.Parameters.Add("@quantity", SqlDbType.Int).Value = transmissionModel.Quantity;
                command.Parameters.Add("@category", SqlDbType.VarChar).Value = transmissionModel.Category;
                command.Parameters.Add("@department", SqlDbType.VarChar).Value = transmissionModel.Department;
                command.Parameters.Add("@building", SqlDbType.VarChar).Value = transmissionModel.Building;
                command.Parameters.Add("@date", SqlDbType.DateTime).Value = transmissionModel.Date;
                command.Parameters.Add("@description", SqlDbType.VarChar).Value = transmissionModel.Description;
                command.Parameters.Add("@consumable", SqlDbType.VarChar).Value = transmissionModel.Consumable;
                command.ExecuteNonQuery();
            }
        }
    }
}
