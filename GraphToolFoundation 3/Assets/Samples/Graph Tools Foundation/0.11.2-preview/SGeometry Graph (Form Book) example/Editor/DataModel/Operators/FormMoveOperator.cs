using System;
using System.Linq;
using UnityEngine;

namespace UnityEditor.GraphToolsFoundation.Overdrive.Samples.MathBook
{
    [Serializable]
    public class FormMoveOperator : FormOperator
    {
        public override string Title
        {
            get => "Move";
            set { }
        }

        public override float Evaluate()
        {
            return Values.Sum();
        }

        protected override void AddInputPorts()
        {
            for (var i = 0; i < InputPortCount; ++i)
                this.AddDataInputPort<float>("Term " + (i + 1));
        }
    }
}
