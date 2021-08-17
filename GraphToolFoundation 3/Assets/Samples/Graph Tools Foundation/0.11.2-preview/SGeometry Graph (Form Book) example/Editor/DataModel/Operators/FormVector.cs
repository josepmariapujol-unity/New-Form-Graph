using System;
using System.Linq;
using UnityEngine;

namespace UnityEditor.GraphToolsFoundation.Overdrive.Samples.MathBook
{
    [Serializable]
    public class FormVector : FormOperator
    {
        public override string Title
        {
            get => "Vector 3";
            set { }
        }

        public override float Evaluate()
        {
            return Values.Sum();
        }

        protected override void AddInputPorts()
        {
            this.AddDataInputPort<Vector3>("Vector");
        }

        protected void AddOutputPorts()
        {
            this.AddDataOutputPort<Vector3>("Vector");
        }
    }
}
