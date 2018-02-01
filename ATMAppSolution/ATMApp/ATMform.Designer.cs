namespace ATMApp
{
    partial class ATMform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATMform));
            this.headerLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.depositeButton = new System.Windows.Forms.Button();
            this.withdrawlButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.depositeTextBox = new System.Windows.Forms.TextBox();
            this.confirmDepositeButton = new System.Windows.Forms.Button();
            this.myAmountLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.languageLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.britainPictureBox = new System.Windows.Forms.PictureBox();
            this.israelPictureBox = new System.Windows.Forms.PictureBox();
            this.languagePictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.britainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.israelPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(236, 20);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(197, 40);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = " Welcome! ";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(263, 112);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(161, 26);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.Text = "Enter Password Here";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(239, 87);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordLabel.Size = new System.Drawing.Size(211, 20);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Please Enter Your Password";
            // 
            // depositeButton
            // 
            this.depositeButton.Location = new System.Drawing.Point(484, 234);
            this.depositeButton.Name = "depositeButton";
            this.depositeButton.Size = new System.Drawing.Size(131, 51);
            this.depositeButton.TabIndex = 3;
            this.depositeButton.Text = "Deposite";
            this.depositeButton.UseVisualStyleBackColor = true;
            this.depositeButton.Visible = false;
            this.depositeButton.Click += new System.EventHandler(this.depositeButton_Click);
            // 
            // withdrawlButton
            // 
            this.withdrawlButton.Location = new System.Drawing.Point(84, 234);
            this.withdrawlButton.Name = "withdrawlButton";
            this.withdrawlButton.Size = new System.Drawing.Size(118, 51);
            this.withdrawlButton.TabIndex = 4;
            this.withdrawlButton.Text = "Withdrawl";
            this.withdrawlButton.UseVisualStyleBackColor = true;
            this.withdrawlButton.Visible = false;
            this.withdrawlButton.Click += new System.EventHandler(this.withdrawlButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(152, 110);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(89, 30);
            this.confirmButton.TabIndex = 5;
            this.confirmButton.Text = "ENTER";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // depositeTextBox
            // 
            this.depositeTextBox.Location = new System.Drawing.Point(283, 245);
            this.depositeTextBox.Name = "depositeTextBox";
            this.depositeTextBox.Size = new System.Drawing.Size(141, 26);
            this.depositeTextBox.TabIndex = 6;
            this.depositeTextBox.Text = "Enter amount in $";
            this.depositeTextBox.Visible = false;
            // 
            // confirmDepositeButton
            // 
            this.confirmDepositeButton.Location = new System.Drawing.Point(272, 290);
            this.confirmDepositeButton.Name = "confirmDepositeButton";
            this.confirmDepositeButton.Size = new System.Drawing.Size(161, 61);
            this.confirmDepositeButton.TabIndex = 7;
            this.confirmDepositeButton.Text = "Confirm Amount to Deposite";
            this.confirmDepositeButton.UseVisualStyleBackColor = true;
            this.confirmDepositeButton.Visible = false;
            this.confirmDepositeButton.Click += new System.EventHandler(this.confirmDepositeButton_Click);
            // 
            // myAmountLabel
            // 
            this.myAmountLabel.AutoSize = true;
            this.myAmountLabel.Location = new System.Drawing.Point(268, 172);
            this.myAmountLabel.Name = "myAmountLabel";
            this.myAmountLabel.Size = new System.Drawing.Size(51, 20);
            this.myAmountLabel.TabIndex = 9;
            this.myAmountLabel.Text = "label1";
            this.myAmountLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.myAmountLabel.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-4, 411);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(729, 24);
            this.progressBar1.TabIndex = 12;
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(585, 65);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(140, 20);
            this.languageLabel.TabIndex = 13;
            this.languageLabel.Text = "Choose Language";
            this.languageLabel.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::ATMApp.Properties.Resources.if_PayPal_73070;
            this.pictureBox3.Location = new System.Drawing.Point(549, 358);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ATMApp.Properties.Resources.if_mastercard_73069;
            this.pictureBox2.Location = new System.Drawing.Point(605, 358);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 50);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // britainPictureBox
            // 
            this.britainPictureBox.Image = global::ATMApp.Properties.Resources.if_United_Kingdom_Great_Britain__16014;
            this.britainPictureBox.Location = new System.Drawing.Point(656, 88);
            this.britainPictureBox.Name = "britainPictureBox";
            this.britainPictureBox.Size = new System.Drawing.Size(56, 50);
            this.britainPictureBox.TabIndex = 15;
            this.britainPictureBox.TabStop = false;
            this.britainPictureBox.Visible = false;
            this.britainPictureBox.Click += new System.EventHandler(this.britainPictureBox_Click);
            // 
            // israelPictureBox
            // 
            this.israelPictureBox.Image = global::ATMApp.Properties.Resources.if_Israel_92143;
            this.israelPictureBox.Location = new System.Drawing.Point(600, 87);
            this.israelPictureBox.Name = "israelPictureBox";
            this.israelPictureBox.Size = new System.Drawing.Size(50, 49);
            this.israelPictureBox.TabIndex = 14;
            this.israelPictureBox.TabStop = false;
            this.israelPictureBox.Visible = false;
            this.israelPictureBox.Click += new System.EventHandler(this.israelPictureBox_Click);
            // 
            // languagePictureBox
            // 
            this.languagePictureBox.Image = global::ATMApp.Properties.Resources.Globe;
            this.languagePictureBox.Location = new System.Drawing.Point(661, 12);
            this.languagePictureBox.Name = "languagePictureBox";
            this.languagePictureBox.Size = new System.Drawing.Size(100, 50);
            this.languagePictureBox.TabIndex = 11;
            this.languagePictureBox.TabStop = false;
            this.languagePictureBox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ATMApp.Properties.Resources.payment_card;
            this.pictureBox1.Location = new System.Drawing.Point(638, 358);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ATMform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(724, 435);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.britainPictureBox);
            this.Controls.Add(this.israelPictureBox);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.languagePictureBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.myAmountLabel);
            this.Controls.Add(this.confirmDepositeButton);
            this.Controls.Add(this.depositeTextBox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.withdrawlButton);
            this.Controls.Add(this.depositeButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.headerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ATMform";
            this.Text = "ATM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.britainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.israelPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button depositeButton;
        private System.Windows.Forms.Button withdrawlButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox depositeTextBox;
        private System.Windows.Forms.Button confirmDepositeButton;
        private System.Windows.Forms.Label myAmountLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox languagePictureBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.PictureBox israelPictureBox;
        private System.Windows.Forms.PictureBox britainPictureBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

