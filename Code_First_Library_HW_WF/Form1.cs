using RelationshipEF_LoadingDb_18._07_WF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_First_Library_HW_WF
{
    public partial class Form1 : Form
    {

        Controller controller = null;
        public Form1()
        {
            InitializeComponent();
            controller = new Controller();
            //  controller.IniBase();
            iniListBox1();

        }

        void iniListBox1()      //увы , по другому не получается создать подклдючение.
                                //Задам по етому поводу вопрос на паре. Пробовал через контроллер , не получается( 
        {
            listBox1.Items.Clear();
            
                foreach (var el in controller.GetBooks())
                {
                    
                    listBox1.Items.Add(el);

                } 
            
        }

        void AddBook(string name, int pages, string category, string author, string productionHouse)
        {
           
                controller.AddBook(name, pages, category, author, productionHouse);
                listBox1.Items.Clear();
                iniListBox1();
            
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {

            AddBook(textBox1.Text, int.Parse(textBox2.Text), textBox3.Text, textBox4.Text, textBox5.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Book bk = (Book)listBox1.SelectedItem;
            controller.DelBook(bk.Id);
            listBox1.Items.Clear();
            iniListBox1();

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            
            Book bk = (Book)listBox1.SelectedItem;
            int temp = bk.Id;
            bk = ChangingData(temp);
            controller.ChangeBook(bk);
            iniListBox1();
        }
        Book ChangingData(int id)
        {
            Dictionary<string, string> data =new Dictionary<string, string>();
            Form_Changing_Data form2 = new Form_Changing_Data(data);
            form2.ShowDialog();
            

            Book bk = new Book() 
            { 
                Id = id,
                Name = data["Name"],
                AmountPages = int.Parse(data["Pages"]),
                Category = new Category { Name = data["Category"] },
                Author = new Author() { Name = data["Author"] },
                ProductionHouse = new ProductionHouse {Name = data["ProductHouse"] }

             };

            return bk;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            Form_Search form_Search = new Form_Search(data);
            form_Search.ShowDialog();
            listBox1.Items.Clear();
            string searchText = "";

            using (controller.libraryContext = new LibraryContext())
            {

                if (data.ContainsKey("Name"))
                {
                    searchText = data["Name"];
                    foreach (var el in controller.SearchBookByName(searchText))
                    {
                        listBox1.Items.Add(el);
                    }

                }
                else if (data.ContainsKey("Category"))
                {
                    searchText = data["Category"];
                    foreach (var el in controller.SearchBookByCategory(searchText))
                    {
                        listBox1.Items.Add(el);
                    }

                }

                else if (data.ContainsKey("Author"))
                {
                    searchText = data["Author"];
                    foreach (var el in controller.SearchBookByAuthor(searchText))
                    {
                        listBox1.Items.Add(el);
                    }
                }

                else if (data.ContainsKey("ProductHouse"))
                {
                    searchText = data["PublishHouse"];
                    foreach (var el in controller.SearchBookByPublishHouse(searchText))
                    {
                        listBox1.Items.Add(el);
                    }
                }



            }    
                
        }



         

          

            
          




        }
    }

