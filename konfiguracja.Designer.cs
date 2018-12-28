namespace LKLogArchiver
{
    partial class konfiguracja
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
            this.zipForge1 = new ComponentAce.Compression.ZipForge.ZipForge();
            this.textPathSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_przegladaj = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.bt_zapisz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textPathCel = new System.Windows.Forms.TextBox();
            this.bt_path_cel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bt_plik_loga = new System.Windows.Forms.Button();
            this.textPlikLoga = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textMaska = new System.Windows.Forms.TextBox();
            this.checkKasuj = new System.Windows.Forms.CheckBox();
            this.checkSzyfruj = new System.Windows.Forms.CheckBox();
            this.textKey = new System.Windows.Forms.TextBox();
            this.checkZastap = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textFTPKatsalog = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textHasloFTP = new System.Windows.Forms.TextBox();
            this.textUserFTP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textserwer_ftp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkSendFTP = new System.Windows.Forms.CheckBox();
            this.checkUsuwajFTP = new System.Windows.Forms.CheckBox();
            this.checkSuma = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zipForge1
            // 
            this.zipForge1.Active = false;
            this.zipForge1.BaseDir = "";
            this.zipForge1.CompressionLevel = ComponentAce.Compression.Archiver.CompressionLevel.Fastest;
            this.zipForge1.CompressionMethod = ComponentAce.Compression.Archiver.CompressionMethod.Deflate;
            this.zipForge1.CompressionMode = ((byte)(1));
            this.zipForge1.EncryptionAlgorithm = ComponentAce.Compression.Archiver.EncryptionAlgorithm.None;
            this.zipForge1.ExtractCorruptedFiles = false;
            this.zipForge1.FileName = "";
            this.zipForge1.InMemory = false;
            this.zipForge1.OpenCorruptedArchives = true;
            this.zipForge1.Password = "";
            this.zipForge1.SFXStub = "";
            this.zipForge1.SpanningMode = ComponentAce.Compression.Archiver.SpanningMode.None;
            this.zipForge1.StoreNTFSTimeStamps = false;
            this.zipForge1.TempDir = "";
            this.zipForge1.UnicodeFilenames = true;
            this.zipForge1.Zip64Mode = ComponentAce.Compression.Archiver.Zip64Mode.Auto;
            // 
            // textPathSource
            // 
            this.textPathSource.Location = new System.Drawing.Point(140, 21);
            this.textPathSource.Name = "textPathSource";
            this.textPathSource.Size = new System.Drawing.Size(465, 22);
            this.textPathSource.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textPathSource, "Podaj lub wybierz przyciskiem Przeglądaj katalog, w którym znajdują się archiwaln" +
        "e logi systemu.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Katalog LOGów:";
            // 
            // bt_przegladaj
            // 
            this.bt_przegladaj.Location = new System.Drawing.Point(611, 18);
            this.bt_przegladaj.Name = "bt_przegladaj";
            this.bt_przegladaj.Size = new System.Drawing.Size(86, 29);
            this.bt_przegladaj.TabIndex = 2;
            this.bt_przegladaj.Text = "Przeglądaj";
            this.bt_przegladaj.UseVisualStyleBackColor = true;
            this.bt_przegladaj.Click += new System.EventHandler(this.bt_przegladaj_Click);
            // 
            // bt_zapisz
            // 
            this.bt_zapisz.Location = new System.Drawing.Point(16, 365);
            this.bt_zapisz.Name = "bt_zapisz";
            this.bt_zapisz.Size = new System.Drawing.Size(100, 39);
            this.bt_zapisz.TabIndex = 3;
            this.bt_zapisz.Text = "Zapisz";
            this.bt_zapisz.UseVisualStyleBackColor = true;
            this.bt_zapisz.Click += new System.EventHandler(this.bt_zapisz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Katalog docelowy:";
            // 
            // textPathCel
            // 
            this.textPathCel.Location = new System.Drawing.Point(140, 64);
            this.textPathCel.Name = "textPathCel";
            this.textPathCel.Size = new System.Drawing.Size(465, 22);
            this.textPathCel.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textPathCel, "Podaj katalog, do w którym chcesz umieścić skompresowane logi");
            // 
            // bt_path_cel
            // 
            this.bt_path_cel.Location = new System.Drawing.Point(611, 63);
            this.bt_path_cel.Name = "bt_path_cel";
            this.bt_path_cel.Size = new System.Drawing.Size(86, 32);
            this.bt_path_cel.TabIndex = 6;
            this.bt_path_cel.Text = "Przeglądaj";
            this.bt_path_cel.UseVisualStyleBackColor = true;
            this.bt_path_cel.Click += new System.EventHandler(this.bt_path_cel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rozszerzenie:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bt_plik_loga
            // 
            this.bt_plik_loga.Location = new System.Drawing.Point(611, 106);
            this.bt_plik_loga.Name = "bt_plik_loga";
            this.bt_plik_loga.Size = new System.Drawing.Size(86, 28);
            this.bt_plik_loga.TabIndex = 8;
            this.bt_plik_loga.Text = "Przeglądaj";
            this.bt_plik_loga.UseVisualStyleBackColor = true;
            this.bt_plik_loga.Click += new System.EventHandler(this.bt_plik_loga_Click);
            // 
            // textPlikLoga
            // 
            this.textPlikLoga.Location = new System.Drawing.Point(140, 109);
            this.textPlikLoga.Name = "textPlikLoga";
            this.textPlikLoga.Size = new System.Drawing.Size(465, 22);
            this.textPlikLoga.TabIndex = 9;
            this.toolTip1.SetToolTip(this.textPlikLoga, "Podaj rozszerzenie plików log - zwykle jest to evtx");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Maska nazwy:";
            // 
            // textMaska
            // 
            this.textMaska.Location = new System.Drawing.Point(140, 143);
            this.textMaska.Name = "textMaska";
            this.textMaska.Size = new System.Drawing.Size(465, 22);
            this.textMaska.TabIndex = 11;
            this.toolTip1.SetToolTip(this.textMaska, "Maska nazwy, np. Windows nazywa archiwizuje logi nazywając je Archive-daty. \r\nAby" +
        " program uwzględniał jedynie logi archiwalne (mocno zalecane), pozostaw Archive-" +
        "");
            // 
            // checkKasuj
            // 
            this.checkKasuj.AutoSize = true;
            this.checkKasuj.Location = new System.Drawing.Point(140, 171);
            this.checkKasuj.Name = "checkKasuj";
            this.checkKasuj.Size = new System.Drawing.Size(224, 20);
            this.checkKasuj.TabIndex = 12;
            this.checkKasuj.Text = "Kasuj plik źródłowy po kompresji";
            this.toolTip1.SetToolTip(this.checkKasuj, "Określa, czy po zakończeniu kompresji każdego pliku archiwalnego, plik ma zostać " +
        "usunięty (oszczędność miejsca) - mocno zalecane");
            this.checkKasuj.UseVisualStyleBackColor = true;
            // 
            // checkSzyfruj
            // 
            this.checkSzyfruj.AutoSize = true;
            this.checkSzyfruj.Location = new System.Drawing.Point(140, 197);
            this.checkSzyfruj.Name = "checkSzyfruj";
            this.checkSzyfruj.Size = new System.Drawing.Size(199, 20);
            this.checkSzyfruj.TabIndex = 13;
            this.checkSzyfruj.Text = "Szyfruj skompresowane pliki ";
            this.toolTip1.SetToolTip(this.checkSzyfruj, "Czy skompresowane pliki mają być zaszyfrowane?");
            this.checkSzyfruj.UseVisualStyleBackColor = true;
            // 
            // textKey
            // 
            this.textKey.Location = new System.Drawing.Point(345, 197);
            this.textKey.Name = "textKey";
            this.textKey.PasswordChar = '*';
            this.textKey.Size = new System.Drawing.Size(147, 22);
            this.textKey.TabIndex = 14;
            this.toolTip1.SetToolTip(this.textKey, "Hasło do archuwum plików ZIP (można je potem otworzyć dowolnym programem archiwiz" +
        "ującym.)");
            // 
            // checkZastap
            // 
            this.checkZastap.AutoSize = true;
            this.checkZastap.Location = new System.Drawing.Point(391, 171);
            this.checkZastap.Name = "checkZastap";
            this.checkZastap.Size = new System.Drawing.Size(211, 20);
            this.checkZastap.TabIndex = 15;
            this.checkZastap.Text = "Zastąp docelowe (jeśli istnieją)";
            this.toolTip1.SetToolTip(this.checkZastap, "Czy zastępować pliki w katalogu docelowym jesli już istnieją? Zalecane - TAK");
            this.checkZastap.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkSuma);
            this.groupBox1.Controls.Add(this.textFTPKatsalog);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textHasloFTP);
            this.groupBox1.Controls.Add(this.textUserFTP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textserwer_ftp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.checkSendFTP);
            this.groupBox1.Controls.Add(this.checkUsuwajFTP);
            this.groupBox1.Location = new System.Drawing.Point(16, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 113);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ustawienia FTP";
            // 
            // textFTPKatsalog
            // 
            this.textFTPKatsalog.Location = new System.Drawing.Point(525, 53);
            this.textFTPKatsalog.Name = "textFTPKatsalog";
            this.textFTPKatsalog.Size = new System.Drawing.Size(150, 22);
            this.textFTPKatsalog.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(433, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Katalog FTP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(440, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Hasło FTP:";
            // 
            // textHasloFTP
            // 
            this.textHasloFTP.Location = new System.Drawing.Point(525, 25);
            this.textHasloFTP.Name = "textHasloFTP";
            this.textHasloFTP.PasswordChar = '*';
            this.textHasloFTP.Size = new System.Drawing.Size(150, 22);
            this.textHasloFTP.TabIndex = 6;
            // 
            // textUserFTP
            // 
            this.textUserFTP.Location = new System.Drawing.Point(345, 25);
            this.textUserFTP.Name = "textUserFTP";
            this.textUserFTP.Size = new System.Drawing.Size(89, 22);
            this.textUserFTP.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Użytkownik FTP:";
            // 
            // textserwer_ftp
            // 
            this.textserwer_ftp.Location = new System.Drawing.Point(96, 25);
            this.textserwer_ftp.Name = "textserwer_ftp";
            this.textserwer_ftp.Size = new System.Drawing.Size(138, 22);
            this.textserwer_ftp.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Serwer FTP:";
            // 
            // checkSendFTP
            // 
            this.checkSendFTP.AutoSize = true;
            this.checkSendFTP.Location = new System.Drawing.Point(14, 61);
            this.checkSendFTP.Name = "checkSendFTP";
            this.checkSendFTP.Size = new System.Drawing.Size(289, 20);
            this.checkSendFTP.TabIndex = 1;
            this.checkSendFTP.Text = "Wysyłaj zarchiwizowane logi na serwer FTP";
            this.checkSendFTP.UseVisualStyleBackColor = true;
            // 
            // checkUsuwajFTP
            // 
            this.checkUsuwajFTP.AutoSize = true;
            this.checkUsuwajFTP.Location = new System.Drawing.Point(14, 87);
            this.checkUsuwajFTP.Name = "checkUsuwajFTP";
            this.checkUsuwajFTP.Size = new System.Drawing.Size(241, 20);
            this.checkUsuwajFTP.TabIndex = 0;
            this.checkUsuwajFTP.Text = "Usuwaj wysłane logi na serwer FTP";
            this.checkUsuwajFTP.UseVisualStyleBackColor = true;
            // 
            // checkSuma
            // 
            this.checkSuma.AutoSize = true;
            this.checkSuma.Location = new System.Drawing.Point(307, 87);
            this.checkSuma.Name = "checkSuma";
            this.checkSuma.Size = new System.Drawing.Size(374, 20);
            this.checkSuma.TabIndex = 10;
            this.checkSuma.Text = "Porównuj sumę kontrolną pliku z plikiem wysłanym na FTP";
            this.checkSuma.UseVisualStyleBackColor = true;
            // 
            // konfiguracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 416);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkZastap);
            this.Controls.Add(this.textKey);
            this.Controls.Add(this.checkSzyfruj);
            this.Controls.Add(this.checkKasuj);
            this.Controls.Add(this.textMaska);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPlikLoga);
            this.Controls.Add(this.bt_plik_loga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_path_cel);
            this.Controls.Add(this.textPathCel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_zapisz);
            this.Controls.Add(this.bt_przegladaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPathSource);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "konfiguracja";
            this.Text = "konfiguracja";
            this.Load += new System.EventHandler(this.konfiguracja_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentAce.Compression.ZipForge.ZipForge zipForge1;
        private System.Windows.Forms.TextBox textPathSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_przegladaj;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button bt_zapisz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPathCel;
        private System.Windows.Forms.Button bt_path_cel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bt_plik_loga;
        private System.Windows.Forms.TextBox textPlikLoga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textMaska;
        private System.Windows.Forms.CheckBox checkKasuj;
        private System.Windows.Forms.CheckBox checkSzyfruj;
        private System.Windows.Forms.TextBox textKey;
        private System.Windows.Forms.CheckBox checkZastap;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textHasloFTP;
        private System.Windows.Forms.TextBox textUserFTP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textserwer_ftp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkSendFTP;
        private System.Windows.Forms.CheckBox checkUsuwajFTP;
        private System.Windows.Forms.TextBox textFTPKatsalog;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkSuma;
    }
}