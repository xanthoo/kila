using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;

namespace KILR_Project
{
    public class Receipt
    {
        Order o;
        public Receipt(Order o)
        {
            this.o = o;
        }
        public void GenerateReceieptinPDF()
        {
            //GENERATE RECEIPT
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            page.Height = 300;
            page.Width = 200;
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XTextFormatter tf = new XTextFormatter(gfx);

            //FONTS
            XFont header = new XFont("Monaco", 22, XFontStyle.BoldItalic);
            XFont secondHeader = new XFont("Monaco", 14, XFontStyle.Bold);
            XFont lineBreakFont = new XFont("Time New Roman", 14, XFontStyle.Bold);
            XFont fontItems = new XFont("Monaco", 11, XFontStyle.Regular);

            //POSITIONING ELEMENTS
            XRect rect = new XRect(0, 60, page.Width, page.Height);
            XPen pen = XPens.Black;
            gfx.DrawString("Jupiter", header, XBrushes.Black,
            new XRect(0, 0, page.Width, page.Height),
            XStringFormats.TopCenter);
            string lineBreak = "-------------------------------------------";
            tf.DrawString(lineBreak, lineBreakFont, XBrushes.Black, new XRect(0, 20, page.Width, page.Height));
            tf.DrawString("Cash Receipt", secondHeader, XBrushes.Black,
            new XRect(55, 32, page.Width, page.Height));
            tf.DrawString(lineBreak, lineBreakFont, XBrushes.Black, new XRect(0, 41, page.Width, page.Height));
            string text = "";
            foreach (Product item in o.GetAllOrderProducts())
            {
                text += item.GetInfoReceipt() + "\r";
            }
            tf.DrawString(text, fontItems, XBrushes.Black, rect, XStringFormats.TopLeft);
            tf.DrawString(lineBreak, lineBreakFont, XBrushes.Black, new XRect(0, 265, page.Width, page.Height));

            string total = "Total: " + o.Total + "€";
            string date = "Date: " + o.OrderedOn;
            gfx.DrawString(date, secondHeader, XBrushes.Black, new XRect(0, -6, page.Width, page.Height), XStringFormats.BottomLeft);
            gfx.DrawString(total, secondHeader, XBrushes.Black, new XRect(0, -30, page.Width, page.Height), XStringFormats.BottomLeft);

            //SAVE DOCUMENT
            const string filepath = "Jupiter Receipt.pdf";
            document.Save(filepath);
            System.Diagnostics.Process.Start(filepath);
        }
    }
}
