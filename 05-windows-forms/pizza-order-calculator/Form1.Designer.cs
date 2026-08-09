namespace Question_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPizzaHut = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.rdSmall = new System.Windows.Forms.RadioButton();
            this.rdMedium = new System.Windows.Forms.RadioButton();
            this.rdLarge = new System.Windows.Forms.RadioButton();
            this.rdThick = new System.Windows.Forms.RadioButton();
            this.rdThin = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.chkJalapeno = new System.Windows.Forms.CheckBox();
            this.chkSpinach = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.chkPineapple = new System.Windows.Forms.CheckBox();
            this.chkSheddedChicken = new System.Windows.Forms.CheckBox();
            this.chkMushroom = new System.Windows.Forms.CheckBox();
            this.chkDriedShrimp = new System.Windows.Forms.CheckBox();
            this.chkGroundedBeef = new System.Windows.Forms.CheckBox();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.txtAmountDue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl1.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblPizzaHut
            // 
            this.lblPizzaHut.AutoSize = true;
            this.lblPizzaHut.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaHut.Location = new System.Drawing.Point(331, 9);
            this.lblPizzaHut.Name = "lblPizzaHut";
            this.lblPizzaHut.Size = new System.Drawing.Size(294, 69);
            this.lblPizzaHut.TabIndex = 1;
            this.lblPizzaHut.Text = "Pizza Hut";
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.rdLarge);
            this.pnl1.Controls.Add(this.rdMedium);
            this.pnl1.Controls.Add(this.rdSmall);
            this.pnl1.Location = new System.Drawing.Point(12, 94);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(601, 57);
            this.pnl1.TabIndex = 2;
            // 
            // pnl2
            // 
            this.pnl2.Controls.Add(this.rdThin);
            this.pnl2.Controls.Add(this.rdThick);
            this.pnl2.Location = new System.Drawing.Point(12, 157);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(601, 49);
            this.pnl2.TabIndex = 3;
            // 
            // rdSmall
            // 
            this.rdSmall.AutoSize = true;
            this.rdSmall.Location = new System.Drawing.Point(19, 15);
            this.rdSmall.Name = "rdSmall";
            this.rdSmall.Size = new System.Drawing.Size(94, 20);
            this.rdSmall.TabIndex = 0;
            this.rdSmall.TabStop = true;
            this.rdSmall.Text = "Small(R20)";
            this.rdSmall.UseVisualStyleBackColor = true;
            // 
            // rdMedium
            // 
            this.rdMedium.AutoSize = true;
            this.rdMedium.Location = new System.Drawing.Point(229, 15);
            this.rdMedium.Name = "rdMedium";
            this.rdMedium.Size = new System.Drawing.Size(108, 20);
            this.rdMedium.TabIndex = 1;
            this.rdMedium.TabStop = true;
            this.rdMedium.Text = "Medium(R35)";
            this.rdMedium.UseVisualStyleBackColor = true;
            // 
            // rdLarge
            // 
            this.rdLarge.AutoSize = true;
            this.rdLarge.Location = new System.Drawing.Point(448, 15);
            this.rdLarge.Name = "rdLarge";
            this.rdLarge.Size = new System.Drawing.Size(95, 20);
            this.rdLarge.TabIndex = 2;
            this.rdLarge.TabStop = true;
            this.rdLarge.Text = "Large(R55)";
            this.rdLarge.UseVisualStyleBackColor = true;
            // 
            // rdThick
            // 
            this.rdThick.AutoSize = true;
            this.rdThick.Location = new System.Drawing.Point(55, 16);
            this.rdThick.Name = "rdThick";
            this.rdThick.Size = new System.Drawing.Size(86, 20);
            this.rdThick.TabIndex = 0;
            this.rdThick.TabStop = true;
            this.rdThick.Text = "Thick(R2)";
            this.rdThick.UseVisualStyleBackColor = true;
            // 
            // rdThin
            // 
            this.rdThin.AutoSize = true;
            this.rdThin.Location = new System.Drawing.Point(465, 16);
            this.rdThin.Name = "rdThin";
            this.rdThin.Size = new System.Drawing.Size(79, 20);
            this.rdThin.TabIndex = 1;
            this.rdThin.TabStop = true;
            this.rdThin.Text = "Thin(R1)";
            this.rdThin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkGroundedBeef);
            this.groupBox1.Controls.Add(this.chkDriedShrimp);
            this.groupBox1.Controls.Add(this.chkMushroom);
            this.groupBox1.Controls.Add(this.chkSheddedChicken);
            this.groupBox1.Controls.Add(this.chkPineapple);
            this.groupBox1.Controls.Add(this.chkExtraCheese);
            this.groupBox1.Controls.Add(this.chkSpinach);
            this.groupBox1.Controls.Add(this.chkJalapeno);
            this.groupBox1.Controls.Add(this.chkPepperoni);
            this.groupBox1.Location = new System.Drawing.Point(13, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 161);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Topping(each@R7)";
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(18, 32);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(92, 20);
            this.chkPepperoni.TabIndex = 0;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // chkJalapeno
            // 
            this.chkJalapeno.AutoSize = true;
            this.chkJalapeno.Location = new System.Drawing.Point(265, 32);
            this.chkJalapeno.Name = "chkJalapeno";
            this.chkJalapeno.Size = new System.Drawing.Size(86, 20);
            this.chkJalapeno.TabIndex = 1;
            this.chkJalapeno.Text = "Jalapeno";
            this.chkJalapeno.UseVisualStyleBackColor = true;
            // 
            // chkSpinach
            // 
            this.chkSpinach.AutoSize = true;
            this.chkSpinach.Location = new System.Drawing.Point(460, 32);
            this.chkSpinach.Name = "chkSpinach";
            this.chkSpinach.Size = new System.Drawing.Size(78, 20);
            this.chkSpinach.TabIndex = 2;
            this.chkSpinach.Text = "Spinach";
            this.chkSpinach.UseVisualStyleBackColor = true;
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Location = new System.Drawing.Point(18, 74);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(109, 20);
            this.chkExtraCheese.TabIndex = 3;
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            // 
            // chkPineapple
            // 
            this.chkPineapple.AutoSize = true;
            this.chkPineapple.Location = new System.Drawing.Point(265, 74);
            this.chkPineapple.Name = "chkPineapple";
            this.chkPineapple.Size = new System.Drawing.Size(91, 20);
            this.chkPineapple.TabIndex = 4;
            this.chkPineapple.Text = "Pineapple";
            this.chkPineapple.UseVisualStyleBackColor = true;
            // 
            // chkSheddedChicken
            // 
            this.chkSheddedChicken.AutoSize = true;
            this.chkSheddedChicken.Location = new System.Drawing.Point(460, 74);
            this.chkSheddedChicken.Name = "chkSheddedChicken";
            this.chkSheddedChicken.Size = new System.Drawing.Size(136, 20);
            this.chkSheddedChicken.TabIndex = 5;
            this.chkSheddedChicken.Text = "Shedded Chicken";
            this.chkSheddedChicken.UseVisualStyleBackColor = true;
            // 
            // chkMushroom
            // 
            this.chkMushroom.AutoSize = true;
            this.chkMushroom.Location = new System.Drawing.Point(18, 119);
            this.chkMushroom.Name = "chkMushroom";
            this.chkMushroom.Size = new System.Drawing.Size(92, 20);
            this.chkMushroom.TabIndex = 6;
            this.chkMushroom.Text = "Mushroom";
            this.chkMushroom.UseVisualStyleBackColor = true;
            // 
            // chkDriedShrimp
            // 
            this.chkDriedShrimp.AutoSize = true;
            this.chkDriedShrimp.Location = new System.Drawing.Point(265, 119);
            this.chkDriedShrimp.Name = "chkDriedShrimp";
            this.chkDriedShrimp.Size = new System.Drawing.Size(107, 20);
            this.chkDriedShrimp.TabIndex = 7;
            this.chkDriedShrimp.Text = "Dried Shrimp";
            this.chkDriedShrimp.UseVisualStyleBackColor = true;
            // 
            // chkGroundedBeef
            // 
            this.chkGroundedBeef.AutoSize = true;
            this.chkGroundedBeef.Location = new System.Drawing.Point(460, 119);
            this.chkGroundedBeef.Name = "chkGroundedBeef";
            this.chkGroundedBeef.Size = new System.Drawing.Size(120, 20);
            this.chkGroundedBeef.TabIndex = 8;
            this.chkGroundedBeef.Text = "Grounded Beef";
            this.chkGroundedBeef.UseVisualStyleBackColor = true;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Location = new System.Drawing.Point(125, 422);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(102, 16);
            this.lblAmountDue.TabIndex = 5;
            this.lblAmountDue.Text = "Amount Due: R  ";
            // 
            // txtAmountDue
            // 
            this.txtAmountDue.Location = new System.Drawing.Point(295, 422);
            this.txtAmountDue.Name = "txtAmountDue";
            this.txtAmountDue.Size = new System.Drawing.Size(100, 22);
            this.txtAmountDue.TabIndex = 7;
            this.txtAmountDue.TextChanged += new System.EventHandler(this.txtAmountDue_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAmountDue);
            this.Controls.Add(this.lblAmountDue);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.lblPizzaHut);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPizzaHut;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.RadioButton rdLarge;
        private System.Windows.Forms.RadioButton rdMedium;
        private System.Windows.Forms.RadioButton rdSmall;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.RadioButton rdThin;
        private System.Windows.Forms.RadioButton rdThick;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkGroundedBeef;
        private System.Windows.Forms.CheckBox chkDriedShrimp;
        private System.Windows.Forms.CheckBox chkMushroom;
        private System.Windows.Forms.CheckBox chkSheddedChicken;
        private System.Windows.Forms.CheckBox chkPineapple;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.CheckBox chkSpinach;
        private System.Windows.Forms.CheckBox chkJalapeno;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.TextBox txtAmountDue;
    }
}

