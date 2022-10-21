
namespace WeatherAPI
{
    partial class frmWeatherAPI
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
            this.btnGetWeatherXML = new System.Windows.Forms.Button();
            this.btnGetWeatherJSON = new System.Windows.Forms.Button();
            this.lblZIP = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblFeelslike = new System.Windows.Forms.Label();
            this.lblWind = new System.Windows.Forms.Label();
            this.lblClouds = new System.Windows.Forms.Label();
            this.txtZIP = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.txtLow = new System.Windows.Forms.TextBox();
            this.txtHigh = new System.Windows.Forms.TextBox();
            this.txtFeelsLike = new System.Windows.Forms.TextBox();
            this.txtWind = new System.Windows.Forms.TextBox();
            this.txtClouds = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetWeatherXML
            // 
            this.btnGetWeatherXML.AccessibleName = "";
            this.btnGetWeatherXML.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGetWeatherXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnGetWeatherXML.Location = new System.Drawing.Point(134, 23);
            this.btnGetWeatherXML.Name = "btnGetWeatherXML";
            this.btnGetWeatherXML.Size = new System.Drawing.Size(405, 64);
            this.btnGetWeatherXML.TabIndex = 0;
            this.btnGetWeatherXML.Text = "Get Weather (XML)";
            this.btnGetWeatherXML.UseVisualStyleBackColor = false;
            this.btnGetWeatherXML.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGetWeatherJSON
            // 
            this.btnGetWeatherJSON.AccessibleName = "";
            this.btnGetWeatherJSON.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGetWeatherJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnGetWeatherJSON.Location = new System.Drawing.Point(134, 120);
            this.btnGetWeatherJSON.Name = "btnGetWeatherJSON";
            this.btnGetWeatherJSON.Size = new System.Drawing.Size(405, 64);
            this.btnGetWeatherJSON.TabIndex = 1;
            this.btnGetWeatherJSON.Text = "Get Weather (JSON)";
            this.btnGetWeatherJSON.UseVisualStyleBackColor = false;
            this.btnGetWeatherJSON.Click += new System.EventHandler(this.btnGetWeatherJSON_Click);
            // 
            // lblZIP
            // 
            this.lblZIP.AccessibleName = "";
            this.lblZIP.AutoSize = true;
            this.lblZIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblZIP.Location = new System.Drawing.Point(77, 226);
            this.lblZIP.Name = "lblZIP";
            this.lblZIP.Size = new System.Drawing.Size(132, 20);
            this.lblZIP.TabIndex = 2;
            this.lblZIP.Text = "Enter a ZIP Code";
            this.lblZIP.Click += new System.EventHandler(this.lblZIP_Click);
            // 
            // lblCity
            // 
            this.lblCity.AccessibleName = "";
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCity.Location = new System.Drawing.Point(77, 295);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(35, 20);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "City";
            // 
            // lblLatitude
            // 
            this.lblLatitude.AccessibleName = "";
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLatitude.Location = new System.Drawing.Point(77, 374);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(67, 20);
            this.lblLatitude.TabIndex = 4;
            this.lblLatitude.Text = "Latitude";
            // 
            // lblLongitude
            // 
            this.lblLongitude.AccessibleName = "";
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLongitude.Location = new System.Drawing.Point(353, 374);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(80, 20);
            this.lblLongitude.TabIndex = 5;
            this.lblLongitude.Text = "Longitude";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AccessibleName = "";
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTemperature.Location = new System.Drawing.Point(77, 451);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(100, 20);
            this.lblTemperature.TabIndex = 6;
            this.lblTemperature.Text = "Temperature";
            // 
            // lblLow
            // 
            this.lblLow.AccessibleName = "";
            this.lblLow.AutoSize = true;
            this.lblLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLow.Location = new System.Drawing.Point(220, 451);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(38, 20);
            this.lblLow.TabIndex = 7;
            this.lblLow.Text = "Low";
            // 
            // lblHigh
            // 
            this.lblHigh.AccessibleName = "";
            this.lblHigh.AutoSize = true;
            this.lblHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHigh.Location = new System.Drawing.Point(353, 451);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(42, 20);
            this.lblHigh.TabIndex = 8;
            this.lblHigh.Text = "High";
            // 
            // lblFeelslike
            // 
            this.lblFeelslike.AccessibleName = "";
            this.lblFeelslike.AutoSize = true;
            this.lblFeelslike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFeelslike.Location = new System.Drawing.Point(491, 451);
            this.lblFeelslike.Name = "lblFeelslike";
            this.lblFeelslike.Size = new System.Drawing.Size(75, 20);
            this.lblFeelslike.TabIndex = 9;
            this.lblFeelslike.Text = "Feels like";
            // 
            // lblWind
            // 
            this.lblWind.AccessibleName = "";
            this.lblWind.AutoSize = true;
            this.lblWind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWind.Location = new System.Drawing.Point(77, 533);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(45, 20);
            this.lblWind.TabIndex = 10;
            this.lblWind.Text = "Wind";
            // 
            // lblClouds
            // 
            this.lblClouds.AccessibleName = "";
            this.lblClouds.AutoSize = true;
            this.lblClouds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblClouds.Location = new System.Drawing.Point(353, 533);
            this.lblClouds.Name = "lblClouds";
            this.lblClouds.Size = new System.Drawing.Size(58, 20);
            this.lblClouds.TabIndex = 11;
            this.lblClouds.Text = "Clouds";
            // 
            // txtZIP
            // 
            this.txtZIP.Location = new System.Drawing.Point(81, 262);
            this.txtZIP.Name = "txtZIP";
            this.txtZIP.Size = new System.Drawing.Size(262, 20);
            this.txtZIP.TabIndex = 12;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(81, 335);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(262, 20);
            this.txtCity.TabIndex = 13;
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(81, 409);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(262, 20);
            this.txtLatitude.TabIndex = 14;
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(357, 409);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(266, 20);
            this.txtLongitude.TabIndex = 15;
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(81, 495);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(128, 20);
            this.txtTemperature.TabIndex = 16;
            // 
            // txtLow
            // 
            this.txtLow.Location = new System.Drawing.Point(224, 495);
            this.txtLow.Name = "txtLow";
            this.txtLow.Size = new System.Drawing.Size(119, 20);
            this.txtLow.TabIndex = 17;
            // 
            // txtHigh
            // 
            this.txtHigh.Location = new System.Drawing.Point(357, 495);
            this.txtHigh.Name = "txtHigh";
            this.txtHigh.Size = new System.Drawing.Size(128, 20);
            this.txtHigh.TabIndex = 18;
            // 
            // txtFeelsLike
            // 
            this.txtFeelsLike.Location = new System.Drawing.Point(495, 495);
            this.txtFeelsLike.Name = "txtFeelsLike";
            this.txtFeelsLike.Size = new System.Drawing.Size(128, 20);
            this.txtFeelsLike.TabIndex = 19;
            // 
            // txtWind
            // 
            this.txtWind.Location = new System.Drawing.Point(81, 569);
            this.txtWind.Name = "txtWind";
            this.txtWind.Size = new System.Drawing.Size(262, 20);
            this.txtWind.TabIndex = 20;
            // 
            // txtClouds
            // 
            this.txtClouds.Location = new System.Drawing.Point(357, 569);
            this.txtClouds.Name = "txtClouds";
            this.txtClouds.Size = new System.Drawing.Size(266, 20);
            this.txtClouds.TabIndex = 21;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(565, 620);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmWeatherAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(681, 666);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtClouds);
            this.Controls.Add(this.txtWind);
            this.Controls.Add(this.txtFeelsLike);
            this.Controls.Add(this.txtHigh);
            this.Controls.Add(this.txtLow);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtZIP);
            this.Controls.Add(this.lblClouds);
            this.Controls.Add(this.lblWind);
            this.Controls.Add(this.lblFeelslike);
            this.Controls.Add(this.lblHigh);
            this.Controls.Add(this.lblLow);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblZIP);
            this.Controls.Add(this.btnGetWeatherJSON);
            this.Controls.Add(this.btnGetWeatherXML);
            this.Name = "frmWeatherAPI";
            this.Text = "Weather API";
            this.Load += new System.EventHandler(this.frmWeatherAPI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetWeatherXML;
        private System.Windows.Forms.Button btnGetWeatherJSON;
        private System.Windows.Forms.Label lblZIP;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label lblFeelslike;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.Label lblClouds;
        private System.Windows.Forms.TextBox txtZIP;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.TextBox txtLow;
        private System.Windows.Forms.TextBox txtHigh;
        private System.Windows.Forms.TextBox txtFeelsLike;
        private System.Windows.Forms.TextBox txtWind;
        private System.Windows.Forms.TextBox txtClouds;
        private System.Windows.Forms.Button btnClose;
    }
}

