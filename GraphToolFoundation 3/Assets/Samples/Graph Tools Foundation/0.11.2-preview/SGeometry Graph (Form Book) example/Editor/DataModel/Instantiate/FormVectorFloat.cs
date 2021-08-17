using System;
using System.Linq;
using UnityEngine;

namespace UnityEditor.GraphToolsFoundation.Overdrive.Samples.MathBook
{
    [Serializable]
    public class FormVectorFloat : FormOperator
    {
        public override string Title
        {
            get => "Vector (float)";
            set { }
        }

        public override float Evaluate()
        {
            var stringValues = Values[0].ToString() + Values[1].ToString() + Values[2].ToString();
            return float.Parse(stringValues);
        }
        
        protected override void AddInputPorts()
        {
            this.AddDataInputPort<float>("x (Start)");
            this.AddDataInputPort<float>("y (Start)");
            this.AddDataInputPort<float>("z (Start)");
        }
    }
}
