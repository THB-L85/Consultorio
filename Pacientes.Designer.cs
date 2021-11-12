
namespace ConsultorioDental
{
    partial class Pacientes
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaPacientesBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.tablaPacientesBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.tablaPacientesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tablaPacientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tablaPacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.agregarPacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablaPacientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPacientesBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPacientesBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPacientesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPacientesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agregarPacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPacientesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.Edit});
            this.dataGridView1.DataSource = this.tablaPacientesBindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(962, 446);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(92, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(510, 29);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(689, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(839, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 57);
            this.button2.TabIndex = 4;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // tablaPacientesBindingSource5
            // 
            this.tablaPacientesBindingSource5.DataSource = typeof(ConsultorioDental.TablaPacientes);
            // 
            // tablaPacientesBindingSource4
            // 
            this.tablaPacientesBindingSource4.DataSource = typeof(ConsultorioDental.TablaPacientes);
            // 
            // tablaPacientesBindingSource3
            // 
            this.tablaPacientesBindingSource3.DataSource = typeof(ConsultorioDental.TablaPacientes);
            // 
            // tablaPacientesBindingSource2
            // 
            this.tablaPacientesBindingSource2.DataSource = typeof(ConsultorioDental.TablaPacientes);
            // 
            // tablaPacientesBindingSource
            // 
            this.tablaPacientesBindingSource.DataSource = typeof(ConsultorioDental.TablaPacientes);
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataSource = typeof(ConsultorioDental.Pacientes);
            // 
            // pacientesBindingSource1
            // 
            this.pacientesBindingSource1.DataSource = typeof(ConsultorioDental.Pacientes);
            // 
            // pacientesBindingSource2
            // 
            this.pacientesBindingSource2.DataSource = typeof(ConsultorioDental.Pacientes);
            // 
            // agregarPacienteBindingSource
            // 
            this.agregarPacienteBindingSource.DataSource = typeof(ConsultorioDental.AgregarPaciente);
            // 
            // pacientesBindingSource3
            // 
            this.pacientesBindingSource3.DataSource = typeof(ConsultorioDental.Pacientes);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(ConsultorioDental.Program);
            // 
            // tablaPacientesBindingSource1
            // 
            this.tablaPacientesBindingSource1.DataSource = typeof(ConsultorioDental.TablaPacientes);
            // 
            // Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 545);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Pacientes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Pacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPacientesBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPacientesBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPacientesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPacientesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agregarPacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPacientesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private System.Windows.Forms.BindingSource pacientesBindingSource1;
        private System.Windows.Forms.BindingSource pacientesBindingSource2;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.BindingSource agregarPacienteBindingSource;
        private System.Windows.Forms.BindingSource pacientesBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tablaPacientesBindingSource;
        private System.Windows.Forms.BindingSource tablaPacientesBindingSource1;
        private System.Windows.Forms.BindingSource tablaPacientesBindingSource2;
        private System.Windows.Forms.BindingSource tablaPacientesBindingSource3;
        private System.Windows.Forms.BindingSource tablaPacientesBindingSource4;
        private System.Windows.Forms.BindingSource tablaPacientesBindingSource5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
    }
}

