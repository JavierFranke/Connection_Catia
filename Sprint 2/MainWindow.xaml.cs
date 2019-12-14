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
            System.Windows.Application.Current.Shutdown();
        }

        private void trv_quadrat_Selected(object sender, RoutedEventArgs e)
        {
            grid_dreieck.Visibility = Visibility.Hidden;
            grid_halbkreis.Visibility = Visibility.Hidden;
            grid_kreis.Visibility = Visibility.Hidden;
            grid_quadrat.Visibility = Visibility.Visible;
            grid_rechteck.Visibility = Visibility.Hidden;
        }

        private void trv_rechteck_Selected(object sender, RoutedEventArgs e)
        {
            grid_dreieck.Visibility = Visibility.Hidden;
            grid_halbkreis.Visibility = Visibility.Hidden;
            grid_kreis.Visibility = Visibility.Hidden;
            grid_quadrat.Visibility = Visibility.Hidden;
            grid_rechteck.Visibility = Visibility.Visible;
        }

        private void trv_dreieck_Selected(object sender, RoutedEventArgs e)
        {
            grid_dreieck.Visibility = Visibility.Visible;
            grid_halbkreis.Visibility = Visibility.Hidden;
            grid_kreis.Visibility = Visibility.Hidden;
            grid_quadrat.Visibility = Visibility.Hidden;
            grid_rechteck.Visibility = Visibility.Hidden;
        }

        private void trv_kreis_Selected(object sender, RoutedEventArgs e)
        {
            grid_dreieck.Visibility = Visibility.Hidden;
            grid_halbkreis.Visibility = Visibility.Hidden;
            grid_kreis.Visibility = Visibility.Visible;
            grid_quadrat.Visibility = Visibility.Hidden;
            grid_rechteck.Visibility = Visibility.Hidden;
        }

        private void trv_halbkreis_Selected(object sender, RoutedEventArgs e)
        {
            grid_dreieck.Visibility = Visibility.Hidden;
            grid_halbkreis.Visibility = Visibility.Visible;
            grid_kreis.Visibility = Visibility.Hidden;
            grid_quadrat.Visibility = Visibility.Hidden;
            grid_rechteck.Visibility = Visibility.Hidden;
        }

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


        private void Btn_rechne_Click(object sender, RoutedEventArgs e)
        {

            string breitedreick = Convert.ToString(txb_breitedreieck.Text);
            string hoehedreieck = Convert.ToString(txb_hoehedreieck.Text);
            string dickedreick = Convert.ToString(txb_dickedreick.Text);
            string dichtedreieck = Convert.ToString(txb_dichtedreieck.Text);


            Double Breite = Convert.ToDouble(breitedreick);
            Double Hoehe = Convert.ToDouble(hoehedreieck);
            Double Dicke = Convert.ToDouble(dickedreick);
            Double Dichte = Convert.ToDouble(dichtedreieck);

            Double Volumen = Breite * Hoehe * Dicke;
            Double Gewicht = Volumen * Dichte;
            Double Flaeche = Breite * Hoehe;

            txb_volumenrechteck.Text = Convert.ToString(Volumen);
            txb_gewichtrechteck.Text = Convert.ToString(Gewicht);
            txb_flaecherechteck.Text = Convert.ToString(Flaeche);


        }



        //Rechnung von Rechteck
        private void btn_rechnerechteck_Click(object sender, RoutedEventArgs e)
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





        //Rechnung von einem Quadrat
        private void Btn_rechne_Click(object sender, RoutedEventArgs e)
        {
            string hoehe = Convert.ToString(txb_hoehe.Text);
            string dichte = Convert.ToString(txb_dichte.Text);


            Double hoehe = Convert.ToDouble(txb_hoehe);
            Double Dichte = Convert.ToDouble(txb_dichtequadrant.text);

            Double Volumen = Math.Pow(hoeher, 2) * laenge;
            Double Gewicht = Volumen * Dichte;
            Double Flaeche = Math.Pow(höer, 2);
            Double ftmiyquadrat = 0.118 * Math.Pow(hoehe, 3);
            Double ftmixquadrat = Math.Pow(hoehe, 2) / 6;
            txb_volumenrechteck.Text = Convert.ToString(Volumen);
            txb_gewichtrechteck.Text = Convert.ToString(Gewicht);
            txb_flaecherechteck.Text = Convert.ToString(Flaeche);
            Txb_ftmiyquadrat.Text = Convert.ToDouble(ftmiyquadrat);
            Txb_ftmixquadrat.Text = Convert.ToDouble(ftmixquadrat);
        }


        //Rechnung von einem Ring
        private void Btn_rechne_Click(object sender, RoutedEventArgs e)
        {
            string innendurchmesser = Convert.ToString(txb_innendurchmesser.Text);
            string aussendurchmesser = Convert.ToString(txb_aussendurchmesser.Text);
            string dichtering = Convert.ToString(txb_dichterring.Text);


            Double innendurchmesser = Convert.ToDouble(innendurchmesser);
            Double aussendurchmesser = Convert.ToDouble(aussendurchmesser);
            Double Dichte = Convert.ToDouble(dichtering);

            Double Volumen = (3, 14 * (innendurchmesser - aussendurchmesser) ^ 3 * 3) / 4;
            Double Gewicht = Volumen * Dichte;
            Double Flaeche = Math.Pow((innendurchmesser - aussendurchmesser), 2) * Math.PI;

            txb_volumenrechteck.Text = Convert.ToString(Volumen);
            txb_gewichtrechteck.Text = Convert.ToString(Gewicht);
            txb_flaecherechteck.Text = Convert.ToString(Flaeche);

            //Rechnung von einem halb Ring
            private void Btn_rechne_Click(object sender, RoutedEventArgs e)
            {

                string innendurchmesse = Convert.ToString(txb_innendurchmesser.Text);
                string aussendurchmesser = Convert.ToString(txb_aussendurchmesser.Text);
                string dichtekreis = Convert.ToString(txb_dichtekreis.Text);

                Double Durchmesser1 = Convert.ToDouble(innendurchmesser);
                Double Durchmesser2 = Convert.ToDouble(aussendurchmesser);
                Double Dichte = Convert.ToDouble(dichtekreis);

                Double Volumen = (Math.PI * Math.Pow((Durchmesser1 - Durchmesser2), 2) * 3) / 8;
                Double Gewicht = Volumen * Dichte;
                Double Flaeche = ((Durchmesser1 - Durchmesser2) ^ 3 * Math.PI) / 2;

                txb_volumenrechteck.Text = Convert.ToString(Volumen);
                txb_gewichtrechteck.Text = Convert.ToString(Gewicht);
                txb_flaecherechteck.Text = Convert.ToString(Flaeche);

            }
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

        private void txb_hoeherechteck_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            double zahl;

            if (Double.TryParse(tb.Text, out zahl))
            {
                tb.Background = Brushes.Green;
                tb.Foreground = Brushes.Black;
                // alles gut
            }
            else
            {
                MessageBox.Show("Es dürfen nur positive Zahlen eingegeben werden!", "Fehler");
                // Fehler
            }
        }

        private void txb_hoeherechteck_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Foreground = Brushes.Black;
            tb.Background = Brushes.White;
        }

       

        public void Button_Click(object sender, RoutedEventArgs e)
        {
           
            Catia_Connection cc = new Catia_Connection();
            if (cc.laeuftCatia())
            {
                int h = Convert.ToInt32(txb_hoeherechteck.Text);
                int b = Convert.ToInt32(txb_breiterechteck.Text);
                int d = Convert.ToInt32(txb_dickerechteck.Text);
                cc.ErzeugePart();
                cc.erstelleLeereSkizze();
                cc.ErzeugeProfil(h,b);
                cc.ErzeugeBalken(d);
            }
        }

    }


    }


           
        
        

    

    


