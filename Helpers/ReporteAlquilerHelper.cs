using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;

public static class ExportHelper
{
    public static void ExportarExcel(DataGridView dgv)
    {
        SaveFileDialog save = new SaveFileDialog();
        save.Filter = "Excel (*.xlsx)|*.xlsx";
        save.FileName = "Reporte.xlsx";

        if (save.ShowDialog() != DialogResult.OK) return;

        using (var wb = new XLWorkbook())
        {
            var ws = wb.Worksheets.Add("Reporte");

            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                ws.Cell(1, i + 1).Value = dgv.Columns[i].HeaderText;
            }

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (dgv.Rows[i].IsNewRow) continue;

                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    ws.Cell(i + 2, j + 1).Value =
                        dgv.Rows[i].Cells[j].Value?.ToString();
                }
            }

            ws.Columns().AdjustToContents();
            wb.SaveAs(save.FileName);
        }

        MessageBox.Show("Excel generado correctamente.");
    }

    public static void ExportarPdf(DataGridView dgv)
    {
        SaveFileDialog save = new SaveFileDialog();
        save.Filter = "PDF (*.pdf)|*.pdf";
        save.FileName = "Reporte.pdf";

        if (save.ShowDialog() != DialogResult.OK) return;

        Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
        PdfWriter.GetInstance(doc, new FileStream(save.FileName, FileMode.Create));

        doc.Open();

        PdfPTable table = new PdfPTable(dgv.Columns.Count);
        table.WidthPercentage = 100;

        foreach (DataGridViewColumn col in dgv.Columns)
        {
            table.AddCell(new Phrase(col.HeaderText));
        }

        foreach (DataGridViewRow row in dgv.Rows)
        {
            if (row.IsNewRow) continue;

            foreach (DataGridViewCell cell in row.Cells)
            {
                table.AddCell(new Phrase(cell.Value?.ToString() ?? ""));
            }
        }

        doc.Add(table);
        doc.Close();

        MessageBox.Show("PDF generado correctamente.");
    }
}