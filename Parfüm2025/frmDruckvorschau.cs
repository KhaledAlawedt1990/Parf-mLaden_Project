using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parfüm2025
{
    public partial class frmDruckvorschau : Form
    {
        public frmDruckvorschau()
        {
            InitializeComponent();

            _MaleEcke();
            //_MaleOntherEcke();

            lblDatum.Text = DateTime.Now.ToString();
        }

        private void _MaleEcke()
        {
            // Erstelle ein Panel für die Ecke

            pnlHaupPanel.Paint += (sender, e) =>
            {
                // Grafikobjekt für das Panel
                Graphics g = e.Graphics;

                // Berechne die Position und Größe des Panels
                int width = pnlHaupPanel.Width;  // Breite des Panels
                int height = pnlHaupPanel.Height; // Höhe des Panels

                // Definiere die Punkte für das Dreieck in der unteren rechten Ecke
                Point[] points = new Point[]
                {
                    new Point(width, height),       // Untere rechte Ecke
                    new Point(width - 800, height),  // 50 Pixel nach links (unten)
                     new Point(width, height - 450)   // 50 Pixel nach oben (rechts)
                };

                // Fülle das Dreieck mit der grünen Farbe
                g.FillPolygon(Brushes.YellowGreen, points);
            };
        }

        private void _MaleOntherEcke()
        {
            // Erstelle ein Panel für die Ecke

            pnlHaupPanel.Paint += (sender, e) =>
            {
                // Grafikobjekt für das Panel
                Graphics g = e.Graphics;

                // Berechne die Position und Größe des Panels
                int width = pnlHaupPanel.Width;  // Breite des Panels
                int height = pnlHaupPanel.Height; // Höhe des Panels

                // Definiere die Punkte für das Dreieck in der unteren rechten Ecke
                Point[] points = new Point[]
                {
                               new Point(0, height),           // Untere linke Ecke des Panels
                             new Point(450, height),         // 100 Pixel nach rechts
                                new Point(0, height - 450)      // 100 Pixel nach oben
 
                };

                // Fülle das Dreieck mit der grünen Farbe
                g.FillPolygon(Brushes.Gold, points);
            };
        }
        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Das Panel, dessen Inhalte gedruckt werden sollen
            Panel panelToPrint = this.pnlHaupPanel; // Beispiel: Dein Hauptpanel

            using (Bitmap bmp = new Bitmap(panelToPrint.Width, panelToPrint.Height))
            {
                // Panel in ein Bitmap rendern
                panelToPrint.DrawToBitmap(bmp, new Rectangle(0, 0, panelToPrint.Width, panelToPrint.Height));

                // Speichere das Bitmap, um zu überprüfen, ob es korrekt ist
               // bmp.Save("test_output.png", System.Drawing.Imaging.ImageFormat.Png);

                //// Berechnung der Skalierung basierend auf der Papiergröße
                //float scaleX = e.MarginBounds.Width / (float)panelToPrint.Width;
                //float scaleY = e.MarginBounds.Height / (float)panelToPrint.Height;
                //float scale = Math.Min(scaleX, scaleY); // Proportional skalieren

                // Zentrierung (optional)
                float offsetX = (e.MarginBounds.Width - panelToPrint.Width) / 2;
                float offsetY = (e.MarginBounds.Height - panelToPrint.Height) / 2;

                // Panel in der Vorschau oder auf dem Papier zeichnen
                e.Graphics.DrawImage(bmp, e.MarginBounds.Left + offsetX, e.MarginBounds.Top + offsetY,
                    panelToPrint.Width, panelToPrint.Height);
            }
            // Optional: Wenn du mehrere Seiten drucken möchtest, setze e.HasMorePages auf true
            e.HasMorePages = false;  // Falls nur eine Seite gedruckt werden soll
        }

        private void btnDrucken_Click(object sender, EventArgs e)
        {
            if (pnlHaupPanel == null || pnlHaupPanel.Controls.Count == 0)
            {
                MessageBox.Show("Das Panel hat keine Inhalte zum Drucken.");
                return;
            }
            try
            {
                // Öffne den Druckdialog
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Druckauftrag starten
                    printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                    printDocument1.Print();
                }
                else
                {
                    MessageBox.Show("Der Druckvorgang wurde abgebrochen.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Behandle Druckfehler
                MessageBox.Show($"Beim Drucken ist ein Fehler aufgetreten: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
