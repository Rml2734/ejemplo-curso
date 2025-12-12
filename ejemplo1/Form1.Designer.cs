namespace ejemplo1
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
            lwElementos = new ListView();
            txtNombre = new TextBox();
            btnAgregar = new Button();
            lblNombre = new Label();
            lblFecha = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            ckbChocolate = new CheckBox();
            lblTitulo = new Label();
            rbtWizard = new RadioButton();
            rbtMuggle = new RadioButton();
            rbtSquibs = new RadioButton();
            gbxTipo = new GroupBox();
            lblColor = new Label();
            cboColorFavorito = new ComboBox();
            numNumeroFavorito = new NumericUpDown();
            lblNumeroFavorito = new Label();
            btnVerPerfil = new Button();
            gbxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numNumeroFavorito).BeginInit();
            SuspendLayout();
            // 
            // lwElementos
            // 
            lwElementos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lwElementos.Location = new Point(109, 435);
            lwElementos.Name = "lwElementos";
            lwElementos.Size = new Size(287, 96);
            lwElementos.TabIndex = 7;
            lwElementos.UseCompatibleStateImageBehavior = false;
            lwElementos.View = View.List;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Location = new Point(201, 73);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(195, 25);
            txtNombre.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregar.Location = new Point(109, 537);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 28);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "&Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(136, 76);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(60, 17);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(84, 109);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(114, 17);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha Nacimineto:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpFechaNacimiento.Location = new Point(196, 106);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(200, 25);
            dtpFechaNacimiento.TabIndex = 1;
            // 
            // ckbChocolate
            // 
            ckbChocolate.AutoSize = true;
            ckbChocolate.Location = new Point(207, 150);
            ckbChocolate.Name = "ckbChocolate";
            ckbChocolate.Size = new Size(160, 21);
            ckbChocolate.TabIndex = 2;
            ckbChocolate.Text = "Te gusta el chocolate ?";
            ckbChocolate.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(84, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(176, 37);
            lblTitulo.TabIndex = 9;
            lblTitulo.Text = "Perfil Persona";
            // 
            // rbtWizard
            // 
            rbtWizard.AutoSize = true;
            rbtWizard.Checked = true;
            rbtWizard.Location = new Point(33, 39);
            rbtWizard.Name = "rbtWizard";
            rbtWizard.Size = new Size(67, 21);
            rbtWizard.TabIndex = 0;
            rbtWizard.TabStop = true;
            rbtWizard.Text = "Wizard";
            rbtWizard.UseVisualStyleBackColor = true;
            // 
            // rbtMuggle
            // 
            rbtMuggle.AutoSize = true;
            rbtMuggle.Location = new Point(169, 41);
            rbtMuggle.Name = "rbtMuggle";
            rbtMuggle.Size = new Size(71, 21);
            rbtMuggle.TabIndex = 11;
            rbtMuggle.TabStop = true;
            rbtMuggle.Text = "Muggle";
            rbtMuggle.UseVisualStyleBackColor = true;
            // 
            // rbtSquibs
            // 
            rbtSquibs.AutoSize = true;
            rbtSquibs.Location = new Point(302, 41);
            rbtSquibs.Name = "rbtSquibs";
            rbtSquibs.Size = new Size(65, 21);
            rbtSquibs.TabIndex = 12;
            rbtSquibs.TabStop = true;
            rbtSquibs.Text = "Squibs";
            rbtSquibs.UseVisualStyleBackColor = true;
            // 
            // gbxTipo
            // 
            gbxTipo.Anchor = AnchorStyles.Top;
            gbxTipo.Controls.Add(rbtWizard);
            gbxTipo.Controls.Add(rbtSquibs);
            gbxTipo.Controls.Add(rbtMuggle);
            gbxTipo.Location = new Point(84, 187);
            gbxTipo.Name = "gbxTipo";
            gbxTipo.Size = new Size(393, 100);
            gbxTipo.TabIndex = 3;
            gbxTipo.TabStop = false;
            gbxTipo.Text = "Tipo";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(109, 303);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(94, 17);
            lblColor.TabIndex = 14;
            lblColor.Text = "Color Favorito:";
            // 
            // cboColorFavorito
            // 
            cboColorFavorito.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboColorFavorito.FormattingEnabled = true;
            cboColorFavorito.Location = new Point(207, 295);
            cboColorFavorito.Name = "cboColorFavorito";
            cboColorFavorito.Size = new Size(189, 25);
            cboColorFavorito.TabIndex = 4;
            // 
            // numNumeroFavorito
            // 
            numNumeroFavorito.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numNumeroFavorito.Location = new Point(207, 337);
            numNumeroFavorito.Name = "numNumeroFavorito";
            numNumeroFavorito.Size = new Size(189, 25);
            numNumeroFavorito.TabIndex = 5;
            // 
            // lblNumeroFavorito
            // 
            lblNumeroFavorito.AutoSize = true;
            lblNumeroFavorito.Location = new Point(91, 339);
            lblNumeroFavorito.Name = "lblNumeroFavorito";
            lblNumeroFavorito.Size = new Size(110, 17);
            lblNumeroFavorito.TabIndex = 17;
            lblNumeroFavorito.Text = "Numero Favorito:";
            // 
            // btnVerPerfil
            // 
            btnVerPerfil.FlatAppearance.BorderColor = Color.Teal;
            btnVerPerfil.FlatAppearance.BorderSize = 2;
            btnVerPerfil.FlatAppearance.MouseOverBackColor = Color.Purple;
            btnVerPerfil.FlatStyle = FlatStyle.Flat;
            btnVerPerfil.Location = new Point(109, 387);
            btnVerPerfil.Name = "btnVerPerfil";
            btnVerPerfil.Size = new Size(94, 42);
            btnVerPerfil.TabIndex = 6;
            btnVerPerfil.Text = "Ver &Perfil";
            btnVerPerfil.UseVisualStyleBackColor = true;
            btnVerPerfil.Click += btnVerPerfil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(505, 577);
            Controls.Add(btnVerPerfil);
            Controls.Add(lblNumeroFavorito);
            Controls.Add(numNumeroFavorito);
            Controls.Add(cboColorFavorito);
            Controls.Add(lblColor);
            Controls.Add(gbxTipo);
            Controls.Add(lblTitulo);
            Controls.Add(ckbChocolate);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(lblFecha);
            Controls.Add(lblNombre);
            Controls.Add(btnAgregar);
            Controls.Add(txtNombre);
            Controls.Add(lwElementos);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MaximumSize = new Size(865, 736);
            MinimumSize = new Size(521, 616);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            gbxTipo.ResumeLayout(false);
            gbxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numNumeroFavorito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView lwElementos;
        private TextBox txtNombre;
        private Button btnAgregar;
        private Label lblNombre;
        private Label lblFecha;
        private DateTimePicker dtpFechaNacimiento;
        private CheckBox ckbChocolate;
        private Label lblTitulo;
        private RadioButton rbtWizard;
        private RadioButton rbtMuggle;
        private RadioButton rbtSquibs;
        private GroupBox gbxTipo;
        private Label lblColor;
        private ComboBox cboColorFavorito;
        private NumericUpDown numNumeroFavorito;
        private Label lblNumeroFavorito;
        private Button btnVerPerfil;
    }
}
