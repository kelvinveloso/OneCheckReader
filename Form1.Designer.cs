
using PaniniNorthAmerica.VisionAPI;
using System;

namespace OneCheckReader
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.deviceParameters1 = new PaniniNorthAmerica.VisionAPI.DeviceParameters();
            this.imageProperties1 = new PaniniNorthAmerica.VisionAPI.ImageProperties();
            this.imageProperties2 = new PaniniNorthAmerica.VisionAPI.ImageProperties();
            this.snippetProperties1 = new PaniniNorthAmerica.VisionAPI.SnippetProperties();
            this.snippet1 = new PaniniNorthAmerica.VisionAPI.Snippet();
            this.visionAPIDotNetControl1 = new PaniniNorthAmerica.VisionAPI.VisionAPIDotNetControl();
            this.BTN_Ler = new System.Windows.Forms.Button();
            this.BTN_Parar = new System.Windows.Forms.Button();
            this.LBL_Status = new System.Windows.Forms.Label();
            this.LBLLeitura = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deviceParameters1
            // 
            this.deviceParameters1.EnableMicr = false;
            this.deviceParameters1.EnablePrint = PaniniNorthAmerica.VisionAPI.PrintType.None;
            this.deviceParameters1.FeedMode = PaniniNorthAmerica.VisionAPI.FeedingMode.HopperFeed;
            this.deviceParameters1.ImagePropertiesFront1 = this.imageProperties1;
            this.deviceParameters1.ImagePropertiesFront2 = this.imageProperties2;
            this.deviceParameters1.ImagePropertiesRear1 = this.imageProperties1;
            this.deviceParameters1.ImagePropertiesRear2 = this.imageProperties2;
            this.deviceParameters1.MicrFont = PaniniNorthAmerica.VisionAPI.MicrFont.Auto;
            this.deviceParameters1.MicrSpaces = PaniniNorthAmerica.VisionAPI.MicrSpace.SpaceAll;
            this.deviceParameters1.NReserved = 0;
            this.deviceParameters1.OneDocMode = false;
            this.deviceParameters1.RejectSymol = '!';
            this.deviceParameters1.Reserved = false;
            this.deviceParameters1.SaveMicrSamples = false;
            this.deviceParameters1.SnippetProperties0 = this.snippetProperties1;
            this.deviceParameters1.SnippetProperties1 = this.snippetProperties1;
            this.deviceParameters1.SnippetProperties2 = this.snippetProperties1;
            this.deviceParameters1.SnippetProperties3 = this.snippetProperties1;
            this.deviceParameters1.SnippetProperties4 = this.snippetProperties1;
            this.deviceParameters1.SnippetProperties5 = this.snippetProperties1;
            this.deviceParameters1.SnippetProperties6 = this.snippetProperties1;
            this.deviceParameters1.SnippetProperties7 = this.snippetProperties1;
            this.deviceParameters1.SnippetProperties8 = this.snippetProperties1;
            this.deviceParameters1.SnippetProperties9 = this.snippetProperties1;
            // 
            // imageProperties1
            // 
            this.imageProperties1.Format = PaniniNorthAmerica.VisionAPI.ImageFormat.FormatJpegTrueColor;
            this.imageProperties1.Resolution = PaniniNorthAmerica.VisionAPI.ImageResolution.Resolution300;
            this.imageProperties1.Threshold = 5;
            // 
            // imageProperties2
            // 
            this.imageProperties2.Format = PaniniNorthAmerica.VisionAPI.ImageFormat.FormatJpegTrueColor;
            this.imageProperties2.Resolution = PaniniNorthAmerica.VisionAPI.ImageResolution.Resolution300;
            this.imageProperties2.Threshold = 75;
            // 
            // snippetProperties1
            // 
            this.snippetProperties1.Enable = PaniniNorthAmerica.VisionAPI.SnippetEnable.Disabled;
            this.snippetProperties1.Front = true;
            this.snippetProperties1.SnippetPropertySettings = this.snippet1;
            // 
            // snippet1
            // 
            this.snippet1.Color = PaniniNorthAmerica.VisionAPI.SnippetColor.GrayLevel;
            this.snippet1.Millimeters = true;
            // 
            // visionAPIDotNetControl1
            // 
            this.visionAPIDotNetControl1.Location = new System.Drawing.Point(424, 356);
            this.visionAPIDotNetControl1.Margin = new System.Windows.Forms.Padding(4);
            this.visionAPIDotNetControl1.Name = "visionAPIDotNetControl1";
            this.visionAPIDotNetControl1.Size = new System.Drawing.Size(200, 185);
            this.visionAPIDotNetControl1.TabIndex = 3;
            this.visionAPIDotNetControl1.DeviceConnectedEvent += new PaniniNorthAmerica.VisionAPI.VisionAPIDotNetControl.DeviceConnectedEventHandler(this.visionAPIDotNetControl1_DeviceConnectedEvent);
            this.visionAPIDotNetControl1.DeviceDisconnectedEvent += new PaniniNorthAmerica.VisionAPI.VisionAPIDotNetControl.DeviceDisconnectedEventHandler(this.visionAPIDotNetControl1_DeviceDisconnectedEvent);
            this.visionAPIDotNetControl1.DeviceNewDocumentEvent += new PaniniNorthAmerica.VisionAPI.VisionAPIDotNetControl.DeviceNewDocumentEventHandler(this.visionAPIDotNetControl1_DeviceNewDocumentEvent);
            this.visionAPIDotNetControl1.DeviceMicrAvailableEvent += new PaniniNorthAmerica.VisionAPI.VisionAPIDotNetControl.DeviceMicrAvailableEventHandler(this.visionAPIDotNetControl1_DeviceMicrAvailableEvent);
            this.visionAPIDotNetControl1.DeviceSetItemOutputEvent += new PaniniNorthAmerica.VisionAPI.VisionAPIDotNetControl.DeviceSetItemOutputEventHandler(this.visionAPIDotNetControl1_DeviceSetItemOutputEvent);
            this.visionAPIDotNetControl1.DeviceDocumentInsidePocketEvent += new PaniniNorthAmerica.VisionAPI.VisionAPIDotNetControl.DeviceDocumentInsidePocketEventHandler(this.visionAPIDotNetControl1_DeviceDocumentInsidePocketEvent);
            this.visionAPIDotNetControl1.DeviceSorterExceptionEvent += new PaniniNorthAmerica.VisionAPI.VisionAPIDotNetControl.DeviceSorterExceptionEventHandler(this.visionAPIDotNetControl1_DeviceSorterExceptionEvent);
            this.visionAPIDotNetControl1.DeviceImagesReadyEvent += new PaniniNorthAmerica.VisionAPI.VisionAPIDotNetControl.DeviceImagesReadyEventHandler(this.visionAPIDotNetControl1_DeviceImagesReadyEvent);
            this.visionAPIDotNetControl1.DeviceSnippetsReadyEvent += new PaniniNorthAmerica.VisionAPI.VisionAPIDotNetControl.DeviceSnippetsReadyEventHandler(this.visionAPIDotNetControl1_DeviceSnippetsReadyEvent);
            this.visionAPIDotNetControl1.DeviceDocumentCompletedEvent += new PaniniNorthAmerica.VisionAPI.VisionAPIDotNetControl.DeviceDocumentCompletedEventHandler(this.visionAPIDotNetControl1_DeviceDocumentCompletedEvent);
            this.visionAPIDotNetControl1.DeviceMagCardEvent += new PaniniNorthAmerica.VisionAPI.VisionAPIDotNetControl.DeviceMagCardEventHandler(this.visionAPIDotNetControl1_DeviceMagCardEvent);
            this.visionAPIDotNetControl1.DeviceSetDownstreamOptionsEvent += new PaniniNorthAmerica.VisionAPI.VisionAPIDotNetControl.DeviceSetDownstreamOptionsEventHandler(this.visionAPIDotNetControl1_DeviceSetDownstreamOptionsEvent);
            // 
            // BTN_Ler
            // 
            this.BTN_Ler.Location = new System.Drawing.Point(37, 38);
            this.BTN_Ler.Name = "BTN_Ler";
            this.BTN_Ler.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ler.TabIndex = 1;
            this.BTN_Ler.Text = "Ler";
            this.BTN_Ler.UseVisualStyleBackColor = true;
            this.BTN_Ler.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTN_Parar
            // 
            this.BTN_Parar.Location = new System.Drawing.Point(37, 67);
            this.BTN_Parar.Name = "BTN_Parar";
            this.BTN_Parar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Parar.TabIndex = 2;
            this.BTN_Parar.Text = "Parar";
            this.BTN_Parar.UseVisualStyleBackColor = true;
            this.BTN_Parar.Click += new System.EventHandler(this.BTN_Parar_Click);
            // 
            // LBL_Status
            // 
            this.LBL_Status.AutoSize = true;
            this.LBL_Status.Location = new System.Drawing.Point(44, 18);
            this.LBL_Status.Name = "LBL_Status";
            this.LBL_Status.Size = new System.Drawing.Size(13, 17);
            this.LBL_Status.TabIndex = 3;
            this.LBL_Status.Text = "-";
            // 
            // LBLLeitura
            // 
            this.LBLLeitura.AutoSize = true;
            this.LBLLeitura.Location = new System.Drawing.Point(118, 44);
            this.LBLLeitura.Name = "LBLLeitura";
            this.LBLLeitura.Size = new System.Drawing.Size(13, 17);
            this.LBLLeitura.TabIndex = 4;
            this.LBLLeitura.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBLLeitura);
            this.Controls.Add(this.LBL_Status);
            this.Controls.Add(this.BTN_Parar);
            this.Controls.Add(this.BTN_Ler);
            this.Name = "Form1";
            this.Text = "OneCheckReader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void visionAPIDotNetControl1_DeviceSetDownstreamOptionsEvent(object sender, VisionXAPIEventArgs e)
        {
//            throw new NotImplementedException();
        }

        private void visionAPIDotNetControl1_DeviceMagCardEvent(object sender, VisionXAPIEventArgs e)
        {
 //           throw new NotImplementedException();
        }

        private void visionAPIDotNetControl1_DeviceDocumentCompletedEvent(object sender, VisionXAPIEventArgs e)
        {
   //         throw new NotImplementedException();
        }

        private void visionAPIDotNetControl1_DeviceSnippetsReadyEvent(object sender, VisionXAPIEventArgs e)
        {
     //       throw new NotImplementedException();
        }

        private void visionAPIDotNetControl1_DeviceImagesReadyEvent(object sender, VisionXAPIImageReadyEventArgs e)
        {
       //     throw new NotImplementedException();
        }

        private void visionAPIDotNetControl1_DeviceSorterExceptionEvent(object sender, VisionXAPIEventArgs e)
        {
         //   throw new NotImplementedException();
        }

        private void visionAPIDotNetControl1_DeviceDocumentInsidePocketEvent(object sender, VisionXAPIEventArgs e)
        {
           // throw new NotImplementedException();
        }

        private void visionAPIDotNetControl1_DeviceSetItemOutputEvent(object sender, VisionXAPIEventArgs e)
        {
          //  throw new NotImplementedException();
        }

        private void visionAPIDotNetControl1_DeviceMicrAvailableEvent(object sender, VisionXAPIEventArgs e)
        {
            // throw new NotImplementedException();
        }

        private void visionAPIDotNetControl1_DeviceNewDocumentEvent(object sender, VisionXAPIEventArgs e)
        {
           // throw new NotImplementedException();
        }

        private void visionAPIDotNetControl1_DeviceDisconnectedEvent(object sender, VisionXAPIEventArgs e)
        {
        //    throw new NotImplementedException();9
        }

        #endregion
        private System.Windows.Forms.ToolStrip tStripDevices;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private PaniniNorthAmerica.VisionAPI.VisionAPIDotNetControl visionAPIDotNetControl1;
        private PaniniNorthAmerica.VisionAPI.DeviceParameters deviceParameters1;
        private PaniniNorthAmerica.VisionAPI.ImageProperties imageProperties2;
        private PaniniNorthAmerica.VisionAPI.Snippet snippet1;
        private PaniniNorthAmerica.VisionAPI.SnippetProperties snippetProperties1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Button btnCloseDevice;
        private System.Windows.Forms.Label lblDeviceState;
        private System.Windows.Forms.Label lblDeviceStateValue;
        private PaniniNorthAmerica.VisionAPI.ImageProperties imageProperties1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Button btnFeed;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Button BTN_Ler;
        private System.Windows.Forms.Button BTN_Parar;
        private System.Windows.Forms.Label LBL_Status;
        private System.Windows.Forms.Label LBLLeitura;
    }
}

