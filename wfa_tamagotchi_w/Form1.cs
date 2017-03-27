using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_tamagotchi_w
{
    public partial class frm_main : Form
    {
        cls_tama Tama = new cls_tama();

        public frm_main()
        {
            InitializeComponent();
        }

        private void lbl_weight_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_age_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            Tama.age = 0;
            Tama.discipline = 5;
            Tama.happiness = 100;
            Tama.hunger = 100;
            Tama.lightstatus = false;
            Tama.sickness = false;
            Tama.sleepstatus = false;
            Tama.weight = 2;

            pgb_happy.Value = 100;
            pgb_hungry.Value = 100;

            lbl_age.Text = Tama.age.ToString();
            lbl_weight.Text = Tama.weight.ToString();

        }

        private void tmr_meds_Tick(object sender, EventArgs e)
        {
            lbl_status.Text = "Your Tamagotchi is sick af, dawg";
            Tama.sickness = true;
        }

        private void btn_givemedi_Click(object sender, EventArgs e)
        {
            try
            {
                Tama.sickness = false;
                lbl_status.Text = "Your Tamagotchi feels well again.";
            }
            catch (Exception)
            {
            }
        }

        private void tmr_pooInTheLoo_Tick(object sender, EventArgs e)
        {
            lbl_status.Text = "Your Tamagotchi pooped!";
            Tama.designatedshitlevels = true;
        }

        private void btn_gototoilet_Click(object sender, EventArgs e)
        {
            try
            {
                Tama.designatedshitlevels = false;
                lbl_status.Text = "Your Tamagotchi feels well again.";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tmr_food_Tick(object sender, EventArgs e)
        {
            Tama.hunger = Tama.hunger - 1;
        }

        private void tmr_fun_Tick(object sender, EventArgs e)
        {
            Tama.happiness = Tama.happiness - 1;
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            try
            {
                Tama.happiness = Tama.happiness + 20;
            }
            catch (Exception ex)
            {

                lbl_status.Text = ex.Message;
            }
        }
    }
}
