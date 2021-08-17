using UnityEditor.GraphToolsFoundation.Overdrive.BasicModel;
using UnityEngine.UIElements;

namespace UnityEditor.GraphToolsFoundation.Overdrive.Samples.MathBook
{
    public class FormBookOnboardingProvider : OnboardingProvider
    {
        public override VisualElement CreateOnboardingElements(CommandDispatcher store)
        {
            var template = new GraphTemplate<FormBookStencil>(FormBookStencil.GraphName);
            return AddNewGraphButton<FormBookAsset>(template);
        }
    }
}
