using System;
using UnityEngine;

namespace UnityEditor.GraphToolsFoundation.Overdrive.Samples.MathBook
{
    [Serializable]
    public class RectFunction : FormFunction
    {
        public override string Title
        {
            get => "Rectangle Root";
            set { }
        }

        public RectFunction()
        {
            if (m_ParameterNames.Length == 0)
            {
                m_ParameterNames = new[] { "Input Rectangle" };
            }
        }

        public override float Evaluate()
        {
            return GetParameterValue(0) * GetParameterValue(0);
        }
    }
}
