namespace GamePuzzle
{
    partial class frmPuzzleGame
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
            this.components = new System.ComponentModel.Container();
            this.gbKhung = new System.Windows.Forms.GroupBox();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.pbx5 = new System.Windows.Forms.PictureBox();
            this.pbx6 = new System.Windows.Forms.PictureBox();
            this.pbx7 = new System.Windows.Forms.PictureBox();
            this.pbx8 = new System.Windows.Forms.PictureBox();
            this.pbx9 = new System.Windows.Forms.PictureBox();
            this.tmrThoiGianDem = new System.Windows.Forms.Timer(this.components);
            this.lblThoiGianDem = new System.Windows.Forms.Label();
            this.lblBuocDuyet = new System.Windows.Forms.Label();
            this.lblTimeGiai = new System.Windows.Forms.Label();
            this.lblBuocDi = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnChoiLai = new System.Windows.Forms.Button();
            this.btnTamDung = new System.Windows.Forms.Button();
            this.btnGiaiBFS = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGiaiToiUu = new System.Windows.Forms.Button();
            this.gbKhung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).BeginInit();
            this.SuspendLayout();
            // 
            // gbKhung
            // 
            this.gbKhung.Controls.Add(this.pbx1);
            this.gbKhung.Controls.Add(this.pbx2);
            this.gbKhung.Controls.Add(this.pbx3);
            this.gbKhung.Controls.Add(this.pbx4);
            this.gbKhung.Controls.Add(this.pbx5);
            this.gbKhung.Controls.Add(this.pbx6);
            this.gbKhung.Controls.Add(this.pbx7);
            this.gbKhung.Controls.Add(this.pbx8);
            this.gbKhung.Controls.Add(this.pbx9);
            this.gbKhung.Location = new System.Drawing.Point(13, 13);
            this.gbKhung.Name = "gbKhung";
            this.gbKhung.Size = new System.Drawing.Size(427, 433);
            this.gbKhung.TabIndex = 0;
            this.gbKhung.TabStop = false;
            this.gbKhung.Text = "Khung";
            // 
            // pbx1
            // 
            this.pbx1.Location = new System.Drawing.Point(17, 23);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(130, 130);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx1.TabIndex = 8;
            this.pbx1.TabStop = false;
            this.pbx1.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx2
            // 
            this.pbx2.Location = new System.Drawing.Point(149, 23);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(130, 130);
            this.pbx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx2.TabIndex = 7;
            this.pbx2.TabStop = false;
            this.pbx2.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx3
            // 
            this.pbx3.Location = new System.Drawing.Point(281, 23);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(130, 130);
            this.pbx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx3.TabIndex = 6;
            this.pbx3.TabStop = false;
            this.pbx3.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx4
            // 
            this.pbx4.Location = new System.Drawing.Point(17, 155);
            this.pbx4.Name = "pbx4";
            this.pbx4.Size = new System.Drawing.Size(130, 130);
            this.pbx4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx4.TabIndex = 5;
            this.pbx4.TabStop = false;
            this.pbx4.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx5
            // 
            this.pbx5.Location = new System.Drawing.Point(149, 155);
            this.pbx5.Name = "pbx5";
            this.pbx5.Size = new System.Drawing.Size(130, 130);
            this.pbx5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx5.TabIndex = 4;
            this.pbx5.TabStop = false;
            this.pbx5.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx6
            // 
            this.pbx6.Location = new System.Drawing.Point(281, 155);
            this.pbx6.Name = "pbx6";
            this.pbx6.Size = new System.Drawing.Size(130, 130);
            this.pbx6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx6.TabIndex = 3;
            this.pbx6.TabStop = false;
            this.pbx6.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx7
            // 
            this.pbx7.Location = new System.Drawing.Point(17, 287);
            this.pbx7.Name = "pbx7";
            this.pbx7.Size = new System.Drawing.Size(130, 130);
            this.pbx7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx7.TabIndex = 2;
            this.pbx7.TabStop = false;
            this.pbx7.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx8
            // 
            this.pbx8.Location = new System.Drawing.Point(149, 287);
            this.pbx8.Name = "pbx8";
            this.pbx8.Size = new System.Drawing.Size(130, 130);
            this.pbx8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx8.TabIndex = 1;
            this.pbx8.TabStop = false;
            this.pbx8.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // pbx9
            // 
            this.pbx9.Location = new System.Drawing.Point(281, 287);
            this.pbx9.Name = "pbx9";
            this.pbx9.Size = new System.Drawing.Size(130, 130);
            this.pbx9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx9.TabIndex = 0;
            this.pbx9.TabStop = false;
            this.pbx9.Click += new System.EventHandler(this.CachThucDiChuyen);
            // 
            // tmrThoiGianDem
            // 
            this.tmrThoiGianDem.Enabled = true;
            this.tmrThoiGianDem.Interval = 900;
            this.tmrThoiGianDem.Tick += new System.EventHandler(this.TinhThoiGian);
            // 
            // lblThoiGianDem
            // 
            this.lblThoiGianDem.AutoSize = true;
            this.lblThoiGianDem.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGianDem.Location = new System.Drawing.Point(611, 262);
            this.lblThoiGianDem.Name = "lblThoiGianDem";
            this.lblThoiGianDem.Size = new System.Drawing.Size(201, 60);
            this.lblThoiGianDem.TabIndex = 2;
            this.lblThoiGianDem.Text = "00:00:00";
            // 
            // lblBuocDuyet
            // 
            this.lblBuocDuyet.AutoSize = true;
            this.lblBuocDuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuocDuyet.Location = new System.Drawing.Point(617, 354);
            this.lblBuocDuyet.Name = "lblBuocDuyet";
            this.lblBuocDuyet.Size = new System.Drawing.Size(144, 20);
            this.lblBuocDuyet.TabIndex = 11;
            this.lblBuocDuyet.Text = "Số bước duyệt: 0";
            // 
            // lblTimeGiai
            // 
            this.lblTimeGiai.AutoSize = true;
            this.lblTimeGiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeGiai.Location = new System.Drawing.Point(617, 322);
            this.lblTimeGiai.Name = "lblTimeGiai";
            this.lblTimeGiai.Size = new System.Drawing.Size(183, 20);
            this.lblTimeGiai.TabIndex = 10;
            this.lblTimeGiai.Text = "Thời gian giải : 0.0 ms";
            // 
            // lblBuocDi
            // 
            this.lblBuocDi.AutoSize = true;
            this.lblBuocDi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuocDi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBuocDi.Location = new System.Drawing.Point(26, 466);
            this.lblBuocDi.Name = "lblBuocDi";
            this.lblBuocDi.Size = new System.Drawing.Size(108, 19);
            this.lblBuocDi.TabIndex = 12;
            this.lblBuocDi.Text = "Số Bước Đi: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "<< Đi lui";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(341, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 30);
            this.button2.TabIndex = 14;
            this.button2.Text = "Đi tiếp >>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnChoiLai
            // 
            this.btnChoiLai.Location = new System.Drawing.Point(463, 461);
            this.btnChoiLai.Name = "btnChoiLai";
            this.btnChoiLai.Size = new System.Drawing.Size(83, 30);
            this.btnChoiLai.TabIndex = 15;
            this.btnChoiLai.Text = "Chơi lại";
            this.btnChoiLai.UseVisualStyleBackColor = true;
            this.btnChoiLai.Click += new System.EventHandler(this.btnChoiLai_Click);
            // 
            // btnTamDung
            // 
            this.btnTamDung.Location = new System.Drawing.Point(552, 461);
            this.btnTamDung.Name = "btnTamDung";
            this.btnTamDung.Size = new System.Drawing.Size(83, 30);
            this.btnTamDung.TabIndex = 16;
            this.btnTamDung.Text = "Tạm dừng";
            this.btnTamDung.UseVisualStyleBackColor = true;
            this.btnTamDung.Click += new System.EventHandler(this.PauseOrResume);
            // 
            // btnGiaiBFS
            // 
            this.btnGiaiBFS.Location = new System.Drawing.Point(641, 461);
            this.btnGiaiBFS.Name = "btnGiaiBFS";
            this.btnGiaiBFS.Size = new System.Drawing.Size(83, 30);
            this.btnGiaiBFS.TabIndex = 17;
            this.btnGiaiBFS.Text = "Giải BFS";
            this.btnGiaiBFS.UseVisualStyleBackColor = true;
            this.btnGiaiBFS.Click += new System.EventHandler(this.btnGiaiBFS_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(819, 461);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(83, 30);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::GamePuzzle.Properties.Resources.original;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Location = new System.Drawing.Point(535, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 247);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hình gốc";
            // 
            // btnGiaiToiUu
            // 
            this.btnGiaiToiUu.Location = new System.Drawing.Point(730, 461);
            this.btnGiaiToiUu.Name = "btnGiaiToiUu";
            this.btnGiaiToiUu.Size = new System.Drawing.Size(83, 30);
            this.btnGiaiToiUu.TabIndex = 18;
            this.btnGiaiToiUu.Text = "Giải tối ưu";
            this.btnGiaiToiUu.UseVisualStyleBackColor = true;
            this.btnGiaiToiUu.Click += new System.EventHandler(this.btnGiaiToiUu_Click);
            // 
            // frmPuzzleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 559);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnGiaiToiUu);
            this.Controls.Add(this.btnGiaiBFS);
            this.Controls.Add(this.btnTamDung);
            this.Controls.Add(this.btnChoiLai);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblBuocDi);
            this.Controls.Add(this.lblBuocDuyet);
            this.Controls.Add(this.lblTimeGiai);
            this.Controls.Add(this.lblThoiGianDem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbKhung);
            this.Name = "frmPuzzleGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Puzzle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KiemTraThoatChuongTrinh);
            this.Load += new System.EventHandler(this.frmPuzzleGame_Load);
            this.gbKhung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKhung;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.PictureBox pbx5;
        private System.Windows.Forms.PictureBox pbx6;
        private System.Windows.Forms.PictureBox pbx7;
        private System.Windows.Forms.PictureBox pbx8;
        private System.Windows.Forms.PictureBox pbx9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer tmrThoiGianDem;
        private System.Windows.Forms.Label lblThoiGianDem;
        private System.Windows.Forms.Label lblBuocDuyet;
        private System.Windows.Forms.Label lblTimeGiai;
        private System.Windows.Forms.Label lblBuocDi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnChoiLai;
        private System.Windows.Forms.Button btnTamDung;
        private System.Windows.Forms.Button btnGiaiBFS;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnGiaiToiUu;
    }
}

