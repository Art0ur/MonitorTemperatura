namespace WeatherWidget
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblClima;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBoxResultado;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblClima = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();

            this.SuspendLayout();

            // panelTop
            this.panelTop.Controls.Add(this.lblTitulo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 50;
            this.panelTop.BackColor = System.Drawing.Color.LightBlue;

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(178, 26);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Monitor de Temperarura";

            // panelBottom
            this.panelBottom.Controls.Add(this.lblCidade);
            this.panelBottom.Controls.Add(this.txtCidade);
            this.panelBottom.Controls.Add(this.btnBuscar);
            this.panelBottom.Controls.Add(this.groupBoxResultado);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Padding = new System.Windows.Forms.Padding(10);

            // txtCidade
            this.txtCidade.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCidade.Location = new System.Drawing.Point(17, 50);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(200, 23);
            this.txtCidade.TabIndex = 0;

            // btnBuscar
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 10F);
            this.btnBuscar.Location = new System.Drawing.Point(223, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            // lblCidade
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Arial", 10F);
            this.lblCidade.Location = new System.Drawing.Point(14, 30);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(54, 16);
            this.lblCidade.TabIndex = 4;
            this.lblCidade.Text = "Cidade:";

            // groupBoxResultado
            this.groupBoxResultado.Controls.Add(this.lblClima);
            this.groupBoxResultado.Controls.Add(this.lblTemperatura);
            this.groupBoxResultado.Font = new System.Drawing.Font("Arial", 10F);
            this.groupBoxResultado.Location = new System.Drawing.Point(17, 80);
            this.groupBoxResultado.Name = "groupBoxResultado";
            this.groupBoxResultado.Size = new System.Drawing.Size(281, 100);
            this.groupBoxResultado.TabIndex = 6;
            this.groupBoxResultado.TabStop = false;
            this.groupBoxResultado.Text = "Resultado";

            // lblClima
            this.lblClima.AutoSize = true;
            this.lblClima.Font = new System.Drawing.Font("Arial", 10F);
            this.lblClima.Location = new System.Drawing.Point(6, 25);
            this.lblClima.Name = "lblClima";
            this.lblClima.Size = new System.Drawing.Size(46, 16);
            this.lblClima.TabIndex = 2;
            this.lblClima.Text = "Clima:";

            // lblTemperatura
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Font = new System.Drawing.Font("Arial", 10F);
            this.lblTemperatura.Location = new System.Drawing.Point(6, 50);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(89, 16);
            this.lblTemperatura.TabIndex = 3;
            this.lblTemperatura.Text = "Temperatura:";

            // Form1
            this.ClientSize = new System.Drawing.Size(324, 250);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "Form1";
            this.Text = "Monitor de Temperarura";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
