using Ejercicio1.Models;

namespace Ejercicio1;

public partial class Form1 : Form
{
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
            string path=openFileDialog1.FileName;
            FileStream fs = null;
            try
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Write);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if(fs != null) fs.Close();
            }
        
        }
    }

    protected void VerSolicitudesPendientes()
    {
        lsbVerSolicitudesImportadas.Items.Clear();

        LinkedListNode<Solicitud> nodo = centro.GetSolicitudPendiente;
        while (nodo != null)
        {
            lsbVerSolicitudesImportadas.Items.Add(nodo.Value);
            nodo = nodo.Next;   
        }
    }
}