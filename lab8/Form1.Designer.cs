namespace lab8
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
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxLocality = new System.Windows.Forms.TextBox();
            this.textBoxGpa = new System.Windows.Forms.TextBox();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.checkBoxAccomodation = new System.Windows.Forms.CheckBox();
            this.checkBoxTransport = new System.Windows.Forms.CheckBox();
            this.groupBoxCampus = new System.Windows.Forms.GroupBox();
            this.radioButtonTituMaiorescu = new System.Windows.Forms.RadioButton();
            this.radioButtonCodrescu = new System.Windows.Forms.RadioButton();
            this.radioButtonTargusorCopou = new System.Windows.Forms.RadioButton();
            this.groupBoxCampus.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(81, 49);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(72, 16);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(78, 95);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(72, 16);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Locality";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "GPA";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(210, 42);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 22);
            this.textBoxFirstName.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(210, 89);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 22);
            this.textBoxLastName.TabIndex = 5;
            // 
            // textBoxLocality
            // 
            this.textBoxLocality.Location = new System.Drawing.Point(210, 141);
            this.textBoxLocality.Name = "textBoxLocality";
            this.textBoxLocality.Size = new System.Drawing.Size(100, 22);
            this.textBoxLocality.TabIndex = 6;
            // 
            // textBoxGpa
            // 
            this.textBoxGpa.Location = new System.Drawing.Point(210, 197);
            this.textBoxGpa.Name = "textBoxGpa";
            this.textBoxGpa.Size = new System.Drawing.Size(100, 22);
            this.textBoxGpa.TabIndex = 7;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(174, 358);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonInfo.TabIndex = 8;
            this.buttonInfo.Text = "Info";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(556, 73);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(10, 16);
            this.labelInfo.TabIndex = 9;
            this.labelInfo.Text = " ";
            // 
            // checkBoxAccomodation
            // 
            this.checkBoxAccomodation.AutoSize = true;
            this.checkBoxAccomodation.Location = new System.Drawing.Point(84, 266);
            this.checkBoxAccomodation.Name = "checkBoxAccomodation";
            this.checkBoxAccomodation.Size = new System.Drawing.Size(159, 20);
            this.checkBoxAccomodation.TabIndex = 10;
            this.checkBoxAccomodation.Text = "Needs accomodation";
            this.checkBoxAccomodation.UseVisualStyleBackColor = true;
            this.checkBoxAccomodation.CheckedChanged += new System.EventHandler(this.checkBoxAccomodation_CheckedChanged);
            // 
            // checkBoxTransport
            // 
            this.checkBoxTransport.AutoSize = true;
            this.checkBoxTransport.Location = new System.Drawing.Point(84, 302);
            this.checkBoxTransport.Name = "checkBoxTransport";
            this.checkBoxTransport.Size = new System.Drawing.Size(165, 20);
            this.checkBoxTransport.TabIndex = 11;
            this.checkBoxTransport.Text = "Needs transport facility";
            this.checkBoxTransport.UseVisualStyleBackColor = true;
            // 
            // groupBoxCampus
            // 
            this.groupBoxCampus.Controls.Add(this.radioButtonTargusorCopou);
            this.groupBoxCampus.Controls.Add(this.radioButtonCodrescu);
            this.groupBoxCampus.Controls.Add(this.radioButtonTituMaiorescu);
            this.groupBoxCampus.Location = new System.Drawing.Point(339, 266);
            this.groupBoxCampus.Name = "groupBoxCampus";
            this.groupBoxCampus.Size = new System.Drawing.Size(200, 100);
            this.groupBoxCampus.TabIndex = 12;
            this.groupBoxCampus.TabStop = false;
            this.groupBoxCampus.Text = "Campus";
            // 
            // radioButtonTituMaiorescu
            // 
            this.radioButtonTituMaiorescu.AutoSize = true;
            this.radioButtonTituMaiorescu.Location = new System.Drawing.Point(7, 22);
            this.radioButtonTituMaiorescu.Name = "radioButtonTituMaiorescu";
            this.radioButtonTituMaiorescu.Size = new System.Drawing.Size(116, 20);
            this.radioButtonTituMaiorescu.TabIndex = 0;
            this.radioButtonTituMaiorescu.TabStop = true;
            this.radioButtonTituMaiorescu.Text = "Titu Maiorescu";
            this.radioButtonTituMaiorescu.UseVisualStyleBackColor = true;
            this.radioButtonTituMaiorescu.CheckedChanged += new System.EventHandler(this.radioButtonTituMaiorescu_CheckedChanged);
            // 
            // radioButtonCodrescu
            // 
            this.radioButtonCodrescu.AutoSize = true;
            this.radioButtonCodrescu.Location = new System.Drawing.Point(7, 49);
            this.radioButtonCodrescu.Name = "radioButtonCodrescu";
            this.radioButtonCodrescu.Size = new System.Drawing.Size(86, 20);
            this.radioButtonCodrescu.TabIndex = 1;
            this.radioButtonCodrescu.TabStop = true;
            this.radioButtonCodrescu.Text = "Codrescu";
            this.radioButtonCodrescu.UseVisualStyleBackColor = true;
            this.radioButtonCodrescu.CheckedChanged += new System.EventHandler(this.radioButtonCodrescu_CheckedChanged);
            // 
            // radioButtonTargusorCopou
            // 
            this.radioButtonTargusorCopou.AutoSize = true;
            this.radioButtonTargusorCopou.Location = new System.Drawing.Point(7, 74);
            this.radioButtonTargusorCopou.Name = "radioButtonTargusorCopou";
            this.radioButtonTargusorCopou.Size = new System.Drawing.Size(126, 20);
            this.radioButtonTargusorCopou.TabIndex = 2;
            this.radioButtonTargusorCopou.TabStop = true;
            this.radioButtonTargusorCopou.Text = "Targusor Copou";
            this.radioButtonTargusorCopou.UseVisualStyleBackColor = true;
            this.radioButtonTargusorCopou.CheckedChanged += new System.EventHandler(this.radioButtonTargusorCopou_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxCampus);
            this.Controls.Add(this.checkBoxTransport);
            this.Controls.Add(this.checkBoxAccomodation);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.textBoxGpa);
            this.Controls.Add(this.textBoxLocality);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxCampus.ResumeLayout(false);
            this.groupBoxCampus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxLocality;
        private System.Windows.Forms.TextBox textBoxGpa;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.CheckBox checkBoxAccomodation;
        private System.Windows.Forms.CheckBox checkBoxTransport;
        private System.Windows.Forms.GroupBox groupBoxCampus;
        private System.Windows.Forms.RadioButton radioButtonTargusorCopou;
        private System.Windows.Forms.RadioButton radioButtonCodrescu;
        private System.Windows.Forms.RadioButton radioButtonTituMaiorescu;
    }
}

