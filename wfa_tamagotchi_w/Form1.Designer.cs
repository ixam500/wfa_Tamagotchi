namespace wfa_tamagotchi_w
{
    partial class frm_main
{
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.pgb_happy = new System.Windows.Forms.ProgressBar();
            this.pgb_hungry = new System.Windows.Forms.ProgressBar();
            this.trb_discipline = new System.Windows.Forms.TrackBar();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.lbl_happy = new System.Windows.Forms.Label();
            this.lbl_hungry = new System.Windows.Forms.Label();
            this.lbl_discipline = new System.Windows.Forms.Label();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_feed = new System.Windows.Forms.Button();
            this.btn_hit = new System.Windows.Forms.Button();
            this.btn_lightoff = new System.Windows.Forms.Button();
            this.btn_lighton = new System.Windows.Forms.Button();
            this.btn_gototoilet = new System.Windows.Forms.Button();
            this.btn_givemedi = new System.Windows.Forms.Button();
            this.btn_givegzyklonb = new System.Windows.Forms.Button();
            this.gbx_treat = new System.Windows.Forms.GroupBox();
            this.gbx_stats = new System.Windows.Forms.GroupBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.pbx_aesthetics = new System.Windows.Forms.PictureBox();
            this.tmr_food = new System.Windows.Forms.Timer(this.components);
            this.tmr_fun = new System.Windows.Forms.Timer(this.components);
            this.tmr_pooInTheLoo = new System.Windows.Forms.Timer(this.components);
            this.tmr_meds = new System.Windows.Forms.Timer(this.components);
            this.tmr_ageIncr = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trb_discipline)).BeginInit();
            this.gbx_treat.SuspendLayout();
            this.gbx_stats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_aesthetics)).BeginInit();
            this.SuspendLayout();
            // 
            // pgb_happy
            // 
            this.pgb_happy.Location = new System.Drawing.Point(96, 9);
            this.pgb_happy.Name = "pgb_happy";
            this.pgb_happy.Size = new System.Drawing.Size(100, 23);
            this.pgb_happy.TabIndex = 0;
            // 
            // pgb_hungry
            // 
            this.pgb_hungry.Location = new System.Drawing.Point(96, 38);
            this.pgb_hungry.Name = "pgb_hungry";
            this.pgb_hungry.Size = new System.Drawing.Size(100, 23);
            this.pgb_hungry.TabIndex = 1;
            // 
            // trb_discipline
            // 
            this.trb_discipline.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.trb_discipline.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.trb_discipline.Enabled = false;
            this.trb_discipline.Location = new System.Drawing.Point(85, 68);
            this.trb_discipline.Name = "trb_discipline";
            this.trb_discipline.Size = new System.Drawing.Size(119, 45);
            this.trb_discipline.TabIndex = 3;
            this.trb_discipline.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trb_discipline.Value = 5;
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Location = new System.Drawing.Point(48, 147);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(34, 13);
            this.lbl_age.TabIndex = 4;
            this.lbl_age.Text = "(Alter)";
            this.lbl_age.TextChanged += new System.EventHandler(this.lbl_age_TextChanged);
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.Location = new System.Drawing.Point(48, 128);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(52, 13);
            this.lbl_weight.TabIndex = 5;
            this.lbl_weight.Text = "(Gewicht)";
            this.lbl_weight.TextChanged += new System.EventHandler(this.lbl_weight_TextChanged);
            // 
            // lbl_happy
            // 
            this.lbl_happy.AutoSize = true;
            this.lbl_happy.Location = new System.Drawing.Point(21, 14);
            this.lbl_happy.Name = "lbl_happy";
            this.lbl_happy.Size = new System.Drawing.Size(69, 13);
            this.lbl_happy.TabIndex = 6;
            this.lbl_happy.Text = "Glücksgefühl";
            // 
            // lbl_hungry
            // 
            this.lbl_hungry.AutoSize = true;
            this.lbl_hungry.Location = new System.Drawing.Point(48, 41);
            this.lbl_hungry.Name = "lbl_hungry";
            this.lbl_hungry.Size = new System.Drawing.Size(42, 13);
            this.lbl_hungry.TabIndex = 7;
            this.lbl_hungry.Text = "Hunger";
            // 
            // lbl_discipline
            // 
            this.lbl_discipline.AutoSize = true;
            this.lbl_discipline.Location = new System.Drawing.Point(45, 82);
            this.lbl_discipline.Name = "lbl_discipline";
            this.lbl_discipline.Size = new System.Drawing.Size(45, 13);
            this.lbl_discipline.TabIndex = 8;
            this.lbl_discipline.Text = "Disziplin";
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(202, 9);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(75, 23);
            this.btn_play.TabIndex = 9;
            this.btn_play.Text = "Spielen";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_feed
            // 
            this.btn_feed.Location = new System.Drawing.Point(202, 38);
            this.btn_feed.Name = "btn_feed";
            this.btn_feed.Size = new System.Drawing.Size(75, 23);
            this.btn_feed.TabIndex = 10;
            this.btn_feed.Text = "Füttern";
            this.btn_feed.UseVisualStyleBackColor = true;
            this.btn_feed.Click += new System.EventHandler(this.btn_feed_Click);
            // 
            // btn_hit
            // 
            this.btn_hit.Location = new System.Drawing.Point(202, 68);
            this.btn_hit.Name = "btn_hit";
            this.btn_hit.Size = new System.Drawing.Size(75, 45);
            this.btn_hit.TabIndex = 11;
            this.btn_hit.Text = "Schlagen";
            this.btn_hit.UseVisualStyleBackColor = true;
            this.btn_hit.Click += new System.EventHandler(this.btn_hit_Click);
            // 
            // btn_lightoff
            // 
            this.btn_lightoff.Location = new System.Drawing.Point(202, 147);
            this.btn_lightoff.Name = "btn_lightoff";
            this.btn_lightoff.Size = new System.Drawing.Size(75, 23);
            this.btn_lightoff.TabIndex = 12;
            this.btn_lightoff.Text = "Licht aus";
            this.btn_lightoff.UseVisualStyleBackColor = true;
            this.btn_lightoff.Click += new System.EventHandler(this.btn_lightoff_Click);
            // 
            // btn_lighton
            // 
            this.btn_lighton.Location = new System.Drawing.Point(202, 118);
            this.btn_lighton.Name = "btn_lighton";
            this.btn_lighton.Size = new System.Drawing.Size(75, 23);
            this.btn_lighton.TabIndex = 13;
            this.btn_lighton.Text = "Licht an";
            this.btn_lighton.UseVisualStyleBackColor = true;
            this.btn_lighton.Click += new System.EventHandler(this.btn_lighton_Click);
            // 
            // btn_gototoilet
            // 
            this.btn_gototoilet.Location = new System.Drawing.Point(6, 21);
            this.btn_gototoilet.Name = "btn_gototoilet";
            this.btn_gototoilet.Size = new System.Drawing.Size(181, 44);
            this.btn_gototoilet.TabIndex = 14;
            this.btn_gototoilet.Text = "auf Toilette gehen";
            this.btn_gototoilet.UseVisualStyleBackColor = true;
            this.btn_gototoilet.Click += new System.EventHandler(this.btn_gototoilet_Click);
            // 
            // btn_givemedi
            // 
            this.btn_givemedi.Location = new System.Drawing.Point(6, 70);
            this.btn_givemedi.Name = "btn_givemedi";
            this.btn_givemedi.Size = new System.Drawing.Size(181, 47);
            this.btn_givemedi.TabIndex = 15;
            this.btn_givemedi.Text = "Medizin geben";
            this.btn_givemedi.UseVisualStyleBackColor = true;
            this.btn_givemedi.Click += new System.EventHandler(this.btn_givemedi_Click);
            // 
            // btn_givegzyklonb
            // 
            this.btn_givegzyklonb.Location = new System.Drawing.Point(6, 123);
            this.btn_givegzyklonb.Name = "btn_givegzyklonb";
            this.btn_givegzyklonb.Size = new System.Drawing.Size(181, 32);
            this.btn_givegzyklonb.TabIndex = 16;
            this.btn_givegzyklonb.Text = "Zyklon B geben";
            this.btn_givegzyklonb.UseVisualStyleBackColor = true;
            this.btn_givegzyklonb.Click += new System.EventHandler(this.btn_givegzyklonb_Click);
            // 
            // gbx_treat
            // 
            this.gbx_treat.Controls.Add(this.btn_gototoilet);
            this.gbx_treat.Controls.Add(this.btn_givegzyklonb);
            this.gbx_treat.Controls.Add(this.btn_givemedi);
            this.gbx_treat.Location = new System.Drawing.Point(283, 9);
            this.gbx_treat.Name = "gbx_treat";
            this.gbx_treat.Size = new System.Drawing.Size(193, 161);
            this.gbx_treat.TabIndex = 17;
            this.gbx_treat.TabStop = false;
            this.gbx_treat.Text = "Bedürfnisse";
            // 
            // gbx_stats
            // 
            this.gbx_stats.Controls.Add(this.lbl_status);
            this.gbx_stats.Location = new System.Drawing.Point(13, 184);
            this.gbx_stats.Name = "gbx_stats";
            this.gbx_stats.Size = new System.Drawing.Size(463, 65);
            this.gbx_stats.TabIndex = 18;
            this.gbx_stats.TabStop = false;
            this.gbx_stats.Text = "Status";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(6, 20);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(157, 33);
            this.lbl_status.TabIndex = 19;
            this.lbl_status.Text = "Feeling fine.";
            // 
            // pbx_aesthetics
            // 
            this.pbx_aesthetics.Image = ((System.Drawing.Image)(resources.GetObject("pbx_aesthetics.Image")));
            this.pbx_aesthetics.Location = new System.Drawing.Point(482, 14);
            this.pbx_aesthetics.Name = "pbx_aesthetics";
            this.pbx_aesthetics.Size = new System.Drawing.Size(192, 320);
            this.pbx_aesthetics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_aesthetics.TabIndex = 19;
            this.pbx_aesthetics.TabStop = false;
            // 
            // tmr_food
            // 
            this.tmr_food.Enabled = true;
            this.tmr_food.Interval = 250;
            this.tmr_food.Tick += new System.EventHandler(this.tmr_food_Tick);
            // 
            // tmr_fun
            // 
            this.tmr_fun.Enabled = true;
            this.tmr_fun.Interval = 300;
            this.tmr_fun.Tick += new System.EventHandler(this.tmr_fun_Tick);
            // 
            // tmr_pooInTheLoo
            // 
            this.tmr_pooInTheLoo.Enabled = true;
            this.tmr_pooInTheLoo.Interval = 20000;
            this.tmr_pooInTheLoo.Tick += new System.EventHandler(this.tmr_pooInTheLoo_Tick);
            // 
            // tmr_meds
            // 
            this.tmr_meds.Enabled = true;
            this.tmr_meds.Interval = 15000;
            this.tmr_meds.Tick += new System.EventHandler(this.tmr_meds_Tick);
            // 
            // tmr_ageIncr
            // 
            this.tmr_ageIncr.Interval = 1000;
            this.tmr_ageIncr.Tick += new System.EventHandler(this.tmr_ageIncr_Tick);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 260);
            this.Controls.Add(this.pbx_aesthetics);
            this.Controls.Add(this.gbx_stats);
            this.Controls.Add(this.gbx_treat);
            this.Controls.Add(this.btn_lighton);
            this.Controls.Add(this.btn_lightoff);
            this.Controls.Add(this.btn_hit);
            this.Controls.Add(this.btn_feed);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.lbl_discipline);
            this.Controls.Add(this.lbl_hungry);
            this.Controls.Add(this.lbl_happy);
            this.Controls.Add(this.lbl_weight);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.trb_discipline);
            this.Controls.Add(this.pgb_hungry);
            this.Controls.Add(this.pgb_happy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_main";
            this.Text = "ａ ｅ ｓ ｔ ｈ ｅ ｔ ｉ ｃ";
            this.Load += new System.EventHandler(this.frm_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trb_discipline)).EndInit();
            this.gbx_treat.ResumeLayout(false);
            this.gbx_stats.ResumeLayout(false);
            this.gbx_stats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_aesthetics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ProgressBar pgb_happy;
    private System.Windows.Forms.ProgressBar pgb_hungry;
    private System.Windows.Forms.TrackBar trb_discipline;
    private System.Windows.Forms.Label lbl_age;
    private System.Windows.Forms.Label lbl_weight;
    private System.Windows.Forms.Label lbl_happy;
    private System.Windows.Forms.Label lbl_hungry;
    private System.Windows.Forms.Label lbl_discipline;
    private System.Windows.Forms.Button btn_play;
    private System.Windows.Forms.Button btn_feed;
    private System.Windows.Forms.Button btn_hit;
    private System.Windows.Forms.Button btn_lightoff;
    private System.Windows.Forms.Button btn_lighton;
    private System.Windows.Forms.Button btn_gototoilet;
    private System.Windows.Forms.Button btn_givemedi;
    private System.Windows.Forms.Button btn_givegzyklonb;
        private System.Windows.Forms.GroupBox gbx_treat;
        private System.Windows.Forms.GroupBox gbx_stats;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.PictureBox pbx_aesthetics;
        private System.Windows.Forms.Timer tmr_food;
        private System.Windows.Forms.Timer tmr_fun;
        private System.Windows.Forms.Timer tmr_pooInTheLoo;
        private System.Windows.Forms.Timer tmr_meds;
        private System.Windows.Forms.Timer tmr_ageIncr;
    }
}


