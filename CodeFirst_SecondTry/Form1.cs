using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace CodeFirst_SecondTry
{
    public partial class Form1 : Form
    {
        STUDENT std = new STUDENT();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            // TODO: This line of code loads data into the 'dataSet1.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.dataSet1.STUDENT);
            this.reset();
        }

           //This Function to fill grid view with data in my database 
        void PopulateGridView()
        {
            dataGridView1.AutoGenerateColumns = false;

            using (School ctx = new School())
            {
                dataGridView1.DataSource = ctx.STUDENTs.ToList<STUDENT>();

            }
        }


        // to Serialize data
        void Serialize()
        {
            using (var ctx = new School())
            {

                List<STUDENT> std_list = new List<STUDENT>();
                std_list = ctx.STUDENTs.ToList<STUDENT>();
                JsonSerializer j = new JsonSerializer();
                if(File.Exists(Environment.CurrentDirectory + "\\data.txt"))
                {
                    File.Delete(Environment.CurrentDirectory + "\\data.txt");
                }
                StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "\\data.txt");
                JsonWriter jsonwriter = new JsonTextWriter(sw);
                j.Serialize(jsonwriter, std_list);
                jsonwriter.Close();
                sw.Close();
            }
        }
        


        //i made this function to handle all operations of CRUD
        public void AUD (int state)
        {
            string msg = "";
            switch (state)
            {
                case 0:     //insert
                    msg = "Inserted Successfully";
                    std.ID = decimal.Parse(id_txt.Text.Trim());
                    std.FIRSTNAME = f_name_txt.Text.Trim();
                    std.LASTNAME = l_name_txt.Text.Trim();
                    std.ADDRESS = address_txt.Text.Trim();
                    std.CITY = city_txt.Text.Trim();

                    break;
                case 1:   //update
                    std.ID = decimal.Parse(id_txt.Text.Trim());
                    std.FIRSTNAME = f_name_txt.Text.Trim();
                    std.LASTNAME = l_name_txt.Text.Trim();
                    std.ADDRESS = address_txt.Text.Trim();
                    std.CITY = city_txt.Text.Trim();
                    msg = "Updated Successfully";

                    break;
                case 2:   //delete
                    msg = "Deleted Successfully";
                    
                    break;
            }
            using (School ctx = new School())
            {
                if(state==0)   //In case of inserting new row
                {
                    ctx.STUDENTs.Add(std);
                }
                else if(state == 1) //In case of updating existing row
                {
                    ctx.Entry(std).State = EntityState.Modified;
                }
                else if(state ==2)  //In Case of Deleting Existing Row
                {
                    
                    if (MessageBox.Show("Are You Sure to delete this?", "EF CRUD Operations", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        var entry = ctx.Entry(std);
                        if(entry.State==EntityState.Detached)
                        {
                            ctx.STUDENTs.Attach(std);
                        }
                        ctx.STUDENTs.Remove(std);
                    }
                }
                ctx.SaveChanges();
            }
            MessageBox.Show(msg);
            this.reset();
            this.PopulateGridView();

        }

        private void ext(object sender, EventArgs e)
        {

        }


          //this when click on Insert Button
        private void insert_btn_Click(object sender, EventArgs e)
        {
            if (id_txt.Text == "" || f_name_txt.Text == "" || l_name_txt.Text == "" || address_txt.Text == "" || city_txt.Text == "")
            {
                MessageBox.Show("Some Required data doesn't Exist !!");
                this.reset();
            }
            else
            {
                this.AUD(0);

            }
        }
          
          //this when click on reset button
        private void reset_btn_Click(object sender, EventArgs e)
        {
            this.reset();
        }

          //this function to reset all form text boxes
        void reset()
        {
            id_txt.Text = f_name_txt.Text = l_name_txt.Text = address_txt.Text = city_txt.Text = "";
            delete_btn.Enabled = false;
            insert_btn.Enabled = true;
            update_btn.Enabled = false;
        }


        // this to handle when double click on a row in data grid view
        //it will fetch the data to the text boxes
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow.Index != -1)
            {
                std.ID = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["idd"].Value);
                using (School ctx = new School())
                {
                    std = ctx.STUDENTs.Where(x => x.ID == std.ID).FirstOrDefault();
                    id_txt.Text = Convert.ToString(std.ID);
                    f_name_txt.Text = std.FIRSTNAME;
                    l_name_txt.Text = std.LASTNAME;
                    address_txt.Text = std.ADDRESS;
                    city_txt.Text = std.CITY;
                }
                delete_btn.Enabled = true;
                insert_btn.Enabled = false;
                update_btn.Enabled = true;
            }
        }


          //when click on update button
        private void update_btn_Click(object sender, EventArgs e)
        {
            this.AUD(1);
        }

           
          //when click on delete button 
        private void delete_btn_Click(object sender, EventArgs e)
        {
            this.AUD(2);
        }

        private void ser_btn_Click(object sender, EventArgs e)
        {
            this.Serialize();
            MessageBox.Show("Data Serialized Successfully in data file");
        }


        //De Serialization button
        private void button1_Click(object sender, EventArgs e)
        {
                string filepath = Environment.CurrentDirectory + "\\data.txt";
                List<STUDENT> list = null;
                JsonSerializer j = new JsonSerializer();
                if (File.Exists(filepath))
                {
                    StreamReader sr = new StreamReader(filepath);
                    JsonReader jr = new JsonTextReader(sr);
                    list = j.Deserialize<List<STUDENT>>(jr);
                    sr.Close();
                    jr.Close();
                   if(list==null)
                    {
                        MessageBox.Show("List is empty");

                    }
                else
                    {
                        MessageBox.Show("De Serialized Successfully");
                        dataGridView1.DataSource = list;
                    }
                        
                }
                    else
                {
                    MessageBox.Show("Unable to find file defined !!");

                }

        }
    }
}
