using BLL;
using Entitys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UsersManeger use=new UsersManeger();
        Users users = new Users();
        private void btn_add_Click(object sender, EventArgs e)
        {
            if(txt_tc.Text!=null&& txt_name.Text!=null&&txt_surname.Text!=null&&
                masked_txt_time.Text!=null&&masked_txt_GSM.Text!=null&&txt_email.Text!=null
                && txt_cars.Text != null)
            {
                users.TC = txt_tc.Text;
                users.date = dateTimePicker1.Value;
                users.name = txt_name.Text;
                users.surname = txt_surname.Text;
                users.time = masked_txt_time.Text;
                users.GSM = masked_txt_GSM.Text;
                users.email = txt_email.Text;
                users.cars = txt_cars.Text;

                use.İnsert(users);

                Clear();

                MessageBox.Show("Rezervasyon işlemi tamamlandı!");
            }
            else
            {
                MessageBox.Show("Bütün alanlar zorunludur! Doldurunuz!");
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void Clear()
        {
            txt_tc.Clear();
            txt_name.Clear();
            txt_surname.Clear();
            masked_txt_time.Clear();
            masked_txt_GSM.Clear();
            txt_email.Clear();
            txt_cars.Items.Clear();
        }
    }
}
