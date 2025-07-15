namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelTitle = new System.Windows.Forms.Label();
            this.takim_id = new System.Windows.Forms.Label();
            this.paket_sayaci = new System.Windows.Forms.Label();
            this.irtifa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gps_boylam = new System.Windows.Forms.Label();
            this.gps_enlem = new System.Windows.Forms.Label();
            this.gps_irtifa = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gorev_boylam = new System.Windows.Forms.Label();
            this.gorev_enlem = new System.Windows.Forms.Label();
            this.gorev_irtifa = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.J_Z = new System.Windows.Forms.Label();
            this.J_Y = new System.Windows.Forms.Label();
            this.J_X = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.İvme_Z = new System.Windows.Forms.Label();
            this.İvme_Y = new System.Windows.Forms.Label();
            this.İvme_X = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.labelID = new System.Windows.Forms.Label();
            this.labelCounter = new System.Windows.Forms.Label();
            this.labelAltitude = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Impact", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTitle.Location = new System.Drawing.Point(41, 35);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(638, 68);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "HYPERMACH YER İSTASYONU";
            // 
            // takim_id
            // 
            this.takim_id.AutoSize = true;
            this.takim_id.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.takim_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.takim_id.Location = new System.Drawing.Point(46, 158);
            this.takim_id.Name = "takim_id";
            this.takim_id.Size = new System.Drawing.Size(134, 39);
            this.takim_id.TabIndex = 1;
            this.takim_id.Text = "Takım ID:";
            // 
            // paket_sayaci
            // 
            this.paket_sayaci.AutoSize = true;
            this.paket_sayaci.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.paket_sayaci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.paket_sayaci.Location = new System.Drawing.Point(48, 206);
            this.paket_sayaci.Name = "paket_sayaci";
            this.paket_sayaci.Size = new System.Drawing.Size(195, 39);
            this.paket_sayaci.TabIndex = 2;
            this.paket_sayaci.Text = "Paket Sayacı :";
            // 
            // irtifa
            // 
            this.irtifa.AutoSize = true;
            this.irtifa.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.irtifa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.irtifa.Location = new System.Drawing.Point(48, 260);
            this.irtifa.Name = "irtifa";
            this.irtifa.Size = new System.Drawing.Size(87, 39);
            this.irtifa.TabIndex = 3;
            this.irtifa.Text = "İrtifa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 39);
            this.label4.TabIndex = 5;
            this.label4.Text = "GPS Enlem:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(6, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 39);
            this.label5.TabIndex = 4;
            this.label5.Text = "GPS İrtifa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(8, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 39);
            this.label6.TabIndex = 10;
            this.label6.Text = "Jiroskop X:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(6, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(272, 39);
            this.label7.TabIndex = 9;
            this.label7.Text = "Görev Yükü Boylam:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(6, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(254, 39);
            this.label8.TabIndex = 8;
            this.label8.Text = "Görev Yükü Enlem:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(6, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(239, 39);
            this.label9.TabIndex = 7;
            this.label9.Text = "Görev Yükü İrtifa:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(6, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 39);
            this.label10.TabIndex = 6;
            this.label10.Text = "GPS Boylam:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(8, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 39);
            this.label14.TabIndex = 11;
            this.label14.Text = "Jiroskop Y:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(8, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 39);
            this.label11.TabIndex = 13;
            this.label11.Text = "İvme  X:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(8, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 39);
            this.label12.TabIndex = 12;
            this.label12.Text = "Jiroskop Z:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(6, 182);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 39);
            this.label13.TabIndex = 15;
            this.label13.Text = "İvme  Z:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(8, 117);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 39);
            this.label15.TabIndex = 14;
            this.label15.Text = "İvme  Y:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.comboBox1.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "deneme"});
            this.comboBox1.Location = new System.Drawing.Point(1020, 365);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(273, 47);
            this.comboBox1.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gps_boylam);
            this.groupBox1.Controls.Add(this.gps_enlem);
            this.groupBox1.Controls.Add(this.gps_irtifa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(53, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 204);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GPS";
            // 
            // gps_boylam
            // 
            this.gps_boylam.AutoSize = true;
            this.gps_boylam.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gps_boylam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gps_boylam.Location = new System.Drawing.Point(175, 145);
            this.gps_boylam.Name = "gps_boylam";
            this.gps_boylam.Size = new System.Drawing.Size(68, 39);
            this.gps_boylam.TabIndex = 9;
            this.gps_boylam.Text = "Veri";
            // 
            // gps_enlem
            // 
            this.gps_enlem.AutoSize = true;
            this.gps_enlem.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gps_enlem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gps_enlem.Location = new System.Drawing.Point(174, 94);
            this.gps_enlem.Name = "gps_enlem";
            this.gps_enlem.Size = new System.Drawing.Size(68, 39);
            this.gps_enlem.TabIndex = 8;
            this.gps_enlem.Text = "Veri";
            // 
            // gps_irtifa
            // 
            this.gps_irtifa.AutoSize = true;
            this.gps_irtifa.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gps_irtifa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gps_irtifa.Location = new System.Drawing.Point(174, 40);
            this.gps_irtifa.Name = "gps_irtifa";
            this.gps_irtifa.Size = new System.Drawing.Size(68, 39);
            this.gps_irtifa.TabIndex = 7;
            this.gps_irtifa.Text = "Veri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gorev_boylam);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.gorev_enlem);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.gorev_irtifa);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(53, 559);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 235);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GÖREV YÜKÜ";
            // 
            // gorev_boylam
            // 
            this.gorev_boylam.AutoSize = true;
            this.gorev_boylam.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gorev_boylam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gorev_boylam.Location = new System.Drawing.Point(273, 182);
            this.gorev_boylam.Name = "gorev_boylam";
            this.gorev_boylam.Size = new System.Drawing.Size(68, 39);
            this.gorev_boylam.TabIndex = 12;
            this.gorev_boylam.Text = "Veri";
            // 
            // gorev_enlem
            // 
            this.gorev_enlem.AutoSize = true;
            this.gorev_enlem.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gorev_enlem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gorev_enlem.Location = new System.Drawing.Point(273, 117);
            this.gorev_enlem.Name = "gorev_enlem";
            this.gorev_enlem.Size = new System.Drawing.Size(68, 39);
            this.gorev_enlem.TabIndex = 11;
            this.gorev_enlem.Text = "Veri";
            // 
            // gorev_irtifa
            // 
            this.gorev_irtifa.AutoSize = true;
            this.gorev_irtifa.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gorev_irtifa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gorev_irtifa.Location = new System.Drawing.Point(273, 51);
            this.gorev_irtifa.Name = "gorev_irtifa";
            this.gorev_irtifa.Size = new System.Drawing.Size(68, 39);
            this.gorev_irtifa.TabIndex = 10;
            this.gorev_irtifa.Text = "Veri";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.J_Z);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.J_Y);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.J_X);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(494, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 204);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "JİROSKOP";
            // 
            // J_Z
            // 
            this.J_Z.AutoSize = true;
            this.J_Z.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.J_Z.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.J_Z.Location = new System.Drawing.Point(167, 145);
            this.J_Z.Name = "J_Z";
            this.J_Z.Size = new System.Drawing.Size(68, 39);
            this.J_Z.TabIndex = 12;
            this.J_Z.Text = "Veri";
            // 
            // J_Y
            // 
            this.J_Y.AutoSize = true;
            this.J_Y.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.J_Y.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.J_Y.Location = new System.Drawing.Point(166, 94);
            this.J_Y.Name = "J_Y";
            this.J_Y.Size = new System.Drawing.Size(68, 39);
            this.J_Y.TabIndex = 11;
            this.J_Y.Text = "Veri";
            // 
            // J_X
            // 
            this.J_X.AutoSize = true;
            this.J_X.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.J_X.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.J_X.Location = new System.Drawing.Point(166, 40);
            this.J_X.Name = "J_X";
            this.J_X.Size = new System.Drawing.Size(68, 39);
            this.J_X.TabIndex = 10;
            this.J_X.Text = "Veri";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.İvme_Z);
            this.groupBox4.Controls.Add(this.İvme_Y);
            this.groupBox4.Controls.Add(this.İvme_X);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.Color.Red;
            this.groupBox4.Location = new System.Drawing.Point(494, 559);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(378, 235);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İVME";
            // 
            // İvme_Z
            // 
            this.İvme_Z.AutoSize = true;
            this.İvme_Z.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İvme_Z.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.İvme_Z.Location = new System.Drawing.Point(128, 182);
            this.İvme_Z.Name = "İvme_Z";
            this.İvme_Z.Size = new System.Drawing.Size(68, 39);
            this.İvme_Z.TabIndex = 18;
            this.İvme_Z.Text = "Veri";
            // 
            // İvme_Y
            // 
            this.İvme_Y.AutoSize = true;
            this.İvme_Y.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İvme_Y.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.İvme_Y.Location = new System.Drawing.Point(129, 117);
            this.İvme_Y.Name = "İvme_Y";
            this.İvme_Y.Size = new System.Drawing.Size(68, 39);
            this.İvme_Y.TabIndex = 17;
            this.İvme_Y.Text = "Veri";
            // 
            // İvme_X
            // 
            this.İvme_X.AutoSize = true;
            this.İvme_X.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İvme_X.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.İvme_X.Location = new System.Drawing.Point(128, 53);
            this.İvme_X.Name = "İvme_X";
            this.İvme_X.Size = new System.Drawing.Size(68, 39);
            this.İvme_X.TabIndex = 16;
            this.İvme_X.Text = "Veri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1165, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(1013, 323);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(146, 39);
            this.label16.TabIndex = 21;
            this.label16.Text = "COM PORT";
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonConnect.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonConnect.FlatAppearance.BorderSize = 0;
            this.buttonConnect.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonConnect.Location = new System.Drawing.Point(1020, 504);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(273, 61);
            this.buttonConnect.TabIndex = 22;
            this.buttonConnect.Text = "Port Aç";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDisconnect.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonDisconnect.FlatAppearance.BorderSize = 0;
            this.buttonDisconnect.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDisconnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDisconnect.Location = new System.Drawing.Point(1020, 610);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(273, 61);
            this.buttonDisconnect.TabIndex = 23;
            this.buttonDisconnect.Text = "Port Kapa";
            this.buttonDisconnect.UseVisualStyleBackColor = false;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelID.Location = new System.Drawing.Point(186, 158);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(68, 39);
            this.labelID.TabIndex = 10;
            this.labelID.Text = "Veri";
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCounter.Location = new System.Drawing.Point(245, 206);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(68, 39);
            this.labelCounter.TabIndex = 24;
            this.labelCounter.Text = "Veri";
            // 
            // labelAltitude
            // 
            this.labelAltitude.AutoSize = true;
            this.labelAltitude.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAltitude.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelAltitude.Location = new System.Drawing.Point(141, 260);
            this.labelAltitude.Name = "labelAltitude";
            this.labelAltitude.Size = new System.Drawing.Size(68, 39);
            this.labelAltitude.TabIndex = 25;
            this.labelAltitude.Text = "Veri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1328, 859);
            this.Controls.Add(this.labelAltitude);
            this.Controls.Add(this.labelCounter);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.irtifa);
            this.Controls.Add(this.paket_sayaci);
            this.Controls.Add(this.takim_id);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "Hypermach Yer İstasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label takim_id;
        private System.Windows.Forms.Label paket_sayaci;
        private System.Windows.Forms.Label irtifa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label gps_irtifa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Label gps_boylam;
        private System.Windows.Forms.Label gps_enlem;
        private System.Windows.Forms.Label gorev_boylam;
        private System.Windows.Forms.Label gorev_enlem;
        private System.Windows.Forms.Label gorev_irtifa;
        private System.Windows.Forms.Label J_Z;
        private System.Windows.Forms.Label J_Y;
        private System.Windows.Forms.Label J_X;
        private System.Windows.Forms.Label İvme_Z;
        private System.Windows.Forms.Label İvme_Y;
        private System.Windows.Forms.Label İvme_X;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.Label labelAltitude;
    }
}

