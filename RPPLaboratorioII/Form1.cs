using Entidades;
namespace RPPLaboratorioII
{
    public partial class FrmView : Form
    {
        public FrmView()
        {
            InitializeComponent();
        }


        private void InicializarFabrica()
        {
            int capacidad = 8;
            Fabrica fabrica = new Fabrica(capacidad);
            Camioneta camioneta = new Camioneta(EPropulsion.Electrica, true);
            fabrica = fabrica + camioneta;
        }
        private void Refrescar() 
        {
            lstVehiculos.DataSource = null;
            lstVehiculos.DataSource = Fabrica.vehiculos;
        }
        private Vehiculo crearVehiculo() 
        {

        }
        private void FrmView_Load(object sender, EventArgs e)
        {

        }

        private void btnFabricar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}