using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

namespace FinalProject.Frontend.Reportes
{
    public partial class FrmRepAsesores : Form
    {
        private DataTable dtInfo = null;

        /// <summary>
        /// Constructor de la pantalla
        /// toma como parámetro una tabla con la información de los asesores
        /// </summary>
        /// <param name="dt"></param>
        public FrmRepAsesores(DataTable dt)
        {
            InitializeComponent();
            this.dtInfo = dt;
            dtRepAsesores.DataSource = dtInfo;
        }

        /// <summary>
        /// Genera un archivo Excel con la información de los asesores
        /// al hacer clic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportar_Click(object sender, EventArgs e)
        {
            DialogResult dr = sfdExportar.ShowDialog();

            if(dr == DialogResult.OK) 
                Exportar(); 
        }

        /// <summary>
        /// Crea un archivo Excel con la información de los asesores
        /// </summary>
        private void Exportar()
        {
            String ruta = Path.GetFullPath(sfdExportar.FileName);

            try
            {
                var excelApp = new Excel.Application();
                excelApp.Workbooks.Add();
                
                Excel._Worksheet ws = excelApp.ActiveSheet;

                ws.Cells[1, 1] = "Reporte de asesores";
                

                for (var i = 0; i < dtInfo.Columns.Count; i++)
                {
                    ws.Cells[3, i + 1] = dtInfo.Columns[i].ColumnName;
                }

                for (var i = 0; i < dtInfo.Rows.Count; i++)
                    for (var j = 0; j < dtInfo.Columns.Count; j++)
                        ws.Cells[i + 4, j + 1] = dtInfo.Rows[i][j];

                if (!string.IsNullOrEmpty(ruta))
                {
                    try
                    {
                        ws.SaveAs(ruta);
                        excelApp.Quit();
                        MessageBox.Show("Reporte generado correctamente.", "Info",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"
                                            + ex.Message);
                    }
                }
                else
                { // no file path is given
                    excelApp.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Exportar a Excel: " + ex.Message);
            }
        }
    }
}
