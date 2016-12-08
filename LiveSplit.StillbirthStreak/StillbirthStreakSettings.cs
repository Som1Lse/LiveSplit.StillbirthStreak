using System;
using System.Drawing;
using System.Windows.Forms;

using LiveSplit.UI;

namespace LiveSplit.StillbirthStreak {
    public partial class StillbirthStreakSettings:UserControl {
        public event Action OnStreakReset;

        public bool p_TextColorEnabled { get; set; }
        
        public string p_Description { get; set; }
        
        public Color p_BackgroundColor { get; set; }
        public Color p_TextColor { get; set; }

        public StillbirthStreakSettings(){
            InitializeComponent();
            
            p_TextColorEnabled = false;

            p_Description = "Stillborn Runs Streak";
        
            p_BackgroundColor = Color.Transparent;
            p_TextColor = Color.White;

            TextColorEnabled.DataBindings.Add("Checked",this,"p_TextColorEnabled",false,DataSourceUpdateMode.OnPropertyChanged);

            Description.DataBindings.Add("Text",this,"p_Description",false,DataSourceUpdateMode.OnPropertyChanged);
            
            BackgroundColor.DataBindings.Add("BackColor",this,"p_BackgroundColor",false,DataSourceUpdateMode.OnPropertyChanged);
            TextColor.DataBindings.Add("BackColor",this,"p_TextColor",false,DataSourceUpdateMode.OnPropertyChanged);
        }

        private void TextColorEnabledChanged(object Sender,EventArgs e){
            TextColor.Enabled = TextColorEnabled.Checked;
        }

        private void StreakReset(object Sender,EventArgs e){
            OnStreakReset?.Invoke();
        }

        private void ColorButtonClick(object sender,EventArgs e) {
            SettingsHelper.ColorButtonClick((Button)sender,this);
        }
    }
}
