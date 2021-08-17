using System;
using System.Linq;
using UnityEngine;

namespace UnityEditor.GraphToolsFoundation.Overdrive.Samples.MathBook
{
    [Serializable]
    public class FormPyramidFloat : FormOperator
    {
        public override string Title
        {
            get => "Pyramid 3P (float)";
            set { }
        }

        public override float Evaluate()
        {
            //POINT A
            string pointA = Values[0].ToString();
            
            string xPointA = pointA[0].ToString();
            float xA = float.Parse(xPointA);
            string yPointA = pointA[1].ToString();
            float yA = float.Parse(yPointA);
            string zPointA = pointA[2].ToString();
            float zA = float.Parse(zPointA);
            
            //POINT B
            string pointB = Values[1].ToString();
            
            string xPointB = pointB[0].ToString();
            float xB = float.Parse(xPointB);
            string yPointB = pointB[1].ToString();
            float yB = float.Parse(yPointB);
            string zPointB = pointB[2].ToString();
            float zB = float.Parse(zPointB);
            
            //POINT C
            string pointC = Values[2].ToString();
            
            string xPointC = pointC[0].ToString();
            float xC = float.Parse(xPointC);
            string yPointC = pointC[1].ToString();
            float yC = float.Parse(yPointC);
            string zPointC = pointC[2].ToString();
            float zC = float.Parse(zPointC);
            
            var node_1 = new Vector3(xA, yA, zA);
            var node_2 = new Vector3(xA, yA, zB);
            var node_3 = new Vector3(xB, yA, zB);
            var node_4 = new Vector3(xB, yA, zA);
            var node_5 = new Vector3(xC, yC, xC);

            Debug.DrawLine(node_1, node_2, Color.black, 5);
            Debug.DrawLine(node_2, node_3, Color.black, 5);
            Debug.DrawLine(node_3, node_4, Color.black, 5);
            Debug.DrawLine(node_4, node_1, Color.black, 5);
            
            Debug.DrawLine(node_1, node_5, Color.black, 5);
            Debug.DrawLine(node_2, node_5, Color.black, 5);
            Debug.DrawLine(node_3, node_5, Color.black, 5);
            Debug.DrawLine(node_4, node_5, Color.black, 5);
            return Values.Last();
        }

        protected override void AddInputPorts()
        {
            this.AddDataInputPort<float>("Point A");
            this.AddDataInputPort<float>("Point B");
            
            this.AddDataInputPort<float>("Point C");
        }
    }
}
