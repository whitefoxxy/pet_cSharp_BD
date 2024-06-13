namespace BD_user_program
{
    partial class Form2
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
            this.ochk = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dioptr1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.oprav = new System.Windows.Forms.ComboBox();
            this.chehol = new System.Windows.Forms.ComboBox();
            this.salfetka = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.price_text = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.dioptr2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ochk
            // 
            this.ochk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ochk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ochk.FormattingEnabled = true;
            this.ochk.Items.AddRange(new object[] {
            "Контактные линзы",
            "Корректирующие",
            "Солнцезащитные"});
            this.ochk.Location = new System.Drawing.Point(127, 103);
            this.ochk.Name = "ochk";
            this.ochk.Size = new System.Drawing.Size(121, 24);
            this.ochk.Sorted = true;
            this.ochk.TabIndex = 0;
            this.ochk.SelectedIndexChanged += new System.EventHandler(this.ochk_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип очков";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Диоптрии";
            // 
            // dioptr1
            // 
            this.dioptr1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dioptr1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dioptr1.Enabled = false;
            this.dioptr1.FormattingEnabled = true;
            this.dioptr1.Location = new System.Drawing.Point(127, 170);
            this.dioptr1.Name = "dioptr1";
            this.dioptr1.Size = new System.Drawing.Size(121, 24);
            this.dioptr1.Sorted = true;
            this.dioptr1.TabIndex = 4;
            this.dioptr1.SelectedValueChanged += new System.EventHandler(this.dioptr1_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Тип оправы";
            // 
            // oprav
            // 
            this.oprav.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.oprav.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.oprav.FormattingEnabled = true;
            this.oprav.Location = new System.Drawing.Point(127, 200);
            this.oprav.Name = "oprav";
            this.oprav.Size = new System.Drawing.Size(121, 24);
            this.oprav.Sorted = true;
            this.oprav.TabIndex = 6;
            this.oprav.SelectedIndexChanged += new System.EventHandler(this.oprav_SelectedIndexChanged);
            // 
            // chehol
            // 
            this.chehol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.chehol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.chehol.FormattingEnabled = true;
            this.chehol.Location = new System.Drawing.Point(127, 250);
            this.chehol.Name = "chehol";
            this.chehol.Size = new System.Drawing.Size(121, 24);
            this.chehol.Sorted = true;
            this.chehol.TabIndex = 8;
            this.chehol.SelectedIndexChanged += new System.EventHandler(this.chehol_SelectedIndexChanged);
            // 
            // salfetka
            // 
            this.salfetka.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.salfetka.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.salfetka.FormattingEnabled = true;
            this.salfetka.Location = new System.Drawing.Point(127, 301);
            this.salfetka.Name = "salfetka";
            this.salfetka.Size = new System.Drawing.Size(121, 24);
            this.salfetka.Sorted = true;
            this.salfetka.TabIndex = 10;
            this.salfetka.SelectedIndexChanged += new System.EventHandler(this.salfetka_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 86);
            this.button1.TabIndex = 14;
            this.button1.Text = "Добавить заказ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // price_text
            // 
            this.price_text.AutoSize = true;
            this.price_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.price_text.Location = new System.Drawing.Point(444, 392);
            this.price_text.Name = "price_text";
            this.price_text.Size = new System.Drawing.Size(84, 29);
            this.price_text.TabIndex = 15;
            this.price_text.Text = "Цена: ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(449, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 86);
            this.button2.TabIndex = 16;
            this.button2.Text = "Посчитать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(41, 254);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 20);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Футляр";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(24, 305);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(95, 20);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "Салфетка";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(667, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 86);
            this.button3.TabIndex = 19;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label6.Location = new System.Drawing.Point(18, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 36);
            this.label6.TabIndex = 20;
            this.label6.Text = "Окно заказа";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(127, 144);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(115, 20);
            this.checkBox3.TabIndex = 21;
            this.checkBox3.Text = "Астигматизм";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckStateChanged += new System.EventHandler(this.checkBox3_CheckStateChanged);
            // 
            // dioptr2
            // 
            this.dioptr2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dioptr2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dioptr2.Enabled = false;
            this.dioptr2.FormattingEnabled = true;
            this.dioptr2.Location = new System.Drawing.Point(270, 170);
            this.dioptr2.Name = "dioptr2";
            this.dioptr2.Size = new System.Drawing.Size(121, 24);
            this.dioptr2.Sorted = true;
            this.dioptr2.TabIndex = 22;
            this.dioptr2.Visible = false;
            this.dioptr2.SelectedIndexChanged += new System.EventHandler(this.dioptr2_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(859, 522);
            this.Controls.Add(this.dioptr2);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.price_text);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.salfetka);
            this.Controls.Add(this.chehol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.oprav);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dioptr1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ochk);
            this.Name = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ochk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox dioptr1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox oprav;
        private System.Windows.Forms.ComboBox chehol;
        private System.Windows.Forms.ComboBox salfetka;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label price_text;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ComboBox dioptr2;
    }
}