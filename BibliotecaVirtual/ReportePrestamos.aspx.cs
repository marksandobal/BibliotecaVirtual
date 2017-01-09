using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaVirtual.Biz;
using BibliotecaVirtual.BizConextions;
using BibliotecaVirtual.Model;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace BibliotecaVirtual
{
    public partial class ReportePrestamos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtFechaInicio.Text = DateTime.Today.ToString("yyyy-MM-dd");
                txtFechaFinal.Text = DateTime.Today.ToString("yyyy-MM-dd");

                rbPorFechaPrestamo.Checked = false;
                rbPorFechaVencimiento.Checked = false;
            }
        }
        protected void btnReport_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio;
            DateTime fechaFinal;
            bool porfechaPrestamo = false;

            fechaInicio = Convert.ToDateTime(txtFechaInicio.Text);
            fechaFinal = Convert.ToDateTime(txtFechaFinal.Text);
            porfechaPrestamo = rbPorFechaPrestamo.Checked;

            if (rbPorFechaPrestamo.Checked != false || rbPorFechaVencimiento.Checked != false)
            {
                GenerarReporte(fechaInicio, fechaFinal, porfechaPrestamo);
            }
            else
            {
                string script = String.Format(@"alert('Debe Seleccionar una Opción');");
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), Guid.NewGuid().ToString(), script, true);
            }

        }
        protected void GenerarReporte(DateTime fechaInicio, DateTime fechaTermino, bool porFechaPrestamo)
        {
            List<PrestamosAuxView> list = new BizPrestamos().GenerateReport(fechaInicio, fechaTermino, porFechaPrestamo);

            Document doc = new Document(PageSize.LETTER.Rotate());
            string FilePathdocument = Server.MapPath("~/Files/ReportePrestamos.pdf");
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(FilePathdocument, FileMode.Create));

            // Le colocamos el título y el autor
            // **Nota: Esto no será visible en el documento
            doc.AddTitle("Reporte Prestamos");
            doc.AddCreator("Arturo Hernandez");

            //Se Abre el Archivo
            doc.Open();

            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            // Creamos la imagen y le ajustamos el tamaño
            string imgPath = Server.MapPath("~/images/logo.PNG");
            iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(imgPath);
            imagen.BorderWidth = 0;
            imagen.Alignment = Element.ALIGN_LEFT;
            float percentage = 0.0f;
            percentage = 150 / imagen.Width;
            imagen.ScalePercent(percentage * 100);

            // Insertamos la imagen en el documento
            doc.Add(imagen);

            //Se Escribe el encabezamiento del documento
            Paragraph para = new Paragraph("Reporte de Prestamos", new Font(Font.FontFamily.HELVETICA, 22));
            para.Alignment = Element.ALIGN_CENTER;
            doc.Add(para);
            // doc.Add(new Paragraph("Reporte de Prestamos"));
            doc.Add(Chunk.NEWLINE);


            // Creamos una tabla que contendrá Todos los campos traidos de la DB
            PdfPTable tblreport = new PdfPTable(9);//asignamos el numero de columnas
            tblreport.WidthPercentage = 100;
            tblreport.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            //Se asigna el titulo de las columnas de la tabla
            PdfPCell clLibroId = new PdfPCell(new Phrase("LibroId", _standardFont));
            clLibroId.BorderWidth = 0;
            clLibroId.BorderWidthBottom = 0.75f;

            PdfPCell clTitulo = new PdfPCell(new Phrase("Titulo", _standardFont));
            clTitulo.BorderWidth = 0;
            clTitulo.BorderWidthBottom = 0.75f;

            PdfPCell clAutor = new PdfPCell(new Phrase("Autor", _standardFont));
            clAutor.BorderWidth = 0;
            clAutor.BorderWidthBottom = 0.75f;

            PdfPCell clEdicion = new PdfPCell(new Phrase("Edicion", _standardFont));
            clEdicion.BorderWidth = 0;
            clEdicion.BorderWidthBottom = 0.75f;

            PdfPCell clEditorial = new PdfPCell(new Phrase("Editorial", _standardFont));
            clEditorial.BorderWidth = 0;
            clEditorial.BorderWidthBottom = 0.75f;

            PdfPCell clDescripcion = new PdfPCell(new Phrase("Descripcion", _standardFont));
            clDescripcion.BorderWidth = 0;
            clDescripcion.BorderWidthBottom = 0.75f;

            PdfPCell clClasificacion = new PdfPCell(new Phrase("Clasificacion", _standardFont));
            clClasificacion.BorderWidth = 0;
            clClasificacion.BorderWidthBottom = 0.75f;

            PdfPCell clFechaPrestamo = new PdfPCell(new Phrase("FechaPrestamo", _standardFont));
            clFechaPrestamo.BorderWidth = 0;
            clFechaPrestamo.BorderWidthBottom = 0.75f;

            PdfPCell clFechaVencimiento = new PdfPCell(new Phrase("FechaVencimiento", _standardFont));
            clFechaVencimiento.BorderWidth = 0;
            clFechaVencimiento.BorderWidthBottom = 0.75f;

            //Se añaden las celdas a la tabla
            tblreport.AddCell(clLibroId);
            tblreport.AddCell(clTitulo);
            tblreport.AddCell(clAutor);
            tblreport.AddCell(clEdicion);
            tblreport.AddCell(clEditorial);
            tblreport.AddCell(clDescripcion);
            tblreport.AddCell(clClasificacion);
            tblreport.AddCell(clFechaPrestamo);
            tblreport.AddCell(clFechaVencimiento);

            //Se llena la tabla con la lista

            foreach (PrestamosAuxView p in list)
            {
                clLibroId = new PdfPCell(new Phrase(p.LibroId.ToString(), _standardFont));
                clLibroId.BorderWidth = 0;

                clTitulo = new PdfPCell(new Phrase(p.Titulo, _standardFont));
                clTitulo.BorderWidth = 0;

                clAutor = new PdfPCell(new Phrase(p.Autor, _standardFont));
                clAutor.BorderWidth = 0;

                clEdicion = new PdfPCell(new Phrase(p.Edicion, _standardFont));
                clEdicion.BorderWidth = 0;

                clEditorial = new PdfPCell(new Phrase(p.Editorial, _standardFont));
                clEditorial.BorderWidth = 0;

                clDescripcion = new PdfPCell(new Phrase(p.Descripcion, _standardFont));
                clDescripcion.BorderWidth = 0;

                clClasificacion = new PdfPCell(new Phrase(p.Clasificacion, _standardFont));
                clClasificacion.BorderWidth = 0;

                clFechaPrestamo = new PdfPCell(new Phrase(p.FechaPrestamo.ToString(), _standardFont));
                clFechaPrestamo.BorderWidth = 0;

                clFechaVencimiento = new PdfPCell(new Phrase(p.FechaVencimiento.ToString(), _standardFont));
                clFechaVencimiento.BorderWidth = 0;

                //Se añade las celdas a la tabla
                tblreport.AddCell(clLibroId);
                tblreport.AddCell(clTitulo);
                tblreport.AddCell(clAutor);
                tblreport.AddCell(clEdicion);
                tblreport.AddCell(clEditorial);
                tblreport.AddCell(clDescripcion);
                tblreport.AddCell(clClasificacion);
                tblreport.AddCell(clFechaPrestamo);
                tblreport.AddCell(clFechaVencimiento);
            }
            // Finalmente, se añade la tabla al documento PDF y se cierra el documento
            doc.Add(tblreport);

            doc.Close();
            writer.Close();

            string liga = string.Format(@"<iframe src='/Files/ReportePrestamos.pdf' style='width:100%; height:700px;' frameborder='0'></iframe>");
            this.ltlIframe.Text = liga;
        }
    }
}