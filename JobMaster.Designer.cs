namespace EmpMenegement
{
    partial class JobMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobMaster));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmpiSoft = new System.Windows.Forms.Label();
            this.PlaceTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HomeButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.TimeTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DescriptionTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.JobsDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JobsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.EmpiSoft);
            this.panel1.Controls.Add(this.PlaceTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.EditButton);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.TimeTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DescriptionTb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NameTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.JobsDGV);
            this.panel1.Location = new System.Drawing.Point(12, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 517);
            this.panel1.TabIndex = 6;
            // 
            // EmpiSoft
            // 
            this.EmpiSoft.AutoSize = true;
            this.EmpiSoft.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpiSoft.ForeColor = System.Drawing.Color.Black;
            this.EmpiSoft.Location = new System.Drawing.Point(4, 20);
            this.EmpiSoft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmpiSoft.Name = "EmpiSoft";
            this.EmpiSoft.Size = new System.Drawing.Size(140, 26);
            this.EmpiSoft.TabIndex = 5;
            this.EmpiSoft.Text = "JobMeneger";
            // 
            // PlaceTb
            // 
            this.PlaceTb.BackColor = System.Drawing.Color.Gainsboro;
            this.PlaceTb.Location = new System.Drawing.Point(201, 330);
            this.PlaceTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlaceTb.Name = "PlaceTb";
            this.PlaceTb.Size = new System.Drawing.Size(118, 20);
            this.PlaceTb.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(197, 305);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Working Place";
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.SeaGreen;
            this.HomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.Location = new System.Drawing.Point(142, 441);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(106, 40);
            this.HomeButton.TabIndex = 36;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.SeaGreen;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(254, 384);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(106, 40);
            this.DeleteButton.TabIndex = 35;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.SeaGreen;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(142, 384);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(106, 40);
            this.EditButton.TabIndex = 34;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.SeaGreen;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(30, 384);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(106, 40);
            this.AddButton.TabIndex = 33;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // TimeTb
            // 
            this.TimeTb.BackColor = System.Drawing.Color.Gainsboro;
            this.TimeTb.Location = new System.Drawing.Point(60, 330);
            this.TimeTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TimeTb.Name = "TimeTb";
            this.TimeTb.Size = new System.Drawing.Size(118, 20);
            this.TimeTb.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(56, 305);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Working Time";
            // 
            // DescriptionTb
            // 
            this.DescriptionTb.BackColor = System.Drawing.Color.Gainsboro;
            this.DescriptionTb.Location = new System.Drawing.Point(182, 252);
            this.DescriptionTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DescriptionTb.Name = "DescriptionTb";
            this.DescriptionTb.Size = new System.Drawing.Size(137, 20);
            this.DescriptionTb.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(178, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Description";
            // 
            // NameTb
            // 
            this.NameTb.BackColor = System.Drawing.Color.Gainsboro;
            this.NameTb.Location = new System.Drawing.Point(60, 252);
            this.NameTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(105, 20);
            this.NameTb.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(56, 227);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Name";
            // 
            // JobsDGV
            // 
            this.JobsDGV.BackgroundColor = System.Drawing.Color.White;
            this.JobsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JobsDGV.Location = new System.Drawing.Point(366, 33);
            this.JobsDGV.Name = "JobsDGV";
            this.JobsDGV.Size = new System.Drawing.Size(563, 464);
            this.JobsDGV.TabIndex = 24;
            this.JobsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.JobsDGV_CellContentClick);
            // 
            // JobMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(965, 623);
            this.Controls.Add(this.panel1);
            this.Name = "JobMaster";
            this.Text = "JobMaster";
            this.Load += new System.EventHandler(this.JobMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JobsDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView JobsDGV;
        private System.Windows.Forms.Label EmpiSoft;
        private System.Windows.Forms.TextBox PlaceTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox TimeTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescriptionTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.Label label2;
    }
}