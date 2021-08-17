using System;
using UnityEditor.GraphToolsFoundation.Overdrive.BasicModel;

namespace UnityEditor.GraphToolsFoundation.Overdrive.Samples.MathBook
{
    [Serializable]
    public class FormBook : GraphModel
    {
        public FormBook()
        {
            StencilType = null;
        }

        public override Type DefaultStencilType => typeof(FormBookStencil);
    }
}
