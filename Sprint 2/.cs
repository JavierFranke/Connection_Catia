using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INFITF;
using MECMOD;
using PARTITF;
using System.Windows.Input;
using System.Windows;

namespace Catia_Connection
{
    class Catia_Connection
    {
       
        
            INFITF.Application hsp_catiaApp;
            MECMOD.PartDocument hsp_catiaPart;
            MECMOD.Sketch hsp_catiaProfil;


            public bool laeuftCatia()
            {
                try
                {
                    object co =
                   System.Runtime.InteropServices.Marshal.GetActiveObject("CATIA.Application");
                    hsp_catiaApp = (INFITF.Application)co;  // _____________________________________muss geändert werden wegen mehrdeutiger Verweis
                    return true;

                }
                catch
                {

                    //MessageBox.Show("");
                    return false;

                    //return true;
                }
            }

            internal void erstelleLeereSkizze()
            {
                HybridBodies catHybridBodies1 = hsp_catiaPart.Part.HybridBodies;
                HybridBody catHybridBody1;
                catHybridBody1 = catHybridBodies1.Item("Geometrisches Set.1");

                catHybridBody1.set_Name("Profile"); // Erstelle eine Skizze mit dem Namen Profile
                Sketches catSketches1 = catHybridBody1.HybridSketches; // Mit den genannten die Umrisse erstellen

                Reference catReference1 = (Reference)hsp_catiaPart.Part.OriginElements.PlaneYZ;
                hsp_catiaProfil = catSketches1.Add(catReference1);
            }


            public void erzeugePart()
            {
                //erzeuge Part
                Document partdoc = hsp_catiaApp.Documents.Add("Part");

                hsp_catiaPart = (PartDocument)partdoc;
            }
        }
            
}
