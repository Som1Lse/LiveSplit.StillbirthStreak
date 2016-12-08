using System;
using System.Xml;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

using LiveSplit.UI;
using LiveSplit.UI.Components;
using LiveSplit.Model;

namespace LiveSplit.StillbirthStreak {

public class StillbirthStreakComponent:IComponent {
    public StillbirthStreakComponent(LiveSplitState State){
        Settings = new StillbirthStreakSettings();
        Settings.OnStreakReset += OnStreakReset;

        this.State = State;
        State.OnReset += OnRunReset;

        PreviousSplitIndex = State.CurrentSplitIndex;
        StreakLength = 0;

        Label = new InfoTextComponent("","0");

        ContextMenuControls = new Dictionary<String, Action>{
            ["Reset Stillbirth Streak"] = OnStreakReset,
        };
    }

    public Control GetSettingsControl(LayoutMode Mode){ return Settings; }
    public XmlNode GetSettings(XmlDocument Document){
        var Element = Document.CreateElement("Settings");
            
        SettingsHelper.CreateSetting(Document,Element,"Version","1.0.0");

        SettingsHelper.CreateSetting(Document,Element,"TextColorEnabled",Settings.p_TextColorEnabled);

        SettingsHelper.CreateSetting(Document,Element,"Description",Settings.p_Description);

        SettingsHelper.CreateSetting(Document,Element,"BackgroundColor",Settings.p_BackgroundColor);
        SettingsHelper.CreateSetting(Document,Element,"TextColor",Settings.p_TextColor);

        return Element;
    }
    public void SetSettings(XmlNode Node){
        var Element = (XmlElement)Node;
        
        Settings.p_TextColorEnabled = SettingsHelper.ParseBool(Element["TextColorEnabled"],Settings.p_TextColorEnabled);
        
        Settings.p_Description = SettingsHelper.ParseString(Element["Description"],Settings.p_Description);

        Settings.p_BackgroundColor = SettingsHelper.ParseColor(Element["BackgroundColor"],Settings.p_BackgroundColor);
        Settings.p_TextColor = SettingsHelper.ParseColor(Element["TextColor"],Settings.p_TextColor);
    }

    private void PrepareDraw(){
        Label.NameLabel.ForeColor = Label.ValueLabel.ForeColor =
            Settings.p_TextColorEnabled?Settings.p_TextColor:State.LayoutSettings.TextColor;
        
        Label.NameLabel.HasShadow = Label.ValueLabel.HasShadow = State.LayoutSettings.DropShadows;
        Label.NameLabel.ShadowColor = Label.ValueLabel.ShadowColor = State.LayoutSettings.ShadowsColor;
    }

    public void DrawHorizontal(Graphics g,LiveSplitState State,float Height,Region ClipRegion){
        PrepareDraw();

        g.FillRectangle(new SolidBrush(Settings.p_BackgroundColor),0.0f,0.0f,HorizontalWidth,Height);

        Label.DrawVertical(g,State,Height,ClipRegion);
    }
    public void DrawVertical(Graphics g,LiveSplitState State,float Width,Region ClipRegion){
        PrepareDraw();

        g.FillRectangle(new SolidBrush(Settings.p_BackgroundColor),0.0f,0.0f,Width,VerticalHeight);

        Label.DrawVertical(g,State,Width,ClipRegion);
    }

    public void Update(IInvalidator Invalidator,LiveSplitState State,float Width,float Height,LayoutMode Mode){
        PreviousSplitIndex = State.CurrentSplitIndex;

        Label.InformationName = Settings.p_Description;
        Label.Update(Invalidator,State,Width,Height,Mode);
    }

    public string ComponentName => "Stillbirth Streak";
    
    public float MinimumWidth  => Label.MinimumWidth;
    public float MinimumHeight => Label.MinimumHeight;

    public float HorizontalWidth => Label.HorizontalWidth;
    public float VerticalHeight  => Label.VerticalHeight;

    public float PaddingLeft   => Label.PaddingLeft;
    public float PaddingTop    => Label.PaddingLeft;
    public float PaddingRight  => Label.PaddingRight;
    public float PaddingBottom => Label.PaddingBottom;

    public IDictionary<string,Action> ContextMenuControls { get; private set; }

    public void Dispose(){
        Settings.OnStreakReset -= OnStreakReset;

        State.OnReset -= OnRunReset;
    }
    
    private LiveSplitState State;
    private StillbirthStreakSettings Settings;

    private InfoTextComponent Label;

    private int PreviousSplitIndex;
    private int StreakLength;
    
    private void OnRunReset(object Sender,TimerPhase e){
        if(PreviousSplitIndex == 0){
            ++StreakLength;
            Label.InformationValue = StreakLength.ToString();
        }else{
            OnStreakReset();
        }
    }
    private void OnStreakReset(){
        StreakLength = 0;
        Label.InformationValue = "0";
    }
}

}
