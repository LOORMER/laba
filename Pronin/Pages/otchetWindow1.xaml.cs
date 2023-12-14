using Microsoft.Win32;
using Pronin.AppData;
using System;
using System.Collections.Generic;
using System.IO;
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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Shapes;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.Remoting.Contexts;
using System.Drawing;


namespace Pronin.Pages
{
    /// <summary>
    /// Логика взаимодействия для otchetWindow1.xaml
    /// </summary>
    public partial class otchetWindow1 : Window
    {
        public otchetWindow1()
        {
            InitializeComponent();
        }

        private void PdfBTN_Click(object sender, RoutedEventArgs e)
        {
          SaveFileDialog save = new SaveFileDialog();
          save.Title = "Выберите файл";
          save.Filter = "PDF файлы (*.pdf*)|*.pdf*";
          bool? res = save.ShowDialog();
          string filepath = " ";
          if (res == true)
          {
              filepath = save.FileName;
          
          }
          Document doc = new Document();
          PdfWriter.GetInstance(doc, new FileStream(filepath, FileMode.Create));
          doc.Open();
          BaseFont baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
          iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
          PdfPTable table = new PdfPTable(9);
          PdfPTable table2 = new PdfPTable(9);
          PdfPTable table3 = new PdfPTable(9);
          PdfPTable table4 = new PdfPTable(9);
          PdfPTable table5 = new PdfPTable(9);
          PdfPTable table6 = new PdfPTable(9);
          PdfPCell cell = new PdfPCell(new Phrase("БД " + filepath + ", таблица №1"));
          cell.HorizontalAlignment = 1;
          cell.Colspan = 9;
          cell.Border = 0;
          table.AddCell(cell);
          var vozmoznocollection = connection.context.spravochnaia.ToList();
          var a = 0;
          var b = 0;
          table.AddCell(new Phrase("Табельный номер", font));
          table2.AddCell(new Phrase("ФИО", font));
          table3.AddCell(new Phrase("Оклад", font));
          table4.AddCell(new Phrase("Сумма доплаты", font));
          table5.AddCell(new Phrase("Всего", font));
          //table6.AddCell(new Phrase("Поступило на сумму", font));
          foreach (var item in vozmoznocollection)
          {
              a = 0;
              table.AddCell(new Phrase(item.tabel_nomer.ToString(), font));
              table2.AddCell(new Phrase(item.FIO.ToString(), font));
              table3.AddCell(new Phrase(item.oklad.ToString(), font));
                a = (int)(item.doplat * item.oklad / 100);
              table4.AddCell(new Phrase(a.ToString(), font));
                b = (int)(item.oklad + (item.oklad * item.doplat / 100));
                table5.AddCell(new Phrase(b.ToString(), font));
 
          }

            table6.AddCell(new Phrase(b.ToString(), font));
          doc.Add(table);
          doc.Add(table2);
          doc.Add(table3);
          doc.Add(table4);
          doc.Add(table5);
          doc.Close();
        }

        private void EXEL_Click(object sender, RoutedEventArgs e)
        {
            Excel.Application app = new Excel.Application()
            {
                Visible = true,
                SheetsInNewWorkbook = 2
            };
            Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            app.DisplayAlerts = false;
            Excel.Worksheet sheet = (Excel.Worksheet)app.Worksheets.get_Item(1); 
            sheet.Name = "Отчёт DOTERA";
            sheet.Cells[1, 1] = "Табельный номер";
            sheet.Cells[1, 2] = "ФИО";
            sheet.Cells[1, 3] = "Оклад";
            sheet.Cells[1, 4] = "Сумма доплаты";
            sheet.Cells[1, 5] = "Всего начислено";

            var currentRow = 2;
          
            int a = 0;
            var prod = connection.context.spravochnaia.ToList(); 
            foreach (var item in prod)
            {
                sheet.Cells[currentRow, 1] = item.tabel_nomer;
                sheet.Cells[currentRow, 2] = item.FIO;
                sheet.Cells[currentRow, 3] = item.oklad;
                sheet.Cells[currentRow, 4] = item.doplat * item.oklad / 100;
                sheet.Cells[currentRow, 5] = item.oklad + (item.oklad * item.doplat / 100);
               

                currentRow++;
            }
            var sup = connection.context.ucetnaya.ToList();
            foreach(var item in sup)
            {
                if (month.Text == item.mouth)
                {
                    a += (int)(item.oklad + (item.oklad * item.doplata));
                    sheet.Cells[7, 5] = a;
                };

            }

            sheet.Cells[7, 1] = "Итого начислено за месяц:                            ";
        
            Excel.Range range2 = sheet.get_Range("A1", "H9"); range2.Cells.Font.Name = "Times New Roman";
            range2.Cells.Font.Size = 10; range2.Font.Bold = true;
            range2.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.DarkGray);
        }
    }
}
