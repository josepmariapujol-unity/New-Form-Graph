using System;
using System.Linq;
using UnityEngine;

namespace UnityEditor.GraphToolsFoundation.Overdrive.Samples.MathBook
{
    [Serializable]
    public class FormRectangleFloat : FormOperator
    {
        public override string Title
        {
            get => "Rectangle XY (float)";
            set { }
        }

        public override float Evaluate()
        {
            int numPoints = Values[0].ToString().Length / 3;
            Debug.Log( Values[0].ToString() + "  lenght");
            Debug.Log( Values[0].ToString().Length + "  lenght");
            Debug.Log(numPoints);
            string numPointsString = Values[0].ToString();

            for (int i = 0; i < numPoints; i++)
            {
                
                string xPoint = numPointsString[(i * 3)].ToString();
                float xA = float.Parse(xPoint);
                string yPoint = numPointsString[(i * 3) + 1].ToString();
                float yA = float.Parse(yPoint);
                string zPoint = numPointsString[(i * 3) + 2].ToString();
                float zA = float.Parse(zPoint);
                
                var position = new Vector3(xA, yA, zA);
                Debug.Log(position);
                var node_1 = new Vector3(Values[1] - Values[1], Values[2] - Values[2], 0) + position;
                var node_2 = new Vector3(Values[1], Values[2] - Values[2], 0) + position;
                var node_3 = new Vector3(Values[1], Values[2], 0) + position;
                var node_4 = new Vector3(Values[1] - Values[1], Values[2], 0) + position;

                Debug.DrawLine(node_1, node_2, Color.black, 5);
                Debug.DrawLine(node_2, node_3, Color.black, 5);
                Debug.DrawLine(node_3, node_4, Color.black, 5);
                Debug.DrawLine(node_4, node_1, Color.black, 5);
            }
            
            return Values.Last();
        }

        protected override void AddInputPorts()
        {
            this.AddDataInputPort<float>("Point (Centre)");
            
            this.AddDataInputPort<float>("x (Edge)");
            this.AddDataInputPort<float>("y (Edge)");
        }
    }
}
