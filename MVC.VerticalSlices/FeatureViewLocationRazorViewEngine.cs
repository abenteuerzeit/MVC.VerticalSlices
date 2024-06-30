using Microsoft.AspNetCore.Mvc.Razor;

namespace MVC.VerticalSlices
{
    public class FeatureFolderViewLocationExpander : IViewLocationExpander
    {
        public string[] FeatureLocations { get; }

        public string[] OldViewLocations { get; } = ["~/Views/{1}/{0}.cshtml", "~/Views/Shared/{0}.cshtml"];

        public FeatureFolderViewLocationExpander()
        {
            FeatureLocations = ["~/Features/{1}/{0}.cshtml", "~/Features/Shared/{0}.cshtml"];
        }


        public FeatureFolderViewLocationExpander(string[] customLocations)
        {
            FeatureLocations = customLocations;
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {
        }

        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            return [.. FeatureLocations, .. OldViewLocations];
        }
    }
}
