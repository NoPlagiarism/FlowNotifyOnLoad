using Flow.Launcher.Plugin;
using System;
using System.Collections.Generic;

namespace Flow.Launcher.Plugin.FlowNotifyOnLoad
{
    public class FlowNotifyOnLoad : IPlugin
    {
        public void Init(PluginInitContext context)
        {
            context.API.ShowMsg("Flow Launcher Loaded", "Or is it? (*_*)");
            if (!string.IsNullOrEmpty(context.CurrentPluginMetadata.ActionKeyword))
                context.API.RemoveActionKeyword(context.CurrentPluginMetadata.ID, context.CurrentPluginMetadata.ActionKeyword);
        }

        public List<Result> Query(Query query)
        {
            return new List<Result>() {new Result {Title = "WTF?!", SubTitle = "The heck are you doing here?! 0-0"}};
        }
    }
}