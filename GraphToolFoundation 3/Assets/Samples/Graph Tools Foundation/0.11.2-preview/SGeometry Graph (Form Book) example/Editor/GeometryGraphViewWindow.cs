using System.Collections.Generic;
using State = UnityEditor.GraphToolsFoundation.Overdrive.GraphToolState;

namespace UnityEditor.GraphToolsFoundation.Overdrive.Samples.MathBook
{
    class GeometryGraphViewWindow : GraphViewEditorWindow
    {
        [InitializeOnLoadMethod]
        static void RegisterTool()
        {
            ShortcutHelper.RegisterDefaultShortcuts<GeometryGraphViewWindow>(FormBookStencil.GraphName);
        }

        [MenuItem("GTF/Samples/FormBook Editor")]
        public static void ShowWindow()
        {
            GetWindow<GeometryGraphViewWindow>();
        }

        protected override void OnEnable()
        {
            EditorToolName = "Form Book";
            base.OnEnable();
        }

        protected override GraphToolState CreateInitialState()
        {
            var prefs = Preferences.CreatePreferences(EditorToolName);
            return new FormBookState(GUID, prefs);
        }

        protected override GraphView CreateGraphView()
        {
            return new GraphView(this, CommandDispatcher, EditorToolName);
        }

        protected override BlankPage CreateBlankPage()
        {
            var onboardingProviders = new List<OnboardingProvider>();
            onboardingProviders.Add(new FormBookOnboardingProvider());

            return new BlankPage(CommandDispatcher, onboardingProviders);
        }

        protected override bool CanHandleAssetType(IGraphAssetModel asset)
        {
            return asset is FormBookAsset;
        }

        protected override MainToolbar CreateMainToolbar()
        {
            return new FormBookMainToolbar(CommandDispatcher, GraphView);
        }
    }
}
