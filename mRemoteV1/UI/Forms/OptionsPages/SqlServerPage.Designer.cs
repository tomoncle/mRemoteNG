

namespace mRemoteNG.UI.Forms.OptionsPages
{
	
    public partial class SqlServerPage : OptionsPage
	{
			
		//UserControl overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
			
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
			
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlServerPage));
            this.lblSQLDatabaseName = new mRemoteNG.UI.Controls.Base.NGLabel();
            this.txtSQLDatabaseName = new mRemoteNG.UI.Controls.Base.NGTextBox();
            this.lblExperimental = new mRemoteNG.UI.Controls.Base.NGLabel();
            this.chkUseSQLServer = new mRemoteNG.UI.Controls.Base.NGCheckBox();
            this.lblSQLUsername = new mRemoteNG.UI.Controls.Base.NGLabel();
            this.txtSQLPassword = new mRemoteNG.UI.Controls.Base.NGTextBox();
            this.lblSQLInfo = new mRemoteNG.UI.Controls.Base.NGLabel();
            this.lblSQLServer = new mRemoteNG.UI.Controls.Base.NGLabel();
            this.txtSQLUsername = new mRemoteNG.UI.Controls.Base.NGTextBox();
            this.txtSQLServer = new mRemoteNG.UI.Controls.Base.NGTextBox();
            this.lblSQLPassword = new mRemoteNG.UI.Controls.Base.NGLabel();
            this.SuspendLayout();
            // 
            // lblSQLDatabaseName
            // 
            this.lblSQLDatabaseName.Enabled = false;
            this.lblSQLDatabaseName.Location = new System.Drawing.Point(23, 132);
            this.lblSQLDatabaseName.Name = "lblSQLDatabaseName";
            this.lblSQLDatabaseName.Size = new System.Drawing.Size(111, 13);
            this.lblSQLDatabaseName.TabIndex = 5;
            this.lblSQLDatabaseName.Text = "Database:";
            this.lblSQLDatabaseName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSQLDatabaseName
            // 
            this.txtSQLDatabaseName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSQLDatabaseName.Enabled = false;
            this.txtSQLDatabaseName.Location = new System.Drawing.Point(140, 130);
            this.txtSQLDatabaseName.Name = "txtSQLDatabaseName";
            this.txtSQLDatabaseName.Size = new System.Drawing.Size(153, 20);
            this.txtSQLDatabaseName.TabIndex = 6;
            // 
            // lblExperimental
            // 
            this.lblExperimental.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExperimental.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.lblExperimental.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblExperimental.Location = new System.Drawing.Point(3, 0);
            this.lblExperimental.Name = "lblExperimental";
            this.lblExperimental.Size = new System.Drawing.Size(596, 25);
            this.lblExperimental.TabIndex = 0;
            this.lblExperimental.Text = "EXPERIMENTAL";
            this.lblExperimental.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkUseSQLServer
            // 
            this.chkUseSQLServer._mice = mRemoteNG.UI.Controls.Base.NGCheckBox.MouseState.HOVER;
            this.chkUseSQLServer.AutoSize = true;
            this.chkUseSQLServer.Location = new System.Drawing.Point(3, 76);
            this.chkUseSQLServer.Name = "chkUseSQLServer";
            this.chkUseSQLServer.Size = new System.Drawing.Size(234, 17);
            this.chkUseSQLServer.TabIndex = 2;
            this.chkUseSQLServer.Text = "Use SQL Server to load && save connections";
            this.chkUseSQLServer.UseVisualStyleBackColor = true;
            this.chkUseSQLServer.CheckedChanged += new System.EventHandler(this.chkUseSQLServer_CheckedChanged);
            // 
            // lblSQLUsername
            // 
            this.lblSQLUsername.Enabled = false;
            this.lblSQLUsername.Location = new System.Drawing.Point(23, 158);
            this.lblSQLUsername.Name = "lblSQLUsername";
            this.lblSQLUsername.Size = new System.Drawing.Size(111, 13);
            this.lblSQLUsername.TabIndex = 7;
            this.lblSQLUsername.Text = "Username:";
            this.lblSQLUsername.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSQLPassword
            // 
            this.txtSQLPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSQLPassword.Enabled = false;
            this.txtSQLPassword.Location = new System.Drawing.Point(140, 182);
            this.txtSQLPassword.Name = "txtSQLPassword";
            this.txtSQLPassword.Size = new System.Drawing.Size(153, 20);
            this.txtSQLPassword.TabIndex = 10;
            this.txtSQLPassword.UseSystemPasswordChar = true;
            // 
            // lblSQLInfo
            // 
            this.lblSQLInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSQLInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.lblSQLInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSQLInfo.Location = new System.Drawing.Point(3, 25);
            this.lblSQLInfo.Name = "lblSQLInfo";
            this.lblSQLInfo.Size = new System.Drawing.Size(596, 25);
            this.lblSQLInfo.TabIndex = 1;
            this.lblSQLInfo.Text = "Please see Help - Getting started - SQL Configuration for more Info!";
            this.lblSQLInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSQLServer
            // 
            this.lblSQLServer.Enabled = false;
            this.lblSQLServer.Location = new System.Drawing.Point(23, 106);
            this.lblSQLServer.Name = "lblSQLServer";
            this.lblSQLServer.Size = new System.Drawing.Size(111, 13);
            this.lblSQLServer.TabIndex = 3;
            this.lblSQLServer.Text = "SQL Server:";
            this.lblSQLServer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSQLUsername
            // 
            this.txtSQLUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSQLUsername.Enabled = false;
            this.txtSQLUsername.Location = new System.Drawing.Point(140, 156);
            this.txtSQLUsername.Name = "txtSQLUsername";
            this.txtSQLUsername.Size = new System.Drawing.Size(153, 20);
            this.txtSQLUsername.TabIndex = 8;
            // 
            // txtSQLServer
            // 
            this.txtSQLServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSQLServer.Enabled = false;
            this.txtSQLServer.Location = new System.Drawing.Point(140, 103);
            this.txtSQLServer.Name = "txtSQLServer";
            this.txtSQLServer.Size = new System.Drawing.Size(153, 20);
            this.txtSQLServer.TabIndex = 4;
            // 
            // lblSQLPassword
            // 
            this.lblSQLPassword.Enabled = false;
            this.lblSQLPassword.Location = new System.Drawing.Point(23, 184);
            this.lblSQLPassword.Name = "lblSQLPassword";
            this.lblSQLPassword.Size = new System.Drawing.Size(111, 13);
            this.lblSQLPassword.TabIndex = 9;
            this.lblSQLPassword.Text = "Password:";
            this.lblSQLPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SqlServerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSQLDatabaseName);
            this.Controls.Add(this.txtSQLDatabaseName);
            this.Controls.Add(this.lblExperimental);
            this.Controls.Add(this.chkUseSQLServer);
            this.Controls.Add(this.lblSQLUsername);
            this.Controls.Add(this.txtSQLPassword);
            this.Controls.Add(this.lblSQLInfo);
            this.Controls.Add(this.lblSQLServer);
            this.Controls.Add(this.txtSQLUsername);
            this.Controls.Add(this.txtSQLServer);
            this.Controls.Add(this.lblSQLPassword);
            this.Name = "SqlServerPage";
            this.PageIcon = ((System.Drawing.Icon)(resources.GetObject("$this.PageIcon")));
            this.Size = new System.Drawing.Size(610, 489);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal Controls.Base.NGLabel lblSQLDatabaseName;
		internal Controls.Base.NGTextBox txtSQLDatabaseName;
		internal Controls.Base.NGLabel lblExperimental;
		internal Controls.Base.NGCheckBox chkUseSQLServer;
		internal Controls.Base.NGLabel lblSQLUsername;
		internal Controls.Base.NGTextBox txtSQLPassword;
		internal Controls.Base.NGLabel lblSQLInfo;
		internal Controls.Base.NGLabel lblSQLServer;
		internal Controls.Base.NGTextBox txtSQLUsername;
		internal Controls.Base.NGTextBox txtSQLServer;
		internal Controls.Base.NGLabel lblSQLPassword;
			
	}
}
