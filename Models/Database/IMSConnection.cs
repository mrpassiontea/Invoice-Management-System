using System;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using InvoiceManagementSystem.Models.Dashboard;
using InvoiceManagementSystem.Models.Entities;
using Microsoft.Data.SqlClient;

namespace InvoiceManagementSystem.Models.Database
{
    public class IMSConnection : IIMSConnection
    {
        public BindingList<DGVInvoice> Invoices { get; set; }
        public BindingList<DGVEmployee> Employees { get; set; }
        public BindingList<User> Users { get; set; }
        public User CurrentUser { get; set; }

        public IMSConnection()
        {
            Employees = AllEmployees();
            Invoices = AllInvoices();
            Users = GetAllUsers();
        }

        public void ModifyEmployee(DGVEmployee employee)
        {
            using (SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["IMSDB"].ConnectionString))
            {
                _connection.Open();
                // Create a SQL transaction.
                var transaction = _connection.BeginTransaction();
                var sql = _connection.CreateCommand();
                sql.Transaction = transaction;
                try
                {
                    // Update Country
                    sql.CommandText = $@"UPDATE [imsdb].[dbo].[country] SET [country] = '{employee.Country}', [lastUpdate] = '{employee.LastUpdate:yyyy-MM-dd}', [lastUpdateBy] = '{employee.LastUpdateBy}' WHERE [imsdb].[dbo].[country].[countryId] = {employee.CountryId}";
                    sql.ExecuteNonQuery();

                    // Update City
                    sql.CommandText = $@"UPDATE [imsdb].[dbo].[city] SET [city] = '{employee.City}', [lastUpdate] = '{employee.LastUpdate:yyyy-MM-dd}', [lastUpdateBy] = '{employee.LastUpdateBy}' WHERE [imsdb].[dbo].[city].[cityId] = {employee.CityId}";
                    sql.ExecuteNonQuery();

                    // Update Address
                    sql.CommandText = $@"UPDATE [imsdb].[dbo].[address] SET [address] = '{employee.Address}', [address2] = '{employee.Address2}', [phone] = '{employee.Phone}', [postalCode] = '{employee.PostalCode}', [lastUpdate] = '{employee.LastUpdate:yyyy-MM-dd}', [lastUpdateBy] = '{employee.LastUpdateBy}' 
                WHERE [imsdb].[dbo].[address].[addressId] = {employee.AddressId}";
                    sql.ExecuteNonQuery();

                    // Update Employee
                    sql.CommandText = $@"UPDATE employee SET employeeName = '{employee.Name}', employeeType = '{employee.EmployeeType}', email = '{employee.Email}', lastUpdate = '{employee.LastUpdate:yyyy-MM-dd HH:mm:ss}', lastUpdateBy = '{employee.LastUpdateBy}' WHERE employee.employeeId = {employee.ID}";
                    sql.ExecuteNonQuery();

                    // Send transaction
                    transaction.Commit();

                    // Update employee in Employees BindingList
                    for (int i = 0; i < Employees.Count; i++)
                    {
                        if (Employees[i].ID == employee.ID)
                        {
                            Employees[i] = employee;
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK);
                    transaction.Rollback();
                }
            }
        }

        public void CreateEmployee(DGVEmployee employee)
        {
            using (SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["IMSDB"].ConnectionString))
            {
                _connection.Open();
                // Create a SQL transaction.
                var transaction = _connection.BeginTransaction();
                var sql = _connection.CreateCommand();
                sql.Transaction = transaction;
                try
                {

                    // Insert into Country
                    sql.CommandText = $@"INSERT INTO [imsdb].[dbo].[country] (country, createDate, createdBy, lastUpdate, lastUpdateBy)
                OUTPUT INSERTED.countryId VALUES('{employee.Country}', '{employee.CreateDate:yyyy-MM-dd}', '{employee.CreatedBy}', '{employee.LastUpdate:yyyy-MM-dd}', '{employee.LastUpdateBy}')";
                    var countryId = (int) sql.ExecuteScalar();

                    // Insert into City
                    sql.CommandText = $@"INSERT INTO [imsdb].[dbo].[city] (city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) OUTPUT INSERTED.cityId
                SELECT '{employee.City}', [countryId], [createDate], [createdBy], [lastUpdate], [lastUpdateBy] FROM [imsdb].[dbo].[country] WHERE [imsdb].[dbo].[country].[countryId]={countryId}";
                    var cityId = (int) sql.ExecuteScalar();

                    // Insert into Address
                    sql.CommandText = $@"INSERT INTO [imsdb].[dbo].[address] (address, address2, postalCode, phone, cityId, createDate, createdBy, lastUpdate, lastUpdateBy) 
                OUTPUT INSERTED.addressId SELECT '{employee.Address}', '{employee.Address2}', '{employee.PostalCode}', '{employee.Phone}', cityId, createDate, createdBy, lastUpdate, lastUpdateBy  
                FROM city WHERE city.cityId={cityId}";
                    var addressId = (int) sql.ExecuteScalar();

                    // Finally insert into Employee
                    sql.CommandText = $@"INSERT INTO employee (employeeName, employeeType, email, addressId, createDate, createdBy, lastUpdate, lastUpdateBy) 
                OUTPUT INSERTED.employeeId SELECT '{employee.Name}', '{employee.EmployeeType}', '{employee.Email}', addressId, createDate, createdBy, lastUpdate, lastUpdateBy FROM address WHERE address.addressId={addressId}";
                    var id = (int) sql.ExecuteScalar();

                    // Send transaction
                    transaction.Commit();
                    var localCreateDate = employee.CreateDate.ToLocalTime();
                    var localLastUpdate = employee.LastUpdate.ToLocalTime();

                    employee.ID = id;
                    employee.CountryId = countryId;
                    employee.CityId = cityId;
                    employee.AddressId = addressId;
                    employee.CreateDate = localCreateDate;
                    employee.LastUpdate = localLastUpdate;
                    Employees.Add(employee);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK);
                    transaction.Rollback();
                }
                return;
            }
        }

        public void DeleteInvoice(string ID)
        {
            try
            {
                var sql = $@"DELETE FROM invoice WHERE invoiceId={ID}";
                using (SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["IMSDB"].ConnectionString))
                {
                    _connection.Open();
                    var cmd = new SqlCommand(sql, _connection).ExecuteNonQuery();
                }
                // Rather than having to waste a call the DB, since the invoice is already removed in the DB-all I need to do is quickly remove the invoice from the Invoices BindingList.
                Invoices.Remove(Invoices.First(invoice => invoice.ID.Equals(int.Parse(ID))));
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK);
            }
            return;
        }

        public void DeleteEmployee(string ID) {
            try
            {
                
                var sql = $@"DELETE FROM invoice WHERE invoice.employeeId={ID}; DELETE FROM employee WHERE employeeId={ID}";
                using (SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["IMSDB"].ConnectionString))
                {
                    _connection.Open();
                    var cmd = new SqlCommand(sql, _connection).ExecuteNonQuery();
                }
                    // Just like in DeleteAppointent(), instead of calling the DB for all the Employees, I can save time and easily just remove the deleted employee from the Employees BindingList.
                    Employees.Remove(Employees.First(employee => employee.ID.Equals(int.Parse(ID))));
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK);
            }
            return;
        }

        public DGVEmployee GetEmployee(string ID)
        {
            return Employees.First(employee => employee.ID.Equals(int.Parse(ID)));
        }

        public void CreateInvoice(DGVInvoice invoice)
        {
            using (SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["IMSDB"].ConnectionString))
            {
                _connection.Open();
                // Create a SQL transaction.
                var transaction = _connection.BeginTransaction();
                var sql = _connection.CreateCommand();
                sql.Transaction = transaction;
                try
                {
                    // Insert into Country
                    sql.CommandText = $@"INSERT INTO invoice (employeeId, userId, description, paymentDueDate, totalAmountDue, hoursWorked, pricePerHour, createDate, createdBy, lastUpdate, lastUpdateBy)
                OUTPUT INSERTED.invoiceId VALUES({invoice.EmployeeId}, {invoice.UserId}, '{invoice.Description}', '{invoice.PaymentDueDate:yyyy-MM-dd}', {invoice.TotalAmountDue}, {invoice.HoursWorked}, {invoice.PricePerHour}, 
                '{invoice.CreateDate:yyyy-MM-dd}', '{invoice.CreatedBy}', '{invoice.LastUpdate:yyyy-MM-dd}', '{invoice.LastUpdateBy}')";
                    var invoiceId = (int)sql.ExecuteScalar();

                    // Send transaction
                    transaction.Commit();
                    var localCreateDate = invoice.CreateDate.ToLocalTime();
                    var localLastUpdate = invoice.LastUpdate.ToLocalTime();
                    invoice.ID = invoiceId;
                    invoice.CreateDate = localCreateDate;
                    invoice.LastUpdate = localLastUpdate;
                    Invoices.Add(invoice);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK);
                    transaction.Rollback();
                }
            }
            return;
        }

        public void ModifyInvoice(DGVInvoice invoice)
        {
            // Create a SQL transaction.
            using (SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["IMSDB"].ConnectionString))
            {
                _connection.Open();
                var transaction = _connection.BeginTransaction();
                var sql = _connection.CreateCommand();
                sql.Transaction = transaction;
                try
                {
                    sql.CommandText = $@"UPDATE invoice SET employeeId = {invoice.EmployeeId}, userId = {invoice.UserId}, description = '{invoice.Description}',  
                    paymentDueDate = '{invoice.PaymentDueDate:yyyy-MM-dd}', totalAmountDue = {invoice.TotalAmountDue}, hoursWorked = {invoice.HoursWorked}, 
                    pricePerHour = {invoice.PricePerHour}, createDate = '{invoice.CreateDate:yyyy-MM-dd}', createdBy = '{invoice.CreatedBy}', 
                    lastUpdate = '{invoice.LastUpdate:yyyy-MM-dd}', lastUpdateBy = '{invoice.LastUpdateBy}' WHERE invoice.invoiceId = {invoice.ID}";

                    sql.ExecuteNonQuery();

                    // Send transaction
                    transaction.Commit();
                    var localCreateDate = invoice.CreateDate.ToLocalTime();
                    var localLastUpdate = invoice.LastUpdate.ToLocalTime();
                    invoice.CreateDate = localCreateDate;
                    invoice.LastUpdate = localLastUpdate;

                    // Update employee in Employees BindingList
                    for (int i = 0; i < Invoices.Count; i++)
                    {
                        if (Invoices[i].ID == invoice.ID)
                        {
                            Invoices[i] = invoice;
                            return;
                        }
                    }
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK);
                    transaction.Rollback();
                }
                
            }
        }

        public DGVInvoice GetInvoice(string ID)
        {
            return Invoices.First(invoice => invoice.ID.Equals(int.Parse(ID)));
        }

        public BindingList<DGVInvoice> AllInvoices()
        {
            var tempInvoiceList = new BindingList<DGVInvoice>();
            try
            {
                var sql = $@"SELECT * FROM [imsdb].[dbo].[invoice]";
                using (SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["IMSDB"].ConnectionString))
                {
                    var cmd = new SqlCommand(sql, _connection);
                    _connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var tempAmountDue = reader.GetDecimal(reader.GetOrdinal("totalAmountDue")).ToString();
                                var tempHoursWorked = reader.GetDouble(reader.GetOrdinal("hoursWorked")).ToString();
                                var tempPricePerHour = reader.GetDecimal(reader.GetOrdinal("pricePerHour")).ToString();
                                tempInvoiceList.Add(new DGVInvoice()
                                {
                                    ID = (int) reader["invoiceId"],
                                    EmployeeId = (int) reader["employeeId"],
                                    UserId = (int) reader["userId"],
                                    Description = (string) reader["description"],
                                    PaymentDueDate =  reader.GetDateTime(reader.GetOrdinal("paymentDueDate")),
                                    TotalAmountDue = string.Format("{0:0.##}", tempAmountDue),
                                    HoursWorked = string.Format("{0:0.##}", tempHoursWorked),
                                    PricePerHour = string.Format("{0:0.##}", tempPricePerHour),
                                    CreateDate = reader.GetDateTime(reader.GetOrdinal("createDate")),
                                    CreatedBy = (string) reader["createdBy"],
                                    LastUpdate = reader.GetDateTime(reader.GetOrdinal("lastUpdate")),
                                    LastUpdateBy = (string) reader["lastUpdateBy"]
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK);
            }
            Invoices = tempInvoiceList;
            return Invoices;
        }

        public void SetCurrentUser(string username)
        {
            var user = new User();
            try
            {
                var sql = $"SELECT [user].[userId] as id FROM [imsdb].[dbo].[user] WHERE [userName]='{username}'";
                using (SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["IMSDB"].ConnectionString))
                {
                    var cmd = new SqlCommand(sql, _connection);
                    _connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            user.UserName = username;
                            while (reader.Read())
                            {
                                user.UserId = reader.GetInt32(reader.GetOrdinal("id"));
                            }
                        }
                    }
                }
                user.UserName = username;
                CurrentUser = user;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK);
            }
        }

        public BindingList<User> GetAllUsers()
        {
            var tempUserList = new BindingList<User>();
            try
            {
                var sql = $@"SELECT [userId], [userName] FROM [imsdb].[dbo].[user]";
                using (SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["IMSDB"].ConnectionString))
                {
                    var cmd = new SqlCommand(sql, _connection);
                    _connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                tempUserList.Add(new User()
                                {
                                    UserId = reader.GetInt32(reader.GetOrdinal("userId")),
                                    UserName = reader.GetString(reader.GetOrdinal("userName"))
                                }) ;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK);
            }
            Users = tempUserList;
            return Users;
        }


        public BindingList<DGVEmployee> AllEmployees()
        {
            var tempEmployeeList = new BindingList<DGVEmployee>();
            try
            {
                var sql = $@"SELECT [imsdb].[dbo].[employee].[employeeId], [imsdb].[dbo].[employee].[employeeName], [imsdb].[dbo].[employee].[employeeType], 
                    [imsdb].[dbo].[employee].[email], [imsdb].[dbo].[employee].[addressId], [imsdb].[dbo].[employee].[createDate], 
                    [imsdb].[dbo].[employee].[createdBy], [imsdb].[dbo].[employee].[lastUpdate], [imsdb].[dbo].[employee].[lastUpdateBy], 
                    [imsdb].[dbo].[address].[address], [imsdb].[dbo].[address].[address2], [imsdb].[dbo].[address].[cityId], [imsdb].[dbo].[address].[postalCode], 
                    [imsdb].[dbo].[address].[phone], [imsdb].[dbo].[city].[city], [imsdb].[dbo].[city].[countryId], [imsdb].[dbo].[country].[country] 
                    FROM [imsdb].[dbo].[employee] INNER JOIN [imsdb].[dbo].[address] ON [imsdb].[dbo].[employee].[addressId] = [imsdb].[dbo].[address].[addressId]
                    INNER JOIN [imsdb].[dbo].[city] ON [imsdb].[dbo].[address].[cityId] = [imsdb].[dbo].[city].[cityId] INNER JOIN [imsdb].[dbo].[country] 
                    on [imsdb].[dbo].[city].[countryId] = [imsdb].[dbo].[country].[countryId]";
                using (SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["IMSDB"].ConnectionString))
                {
                    var cmd = new SqlCommand(sql, _connection);
                    _connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var tempEmployee = new DGVEmployee() {
                                    ID = (int) reader["employeeId"],
                                    Name = (string) reader["employeeName"],
                                    EmployeeType = (string) reader["employeeType"],
                                    Email = (string) reader["email"],
                                    AddressId = (int) reader["addressId"],
                                    CreateDate = reader.GetDateTime(reader.GetOrdinal("createDate")),
                                    CreatedBy = (string) reader["createdBy"],
                                    LastUpdate = reader.GetDateTime(reader.GetOrdinal("lastUpdate")),
                                    LastUpdateBy = (string) reader["lastUpdateBy"],
                                    Address = (string) reader["address"],
                                    CityId = (int) reader["cityId"],
                                    PostalCode = (string) reader["postalCode"],
                                    Phone = (string) reader["phone"],
                                    City = (string) reader["city"],
                                    CountryId = (int) reader["countryId"],
                                    Country = (string) reader["country"]
                                };
                                if (!reader.IsDBNull(reader.GetOrdinal("address2")))
                                {
                                    tempEmployee.Address2 = (string) reader["address2"];
                                } else
                                {
                                    tempEmployee.Address2 = string.Empty;
                                }
                                tempEmployeeList.Add(tempEmployee);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK);
            }
            Employees = tempEmployeeList;
            return Employees;
        }

        public bool AttemptLogin(ResourceManager rm, string usernameTxtBox, string passwordTxtBox)
        {
            bool success;
            try
            {
                string username = "", password = "";
                var sql = $"SELECT [userName],[password] FROM [imsdb].[dbo].[user] WHERE [userName]='{usernameTxtBox}'";
                using (SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["IMSDB"].ConnectionString))
                {
                    var cmd = new SqlCommand(sql, _connection);
                    _connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                username = reader["userName"].ToString();
                                password = reader["password"].ToString();
                            }
                        }
                    }
                }
                if (!username.Equals(usernameTxtBox) || !password.Equals(passwordTxtBox))
                {
                    MessageBox.Show(rm.GetString("ErrorMessage"), "", MessageBoxButtons.OK);
                    success = false;
                }
                else
                {
                    success = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK);
                success = false;
            }
            return success;
        }
    }
}
