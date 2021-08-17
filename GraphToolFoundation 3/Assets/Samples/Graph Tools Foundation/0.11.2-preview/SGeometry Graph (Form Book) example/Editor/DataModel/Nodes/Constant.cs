using System;
using UnityEngine;

namespace UnityEditor.GraphToolsFoundation.Overdrive.Samples.MathBook
{
    [Serializable]
    public class Constant : FormNode
    {
        public override string Title
        {
            get => "π";
            set { }
        }

        public override float Evaluate()
        {
            var x = 1f;
            //return Mathf.PI;
            return x;
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
