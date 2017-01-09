using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Net;

namespace BibliotecaVirtual
{
    public partial class ReportePrueba : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReport_Click(object sender, EventArgs e)
        {
            Document doc = new Document(PageSize.LETTER);
            // FileStream fs = new FileStream("ReportExample.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
            //var fs = new FileStream(Server.MapPath("MyFirstPDF.pdf"), FileMode.Create);
            //PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            string FilePathdocument = Server.MapPath("~/Files/prueba1.pdf");
            PdfWriter writer = PdfWriter.GetInstance(doc,new FileStream(FilePathdocument, FileMode.Create));

            // Le colocamos el título y el autor
            // **Nota: Esto no será visible en el documento
            doc.AddTitle("Mi primer PDF");
            doc.AddCreator("Arturo Hernandez");

            //Se Abre el Archivo
            doc.Open();

            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            //Se Escribe el encabezamiento del documento
            doc.Add(new Paragraph("Report Usuarios"));
            doc.Add(Chunk.NEWLINE);

            // Creamos una tabla que contendrá el nombre, apellido y país
            // de nuestros visitante.

            PdfPTable tblreport = new PdfPTable(3);
            tblreport.WidthPercentage = 100;

            //Se asigna el titulo de las columnas de la tabla
            PdfPCell clNombre = new PdfPCell(new Phrase("Nombre", _standardFont));
            clNombre.BorderWidth = 0;
            clNombre.BorderWidthBottom = 0.75f;

            PdfPCell clApellido = new PdfPCell(new Phrase("Apellido", _standardFont));
            clApellido.BorderWidth = 0;
            clApellido.BorderWidthBottom = 0.75f;

            PdfPCell clPais = new PdfPCell(new Phrase("Apellido", _standardFont));
            clPais.BorderWidth = 0;
            clPais.BorderWidthBottom = 0.75f;

            //Se añaden las celdas a la tabla
            tblreport.AddCell(clNombre);
            tblreport.AddCell(clApellido);
            tblreport.AddCell(clPais);

            //Se llena la tabla con la informacion

            clNombre = new PdfPCell(new Phrase("Roberto", _standardFont));
            clNombre.BorderWidth = 0;

            clApellido = new PdfPCell(new Phrase("Torres", _standardFont));
            clApellido.BorderWidth = 0;

            clPais = new PdfPCell(new Phrase("Mexico", _standardFont));
            clPais.BorderWidth = 0;


            //Se añade las celdas a la tabla
            tblreport.AddCell(clNombre);
            tblreport.AddCell(clApellido);
            tblreport.AddCell(clPais);

            // Finalmente, se añade la tabla al documento PDF y se cierra el documento
            doc.Add(tblreport);

            doc.Close();
            writer.Close();

            string FilePath = Server.MapPath("~/Files/prueba.pdf");
            //WebClient User = new WebClient();
            //Byte[] FileBuffer = User.DownloadData(FilePath);
            //if (FileBuffer != null)
            //{
            //    Response.ContentType = "application/pdf";
            //    Response.AddHeader("content-length", FileBuffer.Length.ToString());
            //    Response.BinaryWrite(FileBuffer);
            //}
            string path = string.Format(@"<iframe src='/Files/prueba.pdf' style='width: 100 %; height: 700px;' frameborder='0'></iframe>");
            this.ltlFrame.Text = path;
            
        }
    }
}