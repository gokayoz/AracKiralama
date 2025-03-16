namespace AracKiralama.UI
{
    partial class KiralamaEkrani
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
            cmbAracSecimi = new ComboBox();
            txtGunSayisi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblModel = new Label();
            lblMarka = new Label();
            lblRenk = new Label();
            lblGunlukUcret = new Label();
            lblToplamUcret = new Label();
            btnKirala = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // cmbAracSecimi
            // 
            cmbAracSecimi.CausesValidation = false;
            cmbAracSecimi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAracSecimi.FormattingEnabled = true;
            cmbAracSecimi.Location = new Point(201, 51);
            cmbAracSecimi.Name = "cmbAracSecimi";
            cmbAracSecimi.Size = new Size(151, 28);
            cmbAracSecimi.TabIndex = 0;
            cmbAracSecimi.SelectedIndexChanged += cmbAracSecimi_SelectedIndexChanged;
            // 
            // txtGunSayisi
            // 
            txtGunSayisi.Location = new Point(201, 103);
            txtGunSayisi.Name = "txtGunSayisi";
            txtGunSayisi.Size = new Size(151, 27);
            txtGunSayisi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 51);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 2;
            label1.Text = "Araç:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 106);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 5;
            label2.Text = "Kiralama Süresi(Gün):";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(394, 49);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(55, 20);
            lblModel.TabIndex = 6;
            lblModel.Text = "Model:";
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.Location = new Point(394, 86);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(53, 20);
            lblMarka.TabIndex = 6;
            lblMarka.Text = "Marka:";
            // 
            // lblRenk
            // 
            lblRenk.AutoSize = true;
            lblRenk.Location = new Point(394, 120);
            lblRenk.Name = "lblRenk";
            lblRenk.Size = new Size(44, 20);
            lblRenk.TabIndex = 6;
            lblRenk.Text = "Renk:";
            // 
            // lblGunlukUcret
            // 
            lblGunlukUcret.AutoSize = true;
            lblGunlukUcret.Location = new Point(394, 157);
            lblGunlukUcret.Name = "lblGunlukUcret";
            lblGunlukUcret.Size = new Size(96, 20);
            lblGunlukUcret.TabIndex = 6;
            lblGunlukUcret.Text = "Günlük Ücret:";
            // 
            // lblToplamUcret
            // 
            lblToplamUcret.AutoSize = true;
            lblToplamUcret.Location = new Point(394, 197);
            lblToplamUcret.Name = "lblToplamUcret";
            lblToplamUcret.Size = new Size(187, 20);
            lblToplamUcret.TabIndex = 6;
            lblToplamUcret.Text = "Toplam Kiralama Ücretiniz:";
            // 
            // btnKirala
            // 
            btnKirala.Location = new Point(201, 193);
            btnKirala.Name = "btnKirala";
            btnKirala.Size = new Size(151, 29);
            btnKirala.TabIndex = 7;
            btnKirala.Text = "Araç Kirala";
            btnKirala.UseVisualStyleBackColor = true;
            btnKirala.Click += btnKirala_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(520, 9);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 8;
            label3.Text = "Kiralama Bilgileriniz";
            // 
            // KiralamaEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            CausesValidation = false;
            ClientSize = new Size(800, 250);
            Controls.Add(label3);
            Controls.Add(btnKirala);
            Controls.Add(lblToplamUcret);
            Controls.Add(lblGunlukUcret);
            Controls.Add(lblRenk);
            Controls.Add(lblMarka);
            Controls.Add(lblModel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtGunSayisi);
            Controls.Add(cmbAracSecimi);
            Name = "KiralamaEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Araç Kiralama Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbAracSecimi;
        private TextBox txtGunSayisi;
        private Label label1;
        private Label label2;
        private Label lblModel;
        private Label lblMarka;
        private Label lblRenk;
        private Label lblGunlukUcret;
        private Label lblToplamUcret;
        private Button btnKirala;
        private Label label3;
    }
}
