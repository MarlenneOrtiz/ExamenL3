namespace Examen1
{
    public partial class Form1 : Form

    {
        double rbases = 0;
        double altura = 0;
        double area = 0;
        double PI = 3.1416;
        string formula;

        // MARLENNE ALEXA ORTIZ QUIÑONEZ
        // VALERY ALEXANDRA LEMUS MEJIA 
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbdtriangulo_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Base";
            txtbase.Visible = true;
            txtaltura.Visible = true;
            formula = "AREA = (BASE X ALTURA)/2";
        }

        private void txtbase_TextChanged(object sender, EventArgs e)
        {
            rbases=Convert.ToDouble(txtbase.Text);

        }

        private void rbdcuadrado_CheckedChanged(object sender, EventArgs e)
        {
            area = (rbases * altura);
            label2.Text = "Base";
            txtbase.Visible = true;
            txtaltura.Visible = true;
            formula = "AREA = LADO X LADO";
        }

        private void rbdrecta_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Base";
            txtbase.Visible = true;
            txtaltura.Visible = true;
            formula = "AREA = BASE X ALTURA";
        }

        private void rbdC_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Radio";
            txtbase.Visible = true;
            txtaltura.Visible = false;
            formula = "AREA = PI X (RADIO^2)";
        }

        private void txtaltura_TextChanged(object sender, EventArgs e)
        {
            altura=Convert.ToDouble(txtaltura.Text);
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            if (rbdtriangulo.Checked == true)
            {
                area = (rbases * altura) / 2;
                Form2 Resultados = new Form2(area.ToString(), formula);
                Resultados.Show();

            }
            if (rbdcuadrado.Checked == true)
            {
                Form2 Resultados = new Form2(area.ToString(), formula);
                Resultados.Show();
            }


            if (rbdrecta.Checked == true)
            {
                area = (rbases * altura);
                Form2 Resultados = new Form2(area.ToString(), formula);
                Resultados.Show();
            }

            if(rbdC.Checked == true) 
            {
                area = PI * Math.Pow(rbases, 2);
                Form2 Resultados = new Form2(area.ToString(), formula);
                Resultados.Show();
            }
        }
    }
}