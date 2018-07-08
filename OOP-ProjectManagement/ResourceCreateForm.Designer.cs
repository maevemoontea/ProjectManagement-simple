namespace PMAppGUI
{
    partial class ResourceCreateForm
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
            this.buttonCreateRes = new System.Windows.Forms.Button();
            this.labelSetResName = new System.Windows.Forms.Label();
            this.textBoxSetResName = new System.Windows.Forms.TextBox();
            this.headingCreateResource = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSetResAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSetResSpec = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.avatarPreview = new System.Windows.Forms.PictureBox();
            this.textBoxSetResPhone = new System.Windows.Forms.MaskedTextBox();
            this.textBoxSetResEmail = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSetResImg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateRes
            // 
            this.buttonCreateRes.Location = new System.Drawing.Point(100, 428);
            this.buttonCreateRes.Name = "buttonCreateRes";
            this.buttonCreateRes.Size = new System.Drawing.Size(175, 37);
            this.buttonCreateRes.TabIndex = 7;
            this.buttonCreateRes.Text = "Create";
            this.buttonCreateRes.UseVisualStyleBackColor = true;
            this.buttonCreateRes.Click += new System.EventHandler(this.ButtonCreateRes_Click);
            // 
            // labelSetResName
            // 
            this.labelSetResName.AutoSize = true;
            this.labelSetResName.Location = new System.Drawing.Point(18, 71);
            this.labelSetResName.Name = "labelSetResName";
            this.labelSetResName.Size = new System.Drawing.Size(38, 13);
            this.labelSetResName.TabIndex = 6;
            this.labelSetResName.Text = "Name:";
            // 
            // textBoxSetResName
            // 
            this.textBoxSetResName.Location = new System.Drawing.Point(120, 64);
            this.textBoxSetResName.Name = "textBoxSetResName";
            this.textBoxSetResName.Size = new System.Drawing.Size(227, 20);
            this.textBoxSetResName.TabIndex = 5;
            // 
            // headingCreateResource
            // 
            this.headingCreateResource.AutoSize = true;
            this.headingCreateResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingCreateResource.Location = new System.Drawing.Point(17, 18);
            this.headingCreateResource.Name = "headingCreateResource";
            this.headingCreateResource.Size = new System.Drawing.Size(121, 24);
            this.headingCreateResource.TabIndex = 4;
            this.headingCreateResource.Text = "New worker";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Age:";
            // 
            // textBoxSetResAge
            // 
            this.textBoxSetResAge.Location = new System.Drawing.Point(120, 95);
            this.textBoxSetResAge.Name = "textBoxSetResAge";
            this.textBoxSetResAge.Size = new System.Drawing.Size(227, 20);
            this.textBoxSetResAge.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Specialization:";
            // 
            // comboBoxSetResSpec
            // 
            this.comboBoxSetResSpec.FormattingEnabled = true;
            this.comboBoxSetResSpec.Items.AddRange(new object[] {
            "Frontend developer",
            "Backend developer",
            "Designer",
            "QA",
            "Project manager"});
            this.comboBoxSetResSpec.Location = new System.Drawing.Point(120, 125);
            this.comboBoxSetResSpec.Name = "comboBoxSetResSpec";
            this.comboBoxSetResSpec.Size = new System.Drawing.Size(227, 21);
            this.comboBoxSetResSpec.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Avatar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Phone number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Contact info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "E-mail:";
            // 
            // avatarPreview
            // 
            this.avatarPreview.Location = new System.Drawing.Point(221, 187);
            this.avatarPreview.Name = "avatarPreview";
            this.avatarPreview.Size = new System.Drawing.Size(126, 125);
            this.avatarPreview.TabIndex = 17;
            this.avatarPreview.TabStop = false;
            // 
            // textBoxSetResPhone
            // 
            this.textBoxSetResPhone.Location = new System.Drawing.Point(120, 352);
            this.textBoxSetResPhone.Mask = "+38(999) 000-00-00";
            this.textBoxSetResPhone.Name = "textBoxSetResPhone";
            this.textBoxSetResPhone.Size = new System.Drawing.Size(227, 20);
            this.textBoxSetResPhone.TabIndex = 18;
            // 
            // textBoxSetResEmail
            // 
            this.textBoxSetResEmail.Location = new System.Drawing.Point(120, 383);
            this.textBoxSetResEmail.Name = "textBoxSetResEmail";
            this.textBoxSetResEmail.Size = new System.Drawing.Size(227, 20);
            this.textBoxSetResEmail.TabIndex = 19;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSetResImg
            // 
            this.btnSetResImg.Location = new System.Drawing.Point(120, 155);
            this.btnSetResImg.Name = "btnSetResImg";
            this.btnSetResImg.Size = new System.Drawing.Size(227, 24);
            this.btnSetResImg.TabIndex = 20;
            this.btnSetResImg.Text = "Upload file";
            this.btnSetResImg.UseVisualStyleBackColor = true;
            this.btnSetResImg.Click += new System.EventHandler(this.BtnSetResImg_Click);
            // 
            // ResourceCreateForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 482);
            this.Controls.Add(this.btnSetResImg);
            this.Controls.Add(this.textBoxSetResEmail);
            this.Controls.Add(this.textBoxSetResPhone);
            this.Controls.Add(this.avatarPreview);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSetResSpec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSetResAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCreateRes);
            this.Controls.Add(this.labelSetResName);
            this.Controls.Add(this.textBoxSetResName);
            this.Controls.Add(this.headingCreateResource);
            this.Name = "ResourceCreateForm";
            this.Text = "New resource";
            ((System.ComponentModel.ISupportInitialize)(this.avatarPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateRes;
        private System.Windows.Forms.Label labelSetResName;
        private System.Windows.Forms.TextBox textBoxSetResName;
        private System.Windows.Forms.Label headingCreateResource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSetResAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSetResSpec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox avatarPreview;
        private System.Windows.Forms.MaskedTextBox textBoxSetResPhone;
        private System.Windows.Forms.TextBox textBoxSetResEmail;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSetResImg;
    }
}