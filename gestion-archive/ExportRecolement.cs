using iText.Kernel.Exceptions;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExportRecolment
{
    internal class ExportRecolement
    {
        public void Download(NpgsqlConnection conn)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog(); //Crée une nouvelle fenetre de dialogue pour l'enregistrement des fichiers

            // Définition des propriétés du fichier
            saveFileDialog.Title = "Enregistrer le recolement"; //Titre fenêtre
            saveFileDialog.Filter = "Fichiers pdf (*.pdf)|*.pdf"; //Formats disponibles

            // Afficher la boîte de dialogue et vérifier si l'utilisateur a appuyé sur le bouton OK
            if (saveFileDialog.ShowDialog() == DialogResult.OK) //L'utilisateur valide l'enregistrement
            {
                // Utiliser le chemin d'accès au fichier pour enregistrer les données, si nécessaire
                string selectedFilePath = saveFileDialog.FileName; //Récupère le chemin choisi par l'utilisateur
                CreateRecolement(selectedFilePath, conn); //Appelle méthode la création du récolement à exporter
                MessageBox.Show($"Récolement généré à l'emplacement : {selectedFilePath}"); //Message que l'opération a réussi à l'utilisateur
            }
        }
        private void CreateRecolement(string FilePath, NpgsqlConnection conn)
        {
            try
            {
                //Recuperation du recolement depuis la BDD et placement dans une DataTable
                var requete_recolement = new NpgsqlCommand("SELECT archive.id_archive, archive.cote, emplacement.id_emplacement, lieu.nom FROM archive INNER JOIN emplacement ON archive.id_emplacement = emplacement.id_emplacement INNER JOIN lieu ON emplacement.id_lieu = lieu.id_lieu WHERE archive.id_emplacement IS NOT NULL", conn);

                requete_recolement.Prepare();

                DataTable dt = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(requete_recolement);
                da.Fill(dt);

                try
                {
                    //Génération du PDF
                    using (FileStream fs = new FileStream(FilePath, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        using (PdfWriter writer = new PdfWriter(fs))
                        {
                            using (PdfDocument pdf = new PdfDocument(writer))
                            {
                                Document document = new Document(pdf);

                                int numberOfPages = pdf.GetNumberOfPages();
                                for (int i = 0; i <= numberOfPages; i++)
                                {
                                    // Pied de page (A.D)
                                    document.ShowTextAligned(new Paragraph("A.D"),
                                        560, 20, i,
                                        TextAlignment.RIGHT, VerticalAlignment.BOTTOM, 0);

                                    // En-tête (Ville de Saint-Chamond)
                                    document.ShowTextAligned(new Paragraph("Ville de Saint-Chamond"),
                                        20, 820, i,
                                        TextAlignment.LEFT, VerticalAlignment.TOP, 0);
                                }

                                //Titre
                                Paragraph title = new Paragraph("Recolement des archives de la commune du " + DateTime.Now.ToString("dd/MM/yyyy")) //Affiche titre avec date d'aujourd'hui
                                    .SetTextAlignment(TextAlignment.CENTER)
                                    .SetFontSize(15)
                                    .SetBold()
                                    .SetUnderline();

                                document.Add(title);
                                document.Add(new Paragraph("***************************************************")
                                    .SetTextAlignment(TextAlignment.CENTER))
                                    .SetFontSize(15)
                                    .SetBold();

                                Table table = new Table(UnitValue.CreatePercentArray(new float[] { 25, 25, 25, 25 })).UseAllAvailableWidth();
                                table.SetFontSize(11);

                                // En-têtes tableau
                                table.AddHeaderCell("ID Archive");
                                table.AddHeaderCell("Côte");
                                table.AddHeaderCell("ID Emplacement");
                                table.AddHeaderCell("Nom Emplacement");

                                // Remplir le tableau avec les données
                                foreach (DataRow row in dt.Rows)//Parcours les lignes de la datatable
                                {
                                    for (int i = 0; i < 4; i++)
                                    {
                                        table.AddCell(row[i].ToString());
                                    }
                                }

                                document.Add(table);
                            }
                        }
                    }
                }
                catch (PdfException ex)
                {
                    MessageBox.Show("Erreur PDF : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur générale : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la connexion à la BDD" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
