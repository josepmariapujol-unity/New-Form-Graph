using System;
using System.Collections.Generic;

namespace UnityEditor.GraphToolsFoundation.Overdrive.Samples.MathBook
{
    class FormOperatorInspector : FieldsInspector
    {
        public static FormOperatorInspector Create(string name, IGraphElementModel model, IModelUI ownerElement, string parentClassName)
        {
            if (model is FormOperator)
            {
                return new FormOperatorInspector(name, model, ownerElement, parentClassName);
            }

            return null;
        }

        /// <inheritdoc />
        public FormOperatorInspector(string name, IGraphElementModel model, IModelUI ownerElement, string parentClassName)
            : base(name, model, ownerElement, parentClassName) { }

        /// <inheritdoc />
        protected override IEnumerable<BaseModelPropertyField> GetFields()
        {
            if (m_Model is FormOperator mathOperator)
            {
                yield return new ModelPropertyField<int>(
                    m_OwnerElement.CommandDispatcher,
                    mathOperator,
                    nameof(mathOperator.InputPortCount),
                    "Number of Inputs",
                    typeof(SetNumberOfInputPortCommand));
            }
        }
    }
}
