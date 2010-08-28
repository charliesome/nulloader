﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using nulloader;

namespace TestPlugin
{
    [PluginName("Test Plugin")]
    public class TestPlugin : Plugin, IPluginIcon
    {
        public TestPlugin()
        {
            RegisterMenuItem((s, e) => MessageBox.Show("Hello, world!"));
            var tabpage = CreateEditorTab("test tab :D");
        }

        public System.Drawing.Image GetIcon()
        {
            return Properties.Resources.emoticon_tongue;
        }
    }
}