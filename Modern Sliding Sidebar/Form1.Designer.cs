namespace Modern_Sliding_Sidebar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Enable = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.Btn_Enable);
            this.panel1.Controls.Add(this.Btn_Add);
            this.panel1.Controls.Add(this.Btn_Update);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Btn_Delete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 589);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 99);
            this.panel2.TabIndex = 0;
            // 
            // Btn_Add
            // 
            this.Btn_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Add.BackColor = System.Drawing.Color.White;
            this.Btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Add.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Add.FlatAppearance.BorderSize = 0;
            this.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Add.Location = new System.Drawing.Point(3, 105);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Btn_Add.Size = new System.Drawing.Size(226, 68);
            this.Btn_Add.TabIndex = 1;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.UseVisualStyleBackColor = false;
            // 
            // Btn_Enable
            // 
            this.Btn_Enable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Enable.BackColor = System.Drawing.Color.White;
            this.Btn_Enable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Enable.Enabled = false;
            this.Btn_Enable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Enable.FlatAppearance.BorderSize = 0;
            this.Btn_Enable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Enable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Enable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Enable.Location = new System.Drawing.Point(2, 327);
            this.Btn_Enable.Name = "Btn_Enable";
            this.Btn_Enable.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Btn_Enable.Size = new System.Drawing.Size(226, 68);
            this.Btn_Enable.TabIndex = 2;
            this.Btn_Enable.Text = "Enable";
            this.Btn_Enable.UseVisualStyleBackColor = false;
            // 
            // Btn_Update
            // 
            this.Btn_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Update.BackColor = System.Drawing.Color.White;
            this.Btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Update.Enabled = false;
            this.Btn_Update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Update.FlatAppearance.BorderSize = 0;
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Update.Location = new System.Drawing.Point(0, 253);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Btn_Update.Size = new System.Drawing.Size(226, 68);
            this.Btn_Update.TabIndex = 3;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = false;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Delete.BackColor = System.Drawing.Color.White;
            this.Btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Delete.Enabled = false;
            this.Btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Delete.FlatAppearance.BorderSize = 0;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Delete.Location = new System.Drawing.Point(2, 179);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Btn_Delete.Size = new System.Drawing.Size(226, 68);
            this.Btn_Delete.TabIndex = 4;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(971, 589);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Enable;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Delete;
    }
}

