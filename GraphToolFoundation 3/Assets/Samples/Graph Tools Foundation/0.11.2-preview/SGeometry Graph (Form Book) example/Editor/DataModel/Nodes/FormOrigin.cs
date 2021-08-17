using System;
using UnityEngine;

namespace UnityEditor.GraphToolsFoundation.Overdrive.Samples.MathBook
{
    [Serializable]
    public class FormOrigin : FormNode
    {
        public override string Title
        {
            get => "Origin";
            set { }
        }

        public override float Evaluate()
        {
            return 0f;
        }

        public override void ResetConnections()
        {
        }

        protected override void OnDefineNode()
        {
            this.AddDataOutputPort<float>("");
        }
    }
}