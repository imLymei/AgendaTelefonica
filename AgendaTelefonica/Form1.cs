using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace AgendaTelefonica
{
    public partial class Form1 : Form
    {
        PhoneList phoneList = new PhoneList();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Name = txtName.Text;
            person.Number = txtNumber.Text;

            phoneList.Add(person);
            PhoneListView.Items.Add(new ListViewItem(new String[] {person.Name.ToString(), person.Number.ToString()}));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListStart();
        }

        public void ListStart()
        {
            PhoneListView.View = View.Details;
            PhoneListView.Columns.Add("Name");
            PhoneListView.Columns.Add("Phone");
            PhoneListView.GridLines = true;
            PhoneListView.Columns[0].Width = 269;
            PhoneListView.Columns[1].Width = 270;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Name = txtName.Text;
            person.Number = txtNumber.Text;

            phoneList.Add(person);
            PhoneListView.Items.Add(new ListViewItem(new String[] { person.Name.ToString(), person.Number.ToString() }));
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Person person = phoneList.FindPerson(txtName.Text);
            phoneList.Remove(person);
            PhoneListView.Clear();
            ListStart();
            foreach (Person person1 in phoneList.PersonList)
            {
                PhoneListView.Items.Add(new ListViewItem(new String[] { person1.Name.ToString(), person1.Number.ToString() }));
            }
        }
    }
}
