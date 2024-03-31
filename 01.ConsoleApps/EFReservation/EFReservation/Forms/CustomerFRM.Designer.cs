namespace EFReservation.Forms;

partial class CustomerFRM
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
        txtName = new TextBox();
        label1 = new Label();
        label2 = new Label();
        txtSurname = new TextBox();
        label3 = new Label();
        txtEmail = new TextBox();
        label4 = new Label();
        txtPhone = new TextBox();
        label5 = new Label();
        txtAdress = new TextBox();
        btnCustomerAdd = new Button();
        dGVCustomers = new DataGridView();
        btnDelete = new Button();
        ((System.ComponentModel.ISupportInitialize)dGVCustomers).BeginInit();
        SuspendLayout();
        // 
        // txtName
        // 
        txtName.Location = new Point(152, 33);
        txtName.Name = "txtName";
        txtName.Size = new Size(150, 31);
        txtName.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(52, 39);
        label1.Name = "label1";
        label1.Size = new Size(59, 25);
        label1.TabIndex = 1;
        label1.Text = "Name";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(52, 93);
        label2.Name = "label2";
        label2.Size = new Size(82, 25);
        label2.TabIndex = 3;
        label2.Text = "Surname";
        label2.Click += label2_Click;
        // 
        // txtSurname
        // 
        txtSurname.Location = new Point(152, 87);
        txtSurname.Name = "txtSurname";
        txtSurname.Size = new Size(150, 31);
        txtSurname.TabIndex = 2;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(52, 159);
        label3.Name = "label3";
        label3.Size = new Size(54, 25);
        label3.TabIndex = 5;
        label3.Text = "Email";
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(152, 153);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(150, 31);
        txtEmail.TabIndex = 4;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(52, 221);
        label4.Name = "label4";
        label4.Size = new Size(62, 25);
        label4.TabIndex = 7;
        label4.Text = "Phone";
        // 
        // txtPhone
        // 
        txtPhone.Location = new Point(152, 215);
        txtPhone.Name = "txtPhone";
        txtPhone.Size = new Size(150, 31);
        txtPhone.TabIndex = 6;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(52, 283);
        label5.Name = "label5";
        label5.Size = new Size(66, 25);
        label5.TabIndex = 9;
        label5.Text = "Adress";
        // 
        // txtAdress
        // 
        txtAdress.Location = new Point(152, 277);
        txtAdress.Name = "txtAdress";
        txtAdress.Size = new Size(150, 31);
        txtAdress.TabIndex = 8;
        // 
        // btnCustomerAdd
        // 
        btnCustomerAdd.Location = new Point(52, 337);
        btnCustomerAdd.Name = "btnCustomerAdd";
        btnCustomerAdd.Size = new Size(250, 49);
        btnCustomerAdd.TabIndex = 10;
        btnCustomerAdd.Text = "CustomerAdd";
        btnCustomerAdd.UseVisualStyleBackColor = true;
        btnCustomerAdd.Click += btnCustomerAdd_Click;
        // 
        // dGVCustomers
        // 
        dGVCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dGVCustomers.Location = new Point(487, 33);
        dGVCustomers.Name = "dGVCustomers";
        dGVCustomers.RowHeadersWidth = 62;
        dGVCustomers.Size = new Size(802, 378);
        dGVCustomers.TabIndex = 11;
        dGVCustomers.CellContentClick += dGVCustomers_CellContentClick;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(1039, 434);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(250, 42);
        btnDelete.TabIndex = 12;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // CustomerFRM
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1321, 751);
        Controls.Add(btnDelete);
        Controls.Add(dGVCustomers);
        Controls.Add(btnCustomerAdd);
        Controls.Add(label5);
        Controls.Add(txtAdress);
        Controls.Add(label4);
        Controls.Add(txtPhone);
        Controls.Add(label3);
        Controls.Add(txtEmail);
        Controls.Add(label2);
        Controls.Add(txtSurname);
        Controls.Add(label1);
        Controls.Add(txtName);
        Name = "CustomerFRM";
        Text = "CustomerFRM";
        Load += CustomerFRM_Load;
        ((System.ComponentModel.ISupportInitialize)dGVCustomers).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtName;
    private Label label1;
    private Label label2;
    private TextBox txtSurname;
    private Label label3;
    private TextBox txtEmail;
    private Label label4;
    private TextBox txtPhone;
    private Label label5;
    private TextBox txtAdress;
    private Button btnCustomerAdd;
    private DataGridView dGVCustomers;
    private Button btnDelete;
}