using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace WinXpath
{
    public partial class Form1 : Form
    {
        private  string _inicioSolo ;
        private string _archivoLog;
        public Form1()
        {
            InitializeComponent();
        }


        private void cargarArchivoConfig() {

            //inicioYCierraSolo
            this.txPagina.Text = ConfigurationManager.AppSettings["pagina_busqueda"];
            this.txXpath.Text = ConfigurationManager.AppSettings["xpath_busqueda"];
            this.txXpathVal.Text = ConfigurationManager.AppSettings["xpath_valida"];
            this.txXpathValor.Text = ConfigurationManager.AppSettings["xpath_valida_valor"];


            this.txXpath2.Text = ConfigurationManager.AppSettings["xpath_busqueda2"];
            this.txXpathVal2.Text = ConfigurationManager.AppSettings["xpath_valida2"];
            this.txXpathValor2.Text = ConfigurationManager.AppSettings["xpath_valida_valor2"];



            this.txArchivoResultado.Text = ConfigurationManager.AppSettings["archivo_resultado"];
            this._inicioSolo = ConfigurationManager.AppSettings["inicioYCierraSolo"];
            this._archivoLog = AppDomain.CurrentDomain.BaseDirectory + "log.txt";              
        }

        private void guardarEnArchivo(string resultado) {            
            String newLine = "";
            
            System.IO.StreamWriter   stream = System.IO.File.CreateText(this.txArchivoResultado.Text  );            
            newLine = resultado + ";" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss")   ;
            guardarLog("Escribe el resultado: " + resultado + " en el archivo: " + this.txArchivoResultado.Text   );
            stream.WriteLine(newLine);
            stream.Close();
        }

        private void guardarLog(string lineaLog) {

            lineaLog = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + ";" + lineaLog;
            if (!System.IO.File.Exists(this._archivoLog))
            {
                // Create a file to write to.
                using (System.IO.StreamWriter sw = System.IO.File.CreateText(this._archivoLog))
                {
                    sw.WriteLine(lineaLog);
                }
            }
            else {
                using (System.IO.StreamWriter sw = System.IO.File.AppendText(this._archivoLog ))
                {
                    sw.WriteLine(lineaLog);
                }
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            HtmlAgilityPack.HtmlDocument htmldocu = new HtmlAgilityPack.HtmlDocument();
            try
            {                       
                WebClient myWebClient = new WebClient();
                myWebClient.Encoding = Encoding.UTF8;
                this.textBox1.Text = myWebClient.DownloadString(this.txPagina.Text);                
                htmldocu.LoadHtml(this.textBox1.Text);
            }
            catch (Exception ex)
            {
                guardarLog("Error al obtener el datos:\n" + ex.Message);                
            }

            try
            {


                if (System.IO.File.Exists(this.txArchivoResultado.Text))
                {
                    System.IO.File.Delete(this.txArchivoResultado.Text);
                }

                //dolar
                if (this.txXpath.Text != "")
                {
                    string resultado = htmldocu.DocumentNode.SelectSingleNode(this.txXpath.Text).InnerHtml;
                    //si tiene datos que validar
                    if (this.txXpathValor.Text != "")
                    {
                        string resultado_valida = htmldocu.DocumentNode.SelectSingleNode(this.txXpathVal.Text).InnerHtml;
                        guardarLog("Compara el valor:" + this.txXpathValor.Text +" contra el resultado: "+ resultado_valida);
                        if (resultado_valida == this.txXpathValor.Text)
                        {
                            guardarEnArchivo(resultado);
                        }
                    }
                    else {
                        guardarEnArchivo(resultado);
                    }
                                         
                }
                //euro
                if (this.txXpath.Text != "")
                {
                    string resultado = htmldocu.DocumentNode.SelectSingleNode(this.txXpath2.Text).InnerHtml;
                    //si tiene datos que validar
                    if (this.txXpathValor2.Text != "")
                    {
                        string resultado_valida = htmldocu.DocumentNode.SelectSingleNode(this.txXpathVal2.Text).InnerHtml;
                        guardarLog("Compara el valor:" + this.txXpathValor2.Text + " contra el resultado: " + resultado_valida);
                        if (resultado_valida == this.txXpathValor2.Text)
                        {
                            guardarEnArchivo(resultado);
                        }
                    }
                    else
                    {
                        guardarEnArchivo(resultado);
                    }

                }

            }
            catch (Exception ex)
            {
                guardarLog("Error al guardar el datos:\n" + ex.Message);                 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarArchivoConfig();
            guardarLog("Inicio de proceso");            
            if (this._inicioSolo == "true") {
                this.button1_Click(sender, e);
                this.Close();
                System.Windows.Forms.Application.Exit();
            }
            guardarLog("Fin de proceso");

        }
    }
}
