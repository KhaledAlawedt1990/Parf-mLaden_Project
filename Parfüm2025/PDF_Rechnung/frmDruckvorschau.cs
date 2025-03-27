using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Busnisse_Layer;
using clsHilfsMethoden;

namespace Parfüm2025
{
    public partial class frmDruckvorschau : Form
    {
        private Panel pnlFooter;
        private Label lblFooter;

        private const int MAX_ZEILEN_PRO_SEITE = 17;
        private int ZeileHinzugefügt = 0;
        private List<clsRechnungsdetails> _verkaufsdatenListe;
        private clsKunde _kudedaten;
        private int _belegID;

        // Diese Felder werden zur Aggregation verwendet
        private float _einzelPreis = 0;
        private float _gesamtPreis = 0;

        public frmDruckvorschau(int belegID, List<clsRechnungsdetails> verkaufsdatenListe, clsKunde kudedaten)
        {
            InitializeComponent();
            this.Size = new Size(800, 1150);
            InitializeFooter();

            _verkaufsdatenListe = verkaufsdatenListe;
            _kudedaten = kudedaten;
            _belegID = belegID;
            lblDatum.Text = DateTime.Now.Date.ToString("MM/dd/yyyy");
        }

        private void InitializeFooter()
        {
            pnlFooter = new Panel
            {
                Height = 30,
                Dock = DockStyle.Bottom,
                BackColor = Color.YellowGreen,
                Visible = true
            };

            lblFooter = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new System.Drawing.Font("Lato", 12, FontStyle.Regular),
                Text = "Diese Vorlage wurde von Alowidat erstellt",
                Visible = true
            };

            pnlFooter.Controls.Add(lblFooter);
            // Wir fügen das Footer-Panel zum Hauptpanel hinzu,
            // damit es immer am unteren Rand von pnlHaupPanel erscheint.
            this.pnlHaupPanel.Controls.Add(pnlFooter);
            pnlFooter.BringToFront();
        }

        #region PDF-Erstellung

        private void SaveAllPagesToPdf()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "Rechnung.pdf");

            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            using (Document pdfDoc = new Document(PageSize.A4))
            {
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();

                int totalRows = _verkaufsdatenListe.Count;
                int startIndex = 0;

                // Setze die Aggregationsvariablen zurück
                _einzelPreis = 0;
                _gesamtPreis = 0;

                while (startIndex < totalRows)
                {
                    // Lade die aktuellen 17 Zeilen aus der Liste
                    var aktuelleSeiteDaten = _verkaufsdatenListe.Skip(startIndex).Take(MAX_ZEILEN_PRO_SEITE).ToList();

                    

                    dgvVerkaufsdaten.Rows.Clear();
                    foreach (var item in aktuelleSeiteDaten)
                    {
                        dgvVerkaufsdaten.Rows.Add(
                            item.parfümNummer,
                            $"{item.verkaufsMenge} Gr",
                            19,
                            item.normalPreis.ToString("C"),
                            item.gesamtPreis.ToString("C")
                        );
                    }

                    SaveCurrentPageToPdf(pdfDoc);
                    startIndex += MAX_ZEILEN_PRO_SEITE;
                }

                // Auf der letzten Seite fügen wir nun die Summen hinzu.
                // Berechne Netto, Steuer und Brutto aus _gesamtPreis
                // Angenommen: Brutto = _gesamtPreis, Netto = Brutto / 1,19, Steuer = Brutto - Netto
                             // Aktualisiere die Labels
                lblNetto.Text = _einzelPreis.ToString("C");
                lblSteuer.Text = 0.ToString("C");
                lblBrutto.Text = _gesamtPreis.ToString("C");

                // Erstelle eine Tabelle, um die Summen anzuzeigen
                PdfPTable summaryTable = new PdfPTable(2);
                summaryTable.WidthPercentage = 100;
                summaryTable.AddCell("Netto:");
                summaryTable.AddCell(lblNetto.Text);
                summaryTable.AddCell("Steuer:");
                summaryTable.AddCell(lblSteuer.Text);
                summaryTable.AddCell("Brutto:");
                summaryTable.AddCell(lblBrutto.Text);

                pdfDoc.Add(summaryTable);
                pdfDoc.Close();
            }

            MessageBox.Show($"PDF gespeichert: {filePath}");
        }

        private void SaveCurrentPageToPdf(Document pdfDoc)
        {
            using (Bitmap bitmap = new Bitmap(pnlHaupPanel.DisplayRectangle.Width, pnlHaupPanel.DisplayRectangle.Height))
            {
                pnlHaupPanel.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height));

                iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(bitmap, System.Drawing.Imaging.ImageFormat.Png);
                // Passe die Skalierung an, damit der Inhalt gut auf A4 passt
                pdfImage.ScaleToFit(pdfDoc.PageSize.Width - 20, pdfDoc.PageSize.Height - 20);
                pdfImage.Alignment = iTextSharp.text.Image.ALIGN_CENTER;

                pdfDoc.Add(pdfImage);
                pdfDoc.NewPage();
            }
        }
        #endregion

        #region Datenanzeige und -bearbeitung

        public void _FülleKundedaten()
        {
            lblVollname.Text = _kudedaten.Vollname;
            lblStrasse.Text = _kudedaten.Straße;
            lblStadt.Text = _kudedaten.Stadt;
        }

        public void _FülleRechnungsdetails()
        {
            lblBelegID.Text = _belegID.ToString();

            dgvVerkaufsdaten.SuspendLayout();
            dgvVerkaufsdaten.Rows.Clear();

            foreach (var item in _verkaufsdatenListe)
            {
                dgvVerkaufsdaten.Rows.Add(
                    item.parfümNummer,
                    $"{item.verkaufsMenge} Gr",
                    19,
                    item.normalPreis.ToString("C"),
                    item.gesamtPreis.ToString("C")
                );
            }

            dgvVerkaufsdaten.ResumeLayout();
            UpdateSummeRow();
        }

        private void UpdateSummeRow()
        {
            float summeEinzelPreis = 0;
            float summeGesamtPreis = 0;

            // Verwende NumberStyles.Currency, falls die Werte formatiert sind
            foreach (DataGridViewRow row in dgvVerkaufsdaten.Rows)
            {
                if (row.Cells[3].Value != null &&
                    float.TryParse(row.Cells[3].Value.ToString(), NumberStyles.Currency, CultureInfo.CurrentCulture, out float einzelPreis))
                {
                    summeEinzelPreis += einzelPreis;
                    _einzelPreis += summeGesamtPreis; 
                }
                if (row.Cells[4].Value != null &&
                    float.TryParse(row.Cells[4].Value.ToString(), NumberStyles.Currency, CultureInfo.CurrentCulture, out float gesamtPreis))
                {
                    summeGesamtPreis += gesamtPreis;
                    _gesamtPreis += summeGesamtPreis;
                }
            }

            _BearbeiteSteuerdaten(summeGesamtPreis, summeEinzelPreis);
        }

        private void _BearbeiteSteuerdaten(float summeGesamtPreis, float summeEinzelPreis)
        {
            // Hier nehmen wir an, dass summeGesamtPreis den Bruttobetrag darstellt.
          
            

            lblNetto.Text = summeEinzelPreis.ToString("C");
            lblSteuer.Text = 0.ToString("C");
            lblBrutto.Text = summeGesamtPreis.ToString("C");
        }

        private void UpdateDataGridViewHeight()
        {
            int rowHeight = dgvVerkaufsdaten.RowTemplate.Height;
            int headerHeight = dgvVerkaufsdaten.ColumnHeadersHeight;
            int rowCount = dgvVerkaufsdaten.Rows.Count;
            int newHeight = (rowHeight * rowCount) + headerHeight;
            int maxHeight = 400;

            dgvVerkaufsdaten.Height = Math.Min(newHeight, maxHeight);
            pnlNettoBrutto.Top = dgvVerkaufsdaten.Bottom + 1;
            pnlHaupPanel.Invalidate();
        }
        #endregion

        #region Event-Handler

        private void frmDruckvorschau_Load(object sender, EventArgs e)
        {
            _FülleKundedaten();
            _FülleRechnungsdetails();
            UpdateDataGridViewHeight();
        }

        private void dgvVerkaufsdaten_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ZeileHinzugefügt = MAX_ZEILEN_PRO_SEITE * dgvVerkaufsdaten.Rows.Count;
            UpdateSummeRow();
            UpdateDataGridViewHeight();
        }

        private void dgvVerkaufsdaten_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ZeileHinzugefügt = MAX_ZEILEN_PRO_SEITE * dgvVerkaufsdaten.Rows.Count;
            UpdateSummeRow();
            UpdateDataGridViewHeight();
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void konvertiereZurPdfDateiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAllPagesToPdf();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveAllPagesToPdf();
            this.Close();
        }
        #endregion
    }
}