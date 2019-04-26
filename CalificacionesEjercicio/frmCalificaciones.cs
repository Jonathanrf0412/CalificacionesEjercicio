using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CalificacionesEjercicio
{
    public partial class frmCalificaciones : Form
    {
        private Excel excel = new Excel();
        private char[] abecedario = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        //Se uso la api de openweathermap.org, la cual es gratuita.
        private const string api_key = "4ab3a4a06de117d0c5f3e9b8a8ba7aa2";
        private const string url = "http://api.openweathermap.org/data/2.5/weather?q=Hermosillo&mode=xml&units=metric&appid=" + api_key;

        public frmCalificaciones()
        {
            InitializeComponent();
        }

        private void frmCalificaciones_Load(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    ObtenerClima(client.DownloadString(url));
                }
                catch (WebException ex)
                {
                    MostrarError(ex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error desconocido\n" + ex.Message);
                }
            }

            timerActualizarClima.Start();
        }

        private void btnSelArchivo_Click(object sender, EventArgs e)
        {
            DialogResult resultado = ofdCargarArchivo.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                List<Estudiante> ListaCalificaciones = excel.LeerDatosDeExcel(ofdCargarArchivo.FileName);

                dgvInfo.Rows.Clear();

                if (ListaCalificaciones.Count > 0)
                {
                    #region ImprimirDatos
                    lblArchivoInfo.Text = "Información del archivo: " + ofdCargarArchivo.SafeFileName;

                    foreach (var registro in ListaCalificaciones)
                    {
                        string clave = "";
                        int Edad;
                        DateTime FechaActual = DateTime.Now;

                        clave += RecorrerCaracteres(registro.Nombres.Substring(0, 2));
                        clave += RecorrerCaracteres(registro.ApellidoM.Substring(registro.ApellidoM.Length-2, 2));

                        Edad = FechaActual.Year - registro.FechaDeN.Year;
                        if (FechaActual.Month < registro.FechaDeN.Month || (FechaActual.Month == registro.FechaDeN.Month && FechaActual.Day < registro.FechaDeN.Day))
                        {
                            Edad--;
                        }

                        clave += Edad;

                        dgvInfo.Rows.Add(registro.Nombres, registro.ApellidoM, registro.ApellidoP, registro.FechaDeN.ToString("dd/MM/yyyy"), registro.Grado, registro.Grupo, registro.Calificacion, clave);
                    }
                    #endregion

                    #region Graficar
                    chartGrafico.ChartAreas["AreaPrincipal"].AxisX.Interval = 1;
                    chartGrafico.Series["Calificaciones"].Points.Clear();

                    foreach (var registro in ListaCalificaciones)
                    {
                        chartGrafico.Series["Calificaciones"].Points.AddXY(registro.ApellidoP + " " + registro.ApellidoM, registro.Calificacion);
                    }
                    #endregion

                    #region MejorYPeorCalificacion
                    dgvMejorCalificacion.Rows.Clear();
                    dgvPeorCalificacion.Rows.Clear();

                    ListaCalificaciones = ListaCalificaciones.OrderByDescending(item => item.Calificacion).ToList();

                    float calificacion = -1;

                    foreach (var registro in ListaCalificaciones)
                    {
                        if (calificacion < 0)
                        {
                            dgvMejorCalificacion.Rows.Add(registro.Nombres + " " + registro.ApellidoP + " " + registro.ApellidoM, registro.Calificacion, registro.Grado + "-" + registro.Grupo);
                            calificacion = registro.Calificacion;
                        }
                        else
                        {
                            if (calificacion == registro.Calificacion)
                            {
                                dgvMejorCalificacion.Rows.Add(registro.Nombres + " " + registro.ApellidoP + " " + registro.ApellidoM, registro.Calificacion, registro.Grado + "-" + registro.Grupo);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                    ListaCalificaciones = ListaCalificaciones.OrderBy(item => item.Calificacion).ToList();

                    calificacion = -1;

                    foreach (var registro in ListaCalificaciones)
                    {
                        if (calificacion < 0)
                        {
                            dgvPeorCalificacion.Rows.Add(registro.Nombres + " " + registro.ApellidoP + " " + registro.ApellidoM, registro.Calificacion, registro.Grado + "-" + registro.Grupo);
                            calificacion = registro.Calificacion;
                        }
                        else
                        {
                            if (calificacion == registro.Calificacion)
                            {
                                dgvPeorCalificacion.Rows.Add(registro.Nombres + " " + registro.ApellidoP + " " + registro.ApellidoM, registro.Calificacion, registro.Grado + "-" + registro.Grupo);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    #endregion

                    #region CalcularPromedio
                    dgvPromedios.Rows.Clear();

                    float grupoPromedio = 0;
                    float globalPromedio = 0;
                    int countAlumnos = 0;
                    int grado = 0;
                    string grupo = "";

                    ListaCalificaciones = ListaCalificaciones.OrderBy(item => item.Grado).ThenBy(item => item.Grupo).ToList();
                    grado = ListaCalificaciones[0].Grado;
                    grupo = ListaCalificaciones[0].Grupo;

                    foreach (var registro in ListaCalificaciones)
                    {
                        if (grado==registro.Grado && grupo.Equals(registro.Grupo))
                        {
                            grupoPromedio += registro.Calificacion;
                            countAlumnos++;
                        }
                        else
                        {
                            dgvPromedios.Rows.Add(grado + "-" + grupo, countAlumnos, grupoPromedio / countAlumnos);
                            grupoPromedio = registro.Calificacion;
                            countAlumnos = 1;
                            grado = registro.Grado;
                            grupo = registro.Grupo;
                        }

                        globalPromedio += registro.Calificacion;
                    }

                    dgvPromedios.Rows.Add(grado + "-" + grupo, countAlumnos, grupoPromedio / countAlumnos);

                    lblPromedio.Text = (globalPromedio / ListaCalificaciones.Count).ToString();
                    lblTotalAlumnos.Text = "Total de alumnos: " + ListaCalificaciones.Count;
                    #endregion
                }
                else
                {
                    MessageBox.Show("Ocurrió un error puede que el archivo este en blanco o que no contenga el formato necesario.");
                }
            }
        }

        private string RecorrerCaracteres(string cadena)
        {
            string resultado = "";
            cadena = cadena.ToLower();

            foreach (char car in cadena)
            {
                int pos = 0;

                foreach (char letra in abecedario)
                {
                    if (car.Equals(letra))
                    {
                        if (pos < 3)
                        {
                            resultado += abecedario[pos - 3 + 27];
                        }
                        else
                        {
                            resultado += abecedario[pos - 3];
                        }

                        break;
                    }
                    pos++;
                }
            }

            return resultado.ToUpper();
        }

        private void timerActualizarClima_Tick(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    ObtenerClima(client.DownloadString(url));
                }
                catch (WebException ex)
                {
                    MostrarError(ex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error desconocido\n" + ex.Message);
                }
            }
        }

        private void ObtenerClima(string xml)
        {
            XmlDocument xml_doc = new XmlDocument();
            xml_doc.LoadXml(xml);

            XmlNode nodoActual;

            nodoActual = xml_doc.DocumentElement.SelectSingleNode("city");
            lblCiudad.Text = nodoActual.Attributes["name"].Value + ", ";

            nodoActual = nodoActual.SelectSingleNode("country");
            lblCiudad.Text += nodoActual.InnerText;

            nodoActual = xml_doc.DocumentElement.SelectSingleNode("temperature");
            lblTemperatura.Text = nodoActual.Attributes["value"].Value + "°C";
            lblMinMaxTemp.Text = "Min. " + nodoActual.Attributes["min"].Value + " - Max. " + nodoActual.Attributes["max"].Value;

            nodoActual = xml_doc.DocumentElement.SelectSingleNode("lastupdate");
            lblFecha.Text = "Última actualización: " + Convert.ToDateTime(nodoActual.Attributes["value"].Value).AddHours(-7).ToShortTimeString();

            nodoActual = xml_doc.DocumentElement.SelectSingleNode("clouds");
            lblNubes.Text = nodoActual.Attributes["name"].Value;
        }

        private void MostrarError(WebException exception)
        {
            try
            {
                StreamReader reader = new StreamReader(exception.Response.GetResponseStream());
                XmlDocument response_doc = new XmlDocument();
                response_doc.LoadXml(reader.ReadToEnd());
                XmlNode mensaje = response_doc.SelectSingleNode("//message");
                MessageBox.Show(mensaje.InnerText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error desconocido\n" + ex.Message);
            }
        }
    }
}
