namespace Soroban
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_Islem = new System.Windows.Forms.TextBox();
            this.btn_Coz = new System.Windows.Forms.Button();
            this.btn_ileri = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_ilk = new System.Windows.Forms.Button();
            this.btn_son = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(29, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(579, 287);
            this.dataGridView1.TabIndex = 0;
            // 
            // tb_Islem
            // 
            this.tb_Islem.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_Islem.Location = new System.Drawing.Point(29, 34);
            this.tb_Islem.Name = "tb_Islem";
            this.tb_Islem.Size = new System.Drawing.Size(640, 53);
            this.tb_Islem.TabIndex = 1;
            // 
            // btn_Coz
            // 
            this.btn_Coz.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Coz.Location = new System.Drawing.Point(701, 37);
            this.btn_Coz.Name = "btn_Coz";
            this.btn_Coz.Size = new System.Drawing.Size(102, 50);
            this.btn_Coz.TabIndex = 2;
            this.btn_Coz.Text = "ÇÖZ";
            this.btn_Coz.UseVisualStyleBackColor = true;
            this.btn_Coz.Click += new System.EventHandler(this.btn_Coz_Click);
            // 
            // btn_ileri
            // 
            this.btn_ileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ileri.Location = new System.Drawing.Point(857, 206);
            this.btn_ileri.Name = "btn_ileri";
            this.btn_ileri.Size = new System.Drawing.Size(141, 64);
            this.btn_ileri.TabIndex = 3;
            this.btn_ileri.Text = "İleri";
            this.btn_ileri.UseVisualStyleBackColor = true;
            this.btn_ileri.Click += new System.EventHandler(this.btn_ileri_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.Location = new System.Drawing.Point(647, 206);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(141, 64);
            this.btn_geri.TabIndex = 4;
            this.btn_geri.Text = "Geri";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_ilk
            // 
            this.btn_ilk.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ilk.Location = new System.Drawing.Point(647, 288);
            this.btn_ilk.Name = "btn_ilk";
            this.btn_ilk.Size = new System.Drawing.Size(141, 64);
            this.btn_ilk.TabIndex = 6;
            this.btn_ilk.Text = "İLK";
            this.btn_ilk.UseVisualStyleBackColor = true;
            this.btn_ilk.Click += new System.EventHandler(this.btn_ilk_Click);
            // 
            // btn_son
            // 
            this.btn_son.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_son.Location = new System.Drawing.Point(857, 288);
            this.btn_son.Name = "btn_son";
            this.btn_son.Size = new System.Drawing.Size(141, 64);
            this.btn_son.TabIndex = 5;
            this.btn_son.Text = "SON";
            this.btn_son.UseVisualStyleBackColor = true;
            this.btn_son.Click += new System.EventHandler(this.btn_son_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 460);
            this.Controls.Add(this.btn_ilk);
            this.Controls.Add(this.btn_son);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_ileri);
            this.Controls.Add(this.btn_Coz);
            this.Controls.Add(this.tb_Islem);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_Islem;
        private System.Windows.Forms.Button btn_Coz;
        private System.Windows.Forms.Button btn_ileri;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_ilk;
        private System.Windows.Forms.Button btn_son;
    }
}

