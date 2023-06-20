using Microsoft.Data.SqlClient;

namespace Products
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Shop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();

            foreach (string line in System.IO.File.ReadAllLines
             (@"E:\shop\categories.txt"))
            {
                string[] subs = line.Split(';');
                SqlCommand cmd = new SqlCommand($"INSERT INTO Categories (Name, Slug) values (N'{subs[0]}' , N'{subs[1]}'  )", con);

                cmd.ExecuteNonQuery();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Shop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();

            foreach (string line in System.IO.File.ReadAllLines
             (@"E:\shop\products.txt"))
            {
                string[] subs = line.Split(';');
                SqlCommand cmd = new SqlCommand($"INSERT INTO Products (Name, Slug, Description, Price, CategoryId, Image) values (N'{subs[0]}' , N'{subs[1]}', N'{subs[2]}' , N'{subs[3]}', N'{subs[4]}' , N'{subs[5]}'  )", con);

                cmd.ExecuteNonQuery();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Shop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE from [Categories]", con);

            cmd.ExecuteNonQuery();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Shop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE from [Products]", con);

            cmd.ExecuteNonQuery();
        }
    }
}