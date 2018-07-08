namespace PMAppGUI
{
    partial class StatusCreateForm
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
            this.buttonCreateStatus = new System.Windows.Forms.Button();
            this.labelSetStatusName = new System.Windows.Forms.Label();
            this.textBoxSetStatusName = new System.Windows.Forms.TextBox();
            this.headingCreateStatus = new System.Windows.Forms.Label();
            this.labelOrder = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.numericOrder = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonSetColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateStatus
            // 
            this.buttonCreateStatus.Location = new System.Drawing.Point(100, 428);
            this.buttonCreateStatus.Name = "buttonCreateStatus";
            this.buttonCreateStatus.Size = new System.Drawing.Size(175, 37);
            this.buttonCreateStatus.TabIndex = 7;
            this.buttonCreateStatus.Text = "Add";
            this.buttonCreateStatus.UseVisualStyleBackColor = true;
            this.buttonCreateStatus.Click += new System.EventHandler(this.ButtonCreateStatus_Click);
            // 
            // labelSetStatusName
            // 
            this.labelSetStatusName.AutoSize = true;
            this.labelSetStatusName.Location = new System.Drawing.Point(18, 67);
            this.labelSetStatusName.Name = "labelSetStatusName";
            this.labelSetStatusName.Size = new System.Drawing.Size(30, 13);
            this.labelSetStatusName.TabIndex = 6;
            this.labelSetStatusName.Text = "Title:";
            // 
            // textBoxSetStatusName
            // 
            this.textBoxSetStatusName.Location = new System.Drawing.Point(120, 64);
            this.textBoxSetStatusName.Name = "textBoxSetStatusName";
            this.textBoxSetStatusName.Size = new System.Drawing.Size(227, 20);
            this.textBoxSetStatusName.TabIndex = 5;
            // 
            // headingCreateStatus
            // 
            this.headingCreateStatus.AutoSize = true;
            this.headingCreateStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingCreateStatus.Location = new System.Drawing.Point(17, 18);
            this.headingCreateStatus.Name = "headingCreateStatus";
            this.headingCreateStatus.Size = new System.Drawing.Size(111, 24);
            this.headingCreateStatus.TabIndex = 4;
            this.headingCreateStatus.Text = "New status";
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Location = new System.Drawing.Point(21, 104);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(36, 13);
            this.labelOrder.TabIndex = 8;
            this.labelOrder.Text = "Order:";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(21, 139);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(34, 13);
            this.labelColor.TabIndex = 9;
            this.labelColor.Text = "Color:";
            // 
            // numericOrder
            // 
            this.numericOrder.Location = new System.Drawing.Point(120, 97);
            this.numericOrder.Name = "numericOrder";
            this.numericOrder.Size = new System.Drawing.Size(120, 20);
            this.numericOrder.TabIndex = 10;
            // 
            // buttonSetColor
            // 
            this.buttonSetColor.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonSetColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetColor.Location = new System.Drawing.Point(120, 139);
            this.buttonSetColor.Name = "buttonSetColor";
            this.buttonSetColor.Size = new System.Drawing.Size(25, 23);
            this.buttonSetColor.TabIndex = 11;
            this.buttonSetColor.UseVisualStyleBackColor = false;
            this.buttonSetColor.Click += new System.EventHandler(this.ButtonSetColor_Click);
            // 
            // StatusCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 482);
            this.Controls.Add(this.buttonSetColor);
            this.Controls.Add(this.numericOrder);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.buttonCreateStatus);
            this.Controls.Add(this.labelSetStatusName);
            this.Controls.Add(this.textBoxSetStatusName);
            this.Controls.Add(this.headingCreateStatus);
            this.Name = "StatusCreateForm";
            this.Text = "Add status";
            ((System.ComponentModel.ISupportInitialize)(this.numericOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateStatus;
        private System.Windows.Forms.Label labelSetStatusName;
        private System.Windows.Forms.TextBox textBoxSetStatusName;
        private System.Windows.Forms.Label headingCreateStatus;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.NumericUpDown numericOrder;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonSetColor;
    }
}