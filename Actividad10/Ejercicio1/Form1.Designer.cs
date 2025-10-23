namespace Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lsbVerSolicitudesImportadas = new ListBox();
            btnImportarSolicitudes = new Button();
            lbSolicitudSeleccionada = new Label();
            btnConfirmarAtencion = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            lsbColaSolicitudesAAtender = new ListBox();
            SuspendLayout();
            // 
            // lsbVerSolicitudesImportadas
            // 
            lsbVerSolicitudesImportadas.FormattingEnabled = true;
            lsbVerSolicitudesImportadas.ItemHeight = 15;
            lsbVerSolicitudesImportadas.Location = new Point(38, 179);
            lsbVerSolicitudesImportadas.Name = "lsbVerSolicitudesImportadas";
            lsbVerSolicitudesImportadas.Size = new Size(276, 244);
            lsbVerSolicitudesImportadas.TabIndex = 0;
            lsbVerSolicitudesImportadas.SelectedValueChanged += lsbVerSolicitudesImportadas_SelectedValueChanged;
            // 
            // btnImportarSolicitudes
            // 
            btnImportarSolicitudes.Location = new Point(121, 56);
            btnImportarSolicitudes.Name = "btnImportarSolicitudes";
            btnImportarSolicitudes.Size = new Size(106, 64);
            btnImportarSolicitudes.TabIndex = 1;
            btnImportarSolicitudes.Text = "Importar Solicitudes";
            btnImportarSolicitudes.UseVisualStyleBackColor = true;
            btnImportarSolicitudes.Click += btnImportarSolicitudes_Click;
            // 
            // lbSolicitudSeleccionada
            // 
            lbSolicitudSeleccionada.BackColor = SystemColors.ActiveCaption;
            lbSolicitudSeleccionada.BorderStyle = BorderStyle.FixedSingle;
            lbSolicitudSeleccionada.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSolicitudSeleccionada.Location = new Point(337, 228);
            lbSolicitudSeleccionada.Name = "lbSolicitudSeleccionada";
            lbSolicitudSeleccionada.Size = new Size(135, 45);
            lbSolicitudSeleccionada.TabIndex = 2;
            lbSolicitudSeleccionada.Text = "Seleccione desde la lista";
            lbSolicitudSeleccionada.Click += label1_Click;
            // 
            // btnConfirmarAtencion
            // 
            btnConfirmarAtencion.Location = new Point(337, 287);
            btnConfirmarAtencion.Name = "btnConfirmarAtencion";
            btnConfirmarAtencion.Size = new Size(135, 102);
            btnConfirmarAtencion.TabIndex = 3;
            btnConfirmarAtencion.Text = "Confirmar seleccion hacia cola de atencion";
            btnConfirmarAtencion.UseVisualStyleBackColor = true;
            btnConfirmarAtencion.Click += btnConfirmarAtencion_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lsbColaSolicitudesAAtender
            // 
            lsbColaSolicitudesAAtender.FormattingEnabled = true;
            lsbColaSolicitudesAAtender.ItemHeight = 15;
            lsbColaSolicitudesAAtender.Location = new Point(498, 179);
            lsbColaSolicitudesAAtender.Name = "lsbColaSolicitudesAAtender";
            lsbColaSolicitudesAAtender.Size = new Size(276, 244);
            lsbColaSolicitudesAAtender.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 450);
            Controls.Add(lsbColaSolicitudesAAtender);
            Controls.Add(btnConfirmarAtencion);
            Controls.Add(lbSolicitudSeleccionada);
            Controls.Add(btnImportarSolicitudes);
            Controls.Add(lsbVerSolicitudesImportadas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lsbVerSolicitudesImportadas;
        private Button btnImportarSolicitudes;
        private Label lbSolicitudSeleccionada;
        private Button btnConfirmarAtencion;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ListBox lsbColaSolicitudesAAtender;
    }
}
