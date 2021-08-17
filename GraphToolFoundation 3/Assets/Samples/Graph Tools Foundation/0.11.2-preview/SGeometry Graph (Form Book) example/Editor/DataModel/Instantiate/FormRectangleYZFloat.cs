using System;
using System.Linq;
using UnityEngine;

namespace UnityEditor.GraphToolsFoundation.Overdrive.Samples.MathBook
{
    [Serializable]
    public class FormRectangleYZFloat : FormOperator
    {
        public override string Title
        {
            get => "Rectangle YZ (float)";
            set { }
        }

        public override float Evaluate()
        {
            var position = new Vector3(Values[2], Values[3], Values[4]);
            
            for (int i = 0; i <= Values[5]; i++)
            {
                var node_1 = new Vector3(Values[2] + i, Values[0] - Values[0], Values[1] - Values[1]) + position;
                var node_2 = new Vector3(Values[2] + i, Values[0], Values[1] - Values[1]) + position;
                var node_3 = new Vector3(Values[2] + i, Values[0], Values[1]) + position;
                var node_4 = new Vector3(Values[2] + i, Values[0] - Values[0], Values[1]) + position;

                Debug.DrawLine(node_1, node_2, Color.black, 5);
                Debug.DrawLine(node_2, node_3, Color.black, 5);
                Debug.DrawLine(node_3, node_4, Color.black, 5);
                Debug.DrawLine(node_4, node_1, Color.black, 5);
                Debug.Log(node_1 + " " + node_2);
            }
            return Values.Last();
        }
        
        protected override void AddInputPorts()
        {
            this.AddDataInputPort<float>("y (Edge)");
            this.AddDataInputPort<float>("z (Edge)");
            
            this.AddDataInputPort<float>("x (Position)");
            this.AddDataInputPort<float>("y (Position)");
            this.AddDataInputPort<float>("z (Position)");
            
            this.AddDataInputPort<float>("Multiplay");
            this.AddDataInputPort<float>("Input");
            //this.AddDataInputPort<int>("Int");
        }
    }
}
