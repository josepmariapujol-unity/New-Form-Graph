using System;
using System.Linq;
using UnityEngine;

namespace UnityEditor.GraphToolsFoundation.Overdrive.Samples.MathBook
{
    [Serializable]
    public class FormPointFloat : FormOperator
    {
        public override string Title
        {
            get => "Point (float)";
            set { }
        }

        public override float Evaluate()
        {
            return Values[0];
        }

        protected override void AddInputPorts()
        {
            this.AddDataInputPort<float>("V");
        }
    }
}
