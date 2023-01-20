
namespace Ogrenci_Otomasyon
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
            this.student_list = new System.Windows.Forms.ListBox();
            this.add_student = new System.Windows.Forms.Button();
            this.student_name_text = new System.Windows.Forms.TextBox();
            this.student_name_label = new System.Windows.Forms.Label();
            this.student_surname_label = new System.Windows.Forms.Label();
            this.student_surname_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.student_number_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.student_update_number_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.student_update_surname_text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.student_update_name_text = new System.Windows.Forms.TextBox();
            this.update_student = new System.Windows.Forms.Button();
            this.delete_student = new System.Windows.Forms.Button();
            this.student_title_label = new System.Windows.Forms.Label();
            this.github_link = new System.Windows.Forms.LinkLabel();
            this.playstore_link = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // student_list
            // 
            this.student_list.FormattingEnabled = true;
            this.student_list.ItemHeight = 16;
            this.student_list.Location = new System.Drawing.Point(12, 60);
            this.student_list.Name = "student_list";
            this.student_list.Size = new System.Drawing.Size(303, 580);
            this.student_list.TabIndex = 0;
            this.student_list.SelectedIndexChanged += new System.EventHandler(this.student_list_SelectedIndexChanged);
            // 
            // add_student
            // 
            this.add_student.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold);
            this.add_student.Location = new System.Drawing.Point(524, 152);
            this.add_student.Name = "add_student";
            this.add_student.Size = new System.Drawing.Size(114, 35);
            this.add_student.TabIndex = 1;
            this.add_student.Text = "Ögrenci Ekle";
            this.add_student.UseVisualStyleBackColor = true;
            this.add_student.Click += new System.EventHandler(this.add_student_Click);
            // 
            // student_name_text
            // 
            this.student_name_text.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold);
            this.student_name_text.Location = new System.Drawing.Point(524, 66);
            this.student_name_text.Name = "student_name_text";
            this.student_name_text.Size = new System.Drawing.Size(114, 21);
            this.student_name_text.TabIndex = 2;
            // 
            // student_name_label
            // 
            this.student_name_label.AutoSize = true;
            this.student_name_label.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold);
            this.student_name_label.Location = new System.Drawing.Point(321, 66);
            this.student_name_label.Name = "student_name_label";
            this.student_name_label.Size = new System.Drawing.Size(106, 17);
            this.student_name_label.TabIndex = 3;
            this.student_name_label.Text = "Adını giriniz:";
            // 
            // student_surname_label
            // 
            this.student_surname_label.AutoSize = true;
            this.student_surname_label.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold);
            this.student_surname_label.Location = new System.Drawing.Point(321, 94);
            this.student_surname_label.Name = "student_surname_label";
            this.student_surname_label.Size = new System.Drawing.Size(128, 17);
            this.student_surname_label.TabIndex = 5;
            this.student_surname_label.Text = "Soyadını giriniz:";
            // 
            // student_surname_text
            // 
            this.student_surname_text.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold);
            this.student_surname_text.Location = new System.Drawing.Point(524, 94);
            this.student_surname_text.Name = "student_surname_text";
            this.student_surname_text.Size = new System.Drawing.Size(114, 21);
            this.student_surname_text.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(321, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Numarasını giriniz:";
            // 
            // student_number_text
            // 
            this.student_number_text.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold);
            this.student_number_text.Location = new System.Drawing.Point(524, 122);
            this.student_number_text.Name = "student_number_text";
            this.student_number_text.Size = new System.Drawing.Size(114, 21);
            this.student_number_text.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(321, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Yeni öğrencinin;";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(321, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Öğrencinin;";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(321, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Numarasını giriniz:";
            // 
            // student_update_number_text
            // 
            this.student_update_number_text.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold);
            this.student_update_number_text.Location = new System.Drawing.Point(524, 360);
            this.student_update_number_text.Name = "student_update_number_text";
            this.student_update_number_text.Size = new System.Drawing.Size(114, 21);
            this.student_update_number_text.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(321, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Soyadını giriniz:";
            // 
            // student_update_surname_text
            // 
            this.student_update_surname_text.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold);
            this.student_update_surname_text.Location = new System.Drawing.Point(524, 332);
            this.student_update_surname_text.Name = "student_update_surname_text";
            this.student_update_surname_text.Size = new System.Drawing.Size(114, 21);
            this.student_update_surname_text.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(321, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Adını giriniz:";
            // 
            // student_update_name_text
            // 
            this.student_update_name_text.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold);
            this.student_update_name_text.Location = new System.Drawing.Point(524, 304);
            this.student_update_name_text.Name = "student_update_name_text";
            this.student_update_name_text.Size = new System.Drawing.Size(114, 21);
            this.student_update_name_text.TabIndex = 10;
            // 
            // update_student
            // 
            this.update_student.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold);
            this.update_student.Location = new System.Drawing.Point(499, 388);
            this.update_student.Name = "update_student";
            this.update_student.Size = new System.Drawing.Size(139, 35);
            this.update_student.TabIndex = 9;
            this.update_student.Text = "Öğrenci Düzenle";
            this.update_student.UseVisualStyleBackColor = true;
            this.update_student.Click += new System.EventHandler(this.update_student_Click);
            // 
            // delete_student
            // 
            this.delete_student.BackColor = System.Drawing.SystemColors.Control;
            this.delete_student.Enabled = false;
            this.delete_student.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_student.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete_student.Location = new System.Drawing.Point(499, 605);
            this.delete_student.Name = "delete_student";
            this.delete_student.Size = new System.Drawing.Size(139, 35);
            this.delete_student.TabIndex = 17;
            this.delete_student.Text = "Öğrenci Sil";
            this.delete_student.UseVisualStyleBackColor = false;
            this.delete_student.Click += new System.EventHandler(this.delete_student_Click);
            // 
            // student_title_label
            // 
            this.student_title_label.AutoSize = true;
            this.student_title_label.Font = new System.Drawing.Font("Modern No. 20", 13F, System.Drawing.FontStyle.Bold);
            this.student_title_label.Location = new System.Drawing.Point(12, 12);
            this.student_title_label.Name = "student_title_label";
            this.student_title_label.Size = new System.Drawing.Size(153, 24);
            this.student_title_label.TabIndex = 18;
            this.student_title_label.Text = "ÖĞRENCİLER";
            // 
            // github_link
            // 
            this.github_link.AutoSize = true;
            this.github_link.Location = new System.Drawing.Point(321, 615);
            this.github_link.Name = "github_link";
            this.github_link.Size = new System.Drawing.Size(97, 17);
            this.github_link.TabIndex = 19;
            this.github_link.TabStop = true;
            this.github_link.Text = "visit my github";
            this.github_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.github_link_LinkClicked);
            // 
            // playstore_link
            // 
            this.playstore_link.AutoSize = true;
            this.playstore_link.Location = new System.Drawing.Point(321, 598);
            this.playstore_link.Name = "playstore_link";
            this.playstore_link.Size = new System.Drawing.Size(116, 17);
            this.playstore_link.TabIndex = 20;
            this.playstore_link.TabStop = true;
            this.playstore_link.Text = "visit my playstore";
            this.playstore_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.playstore_link_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 644);
            this.Controls.Add(this.playstore_link);
            this.Controls.Add(this.github_link);
            this.Controls.Add(this.student_title_label);
            this.Controls.Add(this.delete_student);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.student_update_number_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.student_update_surname_text);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.student_update_name_text);
            this.Controls.Add(this.update_student);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.student_number_text);
            this.Controls.Add(this.student_surname_label);
            this.Controls.Add(this.student_surname_text);
            this.Controls.Add(this.student_name_label);
            this.Controls.Add(this.student_name_text);
            this.Controls.Add(this.add_student);
            this.Controls.Add(this.student_list);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox student_list;
        private System.Windows.Forms.Button add_student;
        private System.Windows.Forms.TextBox student_name_text;
        private System.Windows.Forms.Label student_name_label;
        private System.Windows.Forms.Label student_surname_label;
        private System.Windows.Forms.TextBox student_surname_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox student_number_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox student_update_number_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox student_update_surname_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox student_update_name_text;
        private System.Windows.Forms.Button update_student;
        private System.Windows.Forms.Button delete_student;
        private System.Windows.Forms.Label student_title_label;
        private System.Windows.Forms.LinkLabel github_link;
        private System.Windows.Forms.LinkLabel playstore_link;
    }
}

