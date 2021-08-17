using System;
using UnityEditor.GraphToolsFoundation.Overdrive.Samples.MathBook.UI;

namespace UnityEditor.GraphToolsFoundation.Overdrive.Samples.MathBook
{
    [GraphElementsExtensionMethodsCache(typeof(GraphView))]
    public static class GraphViewFactoryExtensions
    {
        public static IModelUI CreateNode(this ElementBuilder elementBuilder, CommandDispatcher commandDispatcher, FormOperator model)
        {
            IModelUI ui = new VariableInputNode();
            ui.SetupBuildAndUpdate(model, commandDispatcher, elementBuilder.View, elementBuilder.Context);
            return ui;
        }

        public static IModelUI CreateMathResultUI(this ElementBuilder elementBuilder, CommandDispatcher commandDispatcher, FormResult model)
        {
            var ui = new FormResultUI();

            ui.SetupBuildAndUpdate(model, commandDispatcher, elementBuilder.View, elementBuilder.Context);
            return ui;
        }

        public static IModelUI CreateMathBookVariableDeclarationModelUI(this ElementBuilder elementBuilder, CommandDispatcher commandDispatcher, FormBookVariableDeclarationModel model)
        {
            IModelUI ui;

            if (elementBuilder.Context == BlackboardVariablePropertiesPart.blackboardVariablePropertiesPartCreationContext)
            {
                ui = new FormbookBBVarPropertyView();
                ui.SetupBuildAndUpdate(model, commandDispatcher, elementBuilder.View, elementBuilder.Context);
            }
            else
            {
                ui = Overdrive.GraphViewFactoryExtensions.CreateVariableDeclarationModelUI(elementBuilder, commandDispatcher, model);
            }

            return ui;
        }
    }
}