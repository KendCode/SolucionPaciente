/*
 * Creado por SharpDevelop.
 * Usuario: Hilda
 * Fecha: 25/9/2024
 * Hora: 08:09
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace SolucionPaciente
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox lbxMed;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cbbxSintoma;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.RadioButton rbtMasc;
		private System.Windows.Forms.RadioButton rbtFem;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtCi;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.DataGridView dgvPacientes;
		private System.Windows.Forms.DataGridViewTextBoxColumn nro;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
		private System.Windows.Forms.DataGridViewTextBoxColumn ci;
		private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn genero;
		private System.Windows.Forms.DataGridViewTextBoxColumn codRM;
		private System.Windows.Forms.DataGridViewTextBoxColumn sintomas;
		private System.Windows.Forms.DataGridViewTextBoxColumn labo;
		private System.Windows.Forms.DataGridViewTextBoxColumn radio;
		private System.Windows.Forms.DataGridViewTextBoxColumn medi;
		private System.Windows.Forms.DataGridViewTextBoxColumn uni;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lbxMed = new System.Windows.Forms.ListBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cbbxSintoma = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.rbtMasc = new System.Windows.Forms.RadioButton();
			this.rbtFem = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCi = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.dgvPacientes = new System.Windows.Forms.DataGridView();
			this.nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ci = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.codRM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sintomas = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.labo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.radio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.medi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.uni = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(238, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(349, 41);
			this.label1.TabIndex = 0;
			this.label1.Text = "REGISTRO DE PACIENTE";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lbxMed);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.cbbxSintoma);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.rbtMasc);
			this.groupBox1.Controls.Add(this.rbtFem);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.dtpFecha);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtCi);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtApellido);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtNombre);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(13, 45);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(588, 230);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos Paciente";
			// 
			// lbxMed
			// 
			this.lbxMed.FormattingEnabled = true;
			this.lbxMed.ItemHeight = 20;
			this.lbxMed.Items.AddRange(new object[] {
			"Paracetamol",
			"Dexametasona",
			"Eutirox",
			"Orfidal"});
			this.lbxMed.Location = new System.Drawing.Point(428, 125);
			this.lbxMed.Name = "lbxMed";
			this.lbxMed.Size = new System.Drawing.Size(146, 84);
			this.lbxMed.TabIndex = 14;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(369, 98);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(125, 23);
			this.label8.TabIndex = 13;
			this.label8.Text = "Medicamento:";
			// 
			// cbbxSintoma
			// 
			this.cbbxSintoma.FormattingEnabled = true;
			this.cbbxSintoma.Items.AddRange(new object[] {
			"Mareo",
			"Dolor",
			"Desmayo"});
			this.cbbxSintoma.Location = new System.Drawing.Point(247, 125);
			this.cbbxSintoma.Name = "cbbxSintoma";
			this.cbbxSintoma.Size = new System.Drawing.Size(113, 28);
			this.cbbxSintoma.TabIndex = 12;
			this.cbbxSintoma.Text = "Seleccione";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(196, 98);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 11;
			this.label7.Text = "Sintomas:";
			// 
			// rbtMasc
			// 
			this.rbtMasc.Location = new System.Drawing.Point(49, 155);
			this.rbtMasc.Name = "rbtMasc";
			this.rbtMasc.Size = new System.Drawing.Size(141, 24);
			this.rbtMasc.TabIndex = 10;
			this.rbtMasc.TabStop = true;
			this.rbtMasc.Text = "Masculino";
			this.rbtMasc.UseVisualStyleBackColor = true;
			// 
			// rbtFem
			// 
			this.rbtFem.Location = new System.Drawing.Point(49, 125);
			this.rbtFem.Name = "rbtFem";
			this.rbtFem.Size = new System.Drawing.Size(141, 24);
			this.rbtFem.TabIndex = 9;
			this.rbtFem.TabStop = true;
			this.rbtFem.Text = "Femenino";
			this.rbtFem.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(19, 98);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 8;
			this.label6.Text = "Genero:";
			// 
			// dtpFecha
			// 
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(334, 59);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(135, 26);
			this.dtpFecha.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(247, 62);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 6;
			this.label5.Text = "Fecha:";
			// 
			// txtCi
			// 
			this.txtCi.Location = new System.Drawing.Point(106, 59);
			this.txtCi.Name = "txtCi";
			this.txtCi.Size = new System.Drawing.Size(135, 26);
			this.txtCi.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(19, 62);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "CI:";
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(334, 23);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(135, 26);
			this.txtApellido.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(247, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Apellido:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(106, 23);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(135, 26);
			this.txtNombre.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(19, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Nombre:";
			// 
			// btnNuevo
			// 
			this.btnNuevo.Location = new System.Drawing.Point(607, 55);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(138, 30);
			this.btnNuevo.TabIndex = 2;
			this.btnNuevo.Text = "NUEVO";
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.BtnNuevoClick);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(607, 91);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(138, 26);
			this.btnAgregar.TabIndex = 3;
			this.btnAgregar.Text = "AGREGAR";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(607, 124);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(138, 28);
			this.btnModificar.TabIndex = 4;
			this.btnModificar.Text = "MODIFICAR";
			this.btnModificar.UseVisualStyleBackColor = true;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(607, 158);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(138, 28);
			this.btnEliminar.TabIndex = 5;
			this.btnEliminar.Text = "ELIMINAR";
			this.btnEliminar.UseVisualStyleBackColor = true;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(607, 204);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(138, 30);
			this.btnLimpiar.TabIndex = 6;
			this.btnLimpiar.Text = "LIMPIAR";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(607, 239);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(138, 29);
			this.btnSalir.TabIndex = 7;
			this.btnSalir.Text = "SALIR";
			this.btnSalir.UseVisualStyleBackColor = true;
			// 
			// dgvPacientes
			// 
			this.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
			this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.nro,
			this.nombre,
			this.apellido,
			this.ci,
			this.fecha,
			this.genero,
			this.codRM,
			this.sintomas,
			this.labo,
			this.radio,
			this.medi,
			this.uni});
			this.dgvPacientes.Location = new System.Drawing.Point(13, 282);
			this.dgvPacientes.Name = "dgvPacientes";
			this.dgvPacientes.Size = new System.Drawing.Size(732, 150);
			this.dgvPacientes.TabIndex = 8;
			// 
			// nro
			// 
			this.nro.HeaderText = "Nro";
			this.nro.Name = "nro";
			this.nro.Width = 62;
			// 
			// nombre
			// 
			this.nombre.HeaderText = "Nombre";
			this.nombre.Name = "nombre";
			this.nombre.Width = 96;
			// 
			// apellido
			// 
			this.apellido.HeaderText = "Apellido";
			this.apellido.Name = "apellido";
			this.apellido.Width = 98;
			// 
			// ci
			// 
			this.ci.HeaderText = "CI";
			this.ci.Name = "ci";
			this.ci.Width = 52;
			// 
			// fecha
			// 
			this.fecha.HeaderText = "Fecha";
			this.fecha.Name = "fecha";
			this.fecha.Width = 84;
			// 
			// genero
			// 
			this.genero.HeaderText = "Genero";
			this.genero.Name = "genero";
			this.genero.Width = 94;
			// 
			// codRM
			// 
			this.codRM.HeaderText = "Cod RM";
			this.codRM.Name = "codRM";
			this.codRM.Width = 98;
			// 
			// sintomas
			// 
			this.sintomas.HeaderText = "Sintomas";
			this.sintomas.Name = "sintomas";
			this.sintomas.Width = 109;
			// 
			// labo
			// 
			this.labo.HeaderText = "Labo";
			this.labo.Name = "labo";
			this.labo.Width = 74;
			// 
			// radio
			// 
			this.radio.HeaderText = "Radiog";
			this.radio.Name = "radio";
			this.radio.Width = 91;
			// 
			// medi
			// 
			this.medi.HeaderText = "Medicamento";
			this.medi.Name = "medi";
			this.medi.Width = 141;
			// 
			// uni
			// 
			this.uni.HeaderText = "Unidades";
			this.uni.Name = "uni";
			this.uni.Width = 110;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(764, 457);
			this.Controls.Add(this.dgvPacientes);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "MainForm";
			this.Text = "SolucionPaciente";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
