using System;
using System.Linq;
using UnityEngine;

namespace UnityEditor.GraphToolsFoundation.Overdrive.Samples.MathBook
{
    [Serializable]
    public class FormSeriesFloat : FormOperator
    {
        public override string Title
        {
            get => "Series (float)";
            set { }
        }

        public override float Evaluate()
        {
            //Line
            string pointAB = Values[0].ToString();
            
            string xPointA = pointAB[0].ToString();
            float xA = float.Parse(xPointA);
            string yPointA = pointAB[1].ToString();
            float yA = float.Parse(yPointA);
            string zPointA = pointAB[2].ToString();
            float zA = float.Parse(zPointA);

            string xPointB = pointAB[3].ToString();
            float xB = float.Parse(xPointB);
            string yPointB = pointAB[4].ToString();
            float yB = float.Parse(yPointB);
            string zPointB = pointAB[5].ToString();
            float zB = float.Parse(zPointB);
            
            for (int i = 0; i < Values[1]; i++)
            {
                var pas = new Vector3(1,0,0) * (10 * i);
                Debug.DrawLine(new Vector3(xA, yA, zA) + pas, new Vector3(xB, yB, zB) + pas, Color.black, 20);
            }
            
            var stringValues = xA.ToString() + yA.ToString() + zA.ToString() + xB.ToString() + yB.ToString() + zB.ToString();
            return float.Parse(stringValues);
        }

        protected override void AddInputPorts()
        {
            this.AddDataInputPort<float>("Line");
            this.AddDataInputPort<float>("Series");
        }
    }
}