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



namespace Sprint_2
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window  //_________________________________________ muss geändert werden wegen mehrdeutiger Verweis
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_ende_Click(object sender, RoutedEventArgs e)
        {

            if (MessageBox.Show("Wollen Sie das Programm wirklich beenden?", "Schließen des Programms", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void trv_quadrat_Selected(object sender, RoutedEventArgs e)
        {
            grid_dreieck.Visibility = Visibility.Hidden;
            grid_kreisring.Visibility = Visibility.Hidden;
            grid_kreis.Visibility = Visibility.Hidden;
            grid_quadrat.Visibility = Visibility.Visible;
            grid_rechteck.Visibility = Visibility.Hidden;
        }

        private void trv_rechteck_Selected(object sender, RoutedEventArgs e)
        {
            grid_dreieck.Visibility = Visibility.Hidden;
            grid_kreisring.Visibility = Visibility.Hidden;
            grid_kreis.Visibility = Visibility.Hidden;
            grid_quadrat.Visibility = Visibility.Hidden;
            grid_rechteck.Visibility = Visibility.Visible;
        }

        private void trv_dreieck_Selected(object sender, RoutedEventArgs e)
        {
            grid_dreieck.Visibility = Visibility.Visible;
            grid_kreisring.Visibility = Visibility.Hidden;
            grid_kreis.Visibility = Visibility.Hidden;
            grid_quadrat.Visibility = Visibility.Hidden;
            grid_rechteck.Visibility = Visibility.Hidden;
        }

        private void trv_kreis_Selected(object sender, RoutedEventArgs e)
        {
            grid_dreieck.Visibility = Visibility.Hidden;
            grid_kreisring.Visibility = Visibility.Hidden;
            grid_kreis.Visibility = Visibility.Visible;
            grid_quadrat.Visibility = Visibility.Hidden;
            grid_rechteck.Visibility = Visibility.Hidden;
        }

        private void trv_halbkreis_Selected(object sender, RoutedEventArgs e)
        {
            grid_dreieck.Visibility = Visibility.Hidden;
            grid_kreisring.Visibility = Visibility.Visible;
            grid_kreis.Visibility = Visibility.Hidden;
            grid_quadrat.Visibility = Visibility.Hidden;
            grid_rechteck.Visibility = Visibility.Hidden;
        }

        //Rechnung von Rechteck
        public void btn_rechnerechteck_Click(object sender, RoutedEventArgs e)
        {
            double hoeherechteck = Convert.ToDouble(txb_hoeherechteck.Text);
            double breiterechteck = Convert.ToDouble(txb_breiterechteck.Text);
            double dickerechteck = Convert.ToDouble(txb_dickerechteck.Text);
            double dichterechteck = Convert.ToDouble(txb_dichterechteck.Text);

            double flaecherechteck = hoeherechteck * breiterechteck;
            double volumenrechteck = flaecherechteck * dickerechteck;
            double gewichtrechteck = volumenrechteck * dichterechteck;
            double ftmizrechteck = hoeherechteck * Math.Pow(breiterechteck, 3) / 12;
            double ftmiyrechteck = breiterechteck * Math.Pow(hoeherechteck, 3) / 12;

            txb_flaecherechteck.Text = Convert.ToString(flaecherechteck);
            txb_volumenrechteck.Text = Convert.ToString(volumenrechteck);
            txb_gewichtrechteck.Text = Convert.ToString(gewichtrechteck);
            txb_ftmizrechteck.Text = Convert.ToString(ftmizrechteck);
            txb_ftmiyrechteck.Text = Convert.ToString(ftmiyrechteck);

        }
        //Rechnungdreieck
        private void btn_rechnedreieck_Click(object sender, RoutedEventArgs e)
        {
            double breite = Convert.ToDouble(txb_breitedreieck.Text);
            double hoehe = Convert.ToDouble(txb_hoehedreieck.Text);
            double dicke = Convert.ToDouble(txb_dickedreieck.Text);
            double dichte = Convert.ToDouble(txb_dichtedreieck.Text);

            double Volumen = breite * hoehe * dicke;
            double Gewicht = Volumen * dichte;
            double Flaeche = breite * hoehe;
            double ftmizdreieck = (hoehe * Math.Pow(breite, 3)) / 48;
            double ftmiydreieck = (breite * Math.Pow(hoehe, 3)) / 36;

            txb_volumendreieck.Text = Convert.ToString(Volumen);
            txb_gewichtdreieck.Text = Convert.ToString(Gewicht);
            txb_flaechedreieck.Text = Convert.ToString(Flaeche);
            txb_ftmizdreieck.Text = Convert.ToString(ftmizdreieck);
            txb_ftmiydreieck.Text = Convert.ToString(ftmiydreieck);

        }
        private void btn_rechnequadrat_Click(object sender, RoutedEventArgs e)
        {
            double Länge = Convert.ToDouble(txb_längequadrat.Text);
            double Dicke = Convert.ToDouble(txb_dickequadrat.Text);
            double Dichte = Convert.ToDouble(txb_dichtequadrat.Text);

            double fläche = Math.Pow(Länge, 2);
            double volumen = Länge * Dicke;
            double gewicht = volumen * Dichte;
            double ftm = Math.Pow(Länge, 4) / 12;

            txb_flaechequadrat.Text = Convert.ToString(fläche);
            txb_volumenquadrat.Text = Convert.ToString(volumen);
            txb_gewichtquadrat.Text = Convert.ToString(gewicht);
            txb_ftmiyquadrat.Text = Convert.ToString(ftm);
            txb_ftmizquadrat.Text = Convert.ToString(ftm);
        }

        private void Btn_rechnekreis_Click(object sender, RoutedEventArgs e)
        {
            double durchmesser = Convert.ToDouble(txb_durchmesserkreis.Text);
            double dicke = Convert.ToDouble(txb_dickekreis.Text);
            double dichte = Convert.ToDouble(txb_dichtekreis.Text);

            double fläche = Math.PI * Math.Pow(durchmesser / 2, 2);
            double volumen = fläche * dicke;
            double gewicht = volumen * dichte;
            double ftm = (Math.PI * Math.Pow(durchmesser, 4)) / 64;

            txb_flaechekreis.Text = Convert.ToString(fläche);
            txb_volumenkreis.Text = Convert.ToString(volumen);
            txb_gewichtkreis.Text = Convert.ToString(gewicht);
            txb_ftmiykreis.Text = Convert.ToString(ftm);
            txb_ftmizkreis.Text = Convert.ToString(ftm);

        }

        private void Btn_rechnekreisring_Click(object sender, RoutedEventArgs e)
        {

            double außendurchmesser = Convert.ToDouble(txb_außendurchmesserkreisring.Text);
            double innendurchmesser = Convert.ToDouble(txb_innendurchmesserkreisring.Text);
            double dicke = Convert.ToDouble(txb_dickekreisring.Text);
            double dichte = Convert.ToDouble(txb_dichtekreisring.Text);
            if (außendurchmesser > innendurchmesser)
            {
                double fläche = Math.PI * Math.Pow(außendurchmesser / 2, 2) - (Math.PI * Math.Pow(innendurchmesser / 2, 2));
                double volumen = fläche * dicke;
                double gewicht = volumen * dichte;
                double ftm = (Math.PI * (Math.Pow(außendurchmesser, 4) - Math.Pow(innendurchmesser, 4))) / 64;

                txb_flaechekreisring.Text = Convert.ToString(fläche);
                txb_volumenkreisring.Text = Convert.ToString(volumen);
                txb_gewichtkreisring.Text = Convert.ToString(gewicht);
                txb_ftmiykreisring.Text = Convert.ToString(ftm);
                txb_ftmizkreisring.Text = Convert.ToString(ftm);
            }
            else
            {
                MessageBox.Show("Der Außendurchmesser muss größer als der Innendurchmesser sein!");

            }
        }
        private void Btn_löschenquadrat_Click(object sender, RoutedEventArgs e)
        {
            txb_ftmiyquadrat.Text = ("");
            txb_längequadrat.Text = ("");
            txb_dichtequadrat.Text = ("");
            txb_dickequadrat.Text = ("");
            txb_flaechequadrat.Text = ("");
            txb_ftmizquadrat.Text = ("");
            txb_gewichtquadrat.Text = ("");
            txb_volumenquadrat.Text = ("");
        }
        private void btn_clearrechteck_Click(object sender, RoutedEventArgs e)
        {
            txb_ftmiyrechteck.Text = ("");
            txb_breiterechteck.Text = ("");
            txb_dichterechteck.Text = ("");
            txb_dickerechteck.Text = ("");
            txb_flaecherechteck.Text = ("");
            txb_ftmizrechteck.Text = ("");
            txb_gewichtrechteck.Text = ("");
            txb_hoeherechteck.Text = ("");
            txb_volumenrechteck.Text = ("");
        }
        private void Btn_cleardreieck_Click(object sender, RoutedEventArgs e)
        {
            txb_ftmiydreieck.Text = ("");
            txb_breitedreieck.Text = ("");
            txb_dichtedreieck.Text = ("");
            txb_dickedreieck.Text = ("");
            txb_flaechedreieck.Text = ("");
            txb_ftmizdreieck.Text = ("");
            txb_gewichtdreieck.Text = ("");
            txb_hoehedreieck.Text = ("");
            txb_volumendreieck.Text = ("");
        }
        private void Btn_clearkreis_Click(object sender, RoutedEventArgs e)
        {
            txb_ftmiykreis.Text = ("");
            txb_durchmesserkreis.Text = ("");
            txb_dichtekreis.Text = ("");
            txb_dickekreis.Text = ("");
            txb_flaechekreis.Text = ("");
            txb_ftmizkreis.Text = ("");
            txb_gewichtkreis.Text = ("");
            txb_volumenkreis.Text = ("");
        }

        private void Btn_clearkreisring_Click(object sender, RoutedEventArgs e)
        {
            txb_ftmiykreisring.Text = ("");
            txb_außendurchmesserkreisring.Text = ("");
            txb_dichtekreisring.Text = ("");
            txb_dickekreisring.Text = ("");
            txb_flaechekreisring.Text = ("");
            txb_ftmizkreisring.Text = ("");
            txb_gewichtkreisring.Text = ("");
            txb_innendurchmesserkreisring.Text = ("");
            txb_volumenkreisring.Text = ("");


        }
        private void txb_hoeherechteck_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            double zahl;

            if (Double.TryParse(tb.Text, out zahl))
            {

                tb.Foreground = Brushes.Green;
                // alles gut
            }
            else
            {
                MessageBox.Show("Es dürfen nur positive Zahlen eingegeben werden!", "Fehler");
                // Fehler
                tb.Background = Brushes.Red;
            }
        }

        private void txb_hoeherechteck_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Foreground = Brushes.Black;
            tb.Background = Brushes.White;
        }





        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Catia_ConnectionQuadrat cc = new Catia_ConnectionQuadrat();
            if (cc.laeuftCatia())
            {
                int l = Convert.ToInt32(txb_längequadrat.Text);
                int d = Convert.ToInt32(txb_dickequadrat.Text);
                cc.ErzeugePart();
                cc.erstelleLeereSkizze();
                cc.ErzeugeProfil(l);
                cc.ErzeugeBalken(d);
            }
            else
            {
                MessageBox.Show("Bitte öffnen Sie CATIA!");
            }
        }

        private void Btn_catiarechteck_Click(object sender, RoutedEventArgs e)
        {
            Catia_Connection cc = new Catia_Connection();
            if (cc.laeuftCatia())
            {
                int h = Convert.ToInt32(txb_hoeherechteck.Text);
                int b = Convert.ToInt32(txb_breiterechteck.Text);
                int d = Convert.ToInt32(txb_dickerechteck.Text);
                cc.ErzeugePart();
                cc.erstelleLeereSkizze();
                cc.ErzeugeProfil(h, b);
                cc.ErzeugeBalken(d);
            }
            else
            {
                MessageBox.Show("Bitte öffnen Sie CATIA!");
            }
        }

        private void Btn_catiakreis_Click(object sender, RoutedEventArgs e)
        {
            Catia_ConnectionKreis cc = new Catia_ConnectionKreis();
            if (cc.laeuftCatia())
            {
                int r = Convert.ToInt32(txb_durchmesserkreis.Text);
                int d = Convert.ToInt32(txb_dickekreis.Text);



                cc.ErzeugePart();
                cc.erstelleLeereSkizze();
                cc.setMittelpunkt(r);
                cc.ErzeugeBalkenkreis(d);

            }
            else
            {
                MessageBox.Show("Bitte öffnen Sie bitte CATIA.");
            }
        }

        private void Btn_catiaring_Click(object sender, RoutedEventArgs e)
        {
            
                Catia_ConnectionRing cc = new Catia_ConnectionRing();
            if (cc.laeuftCatia())
            {
                //int r = Convert.ToInt32(txb_außendurchmesserkreisring);
                //int d = Convert.ToInt32(txb_dickekreis.Text);
                //int i = Convert.ToInt32(txb_innendurchmesserkreisring);


                cc.ErzeugePart();
                cc.erstelleLeereSkizze();
                cc.setMittelpunkt();
                cc.ErzeugeBalkenRing();
              

            }
            else
            {
                MessageBox.Show("Bitte öffnen Sie bitte CATIA.");
            }
        }
    }
}

           
        
        

    

    


