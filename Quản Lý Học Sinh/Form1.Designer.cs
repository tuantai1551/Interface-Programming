
namespace Quản_Lý_Học_Sinh
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rdLess = new System.Windows.Forms.RadioButton();
            this.rdGay = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.txtToan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDiemTrungBinh = new System.Windows.Forms.Label();
            this.lblXepLoai = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập họ và tên";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(267, 25);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(416, 38);
            this.txtTen.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(12, 91);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(618, 221);
            this.listBox1.TabIndex = 6;
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Location = new System.Drawing.Point(244, 464);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(247, 54);
            this.btnTinh.TabIndex = 7;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Giới tính";
            // 
            // rdLess
            // 
            this.rdLess.AutoSize = true;
            this.rdLess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdLess.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLess.Location = new System.Drawing.Point(366, 227);
            this.rdLess.Name = "rdLess";
            this.rdLess.Size = new System.Drawing.Size(96, 36);
            this.rdLess.TabIndex = 16;
            this.rdLess.TabStop = true;
            this.rdLess.Text = "Less";
            this.rdLess.UseVisualStyleBackColor = false;
            // 
            // rdGay
            // 
            this.rdGay.AutoSize = true;
            this.rdGay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdGay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGay.Location = new System.Drawing.Point(366, 161);
            this.rdGay.Name = "rdGay";
            this.rdGay.Size = new System.Drawing.Size(88, 36);
            this.rdGay.TabIndex = 15;
            this.rdGay.TabStop = true;
            this.rdGay.Text = "Gay";
            this.rdGay.UseVisualStyleBackColor = false;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNu.Location = new System.Drawing.Point(64, 227);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(72, 36);
            this.rdNu.TabIndex = 14;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = false;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNam.Location = new System.Drawing.Point(64, 161);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(95, 36);
            this.rdNam.TabIndex = 13;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = false;
            // 
            // txtToan
            // 
            this.txtToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToan.Location = new System.Drawing.Point(290, 318);
            this.txtToan.Name = "txtToan";
            this.txtToan.Size = new System.Drawing.Size(416, 38);
            this.txtToan.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nhập điểm toán";
            // 
            // txtLy
            // 
            this.txtLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLy.Location = new System.Drawing.Point(290, 362);
            this.txtLy.Name = "txtLy";
            this.txtLy.Size = new System.Drawing.Size(416, 38);
            this.txtLy.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nhập điểm lý";
            // 
            // txtHoa
            // 
            this.txtHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoa.Location = new System.Drawing.Point(290, 406);
            this.txtHoa.Name = "txtHoa";
            this.txtHoa.Size = new System.Drawing.Size(416, 38);
            this.txtHoa.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 32);
            this.label5.TabIndex = 21;
            this.label5.Text = "Nhập điểm hóa";
            // 
            // lblDiemTrungBinh
            // 
            this.lblDiemTrungBinh.AutoSize = true;
            this.lblDiemTrungBinh.BackColor = System.Drawing.Color.Orange;
            this.lblDiemTrungBinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemTrungBinh.Location = new System.Drawing.Point(38, 534);
            this.lblDiemTrungBinh.Name = "lblDiemTrungBinh";
            this.lblDiemTrungBinh.Size = new System.Drawing.Size(230, 32);
            this.lblDiemTrungBinh.TabIndex = 23;
            this.lblDiemTrungBinh.Text = "Điểm trung bình: ";
            // 
            // lblXepLoai
            // 
            this.lblXepLoai.AutoSize = true;
            this.lblXepLoai.BackColor = System.Drawing.Color.Orange;
            this.lblXepLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXepLoai.Location = new System.Drawing.Point(38, 598);
            this.lblXepLoai.Name = "lblXepLoai";
            this.lblXepLoai.Size = new System.Drawing.Size(134, 32);
            this.lblXepLoai.TabIndex = 24;
            this.lblXepLoai.Text = "Xếp loại: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(800, 653);
            this.Controls.Add(this.lblXepLoai);
            this.Controls.Add(this.lblDiemTrungBinh);
            this.Controls.Add(this.txtHoa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtToan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdLess);
            this.Controls.Add(this.rdGay);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdLess;
        private System.Windows.Forms.RadioButton rdGay;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.TextBox txtToan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDiemTrungBinh;
        private System.Windows.Forms.Label lblXepLoai;
    }
}

