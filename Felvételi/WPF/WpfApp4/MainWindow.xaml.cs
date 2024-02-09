using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Collections.ObjectModel;
using System.Windows.Markup.Localizer;
using static System.Net.Mime.MediaTypeNames;
using System.Text.Json;
using System.Text.Encodings.Web;
using MySqlConnector;
using System.Windows.Controls.Primitives;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {




        ObservableCollection<Ujdiak> diakok = new ObservableCollection<Ujdiak>();
        public MainWindow()
        {
            InitializeComponent();
            dgLista.Items.Clear();
        }

        private void Felvetel_Click(object sender, RoutedEventArgs e)
        {
            Ujdiak asd = new Ujdiak();
            Bekeres ujablak = new Bekeres(asd);
            ujablak.ShowDialog();

            diakok.Add(asd);
            dgLista.ItemsSource = diakok;
        }

        private void Torles_Click(object sender, RoutedEventArgs e)
        {
            if (dgLista.SelectedIndex != -1)
            {
                List<Ujdiak> temp = new List<Ujdiak>();
                foreach (Ujdiak item in dgLista.SelectedItems)
                {
                    temp.Add(item);
                }

                foreach (Ujdiak item in temp)
                {
                    diakok.Remove(item);
                }

                dgLista.ItemsSource = diakok;
                MessageBox.Show("Sikeres törlés!");
            }
            else
            {
                MessageBox.Show("Nincs kijelölt adat!");
            }
        }
        private void Modositas_Click(object sender, RoutedEventArgs e)
        {
            if (dgLista.SelectedItems.Count == 1)
            {

                Bekeres ujablak = new Bekeres(diakok[dgLista.SelectedIndex]);
                ujablak.ShowDialog();

                dgLista.ItemsSource = diakok;
                dgLista.Items.Refresh();

            }

            else
            {
                MessageBox.Show("Egy adatnak kell lennie kiválasztva a módosításhoz!");
            }
        }

        private void Importalas_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JSON vagy csv fájlok (*.JSON;*.csv)|*.JSON;*.csv";
            if (diakok.Count > 0)
            {
                MessageBoxResult valasz = MessageBox.Show("A meglévő adatokat szeretné törölni?", "Értesítés", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (valasz == MessageBoxResult.Yes || valasz == MessageBoxResult.No)
                {
                    if (valasz == MessageBoxResult.Yes)
                    {
                        diakok.Clear();
                    }
                }
            }

            if (ofd.ShowDialog() == true)
            {
                if (ofd.FileName.EndsWith(".csv"))
                {
                    foreach (string fajl in File.ReadAllLines(ofd.FileName).Skip(1))
                    {
                        diakok.Add(new Ujdiak(fajl.Split(";")));
                    }
                    dgLista.ItemsSource = diakok;
                    MessageBox.Show("Sikeres importálás!");
                }

                else
                {
                    Ujdiak[] adatok = JsonSerializer.Deserialize<Ujdiak[]>(File.ReadAllText(ofd.FileName));
                    adatok.ToList().ForEach(diak => diakok.Add(diak));
                    dgLista.ItemsSource = diakok;
                    MessageBox.Show("Sikeres importálás!");
                }
            }
        }
        private void Exportalas_Click(object sender, RoutedEventArgs e)
        {
            if (diakok.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Csv fájl (.csv)|*.csv|JSON fájl (.JSON)|*.JSON";
                List<string> lementes = new List<string>();
                if (sfd.ShowDialog() == true)
                {

                    if (sfd.FileName.EndsWith(".csv"))
                    {
                        lementes.Add("OM_Azonosito;Nev;Email;Szuletesi_Datum;ErtesitesiCim;Magyar;Matematika");
                        diakok.ToList().ForEach(asd => lementes.Add(asd.CSVSortAdVissza()));
                        File.WriteAllLines(sfd.FileName, lementes);
                        MessageBox.Show("Sikeres mentés!");
                    }

                    else if (sfd.FileName.EndsWith(".JSON"))
                    {
                        var opciok = new JsonSerializerOptions();
                        opciok.Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
                        opciok.WriteIndented = true;

                        string adatokSorai = JsonSerializer.Serialize(diakok, opciok);

                        var lista = new List<String>();
                        lista.Add(adatokSorai);
                        File.WriteAllLines(sfd.FileName, lista);
                        MessageBox.Show("Sikeres mentés!");
                    }

                    else
                    {
                        MessageBox.Show("Sikertelen mentés!");
                    }
                }
            }

            else
            {
                MessageBox.Show("Nincsen menthető adat!");
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Kilepes_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void SQLexport_Click(object sender, RoutedEventArgs e)
        {
            string connection = "Server=localhost;Database=felvetelisql;User ID=root;Password=;";

            using (MySqlConnection con = new MySqlConnection(connection))
            {
                try
                {
                    con.Open();

                    string clear = "delete from felvetelitabla";
                    using (MySqlCommand clearParancs = new MySqlCommand(clear, con))
                    {
                        clearParancs.ExecuteNonQuery();
                    }

                    diakok.ToList().ForEach(item => {
                        MessageBox.Show(item.OM_Azonosito);
                        string push = $"insert into felvetelitabla (om,nev,cim,email,datum,matek,magyar) values({item.OM_Azonosito}, '{item.Neve}', '{item.ErtesitesiCime}', '{item.Email}', '{item.SzuletesiDatum.Year}-{item.SzuletesiDatum.Month}-{item.SzuletesiDatum.Day}', {item.Matematika}, {item.Magyar})";
                        using (MySqlCommand pushParancs = new MySqlCommand(push, con)) {pushParancs.ExecuteNonQuery();}
                    });
                    MessageBox.Show(":)");
                    con.Close();
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(":(\n"+ex);
                }
            }


        }

        private void SQLimport_Click(object sender, RoutedEventArgs e)
        {
            string connection = "Server=localhost;Database=felvetelisql;User ID=root;Password=;";

            using (MySqlConnection con = new MySqlConnection(connection))
            {
                try
                {
                    con.Open();
                    diakok.Clear();
                    string selectSzoveg = "SELECT * FROM felvetelitabla";

                    using (MySqlCommand selectParancs = new MySqlCommand(selectSzoveg, con))
                    {
                        using (MySqlDataReader reader = selectParancs.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                diakok.Add(new Ujdiak(reader.GetString("om"), reader.GetString("nev"), reader.GetString("email"), DateTime.Now, reader.GetString("cim"), reader.GetInt32("magyar"), reader.GetInt32("matek")));
                            }
                        }
                    }
                    dgLista.ItemsSource = diakok;
                    con.Close();
                    MessageBox.Show(":)");


                }
                catch (Exception ex)
                {
                    MessageBox.Show(":(\n" + ex);
                }
            }

        }
    }
}
