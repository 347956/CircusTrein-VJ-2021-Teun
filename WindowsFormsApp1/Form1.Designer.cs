
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
            this.btnHerbivorS = new System.Windows.Forms.Button();
            this.btnCarnivorL = new System.Windows.Forms.Button();
            this.btnCarnivorS = new System.Windows.Forms.Button();
            this.btnHerbivorM = new System.Windows.Forms.Button();
            this.HerbivorL = new System.Windows.Forms.Button();
            this.btnCarnivorM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbAnimalsToBeAdded = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbWagons = new System.Windows.Forms.ListBox();
            this.lbAnimalsInWagon = new System.Windows.Forms.ListBox();
            this.lblWagons = new System.Windows.Forms.Label();
            this.lblAnimalsInWagon = new System.Windows.Forms.Label();
            this.lblTotalWagons = new System.Windows.Forms.Label();
            this.lblTotalAnimals = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHerbivorS
            // 
            this.btnHerbivorS.Location = new System.Drawing.Point(6, 89);
            this.btnHerbivorS.Name = "btnHerbivorS";
            this.btnHerbivorS.Size = new System.Drawing.Size(96, 23);
            this.btnHerbivorS.TabIndex = 0;
            this.btnHerbivorS.Text = "Herbivor Small";
            this.btnHerbivorS.UseVisualStyleBackColor = true;
            this.btnHerbivorS.Click += new System.EventHandler(this.btnHerbivorS_Click);
            // 
            // btnCarnivorL
            // 
            this.btnCarnivorL.Location = new System.Drawing.Point(108, 31);
            this.btnCarnivorL.Name = "btnCarnivorL";
            this.btnCarnivorL.Size = new System.Drawing.Size(96, 23);
            this.btnCarnivorL.TabIndex = 1;
            this.btnCarnivorL.Text = "Carnivor Large";
            this.btnCarnivorL.UseVisualStyleBackColor = true;
            this.btnCarnivorL.Click += new System.EventHandler(this.btnCarnivorL_Click);
            // 
            // btnCarnivorS
            // 
            this.btnCarnivorS.Location = new System.Drawing.Point(108, 89);
            this.btnCarnivorS.Name = "btnCarnivorS";
            this.btnCarnivorS.Size = new System.Drawing.Size(96, 23);
            this.btnCarnivorS.TabIndex = 2;
            this.btnCarnivorS.Text = "Carnivor Small";
            this.btnCarnivorS.UseVisualStyleBackColor = true;
            this.btnCarnivorS.Click += new System.EventHandler(this.btnCarnivorS_Click);
            // 
            // btnHerbivorM
            // 
            this.btnHerbivorM.Location = new System.Drawing.Point(6, 60);
            this.btnHerbivorM.Name = "btnHerbivorM";
            this.btnHerbivorM.Size = new System.Drawing.Size(96, 23);
            this.btnHerbivorM.TabIndex = 3;
            this.btnHerbivorM.Text = "Herbivor Medium";
            this.btnHerbivorM.UseVisualStyleBackColor = true;
            this.btnHerbivorM.Click += new System.EventHandler(this.btnHerbivorM_Click);
            // 
            // HerbivorL
            // 
            this.HerbivorL.Location = new System.Drawing.Point(6, 31);
            this.HerbivorL.Name = "HerbivorL";
            this.HerbivorL.Size = new System.Drawing.Size(96, 23);
            this.HerbivorL.TabIndex = 4;
            this.HerbivorL.Text = "Herbivor Large";
            this.HerbivorL.UseVisualStyleBackColor = true;
            this.HerbivorL.Click += new System.EventHandler(this.HerbivorL_Click);
            // 
            // btnCarnivorM
            // 
            this.btnCarnivorM.Location = new System.Drawing.Point(108, 60);
            this.btnCarnivorM.Name = "btnCarnivorM";
            this.btnCarnivorM.Size = new System.Drawing.Size(96, 23);
            this.btnCarnivorM.TabIndex = 5;
            this.btnCarnivorM.Text = "Carnivor Medium";
            this.btnCarnivorM.UseVisualStyleBackColor = true;
            this.btnCarnivorM.Click += new System.EventHandler(this.btnCarnivorM_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Available Animals";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 428);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(198, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add to train";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbAnimalsToBeAdded
            // 
            this.lbAnimalsToBeAdded.FormattingEnabled = true;
            this.lbAnimalsToBeAdded.Location = new System.Drawing.Point(6, 145);
            this.lbAnimalsToBeAdded.Name = "lbAnimalsToBeAdded";
            this.lbAnimalsToBeAdded.Size = new System.Drawing.Size(198, 277);
            this.lbAnimalsToBeAdded.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Animals that will be added:";
            // 
            // lbWagons
            // 
            this.lbWagons.FormattingEnabled = true;
            this.lbWagons.Location = new System.Drawing.Point(266, 28);
            this.lbWagons.Name = "lbWagons";
            this.lbWagons.Size = new System.Drawing.Size(196, 394);
            this.lbWagons.TabIndex = 10;
            this.lbWagons.SelectedIndexChanged += new System.EventHandler(this.lbWagons_SelectedIndexChanged);
            // 
            // lbAnimalsInWagon
            // 
            this.lbAnimalsInWagon.FormattingEnabled = true;
            this.lbAnimalsInWagon.Location = new System.Drawing.Point(510, 28);
            this.lbAnimalsInWagon.Name = "lbAnimalsInWagon";
            this.lbAnimalsInWagon.Size = new System.Drawing.Size(196, 394);
            this.lbAnimalsInWagon.TabIndex = 11;
            this.lbAnimalsInWagon.SelectedIndexChanged += new System.EventHandler(this.lbAnimalsInWagon_SelectedIndexChanged);
            // 
            // lblWagons
            // 
            this.lblWagons.AutoSize = true;
            this.lblWagons.Location = new System.Drawing.Point(263, 12);
            this.lblWagons.Name = "lblWagons";
            this.lblWagons.Size = new System.Drawing.Size(50, 13);
            this.lblWagons.TabIndex = 12;
            this.lblWagons.Text = "Wagons:";
            // 
            // lblAnimalsInWagon
            // 
            this.lblAnimalsInWagon.AutoSize = true;
            this.lblAnimalsInWagon.Location = new System.Drawing.Point(507, 12);
            this.lblAnimalsInWagon.Name = "lblAnimalsInWagon";
            this.lblAnimalsInWagon.Size = new System.Drawing.Size(96, 13);
            this.lblAnimalsInWagon.TabIndex = 13;
            this.lblAnimalsInWagon.Text = "Animals In Wagon:";
            // 
            // lblTotalWagons
            // 
            this.lblTotalWagons.AutoSize = true;
            this.lblTotalWagons.Location = new System.Drawing.Point(712, 31);
            this.lblTotalWagons.Name = "lblTotalWagons";
            this.lblTotalWagons.Size = new System.Drawing.Size(86, 13);
            this.lblTotalWagons.TabIndex = 14;
            this.lblTotalWagons.Text = "Total Wagons: 0";
            // 
            // lblTotalAnimals
            // 
            this.lblTotalAnimals.AutoSize = true;
            this.lblTotalAnimals.Location = new System.Drawing.Point(712, 60);
            this.lblTotalAnimals.Name = "lblTotalAnimals";
            this.lblTotalAnimals.Size = new System.Drawing.Size(82, 13);
            this.lblTotalAnimals.TabIndex = 15;
            this.lblTotalAnimals.Text = "Total Animals: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 457);
            this.Controls.Add(this.lblTotalAnimals);
            this.Controls.Add(this.lblTotalWagons);
            this.Controls.Add(this.lblAnimalsInWagon);
            this.Controls.Add(this.lblWagons);
            this.Controls.Add(this.lbAnimalsInWagon);
            this.Controls.Add(this.lbWagons);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAnimalsToBeAdded);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCarnivorM);
            this.Controls.Add(this.HerbivorL);
            this.Controls.Add(this.btnHerbivorM);
            this.Controls.Add(this.btnCarnivorS);
            this.Controls.Add(this.btnCarnivorL);
            this.Controls.Add(this.btnHerbivorS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHerbivorS;
        private System.Windows.Forms.Button btnCarnivorL;
        private System.Windows.Forms.Button btnCarnivorS;
        private System.Windows.Forms.Button btnHerbivorM;
        private System.Windows.Forms.Button HerbivorL;
        private System.Windows.Forms.Button btnCarnivorM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbAnimalsToBeAdded;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbWagons;
        private System.Windows.Forms.ListBox lbAnimalsInWagon;
        private System.Windows.Forms.Label lblWagons;
        private System.Windows.Forms.Label lblAnimalsInWagon;
        private System.Windows.Forms.Label lblTotalWagons;
        private System.Windows.Forms.Label lblTotalAnimals;
    }
}

