﻿
namespace WindowsFormsApp1
{
    partial class KetQua
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
            this.lvKetQua = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLuaChon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvKetQua
            // 
            this.lvKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvKetQua.HideSelection = false;
            this.lvKetQua.Location = new System.Drawing.Point(87, 249);
            this.lvKetQua.Name = "lvKetQua";
            this.lvKetQua.Size = new System.Drawing.Size(1107, 253);
            this.lvKetQua.TabIndex = 36;
            this.lvKetQua.UseCompatibleStateImageBehavior = false;            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 51);
            this.label1.TabIndex = 35;
            this.label1.Text = "Kết quả trúng thưởng";
            // 
            // cbLuaChon
            // 
            this.cbLuaChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLuaChon.FormattingEnabled = true;
            this.cbLuaChon.Location = new System.Drawing.Point(519, 146);
            this.cbLuaChon.Name = "cbLuaChon";
            this.cbLuaChon.Size = new System.Drawing.Size(286, 46);
            this.cbLuaChon.TabIndex = 44;
            this.cbLuaChon.SelectedIndexChanged += new System.EventHandler(this.cbLuaChon_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 38);
            this.label2.TabIndex = 45;
            this.label2.Text = "Lựa chọn loại vé";
            // 
            // KetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 595);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbLuaChon);
            this.Controls.Add(this.lvKetQua);
            this.Controls.Add(this.label1);
            this.Name = "KetQua";
            this.Text = "KetQua";
            this.Load += new System.EventHandler(this.KetQua_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvKetQua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLuaChon;
        private System.Windows.Forms.Label label2;
    }
}