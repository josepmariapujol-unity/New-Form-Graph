using System;
using UnityEngine;

namespace UnityEditor.GraphToolsFoundation.Overdrive.Samples.MathBook
{
    [Serializable]
    public class SqrtFunction : FormFunction
    {
        public override string Title
        {
            get => "Square Root";
            set { }
        }

        public SqrtFunction()
        {
            if (m_ParameterNames.Length == 0)
            {
                m_ParameterNames = new[] { "f" };
            }
        }

        public override float Evaluate()
        {
            return Mathf.Sqrt(GetParameterValue(0));
        }
    }
}
