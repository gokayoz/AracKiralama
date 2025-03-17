namespace AracSimulasyonu.UI
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
            btnKiralamaYap = new MaterialSkin.Controls.MaterialButton();
            cmbAraclar = new MaterialSkin.Controls.MaterialComboBox();
            txtGunSayisi = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            lbKiralamaGecmisi = new ListBox();
            txtToplamUcret = new MaterialSkin.Controls.MaterialTextBox();
            SuspendLayout();
            // 
            // btnKiralamaYap
            // 
            btnKiralamaYap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnKiralamaYap.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnKiralamaYap.Depth = 0;
            btnKiralamaYap.Font = new Font("Segoe UI", 9F);
            btnKiralamaYap.HighEmphasis = true;
            btnKiralamaYap.Icon = null;
            btnKiralamaYap.Location = new Point(622, 224);
            btnKiralamaYap.Margin = new Padding(4, 6, 4, 6);
            btnKiralamaYap.MouseState = MaterialSkin.MouseState.HOVER;
            btnKiralamaYap.Name = "btnKiralamaYap";
            btnKiralamaYap.NoAccentTextColor = Color.Empty;
            btnKiralamaYap.Size = new Size(125, 36);
            btnKiralamaYap.TabIndex = 6;
            btnKiralamaYap.Text = "Kiralama Yap";
            btnKiralamaYap.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnKiralamaYap.UseAccentColor = false;
            btnKiralamaYap.UseVisualStyleBackColor = true;
            btnKiralamaYap.Click += btnKiralamaYap_Click;
            // 
            // cmbAraclar
            // 
            cmbAraclar.AutoResize = false;
            cmbAraclar.BackColor = Color.FromArgb(255, 255, 255);
            cmbAraclar.Depth = 0;
            cmbAraclar.DrawMode = DrawMode.OwnerDrawVariable;
            cmbAraclar.DropDownHeight = 174;
            cmbAraclar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAraclar.DropDownWidth = 121;
            cmbAraclar.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbAraclar.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbAraclar.FormattingEnabled = true;
            cmbAraclar.IntegralHeight = false;
            cmbAraclar.ItemHeight = 43;
            cmbAraclar.Location = new Point(184, 86);
            cmbAraclar.MaxDropDownItems = 4;
            cmbAraclar.MouseState = MaterialSkin.MouseState.OUT;
            cmbAraclar.Name = "cmbAraclar";
            cmbAraclar.Size = new Size(408, 49);
            cmbAraclar.StartIndex = 0;
            cmbAraclar.TabIndex = 7;
            // 
            // txtGunSayisi
            // 
            txtGunSayisi.AnimateReadOnly = false;
            txtGunSayisi.BorderStyle = BorderStyle.None;
            txtGunSayisi.Depth = 0;
            txtGunSayisi.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtGunSayisi.LeadingIcon = null;
            txtGunSayisi.Location = new Point(184, 152);
            txtGunSayisi.MaxLength = 50;
            txtGunSayisi.MouseState = MaterialSkin.MouseState.OUT;
            txtGunSayisi.Multiline = false;
            txtGunSayisi.Name = "txtGunSayisi";
            txtGunSayisi.Size = new Size(125, 50);
            txtGunSayisi.TabIndex = 9;
            txtGunSayisi.Text = "";
            txtGunSayisi.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(84, 98);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(55, 19);
            materialLabel1.TabIndex = 10;
            materialLabel1.Text = "Araçlar:";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(58, 166);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(81, 19);
            materialLabel2.TabIndex = 10;
            materialLabel2.Text = "Gün Sayısı:";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(26, 235);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(113, 19);
            materialLabel4.TabIndex = 10;
            materialLabel4.Text = "Kiralama Ücreti:";
            // 
            // lbKiralamaGecmisi
            // 
            lbKiralamaGecmisi.FormattingEnabled = true;
            lbKiralamaGecmisi.Location = new Point(26, 292);
            lbKiralamaGecmisi.Name = "lbKiralamaGecmisi";
            lbKiralamaGecmisi.Size = new Size(778, 244);
            lbKiralamaGecmisi.TabIndex = 11;
            // 
            // txtToplamUcret
            // 
            txtToplamUcret.AnimateReadOnly = false;
            txtToplamUcret.BorderStyle = BorderStyle.None;
            txtToplamUcret.Depth = 0;
            txtToplamUcret.Enabled = false;
            txtToplamUcret.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtToplamUcret.LeadingIcon = null;
            txtToplamUcret.Location = new Point(184, 218);
            txtToplamUcret.MaxLength = 50;
            txtToplamUcret.MouseState = MaterialSkin.MouseState.OUT;
            txtToplamUcret.Multiline = false;
            txtToplamUcret.Name = "txtToplamUcret";
            txtToplamUcret.Size = new Size(125, 50);
            txtToplamUcret.TabIndex = 9;
            txtToplamUcret.Text = "";
            txtToplamUcret.TrailingIcon = null;
            // 
            // KiralamaEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 562);
            Controls.Add(lbKiralamaGecmisi);
            Controls.Add(materialLabel4);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(txtToplamUcret);
            Controls.Add(txtGunSayisi);
            Controls.Add(cmbAraclar);
            Controls.Add(btnKiralamaYap);
            Name = "KiralamaEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Araç Kiralama";
            Load += KiralamaEkrani_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnKiralamaYap;
        private MaterialSkin.Controls.MaterialComboBox cmbAraclar;
        private MaterialSkin.Controls.MaterialTextBox txtGunSayisi;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private ListBox lbKiralamaGecmisi;
        private MaterialSkin.Controls.MaterialTextBox txtToplamUcret;
    }
}
