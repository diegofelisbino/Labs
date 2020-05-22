using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrarFoto
{
    public partial class FrmFoto : Form
    {
        private bool DeviceExist;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;        
        public FrmFoto()
        {
            InitializeComponent();
            ListarCamerasInstaladas();

            if (DeviceExist)
            {
                videoSource = new VideoCaptureDevice(videoDevices[cboDispositivo.SelectedIndex].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(CapturarFrameCamera);

                //Encerra o sinal da camera.
                this.EncerrarSinalCamera();
                videoSource.Start();

                btnCapturar.Enabled = true;
            }

        }

        #region Metodos        
        private void CapturarFrameCamera(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            Invoke(new Action(() =>
            {
                picFoto.Image = img;
            }));
        }

        private void ListarCamerasInstaladas()
        {
            // código do carregamento(load) do Form
            //lista os dispositivos de captura de imagem do computador/notebook
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                cboDispositivo.Items.Clear();

                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                DeviceExist = true;
                foreach (FilterInfo device in videoDevices)
                {
                    cboDispositivo.Items.Add(device.Name);
                }

                cboDispositivo.SelectedIndex = 0; //make dafault to first cam                
            }
            catch (ApplicationException ex)
            {
                DeviceExist = false;
                cboDispositivo.Items.Add("Nenhum dispositivo encontrado! Erro " + ex.Message);


            }
        }

        private void EncerrarSinalCamera()
        {
            if (!(videoSource == null))
                if (videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource = null;
                }
        }

        #endregion
        private void FrmFoto_FormClosing(object sender, FormClosingEventArgs e)
        {
            EncerrarSinalCamera();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(@"C:\Fotos"))
            {
                Directory.CreateDirectory(@"C:\Fotos\");
            }

            //CAPTURAR
            if (videoSource.IsRunning)
            {
                //Encerra o sinal da camera.
                this.EncerrarSinalCamera();

                btnCapturar.Enabled = false;
            }

            Image imagem = picFoto.Image;
            MemoryStream mem = new MemoryStream();
            imagem.Save(mem, ImageFormat.Jpeg);
            picFoto.Image.Save(@"C:\Fotos\temp.jpg");

            //FECHAR
            this.Close();
        }
    }

       
}
