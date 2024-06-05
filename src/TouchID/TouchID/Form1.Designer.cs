namespace TouchID
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_title = new Label();
            button_pilih_citra = new Button();
            comboBox_algoritma = new ComboBox();
            button_cari = new Button();
            SuspendLayout();
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_title.Location = new Point(90, 9);
            label_title.Name = "label_title";
            label_title.Size = new Size(650, 35);
            label_title.TabIndex = 0;
            label_title.Text = "Aplikasi C# Tugas Besar 3 Strategi Algoritma 2023/2024";
            label_title.TextAlign = ContentAlignment.MiddleCenter;
            label_title.Click += label_title_Click;
            // 
            // button_pilih_citra
            // 
            button_pilih_citra.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_pilih_citra.Location = new Point(48, 304);
            button_pilih_citra.Name = "button_pilih_citra";
            button_pilih_citra.Size = new Size(138, 43);
            button_pilih_citra.TabIndex = 1;
            button_pilih_citra.Text = "Pilih Citra";
            button_pilih_citra.UseVisualStyleBackColor = true;
            button_pilih_citra.Click += button_pilih_citra_Click;
            // 
            // comboBox_algoritma
            // 
            comboBox_algoritma.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox_algoritma.FormattingEnabled = true;
            comboBox_algoritma.Items.AddRange(new object[] { "KM", "BMP" });
            comboBox_algoritma.Location = new Point(218, 304);
            comboBox_algoritma.Name = "comboBox_algoritma";
            comboBox_algoritma.Size = new Size(214, 43);
            comboBox_algoritma.TabIndex = 2;
            comboBox_algoritma.Text = "Pilih algoritma";
            comboBox_algoritma.SelectedIndexChanged += comboBox_algoritma_SelectedIndexChanged;
            // 
            // button_cari
            // 
            button_cari.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_cari.Location = new Point(463, 303);
            button_cari.Name = "button_cari";
            button_cari.Size = new Size(80, 43);
            button_cari.TabIndex = 3;
            button_cari.Text = "Cari";
            button_cari.UseVisualStyleBackColor = true;
            button_cari.Click += button_cari_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_cari);
            Controls.Add(comboBox_algoritma);
            Controls.Add(button_pilih_citra);
            Controls.Add(label_title);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_title;
        private Button button_pilih_citra;
        private ComboBox comboBox_algoritma;
        private Button button_cari;
    }
}
