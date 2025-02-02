﻿        using System;
        using System.Drawing;
        using System.Reflection;
        using System.Windows.Forms;
        using SharpUpdate;

namespace TestApp
{
    public partial class Form1 : Form, ISharpUpdatable
    {
        private SharpUpdater updater;

        public Form1()
        {
            InitializeComponent();

            this.label1.Text = this.ApplicationAssembly.GetName().Version.ToString();
            updater = new SharpUpdater(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        #region SharpUpdate
        public string ApplicationName
        {
            get { return "TestApp"; }
        }

        public string ApplicationID
        {
            get { return "TestApp"; }
        }

        public Assembly ApplicationAssembly
        {
            get { return Assembly.GetExecutingAssembly(); }
        }

        public Icon ApplicationIcon
        {   
            get { return this.Icon; }
        }

        public Uri UpdateXmlLocation
        {
            get { return new Uri("https://www.dropbox.com/home/sharpupdate-master/testapp/bin/Debug/test.xml"); }
        }

        public Form Context
        {
            get { return this; }
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            updater.DoUpdate();
        }

        private void Test_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
