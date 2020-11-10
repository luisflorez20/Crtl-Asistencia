namespace Login
{
    partial class selectPuerta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_puertas = new System.Windows.Forms.ComboBox();
            this.btn_listo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_puertas
            // 
            this.cmb_puertas.FormattingEnabled = true;
            this.cmb_puertas.Items.AddRange(new object[] {
            "Puerta 01 Floresta",
            "Puerta 02 Cabildo",
            "Puerta 03 La Borda",
            "Puerta 04 Olaechea",
            "Puerta 04 Limoncillo"});
            this.cmb_puertas.Location = new System.Drawing.Point(171, 69);
            this.cmb_puertas.Name = "cmb_puertas";
            this.cmb_puertas.Size = new System.Drawing.Size(121, 21);
            this.cmb_puertas.TabIndex = 0;
            this.cmb_puertas.Text = "Selecionar Puerta";
            this.cmb_puertas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_listo
            // 
            this.btn_listo.Location = new System.Drawing.Point(313, 69);
            this.btn_listo.Name = "btn_listo";
            this.btn_listo.Size = new System.Drawing.Size(54, 23);
            this.btn_listo.TabIndex = 1;
            this.btn_listo.Text = "Listo";
            this.btn_listo.UseVisualStyleBackColor = true;
            this.btn_listo.Click += new System.EventHandler(this.btn_listo_Click);
            // 
            // selectPuerta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 180);
            this.Controls.Add(this.btn_listo);
            this.Controls.Add(this.cmb_puertas);
            this.Name = "selectPuerta";
            this.Text = "selectPuerta";
            this.Load += new System.EventHandler(this.selectPuerta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_puertas;
        private System.Windows.Forms.Button btn_listo;
    }
}