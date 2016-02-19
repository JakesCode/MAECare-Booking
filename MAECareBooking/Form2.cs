using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web;
using System.Web.Script.Serialization;

namespace MAECareBooking
{
    public partial class Form2 : Form
    {
        public string chosen { get; set; }
        public Form2(string person)
        {
            InitializeComponent();
            chosen = person;
        }

        public Dictionary<string, string> people = new Dictionary<string, string>();
        private void Form2_Load(object sender, EventArgs e)
        {
            people = new JavaScriptSerializer()
                .Deserialize<Dictionary<string, string>>(File.ReadAllText(@"data.dat"));
            textBox1.Text = people[chosen];
            label1.Text = "Notes for " + chosen;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            people[chosen] = textBox1.Text;
            File.WriteAllText(@"data.dat", new JavaScriptSerializer().Serialize(people));
            this.Close();
        }
    }
}
