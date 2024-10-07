namespace Dapper_Demo
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
            this.dgvObtenerTodos = new System.Windows.Forms.DataGridView();
            this.btnObtenerTodos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxObtenerID = new System.Windows.Forms.TextBox();
            this.btnObtenerid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtboxCustomerID = new System.Windows.Forms.TextBox();
            this.txtboxAdress = new System.Windows.Forms.TextBox();
            this.txtboxContactName = new System.Windows.Forms.TextBox();
            this.txtboxCompannyName = new System.Windows.Forms.TextBox();
            this.txtboxContactTitle = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObtenerTodos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvObtenerTodos
            // 
            this.dgvObtenerTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObtenerTodos.Location = new System.Drawing.Point(26, 12);
            this.dgvObtenerTodos.Name = "dgvObtenerTodos";
            this.dgvObtenerTodos.RowHeadersWidth = 51;
            this.dgvObtenerTodos.RowTemplate.Height = 24;
            this.dgvObtenerTodos.Size = new System.Drawing.Size(240, 150);
            this.dgvObtenerTodos.TabIndex = 0;
            // 
            // btnObtenerTodos
            // 
            this.btnObtenerTodos.Location = new System.Drawing.Point(89, 198);
            this.btnObtenerTodos.Name = "btnObtenerTodos";
            this.btnObtenerTodos.Size = new System.Drawing.Size(75, 23);
            this.btnObtenerTodos.TabIndex = 1;
            this.btnObtenerTodos.Text = "Obtener Cliente";
            this.btnObtenerTodos.UseVisualStyleBackColor = true;
            this.btnObtenerTodos.Click += new System.EventHandler(this.btnObtenerTodos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID Cliente";
            // 
            // txtboxObtenerID
            // 
            this.txtboxObtenerID.Location = new System.Drawing.Point(91, 250);
            this.txtboxObtenerID.Name = "txtboxObtenerID";
            this.txtboxObtenerID.Size = new System.Drawing.Size(100, 22);
            this.txtboxObtenerID.TabIndex = 4;
            // 
            // btnObtenerid
            // 
            this.btnObtenerid.Location = new System.Drawing.Point(208, 248);
            this.btnObtenerid.Name = "btnObtenerid";
            this.btnObtenerid.Size = new System.Drawing.Size(75, 23);
            this.btnObtenerid.TabIndex = 5;
            this.btnObtenerid.Text = "Buscar";
            this.btnObtenerid.UseVisualStyleBackColor = true;
            this.btnObtenerid.Click += new System.EventHandler(this.btnObtenerid_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Company Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contact Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Contact Title";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(464, 256);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(50, 16);
            this.label.TabIndex = 10;
            this.label.Text = "Adress";
            // 
            // txtboxCustomerID
            // 
            this.txtboxCustomerID.Location = new System.Drawing.Point(531, 140);
            this.txtboxCustomerID.Name = "txtboxCustomerID";
            this.txtboxCustomerID.Size = new System.Drawing.Size(100, 22);
            this.txtboxCustomerID.TabIndex = 11;
            // 
            // txtboxAdress
            // 
            this.txtboxAdress.Location = new System.Drawing.Point(531, 250);
            this.txtboxAdress.Name = "txtboxAdress";
            this.txtboxAdress.Size = new System.Drawing.Size(100, 22);
            this.txtboxAdress.TabIndex = 12;
            // 
            // txtboxContactName
            // 
            this.txtboxContactName.Location = new System.Drawing.Point(531, 193);
            this.txtboxContactName.Name = "txtboxContactName";
            this.txtboxContactName.Size = new System.Drawing.Size(100, 22);
            this.txtboxContactName.TabIndex = 13;
            // 
            // txtboxCompannyName
            // 
            this.txtboxCompannyName.Location = new System.Drawing.Point(531, 165);
            this.txtboxCompannyName.Name = "txtboxCompannyName";
            this.txtboxCompannyName.Size = new System.Drawing.Size(100, 22);
            this.txtboxCompannyName.TabIndex = 14;
            // 
            // txtboxContactTitle
            // 
            this.txtboxContactTitle.Location = new System.Drawing.Point(531, 221);
            this.txtboxContactTitle.Name = "txtboxContactTitle";
            this.txtboxContactTitle.Size = new System.Drawing.Size(100, 22);
            this.txtboxContactTitle.TabIndex = 15;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(462, 292);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(169, 23);
            this.btnInsertar.TabIndex = 16;
            this.btnInsertar.Text = "Insertacion de USER";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(467, 374);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(164, 23);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminacion de USER";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(462, 321);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(169, 23);
            this.btnActualizar.TabIndex = 18;
            this.btnActualizar.Text = "Actualizacion de USER";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtboxContactTitle);
            this.Controls.Add(this.txtboxCompannyName);
            this.Controls.Add(this.txtboxContactName);
            this.Controls.Add(this.txtboxAdress);
            this.Controls.Add(this.txtboxCustomerID);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObtenerid);
            this.Controls.Add(this.txtboxObtenerID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnObtenerTodos);
            this.Controls.Add(this.dgvObtenerTodos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvObtenerTodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvObtenerTodos;
        private System.Windows.Forms.Button btnObtenerTodos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxObtenerID;
        private System.Windows.Forms.Button btnObtenerid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtboxCustomerID;
        private System.Windows.Forms.TextBox txtboxAdress;
        private System.Windows.Forms.TextBox txtboxContactName;
        private System.Windows.Forms.TextBox txtboxCompannyName;
        private System.Windows.Forms.TextBox txtboxContactTitle;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
    }
}

