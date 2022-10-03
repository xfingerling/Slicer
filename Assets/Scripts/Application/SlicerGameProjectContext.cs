using System.Collections.Generic;
using Lukomor.Application.Contexts;

public class SlicerGameProjectContext : ProjectContext
{
    public SlicerGameProjectContext()
    {
    }

    public SlicerGameProjectContext(Dictionary<string, IContext> scenesContextMap) : base(scenesContextMap) { }

    protected override void InstallFeatures()
    {

    }

    protected override void InstallServices()
    {

    }
}
