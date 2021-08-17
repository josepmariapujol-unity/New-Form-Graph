using System;
using System.Linq;
using System.Numerics;
using UnityEditor.Graphs;
using UnityEditor.GraphToolsFoundation.Overdrive.BasicModel;

namespace UnityEditor.GraphToolsFoundation.Overdrive.Samples.MathBook
{
    [Serializable]
    public class FormReset : NodeModel
    {
        public override string Title
        {
            get => "Reset";
            set { }
        }

        /*protected override void AddInputPorts()
        {
            this.AddDataInputPort<float>("Vector");
        }*/
        
        public IPortModel DataIn0 { get; private set; }
        public IPortModel DataIn1 { get; private set; }

        protected override void OnDefineNode()
        {
            DataIn0 = this.AddDataInputPort<float>("in");
            DataIn1 = this.AddDataOutputPort<float>("in");
        }
        
    }
}
