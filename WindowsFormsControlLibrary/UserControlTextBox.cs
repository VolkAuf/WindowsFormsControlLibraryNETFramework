﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary
{
    public partial class UserControlTextBox : UserControl
    {
        public UserControlTextBox()
        {
            InitializeComponent();
        }

        private void CheckBoxIsNotNull_CheckedChanged(object sender, EventArgs e)
        {
            textBox.Enabled = !checkBox.Checked;
        }

        public double? Value
        {
            get
            {
                double? nullableElem;

                if (checkBox.Checked)
                {
                    nullableElem = null;
                }
                else
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        throw new ArgumentNullException();
                    }

                    if (!double.TryParse(textBox.Text, out double elem))
                    {
                        throw new ArgumentException();
                    }

                    nullableElem = new double?(elem);
                }
                return nullableElem;
            }
            set
            {
                if (value.HasValue)
                {
                    textBox.Text = value.Value.ToString();
                }
                checkBox.Checked = !value.HasValue;
            }
        }
    }
}
