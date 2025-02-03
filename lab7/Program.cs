using System.Data;
using System.Data.SqlClient;
using System.Formats.Asn1;
using System.Globalization;

//public class Client
//{
//    public int Id { get; set; }
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public string Email { get; set; }
//    public string Phone { get; set; }
//    public DateTime RegistrationDate { get; set; }
//}

//public class DatabaseManager
//{
//    private string connectionString = "your_connection_string";

//    public SqlConnection GetConnection()
//    {
//        return new SqlConnection(connectionString);
//    }

//    public void ExecuteNonQuery(string query, SqlParameter[] parameters)
//    {
//        using (var conn = GetConnection())
//        {
//            conn.Open();
//            using (var cmd = new SqlCommand(query, conn))
//            {
//                if (parameters != null) cmd.Parameters.AddRange(parameters);
//                cmd.ExecuteNonQuery();
//            }
//        }
//    }

//    public DataTable ExecuteReader(string query, SqlParameter[] parameters)
//    {
//        using (var conn = GetConnection())
//        {
//            conn.Open();
//            using (var cmd = new SqlCommand(query, conn))
//            {
//                if (parameters != null) cmd.Parameters.AddRange(parameters);
//                using (var adapter = new SqlDataAdapter(cmd))
//                {
//                    DataTable dt = new DataTable();
//                    adapter.Fill(dt);
//                    return dt;
//                }
//            }
//        }
//    }
//}

//public static class ValidationHelper
//{
//    public static bool IsValidEmail(string email)
//    {
//        return email.Contains("@");
//    }
//}

//public class ClientManager
//{
//    private DatabaseManager dbManager = new DatabaseManager();

//    public void AddClient(Client client)
//    {
//        if (!ValidationHelper.IsValidEmail(client.Email))
//        {
//            throw new Exception("Niepoprawny email");
//        }

//        string query = "INSERT INTO Klienci (Imie, Nazwisko, Email, Telefon) VALUES (@Imie, @Nazwisko, @Email, @Telefon)";
//        SqlParameter[] parameters = {
//            new SqlParameter("@Imie", client.FirstName),
//            new SqlParameter("@Nazwisko", client.LastName),
//            new SqlParameter("@Email", client.Email),
//            new SqlParameter("@Telefon", client.Phone)
//        };
//        dbManager.ExecuteNonQuery(query, parameters);
//    }

//    public List<Client> GetClients()
//    {
//        string query = "SELECT * FROM Klienci";
//        DataTable dt = dbManager.ExecuteReader(query, null);
//        List<Client> clients = new List<Client>();

//        foreach (DataRow row in dt.Rows)
//        {
//            clients.Add(new Client
//            {
//                Id = Convert.ToInt32(row["Id"]),
//                FirstName = row["Imie"].ToString(),
//                LastName = row["Nazwisko"].ToString(),
//                Email = row["Email"].ToString(),
//                Phone = row["Telefon"].ToString(),
//                RegistrationDate = Convert.ToDateTime(row["DataRejestracji"])
//            });
//        }
//        return clients;
//    }
//}

//ClientManager clientManager = new ClientManager();
//Console.WriteLine("Dodawanie nowego klienta");
//Client client = new Client
//{
//    FirstName = "Jan",
//    LastName = "Kowalski",
//    Email = "jan.kowalski@example.com",
//    Phone = "123456789"
//};
//clientManager.AddClient(client);

//Console.WriteLine("Lista klientów:");
//foreach (var c in clientManager.GetClients())
//{
//    Console.WriteLine($"{c.Id}: {c.FirstName} {c.LastName} - {c.Email}");
//}

//Zadanie 2

public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
}

public static void CreateCustomer(string filePath)
{
    var customers = ReadCustomers(filePath);
    var newCustomer = new Customer();

    Console.Write("Id: ");
    newCustomer.Id = int.Parse(Console.ReadLine());
    Console.Write("FirstName: ");
    newCustomer.FirstName = Console.ReadLine();
    Console.Write("LastName: ");
    newCustomer.LastName = Console.ReadLine();
    Console.Write("Email: ");
    newCustomer.Email = Console.ReadLine();
    Console.Write("Phone: ");
    newCustomer.Phone = Console.ReadLine();

    customers.Add(newCustomer);
    WriteCustomers(filePath, customers);
}

public static List<Customer> ReadCustomers(string filePath)
{
    using (var reader = new StreamReader(filePath))
    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
    {
        return csv.GetRecords<Customer>().ToList();
    }
}

public static void DisplayCustomers(string filePath)
{
    var customers = ReadCustomers(filePath);
    foreach (var customer in customers)
    {
        Console.WriteLine($"Id: {customer.Id}, Name: {customer.FirstName} {customer.LastName}, Email: {customer.Email}, Phone: {customer.Phone}");
    }
}

public static void UpdateCustomer(string filePath)
{
    var customers = ReadCustomers(filePath);

    Console.Write("Enter Customer ID to update: ");
    int id = int.Parse(Console.ReadLine());

    var customer = customers.FirstOrDefault(c => c.Id == id);
    if (customer != null)
    {
        Console.Write("New Phone: ");
        customer.Phone = Console.ReadLine();
        WriteCustomers(filePath, customers);
    }
    else
    {
        Console.WriteLine("Customer not found.");
    }
}


public static void DeleteCustomer(string filePath)
{
    var customers = ReadCustomers(filePath);

    Console.Write("Enter Customer ID to delete: ");
    int id = int.Parse(Console.ReadLine());

    var customer = customers.FirstOrDefault(c => c.Id == id);
    if (customer != null)
    {
        customers.Remove(customer);
        WriteCustomers(filePath, customers);
    }
    else
    {
        Console.WriteLine("Customer not found.");
    }
}

public static void WriteCustomers(string filePath, List<Customer> customers)
{
    using (var writer = new StreamWriter(filePath))
    using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
    {
        csv.WriteRecords(customers);
    }
}

string filePath = "customers.csv";
while (true)
{
    Console.WriteLine("1. Add Customer");
    Console.WriteLine("2. Display Customers");
    Console.WriteLine("3. Update Customer");
    Console.WriteLine("4. Delete Customer");
    Console.WriteLine("5. Exit");

    Console.Write("Select an option: ");
    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            CreateCustomer(filePath);
            break;
        case "2":
            DisplayCustomers(filePath);
            break;
        case "3":
            UpdateCustomer(filePath);
            break;
        case "4":
            DeleteCustomer(filePath);
            break;
        case "5":
            return;
        default:
            Console.WriteLine("Invalid choice, try again.");
            break;
    }
}