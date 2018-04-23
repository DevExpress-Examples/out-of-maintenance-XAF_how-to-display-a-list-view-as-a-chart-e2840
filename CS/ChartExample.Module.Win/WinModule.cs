using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

using DevExpress.ExpressApp;

namespace ChartExample.Module.Win {
    [ToolboxItemFilter("Xaf.Platform.Win")]
    public sealed partial class ChartExampleWindowsFormsModule : ModuleBase {
        public ChartExampleWindowsFormsModule() {
            InitializeComponent();
        }
    }
}
