using System;
using System.Xml;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;

using LiveSplit.UI;
using LiveSplit.UI.Components;
using LiveSplit.Model;

namespace LiveSplit.StillbirthStreak {

public class StillbirthStreakComponent:IComponent {
    public StillbirthStreakComponent(LiveSplitState State){
        Settings = new StillbirthStreakSettings();

        this.State = State;

        Label = new InfoTextComponent("","");
    }

    public Control GetSettingsControl(LayoutMode Mode){ return Settings; }
    public XmlNode GetSettings(XmlDocument Document){
        var Element = Document.CreateElement("Settings");
            
        SettingsHelper.CreateSetting(Document,Element,"Version","1.0.0");

        return Element;
    }
    public void SetSettings(XmlNode Node){
        var Element = (XmlElement)Node;
        
        /*
        Settings.p_TextColorEnabled = SettingsHelper.ParseBool(Element["HeaderTextColorEnabled"],Settings.p_HeaderTextColorEnabled);
        Settings.p_TextFontEnabled = SettingsHelper.ParseBool(Element["HeaderTextFontEnabled"],Settings.p_HeaderTextFontEnabled);
        
        Settings.p_Text = SettingsHelper.ParseString(Element["HeaderText"],Settings.p_HeaderText);
        
        Settings.p_TextFont = ParseFont(Element["HeaderTextFont"],Settings.p_HeaderTextFont);

        Settings.p_BackgroundColor = SettingsHelper.ParseColor(Element["HeaderBackgroundColor"],Settings.p_HeaderBackgroundColor);
        Settings.p_TextColor = SettingsHelper.ParseColor(Element["HeaderTextColor"],Settings.p_HeaderTextColor);
        */
    }

    private static Font ParseFont(XmlElement Element,Font Default){
        if(Element == null) return Default;
        return SettingsHelper.GetFontFromElement(Element);
    }

    private void Draw(Graphics g,float Width,float Height){
        /*
        Label.ForeColor = Settings.p_HeaderTextColorEnabled?Settings.p_HeaderTextColor:
                                                                    State.LayoutSettings.TextColor;
        Label.HorizontalAlignment = StringAlignment.Near;
        Label.VerticalAlignment = StringAlignment.Center;
        
        Label.X = 4;
        Label.Y = 2;

        Label.Width = Width;
        Label.Height = Height-4;

        Label.SetActualWidth(g);
        Label.Font = Settings.p_HeaderTextFontEnabled?Settings.p_HeaderTextFont:State.LayoutSettings.TextFont;
        
        Label.HasShadow = State.LayoutSettings.DropShadows;
        Label.ShadowColor = State.LayoutSettings.ShadowsColor;

        g.FillRectangle(new SolidBrush(Settings.p_HeaderBackgroundColor),x,y,Width,Height);
        */
        Label.Draw(g);
    }

    public void DrawHorizontal(Graphics g,LiveSplitState State,float Height,Region ClipRegion){
        //Draw(g,HorizontalWidth,Height);
    }
    public void DrawVertical(Graphics g,LiveSplitState State,float Width,Region ClipRegion){
        //Draw(g,Width,VerticalHeight);
    }

    public void Update(IInvalidator Invalidator,LiveSplitState State,float Width,float Height,LayoutMode Mode){}

    public string ComponentName { get { return "StillbirthStreak"; } }
    
    public float MinimumWidth  { get { return Label.MinimumWidth; } }
    public float MinimumHeight { get { return Label.MinimumHeight; } }

    public float HorizontalWidth { get { return Label.HorizontalWidth; } }
    public float VerticalHeight  { get { return Label.VerticalHeight;  } }

    public float PaddingLeft   { get { return Label.PaddingLeft;   } }
    public float PaddingTop    { get { return Label.PaddingLeft;   } }
    public float PaddingRight  { get { return Label.PaddingRight;  } }
    public float PaddingBottom { get { return Label.PaddingBottom; } }

    public IDictionary<string,Action> ContextMenuControls { get; protected set; }
    
    private LiveSplitState State;
    private StillbirthStreakSettings Settings;

    private InfoTextComponent Label;

    public void Dispose(){
        ;
    }
}

}
