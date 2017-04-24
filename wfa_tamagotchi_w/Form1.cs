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
            //YO THIS FIRES 7 EVENTS

            //SEVEN
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

            tmr_ageIncr.Enabled = true;
            tmr_food.Enabled = true;
            tmr_fun.Enabled = true;
            tmr_meds.Enabled = true;
            tmr_pooInTheLoo.Enabled = true;
            //required for reasons, i guess

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
            try
            {
                Tama.hunger = Tama.hunger - 1;
                pgb_hungry.Value = Tama.hunger;
            }
            catch (Exception)
            {
            }

            if (Tama.hunger < 20)
            {
                lbl_status.Text = "Your Tamagotchi is very hungry.";
            }
        }

        private void tmr_fun_Tick(object sender, EventArgs e)
        {
            try
            {
                Tama.happiness = Tama.happiness - 1;
                pgb_happy.Value = Tama.happiness;
            }
            catch (Exception)
            {
            }

            if (Tama.happiness < 20)
            {
                lbl_status.Text = "Your Tamagotchi is unhappy.";
            }
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            try
            {
                Tama.happiness = Tama.happiness + 20;
                Tama.discipline = Tama.discipline - 1;
                trb_discipline.Value = Tama.discipline;
            }
            catch (Exception ex)
            {

                lbl_status.Text = ex.Message;
                
            }
            
        }

        private void btn_feed_Click(object sender, EventArgs e)
        {
            try
            {
                Tama.hunger = Tama.hunger + 20;
                pgb_hungry.Value = Tama.hunger;
            }
            catch (Exception ex)
            {

                lbl_status.Text = ex.Message;
            }

            Tama.weight = Tama.weight + 1;
            lbl_weight.Text = Tama.weight.ToString();
        }

        private void tmr_ageIncr_Tick(object sender, EventArgs e)
        {
            Tama.age = Tama.age + 1;
            lbl_age.Text = Tama.age.ToString();
        }

        private void btn_hit_Click(object sender, EventArgs e)
        {
            Tama.discipline = Tama.discipline + 2;
            trb_discipline.Value = Tama.discipline;

            Tama.happiness = Tama.happiness - 30;

            if (Tama.discipline < 2)
            {
                lbl_status.Text = "Your Tamagotchi does not listen to you anymore.";
            }
        }

        private void btn_lightoff_Click(object sender, EventArgs e)
        {
            tmr_ageIncr.Enabled = false;
            tmr_food.Enabled = false;
            tmr_fun.Enabled = false;
            tmr_meds.Enabled = false;
            tmr_pooInTheLoo.Enabled = false;

            lbl_status.Text = "Your Tamagotchi is asleep.";
        }

        private void btn_lighton_Click(object sender, EventArgs e)
        {
            tmr_ageIncr.Enabled = true;
            tmr_food.Enabled = true;
            tmr_fun.Enabled = true;
            tmr_meds.Enabled = true;
            tmr_pooInTheLoo.Enabled = true;

            lbl_status.Text = "Feeling fine.";
        }

        private void btn_givegzyklonb_Click(object sender, EventArgs e)
        {

            //how many layers of NSDAP r u on right now
            //maybe, 5 or 6 right now, my dude
            //you are like a little baby        //watch this
            lbl_status.Text = "ｇｅｎｏｃｉｄｅ";
            Application.Exit();

        }
    }
}
