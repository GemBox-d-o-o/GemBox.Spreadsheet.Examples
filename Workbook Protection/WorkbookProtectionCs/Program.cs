﻿using GemBox.Spreadsheet;

class Program
{
    static void Main(string[] args)
    {
        // If using Professional version, put your serial key below.
        SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

        var workbook = new ExcelFile();
        var worksheet = workbook.Worksheets.Add("Workbook Protection");

        // ProtectionSettings class is supported only for XLSX file format.
        var protectionSettings = workbook.ProtectionSettings;
        protectionSettings.ProtectStructure = true;

        worksheet.Cells[0, 0].Value = "Workbook password is 123 (only supported for XLSX file format).";
        protectionSettings.SetPassword("123");

        workbook.Save("Workbook Protection.xlsx");
    }
}