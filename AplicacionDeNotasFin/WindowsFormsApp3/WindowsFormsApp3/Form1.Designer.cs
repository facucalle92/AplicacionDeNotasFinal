namespace WindowsFormsApp3
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApel = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.txtAppelido = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrdenNombre = new System.Windows.Forms.Button();
            this.btnOrdenApellido = new System.Windows.Forms.Button();
            this.btnOrdenNota = new System.Windows.Forms.Button();
            this.dataGridLista = new System.Windows.Forms.DataGridView();
            this.dataGridAcomoda = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOrdenMateria = new System.Windows.Forms.Button();
            this.ComboBoxMaterias = new System.Windows.Forms.ComboBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.lblAgregarMateria = new System.Windows.Forms.Label();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.comboBoxNota = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblorden = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAcomoda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNom.Location = new System.Drawing.Point(12, 20);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(47, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(73, 17);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(171, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblApel
            // 
            this.lblApel.AutoSize = true;
            this.lblApel.ForeColor = System.Drawing.SystemColors.Control;
            this.lblApel.Location = new System.Drawing.Point(12, 54);
            this.lblApel.Name = "lblApel";
            this.lblApel.Size = new System.Drawing.Size(47, 13);
            this.lblApel.TabIndex = 2;
            this.lblApel.Text = "Apellido:";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNota.Location = new System.Drawing.Point(26, 127);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(33, 13);
            this.lblNota.TabIndex = 3;
            this.lblNota.Text = "Nota:";
            // 
            // txtAppelido
            // 
            this.txtAppelido.BackColor = System.Drawing.Color.White;
            this.txtAppelido.Location = new System.Drawing.Point(73, 51);
            this.txtAppelido.Name = "txtAppelido";
            this.txtAppelido.Size = new System.Drawing.Size(171, 20);
            this.txtAppelido.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Location = new System.Drawing.Point(153, 127);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(91, 24);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(603, 54);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(103, 20);
            this.txtBuscar.TabIndex = 7;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(718, 34);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 22);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.Location = new System.Drawing.Point(718, 85);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(550, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre:";
            // 
            // btnOrdenNombre
            // 
            this.btnOrdenNombre.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOrdenNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOrdenNombre.Location = new System.Drawing.Point(475, 158);
            this.btnOrdenNombre.Name = "btnOrdenNombre";
            this.btnOrdenNombre.Size = new System.Drawing.Size(85, 24);
            this.btnOrdenNombre.TabIndex = 17;
            this.btnOrdenNombre.Text = "Orden Nombre";
            this.btnOrdenNombre.UseVisualStyleBackColor = false;
            this.btnOrdenNombre.Click += new System.EventHandler(this.BtnOrdenNombre_Click);
            // 
            // btnOrdenApellido
            // 
            this.btnOrdenApellido.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOrdenApellido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOrdenApellido.Location = new System.Drawing.Point(566, 158);
            this.btnOrdenApellido.Name = "btnOrdenApellido";
            this.btnOrdenApellido.Size = new System.Drawing.Size(84, 24);
            this.btnOrdenApellido.TabIndex = 18;
            this.btnOrdenApellido.Text = "Orden Apellido";
            this.btnOrdenApellido.UseVisualStyleBackColor = false;
            this.btnOrdenApellido.Click += new System.EventHandler(this.BtnOrdenApellido_Click);
            // 
            // btnOrdenNota
            // 
            this.btnOrdenNota.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOrdenNota.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOrdenNota.Location = new System.Drawing.Point(755, 158);
            this.btnOrdenNota.Name = "btnOrdenNota";
            this.btnOrdenNota.Size = new System.Drawing.Size(74, 24);
            this.btnOrdenNota.TabIndex = 19;
            this.btnOrdenNota.Text = "Orden Nota";
            this.btnOrdenNota.UseVisualStyleBackColor = false;
            this.btnOrdenNota.Click += new System.EventHandler(this.BtnOrdenNota_Click);
            // 
            // dataGridLista
            // 
            this.dataGridLista.AllowUserToAddRows = false;
            this.dataGridLista.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.dataGridLista.EnableHeadersVisualStyles = false;
            this.dataGridLista.GridColor = System.Drawing.Color.Black;
            this.dataGridLista.Location = new System.Drawing.Point(29, 238);
            this.dataGridLista.Name = "dataGridLista";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridLista.RowHeadersVisible = false;
            this.dataGridLista.Size = new System.Drawing.Size(354, 272);
            this.dataGridLista.TabIndex = 20;
            // 
            // dataGridAcomoda
            // 
            this.dataGridAcomoda.AllowUserToAddRows = false;
            this.dataGridAcomoda.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAcomoda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridAcomoda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAcomoda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column5,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAcomoda.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridAcomoda.EnableHeadersVisualStyles = false;
            this.dataGridAcomoda.GridColor = System.Drawing.Color.Black;
            this.dataGridAcomoda.Location = new System.Drawing.Point(475, 238);
            this.dataGridAcomoda.Name = "dataGridAcomoda";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAcomoda.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridAcomoda.RowHeadersVisible = false;
            this.dataGridAcomoda.Size = new System.Drawing.Size(354, 272);
            this.dataGridAcomoda.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(144, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Lista Original";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(599, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Lista Ordenada";
            // 
            // btnOrdenMateria
            // 
            this.btnOrdenMateria.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOrdenMateria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOrdenMateria.Location = new System.Drawing.Point(665, 158);
            this.btnOrdenMateria.Name = "btnOrdenMateria";
            this.btnOrdenMateria.Size = new System.Drawing.Size(84, 24);
            this.btnOrdenMateria.TabIndex = 24;
            this.btnOrdenMateria.Text = "Orden Materia";
            this.btnOrdenMateria.UseVisualStyleBackColor = false;
            this.btnOrdenMateria.Click += new System.EventHandler(this.BtnOrdenMateria_Click);
            // 
            // ComboBoxMaterias
            // 
            this.ComboBoxMaterias.FormattingEnabled = true;
            this.ComboBoxMaterias.Items.AddRange(new object[] {
            "Astronomía",
            "Biología",
            "Sistemas y Organizaciones",
            "Física",
            "Geografía",
            "Historia",
            "Inglés",
            "Lengua",
            "Matemática",
            "Música",
            "Programación",
            "Tecnología"});
            this.ComboBoxMaterias.Location = new System.Drawing.Point(73, 87);
            this.ComboBoxMaterias.Name = "ComboBoxMaterias";
            this.ComboBoxMaterias.Size = new System.Drawing.Size(109, 21);
            this.ComboBoxMaterias.TabIndex = 25;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMateria.Location = new System.Drawing.Point(14, 90);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(45, 13);
            this.lblMateria.TabIndex = 26;
            this.lblMateria.Text = "Materia:";
            // 
            // txtMateria
            // 
            this.txtMateria.BackColor = System.Drawing.Color.White;
            this.txtMateria.Location = new System.Drawing.Point(338, 47);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(119, 20);
            this.txtMateria.TabIndex = 27;
            // 
            // lblAgregarMateria
            // 
            this.lblAgregarMateria.AutoSize = true;
            this.lblAgregarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarMateria.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAgregarMateria.Location = new System.Drawing.Point(334, 13);
            this.lblAgregarMateria.Name = "lblAgregarMateria";
            this.lblAgregarMateria.Size = new System.Drawing.Size(123, 20);
            this.lblAgregarMateria.TabIndex = 28;
            this.lblAgregarMateria.Text = "Agregar Materia";
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarMateria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarMateria.Location = new System.Drawing.Point(354, 84);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(91, 24);
            this.btnAgregarMateria.TabIndex = 29;
            this.btnAgregarMateria.Text = "Agregar";
            this.btnAgregarMateria.UseVisualStyleBackColor = false;
            this.btnAgregarMateria.Click += new System.EventHandler(this.BtnAgregarMateria_Click);
            // 
            // comboBoxNota
            // 
            this.comboBoxNota.FormattingEnabled = true;
            this.comboBoxNota.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxNota.Location = new System.Drawing.Point(73, 124);
            this.comboBoxNota.Name = "comboBoxNota";
            this.comboBoxNota.Size = new System.Drawing.Size(38, 21);
            this.comboBoxNota.TabIndex = 30;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Indigo;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.Width = 105;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Indigo;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Apellido";
            this.Column2.Name = "Column2";
            this.Column2.Width = 105;
            // 
            // Column4
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Indigo;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "Materia";
            this.Column4.Name = "Column4";
            this.Column4.Width = 105;
            // 
            // Column3
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Indigo;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column3.HeaderText = "Nota";
            this.Column3.Name = "Column3";
            this.Column3.Width = 35;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 105;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn2.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 105;
            // 
            // Column5
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Indigo;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column5.HeaderText = "Materia";
            this.Column5.Name = "Column5";
            this.Column5.Width = 105;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn3.HeaderText = "Nota";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 35;
            // 
            // lblorden
            // 
            this.lblorden.AutoSize = true;
            this.lblorden.ForeColor = System.Drawing.SystemColors.Control;
            this.lblorden.Location = new System.Drawing.Point(637, 222);
            this.lblorden.Name = "lblorden";
            this.lblorden.Size = new System.Drawing.Size(0, 13);
            this.lblorden.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(883, 566);
            this.Controls.Add(this.lblorden);
            this.Controls.Add(this.comboBoxNota);
            this.Controls.Add(this.btnAgregarMateria);
            this.Controls.Add(this.lblAgregarMateria);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.ComboBoxMaterias);
            this.Controls.Add(this.btnOrdenMateria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridAcomoda);
            this.Controls.Add(this.dataGridLista);
            this.Controls.Add(this.btnOrdenNota);
            this.Controls.Add(this.btnOrdenApellido);
            this.Controls.Add(this.btnOrdenNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtAppelido);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.lblApel);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNom);
            this.Name = "Form1";
            this.Text = "Calificaciones";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAcomoda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApel;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.TextBox txtAppelido;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrdenNombre;
        private System.Windows.Forms.Button btnOrdenApellido;
        private System.Windows.Forms.Button btnOrdenNota;
        private System.Windows.Forms.DataGridView dataGridLista;
        private System.Windows.Forms.DataGridView dataGridAcomoda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOrdenMateria;
        private System.Windows.Forms.ComboBox ComboBoxMaterias;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Label lblAgregarMateria;
        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.ComboBox comboBoxNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label lblorden;
    }
}

