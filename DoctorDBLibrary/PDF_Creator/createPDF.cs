using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DoctorDBLibrary.PDF_Creator
{
    public class createPDF
    {
        public void pdfCreator(TextBox firstName, TextBox lastName, TextBox idNumber, TextBox contactNumber, TextBox medicalNumber, TextBox medicalType, TextBox DOB, ComboBox gender, TextBox emailAddress, TextBox Address)
        {
            try
            {


                #region Common Part
                PdfPTable table = new PdfPTable(1);

                //Footer Section
                PdfPTable footer = new PdfPTable(1);
                footer.DefaultCell.BorderWidth = 0;
                footer.WidthPercentage = 100;
                footer.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;

                Chunk cFooter = new Chunk("This is the Footer", FontFactory.GetFont("Times New Roman"));
                cFooter.Font.Size = 8;
                footer.AddCell(new Phrase(cFooter));
                // End Footer

                table.AddCell(new Phrase(" "));
                table.DefaultCell.Border = 0;
                #endregion

                #region Page
                #region Section-1 <Header FORM>
                PdfPTable pdftable1 = new PdfPTable(1);
                PdfPTable pdftable2 = new PdfPTable(1);
                PdfPTable pdftable3 = new PdfPTable(2);

              
                // This is the 3 tables created
                pdftable1.WidthPercentage = 80;
                pdftable1.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdftable1.DefaultCell.VerticalAlignment = Element.ALIGN_CENTER;
                pdftable1.DefaultCell.BorderWidth = 0;

                pdftable2.WidthPercentage = 80;
                pdftable2.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdftable2.DefaultCell.VerticalAlignment = Element.ALIGN_CENTER;
                pdftable2.DefaultCell.BorderWidth = 0;

                pdftable3.DefaultCell.Padding = 5;
                pdftable3.WidthPercentage = 80;
                pdftable3.DefaultCell.BorderWidth = 0.5f;

                Chunk c1 = new Chunk("Doctor DB", FontFactory.GetFont("Times New Roman"));
                c1.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c1.Font.SetStyle(0);
                c1.Font.Size = 14;
                Phrase p1 = new Phrase();
                p1.Add(c1);
                pdftable1.AddCell(p1);

                Chunk c2 = new Chunk("This is the PDF Form", FontFactory.GetFont("Times New Roman"));
                c2.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c2.Font.SetStyle(0);
                c2.Font.Size = 11;
                Phrase p2 = new Phrase();
                p2.Add(c2);
                pdftable2.AddCell(p2);

                Chunk c3 = new Chunk("Created by - Fawaaz Dassie 24/04/2019", FontFactory.GetFont("Times New Roman"));
                c3.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c3.Font.SetStyle(0);
                c3.Font.Size = 10;
                Phrase p3 = new Phrase();
                p3.Add(c3);
                pdftable2.AddCell(p3);
                #endregion

                #region Section <Bill Upper>
                PdfPTable pdfTable4 = new PdfPTable(4);
                pdfTable4.DefaultCell.Padding = 5;
                pdfTable4.WidthPercentage = 80;
                pdfTable4.DefaultCell.BorderWidth = 0.0f;

                #endregion


                #region SelectionTable
                pdftable3.AddCell(new Phrase("Full name:"));
                pdftable3.AddCell(new Phrase(string.Format("{0} {1}", firstName.Text, lastName.Text)));

                pdftable3.AddCell(new Phrase("ID Number"));
                pdftable3.AddCell(new Phrase(idNumber.Text));

                pdftable3.AddCell(new Phrase("Contact Number"));
                pdftable3.AddCell(new Phrase(contactNumber.Text));

                pdftable3.AddCell(new Phrase("Medical Aid Number"));
                pdftable3.AddCell(new Phrase(medicalNumber.Text));

                pdftable3.AddCell(new Phrase("Medical Aid Type"));
                pdftable3.AddCell(new Phrase(medicalType.Text));

                pdftable3.AddCell(new Phrase("DOB"));
                pdftable3.AddCell(new Phrase(DOB.Text));

                pdftable3.AddCell(new Phrase("Gender"));
                pdftable3.AddCell(new Phrase(gender.Text));

                pdftable3.AddCell(new Phrase("Email"));
                pdftable3.AddCell(new Phrase(emailAddress.Text));

                pdftable3.AddCell(new Phrase("Address"));
                pdftable3.AddCell(new Phrase(Address.Text));
                #endregion


                #region PDF Generation
                string folderPath = @"C:\Users\fdassie\Desktop\";

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                // File Name
                int fileCount = Directory.GetFiles(@"C:\Users\fdassie\Desktop\").Length;
                string strFileName = "TestPdf" + (fileCount + 1) + ".pdf";

                using (FileStream stream = new FileStream(folderPath + strFileName, FileMode.Create))
                {
                    Document doc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                    PdfWriter.GetInstance(doc, stream);
                    doc.Open();

                    #region Page-1
                    doc.Add(pdftable1);
                    doc.Add(pdftable2);
                    doc.Add(table);
                    doc.Add(pdftable3);
                    doc.Add(footer);
                    doc.NewPage();
                    #endregion

                    doc.Close();
                    stream.Close();
                }
                #endregion

                #region Display PDF
                System.Diagnostics.Process.Start(folderPath + "\\" + strFileName);
                #endregion

            }
            catch (Exception ex)
            {
                throw;
            }
            #endregion

        }
    }
}
