using System;
using System.Linq;
using UnityEngine;

namespace UnityEditor.GraphToolsFoundation.Overdrive.Samples.MathBook
{
    [Serializable]
    public class FormLineFloat : FormOperator
    {
        public override string Title
        {
            get => "Line (float)";
            set { }
        }

        public override float Evaluate()
        {
            //Point A
            string pointA = Values[0].ToString();
            
            string xPointA = pointA[0].ToString();
            float xA = float.Parse(xPointA);
            string yPointA = pointA[1].ToString();
            float yA = float.Parse(yPointA);
            string zPointA = pointA[2].ToString();
            float zA = float.Parse(zPointA);

            //Point B
            string pointB = Values[1].ToString();
            
            string xPointB = pointB[0].ToString();
            float xB = float.Parse(xPointB);
            string yPointB = pointB[1].ToString();
            float yB = float.Parse(yPointB);
            string zPointB = pointB[2].ToString();
            float zB = float.Parse(zPointB);
            
            //Line
            Debug.DrawLine(new Vector3(xA,yA,zA), new Vector3(xB,yB,zB), Color.black, 5);
            
            var stringValues = xA.ToString() + yA.ToString() + zA.ToString() + xB.ToString() + yB.ToString() + zB.ToString();
            return float.Parse(stringValues);
        }

        protected override void AddInputPorts()
        {
            this.AddDataInputPort<float>("Point A");
            this.AddDataInputPort<float>("Point B");
        }
    }
}