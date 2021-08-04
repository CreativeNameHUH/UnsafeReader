
namespace UnsafeReader
{
    partial class MainForm
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
            this.ProcessNameBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GetProcessButton = new System.Windows.Forms.Button();
            this.MemoryAddressBox = new System.Windows.Forms.TextBox();
            this.NumberOfBytesBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MemoryDumpBox = new System.Windows.Forms.TextBox();
            this.NewValueBox = new System.Windows.Forms.TextBox();
            this.WriteButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProcessNameBox
            // 
            this.ProcessNameBox.Location = new System.Drawing.Point(3, 3);
            this.ProcessNameBox.Name = "ProcessNameBox";
            this.ProcessNameBox.Size = new System.Drawing.Size(214, 20);
            this.ProcessNameBox.TabIndex = 0;
            this.ProcessNameBox.Text = "Process name";
            // 
            // SearchButton
            // 
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(223, 29);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 20);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.NewValueBox);
            this.panel1.Controls.Add(this.WriteButton);
            this.panel1.Controls.Add(this.GetProcessButton);
            this.panel1.Controls.Add(this.MemoryAddressBox);
            this.panel1.Controls.Add(this.NumberOfBytesBox);
            this.panel1.Controls.Add(this.ProcessNameBox);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 55);
            this.panel1.TabIndex = 2;
            // 
            // GetProcessButton
            // 
            this.GetProcessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetProcessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetProcessButton.Location = new System.Drawing.Point(223, 3);
            this.GetProcessButton.Name = "GetProcessButton";
            this.GetProcessButton.Size = new System.Drawing.Size(75, 20);
            this.GetProcessButton.TabIndex = 4;
            this.GetProcessButton.Text = "Get Process";
            this.GetProcessButton.UseVisualStyleBackColor = true;
            this.GetProcessButton.Click += new System.EventHandler(this.GetProcessButton_Click);
            // 
            // MemoryAddressBox
            // 
            this.MemoryAddressBox.Location = new System.Drawing.Point(3, 29);
            this.MemoryAddressBox.Name = "MemoryAddressBox";
            this.MemoryAddressBox.Size = new System.Drawing.Size(182, 20);
            this.MemoryAddressBox.TabIndex = 3;
            this.MemoryAddressBox.Text = "Memory Address";
            // 
            // NumberOfBytesBox
            // 
            this.NumberOfBytesBox.Location = new System.Drawing.Point(191, 29);
            this.NumberOfBytesBox.Name = "NumberOfBytesBox";
            this.NumberOfBytesBox.Size = new System.Drawing.Size(26, 20);
            this.NumberOfBytesBox.TabIndex = 2;
            this.NumberOfBytesBox.Text = "24";
            this.NumberOfBytesBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MemoryDumpBox);
            this.panel2.Location = new System.Drawing.Point(12, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 365);
            this.panel2.TabIndex = 3;
            // 
            // MemoryDumpBox
            // 
            this.MemoryDumpBox.Location = new System.Drawing.Point(3, 3);
            this.MemoryDumpBox.Multiline = true;
            this.MemoryDumpBox.Name = "MemoryDumpBox";
            this.MemoryDumpBox.ReadOnly = true;
            this.MemoryDumpBox.Size = new System.Drawing.Size(770, 359);
            this.MemoryDumpBox.TabIndex = 0;
            // 
            // NewValueBox
            // 
            this.NewValueBox.Location = new System.Drawing.Point(510, 29);
            this.NewValueBox.Name = "NewValueBox";
            this.NewValueBox.Size = new System.Drawing.Size(182, 20);
            this.NewValueBox.TabIndex = 7;
            this.NewValueBox.Text = "New Value";
            // 
            // WriteButton
            // 
            this.WriteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WriteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteButton.Location = new System.Drawing.Point(698, 29);
            this.WriteButton.Name = "WriteButton";
            this.WriteButton.Size = new System.Drawing.Size(75, 20);
            this.WriteButton.TabIndex = 5;
            this.WriteButton.Text = "Write";
            this.WriteButton.UseVisualStyleBackColor = true;
            this.WriteButton.Click += new System.EventHandler(this.WriteButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(698, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 20);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ProcessNameBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox NumberOfBytesBox;
        private System.Windows.Forms.TextBox MemoryAddressBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox MemoryDumpBox;
        private System.Windows.Forms.Button GetProcessButton;
        private System.Windows.Forms.TextBox NewValueBox;
        private System.Windows.Forms.Button WriteButton;
        private System.Windows.Forms.Button ClearButton;
    }
}