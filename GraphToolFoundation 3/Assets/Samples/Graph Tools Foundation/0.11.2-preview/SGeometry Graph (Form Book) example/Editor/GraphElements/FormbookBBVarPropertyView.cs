namespace UnityEditor.GraphToolsFoundation.Overdrive.Samples.MathBook.UI
{
    public class FormbookBBVarPropertyView : BlackboardVariablePropertyView
    {
        protected override void BuildRows()
        {
            AddInitializationField();
            AddTooltipField();
        }

    }
}
