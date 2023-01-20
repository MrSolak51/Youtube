using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;

namespace Ogrenci_Otomasyon
{
    public partial class Form1 : Form
    {
        public ArrayList student_name = new ArrayList(){ "Ahmet","Mustafa","Melisa","Ayşe","Fırat","Fadime","Temel","Dursun","Ela","Esra" };
        public ArrayList student_surname = new ArrayList() { "Durmaz", "Tokluoğlu", "Erenler", "Alemdar", "Haçan", "Kal", "Git", "Göz", "Algören", "Turgut" };
        public ArrayList student_number = new ArrayList() { "00000", "00001", "00002", "00003", "00004", "00005", "00006", "00007", "00008", "00009" };
        public ArrayList student_info = new ArrayList();
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0;i<student_name.Count;i++)
            {
                student_info.Add(student_name[i] + " " + student_surname[i] + " " + student_number[i]);
            }
            foreach (string sn in student_info)
            {
                student_list.Items.Add(sn);
            }
        }

        // add student
        private void add_student_Click(object sender, EventArgs e)
        {
            student_name.Add(student_name);
            student_surname.Add(student_surname_text.Text);
            student_number.Add(student_number_text.Text);
            student_info.Add(student_name[student_surname.Count-1] + " " + student_surname[student_surname.Count - 1] + " " + student_number[student_surname.Count - 1]);
            student_list.Items.Add(student_info[student_info.Count-1]);
        }

        private void student_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                student_update_name_text.Text = student_name[student_list.SelectedIndex].ToString();
                student_update_surname_text.Text = student_surname[student_list.SelectedIndex].ToString();
                student_update_number_text.Text = student_number[student_list.SelectedIndex].ToString();
                delete_student.Enabled = true;
                delete_student.BackColor = Color.DarkRed;
                delete_student.ForeColor = Color.White;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
        }

        private void update_student_Click(object sender, EventArgs e)
        {
            student_name[student_list.SelectedIndex] = student_update_name_text.Text;
            student_surname[student_list.SelectedIndex] = student_update_surname_text.Text;
            student_number[student_list.SelectedIndex] = student_update_number_text.Text;
            student_info[student_list.SelectedIndex] = student_name[student_list.SelectedIndex] + " " + student_surname[student_list.SelectedIndex] + " " + student_number[student_list.SelectedIndex];
            student_list.Items.Clear();
            foreach (string sn in student_info)
            {
                student_list.Items.Add(sn);
            }
        }

        private void delete_student_Click(object sender, EventArgs e)
        {
            student_name.RemoveAt(student_list.SelectedIndex);
            student_surname.RemoveAt(student_list.SelectedIndex);
            student_number.RemoveAt(student_list.SelectedIndex);
            student_info.RemoveAt(student_list.SelectedIndex);
            student_list.Items.Clear();
            foreach (string sn in student_info)
            {
                student_list.Items.Add(sn);
            }
            student_update_name_text.Text = "";
            student_update_surname_text.Text = "";
            student_update_number_text.Text = "";
            delete_student.Enabled = false;
            delete_student.BackColor = Color.Transparent;
        }

        private void github_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/MrSolak51?tab=repositories");
        }

        private void playstore_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://play.google.com/store/apps/dev?id=8068675830237888072");
        }
    }
}
