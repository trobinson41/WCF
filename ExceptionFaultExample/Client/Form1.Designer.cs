namespace Client
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
            this.btnCreateNewProxyInstance = new System.Windows.Forms.Button();
            this.btnThrowException = new System.Windows.Forms.Button();
            this.btnIsProxyAlive = new System.Windows.Forms.Button();
            this.btnThrowExceptionOneWay = new System.Windows.Forms.Button();
            this.btnThrowSimpleFault = new System.Windows.Forms.Button();
            this.btnCultureFault = new System.Windows.Forms.Button();
            this.btnStronglyTypedFault = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateNewProxyInstance
            // 
            this.btnCreateNewProxyInstance.Location = new System.Drawing.Point(37, 12);
            this.btnCreateNewProxyInstance.Name = "btnCreateNewProxyInstance";
            this.btnCreateNewProxyInstance.Size = new System.Drawing.Size(227, 23);
            this.btnCreateNewProxyInstance.TabIndex = 0;
            this.btnCreateNewProxyInstance.Text = "Create New Proxy Instance";
            this.btnCreateNewProxyInstance.UseVisualStyleBackColor = true;
            this.btnCreateNewProxyInstance.Click += new System.EventHandler(this.btnCreateNewProxyInstance_Click);
            // 
            // btnThrowException
            // 
            this.btnThrowException.Location = new System.Drawing.Point(37, 52);
            this.btnThrowException.Name = "btnThrowException";
            this.btnThrowException.Size = new System.Drawing.Size(227, 23);
            this.btnThrowException.TabIndex = 1;
            this.btnThrowException.Text = "Throw Exception";
            this.btnThrowException.UseVisualStyleBackColor = true;
            this.btnThrowException.Click += new System.EventHandler(this.btnThrowException_Click);
            // 
            // btnIsProxyAlive
            // 
            this.btnIsProxyAlive.Location = new System.Drawing.Point(37, 252);
            this.btnIsProxyAlive.Name = "btnIsProxyAlive";
            this.btnIsProxyAlive.Size = new System.Drawing.Size(227, 23);
            this.btnIsProxyAlive.TabIndex = 3;
            this.btnIsProxyAlive.Text = "Is Proxy Alive";
            this.btnIsProxyAlive.UseVisualStyleBackColor = true;
            this.btnIsProxyAlive.Click += new System.EventHandler(this.btnIsProxyAlive_Click);
            // 
            // btnThrowExceptionOneWay
            // 
            this.btnThrowExceptionOneWay.Location = new System.Drawing.Point(37, 92);
            this.btnThrowExceptionOneWay.Name = "btnThrowExceptionOneWay";
            this.btnThrowExceptionOneWay.Size = new System.Drawing.Size(227, 23);
            this.btnThrowExceptionOneWay.TabIndex = 4;
            this.btnThrowExceptionOneWay.Text = "Throw Exception One Way";
            this.btnThrowExceptionOneWay.UseVisualStyleBackColor = true;
            this.btnThrowExceptionOneWay.Click += new System.EventHandler(this.btnThrowExceptionOneWay_Click);
            // 
            // btnThrowSimpleFault
            // 
            this.btnThrowSimpleFault.Location = new System.Drawing.Point(37, 132);
            this.btnThrowSimpleFault.Name = "btnThrowSimpleFault";
            this.btnThrowSimpleFault.Size = new System.Drawing.Size(227, 23);
            this.btnThrowSimpleFault.TabIndex = 5;
            this.btnThrowSimpleFault.Text = "Throw Simple Fault";
            this.btnThrowSimpleFault.UseVisualStyleBackColor = true;
            this.btnThrowSimpleFault.Click += new System.EventHandler(this.btnThrowSimpleFault_Click);
            // 
            // btnCultureFault
            // 
            this.btnCultureFault.Location = new System.Drawing.Point(37, 172);
            this.btnCultureFault.Name = "btnCultureFault";
            this.btnCultureFault.Size = new System.Drawing.Size(227, 23);
            this.btnCultureFault.TabIndex = 6;
            this.btnCultureFault.Text = "Throw Fault with Culture Specific Reason";
            this.btnCultureFault.UseVisualStyleBackColor = true;
            this.btnCultureFault.Click += new System.EventHandler(this.btnCultureFault_Click);
            // 
            // btnStronglyTypedFault
            // 
            this.btnStronglyTypedFault.Location = new System.Drawing.Point(37, 212);
            this.btnStronglyTypedFault.Name = "btnStronglyTypedFault";
            this.btnStronglyTypedFault.Size = new System.Drawing.Size(227, 23);
            this.btnStronglyTypedFault.TabIndex = 6;
            this.btnStronglyTypedFault.Text = "Throw Strongly Typed Fault";
            this.btnStronglyTypedFault.UseVisualStyleBackColor = true;
            this.btnStronglyTypedFault.Click += new System.EventHandler(this.btnStronglyTypedFault_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 295);
            this.Controls.Add(this.btnStronglyTypedFault);
            this.Controls.Add(this.btnCultureFault);
            this.Controls.Add(this.btnThrowSimpleFault);
            this.Controls.Add(this.btnThrowExceptionOneWay);
            this.Controls.Add(this.btnIsProxyAlive);
            this.Controls.Add(this.btnThrowException);
            this.Controls.Add(this.btnCreateNewProxyInstance);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateNewProxyInstance;
        private System.Windows.Forms.Button btnThrowException;
        private System.Windows.Forms.Button btnIsProxyAlive;
        private System.Windows.Forms.Button btnThrowExceptionOneWay;
        private System.Windows.Forms.Button btnThrowSimpleFault;
        private System.Windows.Forms.Button btnCultureFault;
        private System.Windows.Forms.Button btnStronglyTypedFault;
    }
}

