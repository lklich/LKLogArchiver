using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LKLogArchiver
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            if (args.Length == 0)
            {
                try
                {
                    naglowek();
                    string katalog_source = Properties.Settings.Default.path_log + "\\";
                    string rozszerzenie = Properties.Settings.Default.extension;
                    string katalog_dest = Properties.Settings.Default.path_destination;
                    string[] array1 = Directory.GetFiles(katalog_source, Properties.Settings.Default.maska_nazwy + "*." + rozszerzenie); // <-- Case-insensitive
                    string serwer = Properties.Settings.Default.ftp_serwer.Trim();
                    string username = Properties.Settings.Default.ftp_login.Trim();
                    string haslo = Properties.Settings.Default.ftp_haslo;
                    string katalog = Properties.Settings.Default.ftp_katalog;
                    string katalog_out = Properties.Settings.Default.path_destination;
                    string plik_wysylka = "";

                    loguj(katalog_source+Properties.Settings.Default.maska_nazwy.Trim() + "*." + rozszerzenie);
                    loguj("Katalog źródłowy: " + katalog_source + " Katalog docelowy: " + katalog_dest + " Pliki typu: " + rozszerzenie);
                    loguj("Do kompresji znaleziono " + array1.Count() + " plików.");
                    Console.WriteLine("");
                    Console.WriteLine("--- Kompresja  " + array1.Count() + " plików ---");

                    ComponentAce.Compression.ZipForge.ZipForge zip = new ComponentAce.Compression.ZipForge.ZipForge();
                    if (Properties.Settings.Default.szyfruj)
                    {
                        zip.EncryptionAlgorithm = ComponentAce.Compression.Archiver.EncryptionAlgorithm.Aes128;
                        zip.Password = Properties.Settings.Default.key.Trim();
                    }
                    int licznik = 1;
                    foreach (string name in array1)
                    {
                        zip.FileName = katalog_dest + "\\" + Path.GetFileNameWithoutExtension(name) + ".zip";
                        zip.BaseDir = katalog_source;
                        zip.OpenArchive(System.IO.FileMode.Create);
                        loguj("Pozostało " + licznik.ToString() + " z " + array1.Count());
                        loguj("Plik źródłowy: " + name);
                        loguj("Plik docelowy: "+ katalog_dest + "\\" + Path.GetFileNameWithoutExtension(name) + ".zip");
                        zip.AddFiles(name);
                        if (Properties.Settings.Default.delete_old)
                        {
                            if (File.Exists(katalog_dest + "\\" + Path.GetFileNameWithoutExtension(name) + ".zip")) wykasuj_stary_plik(name);
                        }
                        zip.CloseArchive();
                        if(Properties.Settings.Default.ftp_suma) loguj("Suma kontrolna archiwum ZIP: " + GetMD5HashFromFile2(katalog_dest + "\\" + Path.GetFileNameWithoutExtension(name) + ".zip"));
                        //Wysylanie na FTP
                        if (Properties.Settings.Default.send_ftp)
                        {
                            // Wysyłanie na FTP
                            try
                            {
                                //loguj("Wysyłanie " + array1.Count() + " plików ZIP na FTP");
                                    if (katalog.Length == 0) katalog = Properties.Settings.Default.ftp_katalog;
                                    if (katalog.Length > 0) katalog = Properties.Settings.Default.ftp_katalog + "/";
                                    plik_wysylka = katalog_out + "\\" + Path.GetFileNameWithoutExtension(name) + ".zip";
                                    FileInfo f = new FileInfo(name);
                                    loguj("FTP: " + Path.GetFileNameWithoutExtension(name) + ".zip, Rozmiar: " + f.Length.ToString() + " => " + "ftp://" + serwer + "/" + katalog + Path.GetFileNameWithoutExtension(name) + ".zip");
                                    UploadFile(katalog_dest+"\\"+Path.GetFileNameWithoutExtension(name)+".zip", "ftp://" + serwer + "/" + katalog + Path.GetFileNameWithoutExtension(name) + ".zip", username, haslo);

                                    if (Properties.Settings.Default.ftp_usun_stare)
                                    {
                                        if (File.Exists(katalog_dest + "\\" + Path.GetFileNameWithoutExtension(name) + ".zip")) wykasuj_stary_plik(katalog_dest + "\\" + Path.GetFileNameWithoutExtension(name) + ".zip");
                                        loguj("Usuwanie wysłanego pliku ZIP: " + katalog_dest + "\\" + Path.GetFileNameWithoutExtension(name) + ".zip");
                                    }
                            }
                            catch (Exception ee)
                            {
                                loguj("Wystąpił błąd FTP: " + ee.Message);
                            }
                        }
                        licznik++;
                        loguj(" --- koniec obsługi pliku ---- ");
                    }
                    loguj("Zadanie zakończone poprawnie");

                    }
                catch (Exception ex)
                {
                    loguj("Błąd: " + ex.Message.ToString());
                }
            }
            if (args.Length == 1)
            {
                if (args[0] == "/k")
                {
                    naglowek();
                    Console.WriteLine("Wywołanie programu konfiguracyjnego...");                
                    konfiguracja konfig = new konfiguracja();
                    konfig.ShowDialog();
                }

                if (args[0] == "/p")
                {
                    naglowek();
                    Console.WriteLine("");
                    Console.WriteLine("Pomoc do programu LKLogArchiver, autor: Leszek Klich (leszek.klich@gmail.com)");
                    Console.WriteLine("Program LKLogArchiver służy do automatycznej kompresji archiwalnych logów ");
                    Console.WriteLine("systemowych Windows. Program stosuje maskę pliku, dzięki czemu ");
                    Console.WriteLine("obejmuje tylko pliki archiwalne, kompresuje je metodą ZIP (opcjonalnie ");
                    Console.WriteLine("umożliwia też szyfrowanie plików), oraz wysłanie zarchiwizowanych plików");
                    Console.WriteLine("na serwer FTP. Wszelkie działania program dokumentuje w pliku log.txt");
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("Konfigurację można przeprowadzić wizualnie - LKLogArchiver /k ");
                    Console.WriteLine(" lub poprzez ręczną edycję pliku LKLogArchiver.config (jest to plik XML).");
                    Console.WriteLine("Po skonfigurowaniu programu mozna dodać zadanie jegu uruchamiania ");
                    Console.WriteLine("w harmonogramie zadań systemu.");
                    Console.WriteLine("");
                    Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
                    Console.ReadKey();
                }

            }
        }

        public static String GetMD5HashFromFile2(String fileName) 
        { 
            FileStream file = new FileStream(fileName, FileMode.Open); 
            MD5 md5 = new MD5CryptoServiceProvider(); 
            byte[] retVal = md5.ComputeHash(file); 
            file.Close(); 
            StringBuilder sb = new StringBuilder(); 
            for (int i = 0; i < retVal.Length; i++) 
            { 
                sb.Append(retVal[i].ToString("x2")); 
            } 
            return sb.ToString(); 
        }

        static void naglowek()
        {
            Console.WriteLine("+--------------------------------------------------------------------+");
            Console.WriteLine("| Archiwizator logów - autor - Leszek Klich (c) 2014 SR Stalowa Wola |");
            Console.WriteLine("+--------------------------------------------------------------------+");
            Console.WriteLine("|   LKLogArchiver /k - konfiguracja programu (lub ręczna .config)    |");
            Console.WriteLine("|   LKLogArchiver /p - pomoc ekranowa z opisem opcji                 |");
            Console.WriteLine("+--------------------------------------------------------------------+");
        }

        static void wykasuj_stary_plik(string plik)
        {
            if (File.Exists(plik)) File.Delete(plik);
        }

        static void loguj(string co)
        {
            string czas = DateTime.Now.ToString();
                string path = @"log.txt";
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        Console.WriteLine(czas + ": " + co);
                        sw.WriteLine(czas + ": " + co);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        Console.WriteLine(czas + ": " + co);
                        sw.WriteLine(czas + ": " + co);
                    }
                }   
        }

        static void UploadFile(string _FileName, string _UploadPath, string _FTPUser, string _FTPPass)
        {
            System.IO.FileInfo _FileInfo = new System.IO.FileInfo(_FileName);
            System.Net.FtpWebRequest _FtpWebRequest = (System.Net.FtpWebRequest)System.Net.FtpWebRequest.Create(new Uri(_UploadPath));
            _FtpWebRequest.Credentials = new System.Net.NetworkCredential(_FTPUser, _FTPPass);
            _FtpWebRequest.KeepAlive = false;
            _FtpWebRequest.Timeout = 20000;
            _FtpWebRequest.Method = System.Net.WebRequestMethods.Ftp.UploadFile;
            _FtpWebRequest.UseBinary = true;
            _FtpWebRequest.ContentLength = _FileInfo.Length;
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            System.IO.FileStream _FileStream = _FileInfo.OpenRead();

            try
            {
                System.IO.Stream _Stream = _FtpWebRequest.GetRequestStream();
                int contentLen = _FileStream.Read(buff, 0, buffLength);
                while (contentLen != 0)
                {
                    _Stream.Write(buff, 0, contentLen);
                    contentLen = _FileStream.Read(buff, 0, buffLength);
                }
                _Stream.Close();
                _Stream.Dispose();
                _FileStream.Close();
                _FileStream.Dispose();
            }
            catch (Exception ex)
            {
                loguj("Błąd FTP: " + ex.Message.ToString());
            }
        }
    }
}
