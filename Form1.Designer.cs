namespace BackdoorClient
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConnectButton = new System.Windows.Forms.Button();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connText = new System.Windows.Forms.Label();
            this.responseText = new System.Windows.Forms.Label();
            this.commandTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.taskMgrButton = new System.Windows.Forms.Button();
            this.sendMesageBut = new System.Windows.Forms.Button();
            this.crashSysButton = new System.Windows.Forms.Button();
            this.filesManagerBut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.screenTraslBut = new System.Windows.Forms.Button();
            this.jokesButton = new System.Windows.Forms.Button();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(560, 14);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(83, 35);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Подключить";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // adressTextBox
            // 
            this.adressTextBox.Location = new System.Drawing.Point(229, 14);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(181, 20);
            this.adressTextBox.TabIndex = 1;
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(484, 14);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(61, 20);
            this.portTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Порт:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Адрес:";
            // 
            // connText
            // 
            this.connText.AutoSize = true;
            this.connText.ForeColor = System.Drawing.Color.Crimson;
            this.connText.Location = new System.Drawing.Point(226, 47);
            this.connText.Name = "connText";
            this.connText.Size = new System.Drawing.Size(85, 13);
            this.connText.TabIndex = 5;
            this.connText.Text = "Не подключено";
            // 
            // responseText
            // 
            this.responseText.AutoSize = true;
            this.responseText.Location = new System.Drawing.Point(12, 164);
            this.responseText.Name = "responseText";
            this.responseText.Size = new System.Drawing.Size(135, 39);
            this.responseText.TabIndex = 6;
            this.responseText.Text = "Пока ничего не пришло :(\r\nыыыыыы\r\n😎😎😎😎\r\n";
            // 
            // commandTextBox
            // 
            this.commandTextBox.AcceptsReturn = true;
            this.commandTextBox.Location = new System.Drawing.Point(15, 123);
            this.commandTextBox.Multiline = true;
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.Size = new System.Drawing.Size(307, 20);
            this.commandTextBox.TabIndex = 7;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(339, 117);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(84, 30);
            this.sendButton.TabIndex = 8;
            this.sendButton.Text = "Отправить";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // taskMgrButton
            // 
            this.taskMgrButton.Location = new System.Drawing.Point(484, 117);
            this.taskMgrButton.Name = "taskMgrButton";
            this.taskMgrButton.Size = new System.Drawing.Size(88, 32);
            this.taskMgrButton.TabIndex = 9;
            this.taskMgrButton.Text = "Дисп. задач";
            this.taskMgrButton.UseVisualStyleBackColor = true;
            this.taskMgrButton.Click += new System.EventHandler(this.taskMgrButton_Click);
            // 
            // sendMesageBut
            // 
            this.sendMesageBut.Location = new System.Drawing.Point(484, 171);
            this.sendMesageBut.Name = "sendMesageBut";
            this.sendMesageBut.Size = new System.Drawing.Size(88, 32);
            this.sendMesageBut.TabIndex = 10;
            this.sendMesageBut.Text = "Сообщ. Пол.";
            this.sendMesageBut.UseVisualStyleBackColor = true;
            this.sendMesageBut.Click += new System.EventHandler(this.sendMesageBut_Click);
            // 
            // crashSysButton
            // 
            this.crashSysButton.Location = new System.Drawing.Point(582, 117);
            this.crashSysButton.Name = "crashSysButton";
            this.crashSysButton.Size = new System.Drawing.Size(88, 32);
            this.crashSysButton.TabIndex = 11;
            this.crashSysButton.Text = "Краш. сист";
            this.crashSysButton.UseVisualStyleBackColor = true;
            this.crashSysButton.Click += new System.EventHandler(this.crashSysButton_Click);
            // 
            // filesManagerBut
            // 
            this.filesManagerBut.Location = new System.Drawing.Point(582, 171);
            this.filesManagerBut.Name = "filesManagerBut";
            this.filesManagerBut.Size = new System.Drawing.Size(88, 32);
            this.filesManagerBut.TabIndex = 12;
            this.filesManagerBut.Text = "Файлы";
            this.filesManagerBut.UseVisualStyleBackColor = true;
            this.filesManagerBut.Click += new System.EventHandler(this.filesManagerBut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(668, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "(вним. очень\r\nопасно)";
            // 
            // screenTraslBut
            // 
            this.screenTraslBut.Location = new System.Drawing.Point(582, 223);
            this.screenTraslBut.Name = "screenTraslBut";
            this.screenTraslBut.Size = new System.Drawing.Size(88, 32);
            this.screenTraslBut.TabIndex = 14;
            this.screenTraslBut.Text = "Трансл Экран";
            this.screenTraslBut.UseVisualStyleBackColor = true;
            this.screenTraslBut.Click += new System.EventHandler(this.screenTraslBut_Click);
            // 
            // jokesButton
            // 
            this.jokesButton.Location = new System.Drawing.Point(484, 223);
            this.jokesButton.Name = "jokesButton";
            this.jokesButton.Size = new System.Drawing.Size(88, 32);
            this.jokesButton.TabIndex = 15;
            this.jokesButton.Text = "Приколы";
            this.jokesButton.UseVisualStyleBackColor = true;
            this.jokesButton.Click += new System.EventHandler(this.jokesButton_Click);
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Location = new System.Drawing.Point(649, 14);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(77, 35);
            this.DisconnectBtn.TabIndex = 16;
            this.DisconnectBtn.Text = "Отключить";
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 395);
            this.Controls.Add(this.DisconnectBtn);
            this.Controls.Add(this.jokesButton);
            this.Controls.Add(this.screenTraslBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filesManagerBut);
            this.Controls.Add(this.crashSysButton);
            this.Controls.Add(this.sendMesageBut);
            this.Controls.Add(this.taskMgrButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.commandTextBox);
            this.Controls.Add(this.responseText);
            this.Controls.Add(this.connText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(this.ConnectButton);
            this.Name = "Form1";
            this.Text = "Копытень RAT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label connText;
        private System.Windows.Forms.Label responseText;
        private System.Windows.Forms.TextBox commandTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button taskMgrButton;
        private System.Windows.Forms.Button sendMesageBut;
        private System.Windows.Forms.Button crashSysButton;
        private System.Windows.Forms.Button filesManagerBut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button screenTraslBut;
        private System.Windows.Forms.Button jokesButton;
        private System.Windows.Forms.Button DisconnectBtn;
    }
}

