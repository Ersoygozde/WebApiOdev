namespace EFReservation.Forms;

partial class MenuFRM
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
        label1 = new Label();
        txtTitle = new TextBox();
        txtDescription = new TextBox();
        label2 = new Label();
        txtPrice = new TextBox();
        label3 = new Label();
        textBox4 = new TextBox();
        label4 = new Label();
        btnMenu = new Button();
        dataGridView1 = new DataGridView();
        button2 = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(88, 43);
        label1.Name = "label1";
        label1.Size = new Size(44, 25);
        label1.TabIndex = 0;
        label1.Text = "Title";
        // 
        // txtTitle
        // 
        txtTitle.Location = new Point(187, 43);
        txtTitle.Name = "txtTitle";
        txtTitle.Size = new Size(150, 31);
        txtTitle.TabIndex = 1;
        // 
        // txtDescription
        // 
        txtDescription.Location = new Point(187, 108);
        txtDescription.Name = "txtDescription";
        txtDescription.Size = new Size(150, 31);
        txtDescription.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(88, 108);
        label2.Name = "label2";
        label2.Size = new Size(102, 25);
        label2.TabIndex = 2;
        label2.Text = "Description";
        // 
        // txtPrice
        // 
        txtPrice.Location = new Point(187, 175);
        txtPrice.Name = "txtPrice";
        txtPrice.Size = new Size(150, 31);
        txtPrice.TabIndex = 5;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(88, 175);
        label3.Name = "label3";
        label3.Size = new Size(49, 25);
        label3.TabIndex = 4;
        label3.Text = "Price";
        // 
        // textBox4
        // 
        textBox4.Location = new Point(187, 244);
        textBox4.Name = "textBox4";
        textBox4.Size = new Size(150, 31);
        textBox4.TabIndex = 7;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(88, 244);
        label4.Name = "label4";
        label4.Size = new Size(59, 25);
        label4.TabIndex = 6;
        label4.Text = "label4";
        // 
        // btnMenu
        // 
        btnMenu.Location = new Point(88, 333);
        btnMenu.Name = "btnMenu";
        btnMenu.Size = new Size(249, 40);
        btnMenu.TabIndex = 8;
        btnMenu.Text = "MenuAdd";
        btnMenu.UseVisualStyleBackColor = true;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(526, 43);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 62;
        dataGridView1.Size = new Size(789, 423);
        dataGridView1.TabIndex = 9;
        // 
        // button2
        // 
        button2.Location = new Point(1125, 496);
        button2.Name = "button2";
        button2.Size = new Size(190, 31);
        button2.TabIndex = 10;
        button2.Text = "button2";
        button2.UseVisualStyleBackColor = true;
        // 
        // MenuFRM
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1327, 724);
        Controls.Add(button2);
        Controls.Add(dataGridView1);
        Controls.Add(btnMenu);
        Controls.Add(textBox4);
        Controls.Add(label4);
        Controls.Add(txtPrice);
        Controls.Add(label3);
        Controls.Add(txtDescription);
        Controls.Add(label2);
        Controls.Add(txtTitle);
        Controls.Add(label1);
        Name = "MenuFRM";
        Text = "MenuFRM";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txtTitle;
    private TextBox txtDescription;
    private Label label2;
    private TextBox txtPrice;
    private Label label3;
    private TextBox textBox4;
    private Label label4;
    private Button btnMenu;
    private DataGridView dataGridView1;
    private Button button2;
}