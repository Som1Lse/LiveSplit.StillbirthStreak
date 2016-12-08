using System;
using System.Reflection;

using LiveSplit.Model;
using LiveSplit.UI.Components;

[assembly: ComponentFactory(typeof(LiveSplit.StillbirthStreak.StillbirthStreakFactory))]

namespace LiveSplit.StillbirthStreak {

public class StillbirthStreakFactory:IComponentFactory {
    public string ComponentName { get { return "Stillbirth Streak"; } }
    public string Description { get { return "Keeps track of stillborn runs and displays them"; } }
    public ComponentCategory Category { get{ return ComponentCategory.Information; } }

    public IComponent Create(LiveSplitState State){ return new StillbirthStreakComponent(State); }
    
    public Version Version { get { return Assembly.GetExecutingAssembly().GetName().Version; } }

    public string UpdateName { get { return ComponentName; } }
    public string UpdateURL { get { return ""; } }
    public string XMLURL { get { return ""; } }
}

}
