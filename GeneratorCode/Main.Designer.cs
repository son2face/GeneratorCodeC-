namespace GeneratorCode
{
    partial class Main
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
            this.UrlBtn = new System.Windows.Forms.Button();
            this.OpenModelsFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.UrlTb = new System.Windows.Forms.TextBox();
            this.moduleModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GetModuleBtn = new System.Windows.Forms.Button();
            this.PrefixTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackendFolderTb = new System.Windows.Forms.TextBox();
            this.CreateFolderBackEndBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NameSpaceTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OpenModulesFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.ChooseFolderBackEndBtn = new System.Windows.Forms.Button();
            this.StatusLb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EntityTb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UpdateRouteFile = new System.Windows.Forms.Button();
            this.RouteFile = new System.Windows.Forms.Button();
            this.RouteFileTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UpdateAppModuleBtn = new System.Windows.Forms.Button();
            this.AppModuleFolderBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AppModuleFileTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ChooseFolderFrontEndBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.FrontEndFolderTb = new System.Windows.Forms.TextBox();
            this.CreateFolderFrontEndBtn = new System.Windows.Forms.Button();
            this.OpenAppModuleFile = new System.Windows.Forms.OpenFileDialog();
            this.ModeCb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.moduleModelBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // UrlBtn
            // 
            this.UrlBtn.Location = new System.Drawing.Point(21, 30);
            this.UrlBtn.Name = "UrlBtn";
            this.UrlBtn.Size = new System.Drawing.Size(150, 23);
            this.UrlBtn.TabIndex = 1;
            this.UrlBtn.Text = "Chọn đường dẫn Models";
            this.UrlBtn.UseVisualStyleBackColor = true;
            this.UrlBtn.Click += new System.EventHandler(this.UrlBtn_Click);
            // 
            // UrlTb
            // 
            this.UrlTb.Location = new System.Drawing.Point(190, 32);
            this.UrlTb.Name = "UrlTb";
            this.UrlTb.Size = new System.Drawing.Size(261, 20);
            this.UrlTb.TabIndex = 2;
            this.UrlTb.Text = "C:\\ThuctapFPT\\FAMS\\FAMS\\FAMS.API\\Models";
            // 
            // GetModuleBtn
            // 
            this.GetModuleBtn.Location = new System.Drawing.Point(503, 66);
            this.GetModuleBtn.Name = "GetModuleBtn";
            this.GetModuleBtn.Size = new System.Drawing.Size(126, 23);
            this.GetModuleBtn.TabIndex = 3;
            this.GetModuleBtn.Text = "Lấy Modules";
            this.GetModuleBtn.UseVisualStyleBackColor = true;
            this.GetModuleBtn.Click += new System.EventHandler(this.GetModuleBtn_Click);
            // 
            // PrefixTb
            // 
            this.PrefixTb.Location = new System.Drawing.Point(195, 128);
            this.PrefixTb.Name = "PrefixTb";
            this.PrefixTb.Size = new System.Drawing.Size(166, 20);
            this.PrefixTb.TabIndex = 9;
            this.PrefixTb.Text = "M";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tiền tố của modules";
            // 
            // BackendFolderTb
            // 
            this.BackendFolderTb.Location = new System.Drawing.Point(195, 38);
            this.BackendFolderTb.Name = "BackendFolderTb";
            this.BackendFolderTb.Size = new System.Drawing.Size(166, 20);
            this.BackendFolderTb.TabIndex = 6;
            this.BackendFolderTb.Text = "C:\\Users\\Son\\Desktop\\Modules";
            // 
            // CreateFolderBackEndBtn
            // 
            this.CreateFolderBackEndBtn.Location = new System.Drawing.Point(235, 289);
            this.CreateFolderBackEndBtn.Name = "CreateFolderBackEndBtn";
            this.CreateFolderBackEndBtn.Size = new System.Drawing.Size(85, 23);
            this.CreateFolderBackEndBtn.TabIndex = 7;
            this.CreateFolderBackEndBtn.Text = "Tạo Modules";
            this.CreateFolderBackEndBtn.UseVisualStyleBackColor = true;
            this.CreateFolderBackEndBtn.Click += new System.EventHandler(this.CreateFolderBackEndBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Namespace of Project";
            // 
            // NameSpaceTb
            // 
            this.NameSpaceTb.Location = new System.Drawing.Point(195, 84);
            this.NameSpaceTb.Name = "NameSpaceTb";
            this.NameSpaceTb.Size = new System.Drawing.Size(166, 20);
            this.NameSpaceTb.TabIndex = 8;
            this.NameSpaceTb.Text = "FAMS.API";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Đường dẫn Modules(Output)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ChooseFolderBackEndBtn
            // 
            this.ChooseFolderBackEndBtn.Location = new System.Drawing.Point(398, 35);
            this.ChooseFolderBackEndBtn.Name = "ChooseFolderBackEndBtn";
            this.ChooseFolderBackEndBtn.Size = new System.Drawing.Size(150, 23);
            this.ChooseFolderBackEndBtn.TabIndex = 12;
            this.ChooseFolderBackEndBtn.Text = "Chọn đường dẫn Modules";
            this.ChooseFolderBackEndBtn.UseVisualStyleBackColor = true;
            this.ChooseFolderBackEndBtn.Click += new System.EventHandler(this.ModuleBtn_Click);
            // 
            // StatusLb
            // 
            this.StatusLb.AutoSize = true;
            this.StatusLb.Location = new System.Drawing.Point(23, 267);
            this.StatusLb.Name = "StatusLb";
            this.StatusLb.Size = new System.Drawing.Size(0, 13);
            this.StatusLb.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Entity";
            // 
            // EntityTb
            // 
            this.EntityTb.Location = new System.Drawing.Point(195, 171);
            this.EntityTb.Name = "EntityTb";
            this.EntityTb.Size = new System.Drawing.Size(166, 20);
            this.EntityTb.TabIndex = 10;
            this.EntityTb.Text = "FAMSEntities";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.EntityTb);
            this.groupBox1.Controls.Add(this.StatusLb);
            this.groupBox1.Controls.Add(this.ChooseFolderBackEndBtn);
            this.groupBox1.Controls.Add(this.PrefixTb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BackendFolderTb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CreateFolderBackEndBtn);
            this.groupBox1.Controls.Add(this.NameSpaceTb);
            this.groupBox1.Location = new System.Drawing.Point(21, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 349);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BackEnd";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UpdateRouteFile);
            this.groupBox2.Controls.Add(this.RouteFile);
            this.groupBox2.Controls.Add(this.RouteFileTb);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.UpdateAppModuleBtn);
            this.groupBox2.Controls.Add(this.AppModuleFolderBtn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.AppModuleFileTb);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.ChooseFolderFrontEndBtn);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.FrontEndFolderTb);
            this.groupBox2.Controls.Add(this.CreateFolderFrontEndBtn);
            this.groupBox2.Location = new System.Drawing.Point(717, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(608, 349);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FrontEnd";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // UpdateRouteFile
            // 
            this.UpdateRouteFile.Location = new System.Drawing.Point(403, 289);
            this.UpdateRouteFile.Name = "UpdateRouteFile";
            this.UpdateRouteFile.Size = new System.Drawing.Size(122, 23);
            this.UpdateRouteFile.TabIndex = 21;
            this.UpdateRouteFile.Text = "Sửa File Route";
            this.UpdateRouteFile.UseVisualStyleBackColor = true;
            this.UpdateRouteFile.Click += new System.EventHandler(this.UpdateRouteFile_Click);
            // 
            // RouteFile
            // 
            this.RouteFile.Location = new System.Drawing.Point(403, 126);
            this.RouteFile.Name = "RouteFile";
            this.RouteFile.Size = new System.Drawing.Size(150, 23);
            this.RouteFile.TabIndex = 20;
            this.RouteFile.Text = "Chọn đường dẫn file Route";
            this.RouteFile.UseVisualStyleBackColor = true;
            this.RouteFile.Click += new System.EventHandler(this.RouteFile_Click);
            // 
            // RouteFileTb
            // 
            this.RouteFileTb.Location = new System.Drawing.Point(200, 128);
            this.RouteFileTb.Name = "RouteFileTb";
            this.RouteFileTb.Size = new System.Drawing.Size(166, 20);
            this.RouteFileTb.TabIndex = 19;
            this.RouteFileTb.Text = "C:\\ThuctapFPT\\FAMS\\FAMS\\FAMS.UI\\Angular4\\src\\app\\Route.ts";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Đường dẫn File Route";
            // 
            // UpdateAppModuleBtn
            // 
            this.UpdateAppModuleBtn.Location = new System.Drawing.Point(263, 289);
            this.UpdateAppModuleBtn.Name = "UpdateAppModuleBtn";
            this.UpdateAppModuleBtn.Size = new System.Drawing.Size(122, 23);
            this.UpdateAppModuleBtn.TabIndex = 17;
            this.UpdateAppModuleBtn.Text = "Sửa App Module";
            this.UpdateAppModuleBtn.UseVisualStyleBackColor = true;
            this.UpdateAppModuleBtn.Click += new System.EventHandler(this.UpdateAppModuleBtn_Click);
            // 
            // AppModuleFolderBtn
            // 
            this.AppModuleFolderBtn.Location = new System.Drawing.Point(403, 87);
            this.AppModuleFolderBtn.Name = "AppModuleFolderBtn";
            this.AppModuleFolderBtn.Size = new System.Drawing.Size(150, 23);
            this.AppModuleFolderBtn.TabIndex = 16;
            this.AppModuleFolderBtn.Text = "Chọn đường dẫn Modules";
            this.AppModuleFolderBtn.UseVisualStyleBackColor = true;
            this.AppModuleFolderBtn.Click += new System.EventHandler(this.ChooseFileAppModule_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Đường dẫn File App Module";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // AppModuleFileTb
            // 
            this.AppModuleFileTb.Location = new System.Drawing.Point(200, 88);
            this.AppModuleFileTb.Name = "AppModuleFileTb";
            this.AppModuleFileTb.Size = new System.Drawing.Size(166, 20);
            this.AppModuleFileTb.TabIndex = 14;
            this.AppModuleFileTb.Text = "C:\\ThuctapFPT\\FAMS\\FAMS\\FAMS.UI\\Angular4\\src\\app\\app.module.ts";
            this.AppModuleFileTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 13;
            // 
            // ChooseFolderFrontEndBtn
            // 
            this.ChooseFolderFrontEndBtn.Location = new System.Drawing.Point(403, 41);
            this.ChooseFolderFrontEndBtn.Name = "ChooseFolderFrontEndBtn";
            this.ChooseFolderFrontEndBtn.Size = new System.Drawing.Size(150, 23);
            this.ChooseFolderFrontEndBtn.TabIndex = 12;
            this.ChooseFolderFrontEndBtn.Text = "Chọn đường dẫn Modules";
            this.ChooseFolderFrontEndBtn.UseVisualStyleBackColor = true;
            this.ChooseFolderFrontEndBtn.Click += new System.EventHandler(this.ChooseFolderFrontEndBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Đường dẫn Modules(Output)";
            // 
            // FrontEndFolderTb
            // 
            this.FrontEndFolderTb.Location = new System.Drawing.Point(200, 44);
            this.FrontEndFolderTb.Name = "FrontEndFolderTb";
            this.FrontEndFolderTb.Size = new System.Drawing.Size(166, 20);
            this.FrontEndFolderTb.TabIndex = 6;
            this.FrontEndFolderTb.Text = "C:\\Users\\Son\\Desktop\\FrontEnd";
            // 
            // CreateFolderFrontEndBtn
            // 
            this.CreateFolderFrontEndBtn.Location = new System.Drawing.Point(144, 289);
            this.CreateFolderFrontEndBtn.Name = "CreateFolderFrontEndBtn";
            this.CreateFolderFrontEndBtn.Size = new System.Drawing.Size(85, 23);
            this.CreateFolderFrontEndBtn.TabIndex = 7;
            this.CreateFolderFrontEndBtn.Text = "Tạo Modules";
            this.CreateFolderFrontEndBtn.UseVisualStyleBackColor = true;
            this.CreateFolderFrontEndBtn.Click += new System.EventHandler(this.CreateFolderFrontEndBtn_Click);
            // 
            // OpenAppModuleFile
            // 
            this.OpenAppModuleFile.FileName = "OpenAppModuleFile";
            // 
            // ModeCb
            // 
            this.ModeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeCb.FormattingEnabled = true;
            this.ModeCb.Items.AddRange(new object[] {
            "ASP.NET - ENTITY FRAMEWORK",
            "JAVA - HIBERNATE ANOTATION"});
            this.ModeCb.Location = new System.Drawing.Point(190, 69);
            this.ModeCb.Name = "ModeCb";
            this.ModeCb.Size = new System.Drawing.Size(261, 21);
            this.ModeCb.TabIndex = 18;
            this.ModeCb.SelectedIndexChanged += new System.EventHandler(this.ModeCb_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(90, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Kiểu model";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 477);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ModeCb);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GetModuleBtn);
            this.Controls.Add(this.UrlBtn);
            this.Controls.Add(this.UrlTb);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moduleModelBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button UrlBtn;
        public System.Windows.Forms.FolderBrowserDialog OpenModelsFolder;
        private System.Windows.Forms.TextBox UrlTb;
        private System.Windows.Forms.Button GetModuleBtn;
        private System.Windows.Forms.BindingSource moduleModelBindingSource;
        private System.Windows.Forms.TextBox PrefixTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BackendFolderTb;
        private System.Windows.Forms.Button CreateFolderBackEndBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameSpaceTb;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.FolderBrowserDialog OpenModulesFolder;
        private System.Windows.Forms.Button ChooseFolderBackEndBtn;
        private System.Windows.Forms.Label StatusLb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EntityTb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ChooseFolderFrontEndBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox FrontEndFolderTb;
        private System.Windows.Forms.Button CreateFolderFrontEndBtn;
        private System.Windows.Forms.Button AppModuleFolderBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AppModuleFileTb;
        private System.Windows.Forms.OpenFileDialog OpenAppModuleFile;
        private System.Windows.Forms.Button UpdateAppModuleBtn;
        private System.Windows.Forms.Button RouteFile;
        private System.Windows.Forms.TextBox RouteFileTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button UpdateRouteFile;
        private System.Windows.Forms.ComboBox ModeCb;
        private System.Windows.Forms.Label label9;
    }
}

