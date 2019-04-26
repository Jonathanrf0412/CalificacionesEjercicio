using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace CalificacionesEjercicio
{
    public class Excel
    {
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;

        public List<Estudiante> LeerDatosDeExcel(string ruta)
        {
            List<Estudiante> ListaCalificaciones = new List<Estudiante>();
            wb = excel.Workbooks.Open(ruta);
            ws = wb.Worksheets[1];

            if (ws.Cells[1,1].value.Equals("Nombres"))
            {
                try
                {
                    int i = 2;
                    string hola = ws.Cells[i, 1].value;

                    while (ws.Cells[i,1].value != null)
                    {
                        string Fecha = Convert.ToString(ws.Cells[i, 4].value);
                        if (Fecha.Length > 10)
                        {
                            Fecha = Fecha.Split(' ')[0];
                        }

                        ListaCalificaciones.Add(new Estudiante()
                        {
                            Nombres = ws.Cells[i, 1].value,
                            ApellidoM = ws.Cells[i, 2].value,
                            ApellidoP = ws.Cells[i, 3].value,
                            FechaDeN = DateTime.ParseExact(Fecha, "d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                            Grado = Convert.ToInt32(ws.Cells[i, 5].value),
                            Grupo = ws.Cells[i, 6].value,
                            Calificacion = (float)Convert.ToDecimal(ws.Cells[i, 7].value)
                        });
                        i++;
                    }
                    return ListaCalificaciones;
                }
                catch (Exception e)
                {
                    return new List<Estudiante>();
                }
            }
            else
            {
                return ListaCalificaciones;
            }
        }
    }
}
