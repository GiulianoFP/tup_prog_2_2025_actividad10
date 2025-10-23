using Ejercicio1.Models;

namespace Ejercicio1;

public partial class Form1 : Form
{
    CentroDeAtencion centro = new CentroDeAtencion();
    public Form1()
    {
        InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void btnImportarSolicitudes_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            string path = openFileDialog1.FileName;

            FileStream fs = null;
            try
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                centro.ImportarCsvSolicitudesEntrantes(fs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (fs != null) fs.Close();
            }

            VerSolicitudesPendientes();


        }
    }

    protected void VerSolicitudesPendientes()
    {
        lsbVerSolicitudesImportadas.Items.Clear();

        LinkedListNode<Solicitud> nodo = centro.GetSolicitudPendiente();
        while (nodo != null)
        {
            lsbVerSolicitudesImportadas.Items.Add(nodo.Value);
            nodo = nodo.Next;
        }
    }
    protected void VerSolicitudesAAtender()
    {
        lsbColaSolicitudesAAtender.Items.Clear();
        lsbColaSolicitudesAAtender.Items.AddRange(centro.VerDescripcionColaAtencion());
    }

    private void lsbVerSolicitudesImportadas_SelectedValueChanged(object sender, EventArgs e)
    {
        Solicitud seleccionada = lsbVerSolicitudesImportadas.SelectedItem as Solicitud;
        if (seleccionada != null)
        {
            lbSolicitudSeleccionada.Text = seleccionada.ToString();

        }
    }

    private void btnConfirmarAtencion_Click(object sender, EventArgs e)
    {
        Solicitud seleccionada = lsbVerSolicitudesImportadas.SelectedItem as Solicitud;
        if (seleccionada != null)
        {
            centro.Atender(seleccionada);

            VerSolicitudesPendientes();
            VerSolicitudesAAtender();

            lsbVerSolicitudesImportadas.SelectedItem = null;
            lbSolicitudSeleccionada.Text = "Seleccione un registro";
        }
        else
        {
            MessageBox.Show("Debe seleccionar un registro");
        }
    }
}