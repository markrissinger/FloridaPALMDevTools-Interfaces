using ClosedXML.Excel;


string fileName = "C:\\Folder1\\Prev.xlsx";
var workbook = new XLWorkbook(fileName);
var ws1 = workbook.Worksheet(1);

Console.WriteLine("Loaded ");