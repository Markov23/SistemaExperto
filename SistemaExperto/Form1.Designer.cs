
namespace SistemaExperto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tablaJuegos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEtiqueta1 = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbEtiquetas = new System.Windows.Forms.ListBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEtiqueta2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbEtiqueta3 = new System.Windows.Forms.ComboBox();
            this.checkEtiqueta2 = new System.Windows.Forms.CheckBox();
            this.checkEtiqueta3 = new System.Windows.Forms.CheckBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaJuegos)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaJuegos
            // 
            this.tablaJuegos.AllowUserToAddRows = false;
            this.tablaJuegos.AllowUserToDeleteRows = false;
            this.tablaJuegos.AllowUserToResizeColumns = false;
            this.tablaJuegos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaJuegos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaJuegos.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaJuegos.Location = new System.Drawing.Point(420, 50);
            this.tablaJuegos.MultiSelect = false;
            this.tablaJuegos.Name = "tablaJuegos";
            this.tablaJuegos.ReadOnly = true;
            this.tablaJuegos.RowHeadersVisible = false;
            this.tablaJuegos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tablaJuegos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaJuegos.Size = new System.Drawing.Size(350, 212);
            this.tablaJuegos.TabIndex = 0;
            this.tablaJuegos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaJuegos_CellContentClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(420, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resultados";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbEtiqueta1
            // 
            this.cbEtiqueta1.DropDownHeight = 160;
            this.cbEtiqueta1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEtiqueta1.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEtiqueta1.FormattingEnabled = true;
            this.cbEtiqueta1.IntegralHeight = false;
            this.cbEtiqueta1.Location = new System.Drawing.Point(10, 80);
            this.cbEtiqueta1.Name = "cbEtiqueta1";
            this.cbEtiqueta1.Size = new System.Drawing.Size(350, 32);
            this.cbEtiqueta1.Sorted = true;
            this.cbEtiqueta1.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(114)))), ((int)(((byte)(201)))));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(260, 310);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 30);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(420, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Detalles";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEtiquetas
            // 
            this.lbEtiquetas.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEtiquetas.FormattingEnabled = true;
            this.lbEtiquetas.ItemHeight = 24;
            this.lbEtiquetas.Location = new System.Drawing.Point(420, 350);
            this.lbEtiquetas.Name = "lbEtiquetas";
            this.lbEtiquetas.Size = new System.Drawing.Size(350, 100);
            this.lbEtiquetas.TabIndex = 8;
            // 
            // labelNombre
            // 
            this.labelNombre.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(420, 290);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(350, 25);
            this.labelNombre.TabIndex = 9;
            this.labelNombre.Text = "Nombre:";
            this.labelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Etiqueta 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Etiqueta 2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbEtiqueta2
            // 
            this.cbEtiqueta2.DropDownHeight = 160;
            this.cbEtiqueta2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEtiqueta2.Enabled = false;
            this.cbEtiqueta2.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEtiqueta2.FormattingEnabled = true;
            this.cbEtiqueta2.IntegralHeight = false;
            this.cbEtiqueta2.Location = new System.Drawing.Point(10, 155);
            this.cbEtiqueta2.Name = "cbEtiqueta2";
            this.cbEtiqueta2.Size = new System.Drawing.Size(250, 32);
            this.cbEtiqueta2.Sorted = true;
            this.cbEtiqueta2.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(350, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Etiqueta 3";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbEtiqueta3
            // 
            this.cbEtiqueta3.DropDownHeight = 160;
            this.cbEtiqueta3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEtiqueta3.Enabled = false;
            this.cbEtiqueta3.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEtiqueta3.FormattingEnabled = true;
            this.cbEtiqueta3.IntegralHeight = false;
            this.cbEtiqueta3.Location = new System.Drawing.Point(10, 230);
            this.cbEtiqueta3.Name = "cbEtiqueta3";
            this.cbEtiqueta3.Size = new System.Drawing.Size(250, 32);
            this.cbEtiqueta3.Sorted = true;
            this.cbEtiqueta3.TabIndex = 14;
            // 
            // checkEtiqueta2
            // 
            this.checkEtiqueta2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkEtiqueta2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(114)))), ((int)(((byte)(201)))));
            this.checkEtiqueta2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkEtiqueta2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkEtiqueta2.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEtiqueta2.ForeColor = System.Drawing.Color.White;
            this.checkEtiqueta2.Location = new System.Drawing.Point(285, 155);
            this.checkEtiqueta2.Name = "checkEtiqueta2";
            this.checkEtiqueta2.Size = new System.Drawing.Size(75, 32);
            this.checkEtiqueta2.TabIndex = 16;
            this.checkEtiqueta2.Text = "Etiqueta 2";
            this.checkEtiqueta2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkEtiqueta2.UseVisualStyleBackColor = false;
            this.checkEtiqueta2.CheckedChanged += new System.EventHandler(this.checkEtiqueta2_CheckedChanged);
            // 
            // checkEtiqueta3
            // 
            this.checkEtiqueta3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkEtiqueta3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(114)))), ((int)(((byte)(201)))));
            this.checkEtiqueta3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkEtiqueta3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkEtiqueta3.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEtiqueta3.ForeColor = System.Drawing.Color.White;
            this.checkEtiqueta3.Location = new System.Drawing.Point(285, 230);
            this.checkEtiqueta3.Name = "checkEtiqueta3";
            this.checkEtiqueta3.Size = new System.Drawing.Size(75, 32);
            this.checkEtiqueta3.TabIndex = 17;
            this.checkEtiqueta3.Text = "Etiqueta 3";
            this.checkEtiqueta3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkEtiqueta3.UseVisualStyleBackColor = false;
            this.checkEtiqueta3.CheckedChanged += new System.EventHandler(this.checkEtiqueta3_CheckedChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(114)))), ((int)(((byte)(201)))));
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(10, 310);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(420, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(350, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Etiquetas";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(83)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.checkEtiqueta3);
            this.Controls.Add(this.checkEtiqueta2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbEtiqueta3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbEtiqueta2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.lbEtiquetas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbEtiqueta1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaJuegos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Encuentra tu juego ideal";
            ((System.ComponentModel.ISupportInitialize)(this.tablaJuegos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaJuegos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEtiqueta1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbEtiquetas;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEtiqueta2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbEtiqueta3;
        private System.Windows.Forms.CheckBox checkEtiqueta2;
        private System.Windows.Forms.CheckBox checkEtiqueta3;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label5;
    }
}

