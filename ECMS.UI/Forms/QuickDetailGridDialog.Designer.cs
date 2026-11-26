namespace ECMS.UI.Forms;

partial class QuickDetailGridDialog
{
    private System.ComponentModel.IContainer components = null;

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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
        pnlHeader = new System.Windows.Forms.Panel();
        lblTitle = new System.Windows.Forms.Label();
        pnlBody = new System.Windows.Forms.Panel();
        cardGrid = new ECMS.UI.Controls.AppCard();
        dgvGrid = new ECMS.UI.Controls.AppDataGrid();
        pnlHeader.SuspendLayout();
        pnlBody.SuspendLayout();
        cardGrid.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvGrid).BeginInit();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = System.Drawing.Color.White;
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        pnlHeader.Location = new System.Drawing.Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 12);
        pnlHeader.Size = new System.Drawing.Size(820, 72);
        pnlHeader.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold);
        lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)15)), ((int)((byte)23)), ((int)((byte)42)));
        lblTitle.Location = new System.Drawing.Point(22, 14);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(226, 31);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Tiêu đề xem chi tiết";
        // 
        // pnlBody
        // 
        pnlBody.Controls.Add(cardGrid);
        pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlBody.Location = new System.Drawing.Point(0, 72);
        pnlBody.Name = "pnlBody";
        pnlBody.Padding = new System.Windows.Forms.Padding(20, 16, 20, 12);
        pnlBody.Size = new System.Drawing.Size(820, 474);
        pnlBody.TabIndex = 1;
        // 
        // cardGrid
        // 
        cardGrid.BackColor = System.Drawing.Color.White;
        cardGrid.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        cardGrid.BorderWidth = 1;
        cardGrid.Controls.Add(dgvGrid);
        cardGrid.CornerRadius = 6;
        cardGrid.Dock = System.Windows.Forms.DockStyle.Fill;
        cardGrid.Location = new System.Drawing.Point(20, 16);
        cardGrid.Name = "cardGrid";
        cardGrid.Padding = new System.Windows.Forms.Padding(12);
        cardGrid.Size = new System.Drawing.Size(780, 446);
        cardGrid.TabIndex = 0;
        // 
        // dgvGrid
        // 
        dgvGrid.AllowUserToAddRows = false;
        dgvGrid.AllowUserToDeleteRows = false;
        dgvGrid.AllowUserToResizeColumns = true;
        dgvGrid.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dgvGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        dgvGrid.BackgroundColor = System.Drawing.Color.White;
        dgvGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dgvGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        dgvGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)100)), ((int)((byte)116)), ((int)((byte)139)));
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)30)), ((int)((byte)41)), ((int)((byte)59)));
        dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)239)), ((int)((byte)246)), ((int)((byte)255)));
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)37)), ((int)((byte)99)), ((int)((byte)235)));
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        dgvGrid.DefaultCellStyle = dataGridViewCellStyle3;
        dgvGrid.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvGrid.EnableHeadersVisualStyles = false;
        dgvGrid.GridColor = System.Drawing.Color.FromArgb(((int)((byte)226)), ((int)((byte)232)), ((int)((byte)240)));
        dgvGrid.Location = new System.Drawing.Point(12, 12);
        dgvGrid.MultiSelect = false;
        dgvGrid.Name = "dgvGrid";
        dgvGrid.ReadOnly = false;
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        dgvGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvGrid.RowHeadersVisible = false;
        dgvGrid.RowHeadersWidth = 51;
        dgvGrid.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        dgvGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvGrid.Size = new System.Drawing.Size(1056, 556);
        dgvGrid.TabIndex = 0;
        // 
        // QuickDetailGridDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)248)), ((int)((byte)250)), ((int)((byte)252)));
        ClientSize = new System.Drawing.Size(1120, 680);
        Controls.Add(pnlBody);
        Controls.Add(pnlHeader);
        Font = new System.Drawing.Font("Segoe UI", 9F);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        MaximizeBox = true;
        MinimizeBox = false;
        MinimumSize = new System.Drawing.Size(800, 500);
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Chi tiết dữ liệu";
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlBody.ResumeLayout(false);
        cardGrid.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvGrid).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel pnlBody;
    private ECMS.UI.Controls.AppCard cardGrid;
    private ECMS.UI.Controls.AppDataGrid dgvGrid;
}
