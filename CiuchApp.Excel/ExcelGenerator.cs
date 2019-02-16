using CiuchApp.Domain;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiuchApp.Excel
{
    public class ExcelGenerator
    {
        public static MemoryStream GetKpcExcelMemoryStream(IList<Piece> pieces, string webRootPath, string folderName, string excelName)
        {
            var pathToFile = Path.Combine(webRootPath, folderName, excelName);
            FileInfo file = new FileInfo(pathToFile);
            var memory = new MemoryStream();
            using (var fs = new FileStream(pathToFile, FileMode.Create, FileAccess.Write))
            {
                IWorkbook workbook;
                workbook = new XSSFWorkbook();
                ISheet excelSheet = workbook.CreateSheet("Dane KPC");
                IRow row = excelSheet.CreateRow(0);

                row.CreateCell(0).SetCellValue("Sezon");
                row.CreateCell(1).SetCellValue("Marka");
                row.CreateCell(2).SetCellValue("Kod grupy asortymentowej");
                row.CreateCell(3).SetCellValue("Kod koloru");
                row.CreateCell(4).SetCellValue("kategoria");
                row.CreateCell(5).SetCellValue("grupa asortymentowa");
                row.CreateCell(6).SetCellValue("Dostawca");
                row.CreateCell(7).SetCellValue("Krzywa rozmiarowa");
                row.CreateCell(8).SetCellValue("Waluta");
                row.CreateCell(9).SetCellValue("płeć");
                row.CreateCell(10).SetCellValue("Skład materiałowy");
                row.CreateCell(11).SetCellValue("symbol prod");
                row.CreateCell(12).SetCellValue("nazwa");
                row.CreateCell(13).SetCellValue("Cena zakupu");
                row.CreateCell(14).SetCellValue("Cena detaliczna");
                row.CreateCell(15).SetCellValue("Typ towaru");
                row.CreateCell(16).SetCellValue("rozmiar");
                row.CreateCell(17).SetCellValue("Kod koloru producent");
                row.CreateCell(18).SetCellValue("EAN");
                row.CreateCell(19).SetCellValue("Cena sug detal PLN");
                row.CreateCell(20).SetCellValue("Nazwa dostawy");
                row.CreateCell(21).SetCellValue("Data zamówienia");
                row.CreateCell(22).SetCellValue("Planowana data wysyłki");
                row.CreateCell(23).SetCellValue("Rzeczywista data wysyłki");
                row.CreateCell(24).SetCellValue("Planowana data w magazynie");
                row.CreateCell(25).SetCellValue("Rzeczywista data w magazynie");
                row.CreateCell(26).SetCellValue("Planowana data w sklepie");
                row.CreateCell(27).SetCellValue("KD:OnlineANS");
                row.CreateCell(28).SetCellValue("KD:Online");
                row.CreateCell(29).SetCellValue("ID odpowiednika");
                row.CreateCell(30).SetCellValue("OpisCMS");
                row.CreateCell(31).SetCellValue("kraj pochodzenia");
                row.CreateCell(32).SetCellValue("kod cn");
                row.CreateCell(33).SetCellValue("set");
                row.CreateCell(34).SetCellValue("Sezon zamówieniowy");
                row.CreateCell(35).SetCellValue("cechy cms");


                ////Makes font very very small
                //var boldedFont = workbook.CreateFont();
                //boldedFont.Boldweight = (short)NPOI.SS.UserModel.FontBoldWeight.Bold;
                //foreach (var cell in row.Cells)
                //{
                //    cell.RichStringCellValue.ApplyFont(boldedFont);
                //}
                
                for(var rowIndex = 1; rowIndex<=pieces.Count; rowIndex++)
                {
                    row = excelSheet.CreateRow(rowIndex);
                    var piece = pieces[rowIndex - 1];
                    row.CreateCell(0).SetCellValue("WW19");
                    row.CreateCell(1).SetCellValue(piece.Name);
                    row.CreateCell(2).SetCellValue(piece.Supplier.Name);
                }

                workbook.Write(fs);
            }
            //WriteFrom file (stream) to memory stream
            using (var stream = new FileStream(pathToFile, FileMode.Open))
            {
                stream.CopyTo(memory);
            }
            memory.Position = 0;

            return memory;
        }
    }
}
