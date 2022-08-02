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
    public class ItemRepository: BaseRepository,  IItemRepository
    {
        public ItemRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(ItemModel userModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Items values (@item, @supplier, @category, @size, @contain, @quantity, @price, @totalPrice, @addedDate, @description)";
                command.Parameters.Add("@item", SqlDbType.VarChar).Value = userModel.ItemName;
                command.Parameters.Add("@supplier", SqlDbType.VarChar).Value = userModel.ItemSupplier;
                command.Parameters.Add("@category", SqlDbType.VarChar).Value = userModel.ItemCategory;
                command.Parameters.Add("@size", SqlDbType.VarChar).Value = userModel.ItemSize;
                command.Parameters.Add("@contain", SqlDbType.Int).Value = userModel.ItemContain;
                command.Parameters.Add("@quantity", SqlDbType.Int).Value = userModel.ItemQuantity;
                command.Parameters.Add("@price", SqlDbType.Money).Value = userModel.ItemPrice;
                command.Parameters.Add("@totalPrice", SqlDbType.Money).Value = userModel.TotalPrice;
                command.Parameters.Add("@addedDate", SqlDbType.DateTime).Value = userModel.AddedDate;
                command.Parameters.Add("@description", SqlDbType.VarChar).Value = userModel.Description;
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
                command.CommandText = "delete from Items where ID = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ItemModel> GetAll()
        {
           var itemsList = new List<ItemModel>();
            using(var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Items order by ID desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new ItemModel();
                        item.Id = (int)reader[0];
                        item.ItemName = reader[1].ToString();
                        item.ItemSupplier = reader[2].ToString();
                        item.ItemCategory = reader[3].ToString();
                        item.ItemSize =  reader[4].ToString();
                        item.ItemContain = (int)reader[5];
                        item.ItemQuantity = (int)reader[6] ;
                        item.ItemPrice = Convert.ToDouble(reader[7]);
                        item.TotalPrice = Convert.ToDouble(reader[8]);
                        item.AddedDate = (DateTime)reader[9];
                        item.Description = reader[10].ToString();
                        itemsList.Add(item);

                    }
                }
                return itemsList;
            }
        }

        public IEnumerable<ItemModel> GetByvalue(string value)
        {
            var itemsList = new List<ItemModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select * FROM Items 
                                        where Item like @item+'%' or Supplier like @supplier+'%' or Category like @category+'%'";
                command.Parameters.Add("@item", SqlDbType.VarChar).Value = value;
                command.Parameters.Add("@supplier", SqlDbType.VarChar).Value = value;
                command.Parameters.Add("@category", SqlDbType.VarChar).Value = value;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new ItemModel();
                        item.Id = (int)reader[0];
                        item.ItemName = reader[1].ToString();
                        item.ItemSupplier = reader[2].ToString();
                        item.ItemCategory = reader[3].ToString();
                        item.ItemSize = reader[4].ToString();
                        item.ItemContain = (int)reader[5];
                        item.ItemQuantity = (int)reader[6];
                        item.ItemPrice = Convert.ToDouble(reader[7]);
                        item.TotalPrice = Convert.ToDouble(reader[8]);
                        item.AddedDate = (DateTime)reader[9];
                        item.Description = reader[10].ToString();
                        itemsList.Add(item);

                    }
                }
                return itemsList;
            }
        }

        public void Update(ItemModel userModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE Items SET Item = @item, Supplier = @supplier, Category = @category, Size = @size, Contain = @contain, Quantity = @quantity, Price = @price, TotalPrice = @totalPrice, AddedDate = @addedDate, Description = @description where ID = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = userModel.Id;
                command.Parameters.Add("@item", SqlDbType.VarChar).Value = userModel.ItemName;
                command.Parameters.Add("@supplier", SqlDbType.VarChar).Value = userModel.ItemSupplier;
                command.Parameters.Add("@category", SqlDbType.VarChar).Value = userModel.ItemCategory;
                command.Parameters.Add("@size", SqlDbType.VarChar).Value = userModel.ItemSize;
                command.Parameters.Add("@contain", SqlDbType.Int).Value = userModel.ItemContain;
                command.Parameters.Add("@quantity", SqlDbType.Int).Value = userModel.ItemQuantity;
                command.Parameters.Add("@price", SqlDbType.Money).Value = userModel.ItemPrice;
                command.Parameters.Add("@totalPrice", SqlDbType.Money).Value = userModel.TotalPrice;
                command.Parameters.Add("@addedDate", SqlDbType.DateTime).Value = userModel.AddedDate;
                command.Parameters.Add("@description", SqlDbType.VarChar).Value = userModel.Description;
                command.ExecuteNonQuery();
            }
        }
    }
}
