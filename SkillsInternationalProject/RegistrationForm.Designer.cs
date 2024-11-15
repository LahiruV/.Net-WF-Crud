namespace SkillsInternationalProject
{
    partial class RegistrationForm
    {
        private System.Windows.Forms.GroupBox groupBoxBasicDetails;
        private System.Windows.Forms.GroupBox groupBoxContactDetails;
        private System.Windows.Forms.GroupBox groupBoxParentDetails;
        private System.Windows.Forms.Label labelRegNo;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox txtRegNo;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelMobilePhone;
        private System.Windows.Forms.Label labelHomePhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobilePhone;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.Label labelParentName;
        private System.Windows.Forms.Label labelNIC;
        private System.Windows.Forms.Label labelContactNo;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox comboBoxRegNo;
        private System.Windows.Forms.LinkLabel linkLogout;
        private System.Windows.Forms.LinkLabel linkExit;
        private System.Windows.Forms.Label labelTitle;

        private void InitializeComponent()
        {
            this.groupBoxBasicDetails = new System.Windows.Forms.GroupBox();
            this.labelRegNo = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.labelAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.groupBoxContactDetails = new System.Windows.Forms.GroupBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelMobilePhone = new System.Windows.Forms.Label();
            this.labelHomePhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobilePhone = new System.Windows.Forms.TextBox();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.groupBoxParentDetails = new System.Windows.Forms.GroupBox();
            this.labelParentName = new System.Windows.Forms.Label();
            this.labelNIC = new System.Windows.Forms.Label();
            this.labelContactNo = new System.Windows.Forms.Label();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.comboBoxRegNo = new System.Windows.Forms.ComboBox();
            this.linkLogout = new System.Windows.Forms.LinkLabel();
            this.linkExit = new System.Windows.Forms.LinkLabel();
            this.labelTitle = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(250, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(250, 35);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Skills International";

            // groupBoxBasicDetails
            this.groupBoxBasicDetails.Controls.Add(this.labelRegNo);
            this.groupBoxBasicDetails.Controls.Add(this.labelFirstName);
            this.groupBoxBasicDetails.Controls.Add(this.labelLastName);
            this.groupBoxBasicDetails.Controls.Add(this.labelDOB);
            this.groupBoxBasicDetails.Controls.Add(this.labelGender);
            this.groupBoxBasicDetails.Controls.Add(this.txtRegNo);
            this.groupBoxBasicDetails.Controls.Add(this.txtFirstName);
            this.groupBoxBasicDetails.Controls.Add(this.txtLastName);
            this.groupBoxBasicDetails.Controls.Add(this.dateTimePickerDOB);
            this.groupBoxBasicDetails.Controls.Add(this.rbMale);
            this.groupBoxBasicDetails.Controls.Add(this.rbFemale);
            this.groupBoxBasicDetails.Controls.Add(this.labelAddress);
            this.groupBoxBasicDetails.Controls.Add(this.txtAddress);
            this.groupBoxBasicDetails.Location = new System.Drawing.Point(20, 60);
            this.groupBoxBasicDetails.Name = "groupBoxBasicDetails";
            this.groupBoxBasicDetails.Size = new System.Drawing.Size(350, 300);
            this.groupBoxBasicDetails.TabIndex = 1;
            this.groupBoxBasicDetails.TabStop = false;
            this.groupBoxBasicDetails.Text = "Basic Details";

            // labelRegNo
            this.labelRegNo.AutoSize = true;
            this.labelRegNo.Location = new System.Drawing.Point(10, 30);
            this.labelRegNo.Name = "labelRegNo";
            this.labelRegNo.Size = new System.Drawing.Size(50, 17);
            this.labelRegNo.TabIndex = 0;
            this.labelRegNo.Text = "Reg No";

            // txtRegNo
            this.txtRegNo.Location = new System.Drawing.Point(130, 27);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(200, 22);
            this.txtRegNo.TabIndex = 1;

            // labelFirstName
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(10, 60);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(76, 17);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "First Name";

            // txtFirstName
            this.txtFirstName.Location = new System.Drawing.Point(130, 57);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 22);
            this.txtFirstName.TabIndex = 3;

            // labelLastName
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(10, 90);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(76, 17);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Last Name";

            // txtLastName
            this.txtLastName.Location = new System.Drawing.Point(130, 87);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 22);
            this.txtLastName.TabIndex = 5;

            // labelDOB
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(10, 120);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(90, 17);
            this.labelDOB.TabIndex = 6;
            this.labelDOB.Text = "Date of Birth";

            // dateTimePickerDOB
            this.dateTimePickerDOB.Location = new System.Drawing.Point(130, 117);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDOB.TabIndex = 7;

            // labelGender
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(10, 150);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(56, 17);
            this.labelGender.TabIndex = 8;
            this.labelGender.Text = "Gender";

            // rbMale
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(130, 148);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(59, 21);
            this.rbMale.TabIndex = 9;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;

            // rbFemale
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(200, 148);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(75, 21);
            this.rbFemale.TabIndex = 10;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;

            // labelAddress
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(10, 180);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(60, 17);
            this.labelAddress.TabIndex = 11;
            this.labelAddress.Text = "Address";

            // txtAddress
            this.txtAddress.Location = new System.Drawing.Point(130, 177);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 50);
            this.txtAddress.TabIndex = 12;

            // groupBoxContactDetails
            this.groupBoxContactDetails.Controls.Add(this.labelEmail);
            this.groupBoxContactDetails.Controls.Add(this.labelMobilePhone);
            this.groupBoxContactDetails.Controls.Add(this.labelHomePhone);
            this.groupBoxContactDetails.Controls.Add(this.txtEmail);
            this.groupBoxContactDetails.Controls.Add(this.txtMobilePhone);
            this.groupBoxContactDetails.Controls.Add(this.txtHomePhone);
            this.groupBoxContactDetails.Location = new System.Drawing.Point(400, 60);
            this.groupBoxContactDetails.Name = "groupBoxContactDetails";
            this.groupBoxContactDetails.Size = new System.Drawing.Size(350, 150);
            this.groupBoxContactDetails.TabIndex = 2;
            this.groupBoxContactDetails.TabStop = false;
            this.groupBoxContactDetails.Text = "Contact Details";

            // labelEmail
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(10, 30);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 17);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email";

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(130, 27);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 1;

            // labelMobilePhone
            this.labelMobilePhone.AutoSize = true;
            this.labelMobilePhone.Location = new System.Drawing.Point(10, 60);
            this.labelMobilePhone.Name = "labelMobilePhone";
            this.labelMobilePhone.Size = new System.Drawing.Size(93, 17);
            this.labelMobilePhone.TabIndex = 2;
            this.labelMobilePhone.Text = "Mobile Phone";

            // txtMobilePhone
            this.txtMobilePhone.Location = new System.Drawing.Point(130, 57);
            this.txtMobilePhone.Name = "txtMobilePhone";
            this.txtMobilePhone.Size = new System.Drawing.Size(200, 22);
            this.txtMobilePhone.TabIndex = 3;

            // labelHomePhone
            this.labelHomePhone.AutoSize = true;
            this.labelHomePhone.Location = new System.Drawing.Point(10, 90);
            this.labelHomePhone.Name = "labelHomePhone";
            this.labelHomePhone.Size = new System.Drawing.Size(89, 17);
            this.labelHomePhone.TabIndex = 4;
            this.labelHomePhone.Text = "Home Phone";

            // txtHomePhone
            this.txtHomePhone.Location = new System.Drawing.Point(130, 87);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(200, 22);
            this.txtHomePhone.TabIndex = 5;

            // groupBoxParentDetails
            this.groupBoxParentDetails.Controls.Add(this.labelParentName);
            this.groupBoxParentDetails.Controls.Add(this.labelNIC);
            this.groupBoxParentDetails.Controls.Add(this.labelContactNo);
            this.groupBoxParentDetails.Controls.Add(this.txtParentName);
            this.groupBoxParentDetails.Controls.Add(this.txtNIC);
            this.groupBoxParentDetails.Controls.Add(this.txtContactNo);
            this.groupBoxParentDetails.Location = new System.Drawing.Point(400, 220);
            this.groupBoxParentDetails.Name = "groupBoxParentDetails";
            this.groupBoxParentDetails.Size = new System.Drawing.Size(350, 140);
            this.groupBoxParentDetails.TabIndex = 3;
            this.groupBoxParentDetails.TabStop = false;
            this.groupBoxParentDetails.Text = "Parent Details";

            // labelParentName
            this.labelParentName.AutoSize = true;
            this.labelParentName.Location = new System.Drawing.Point(10, 30);
            this.labelParentName.Name = "labelParentName";
            this.labelParentName.Size = new System.Drawing.Size(91, 17);
            this.labelParentName.TabIndex = 0;
            this.labelParentName.Text = "Parent Name";

            // txtParentName
            this.txtParentName.Location = new System.Drawing.Point(130, 27);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(200, 22);
            this.txtParentName.TabIndex = 1;

            // labelNIC
            this.labelNIC.AutoSize = true;
            this.labelNIC.Location = new System.Drawing.Point(10, 60);
            this.labelNIC.Name = "labelNIC";
            this.labelNIC.Size = new System.Drawing.Size(30, 17);
            this.labelNIC.TabIndex = 2;
            this.labelNIC.Text = "NIC";

            // txtNIC
            this.txtNIC.Location = new System.Drawing.Point(130, 57);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(200, 22);
            this.txtNIC.TabIndex = 3;

            // labelContactNo
            this.labelContactNo.AutoSize = true;
            this.labelContactNo.Location = new System.Drawing.Point(10, 90);
            this.labelContactNo.Name = "labelContactNo";
            this.labelContactNo.Size = new System.Drawing.Size(77, 17);
            this.labelContactNo.TabIndex = 4;
            this.labelContactNo.Text = "Contact No";

            // txtContactNo
            this.txtContactNo.Location = new System.Drawing.Point(130, 87);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(200, 22);
            this.txtContactNo.TabIndex = 5;

            // btnRegister
            this.btnRegister.Location = new System.Drawing.Point(20, 370);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(80, 30);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // btnUpdate
            this.btnUpdate.Location = new System.Drawing.Point(120, 370);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 30);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(220, 370);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 30);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(320, 370);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // comboBoxRegNo
            this.comboBoxRegNo.FormattingEnabled = true;
            this.comboBoxRegNo.Location = new System.Drawing.Point(420, 370);
            this.comboBoxRegNo.Name = "comboBoxRegNo";
            this.comboBoxRegNo.Size = new System.Drawing.Size(200, 24);
            this.comboBoxRegNo.TabIndex = 8;
            this.comboBoxRegNo.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegNo_SelectedIndexChanged);

            // linkLogout
            this.linkLogout.AutoSize = true;
            this.linkLogout.Location = new System.Drawing.Point(640, 380);
            this.linkLogout.Name = "linkLogout";
            this.linkLogout.Size = new System.Drawing.Size(55, 17);
            this.linkLogout.TabIndex = 9;
            this.linkLogout.TabStop = true;
            this.linkLogout.Text = "Logout";
            this.linkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogout_LinkClicked);

            // linkExit
            this.linkExit.AutoSize = true;
            this.linkExit.Location = new System.Drawing.Point(710, 380);
            this.linkExit.Name = "linkExit";
            this.linkExit.Size = new System.Drawing.Size(30, 17);
            this.linkExit.TabIndex = 10;
            this.linkExit.TabStop = true;
            this.linkExit.Text = "Exit";
            this.linkExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkExit_LinkClicked);

            // RegistrationForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.groupBoxBasicDetails);
            this.Controls.Add(this.groupBoxContactDetails);
            this.Controls.Add(this.groupBoxParentDetails);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.comboBoxRegNo);
            this.Controls.Add(this.linkLogout);
            this.Controls.Add(this.linkExit);
            this.Name = "RegistrationForm";
            this.Text = "Registration Form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
