using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap
{
    public class Vongtron
    {
        
            private double radius;
            private String _Color;


            public Vongtron()
            {
                radius = 1.0;
                _Color = "red";
            }


            public Vongtron(double r)
            {
                radius = r;
                _Color = "red";
            }


            public double getRadius()
            {
                return radius;
            }


            public double getArea()
            {
                return radius * radius * Math.PI;
            }
          //  public string _Color()
          //  { 
             //   get;
           //     {
            //        return this._Color;
           //     }
            //    Set;
           //     {
           //         this._Color = Value;
             //   }
           // }
            
            public Vongtron(double r, String c)
            {
                radius = r;
                _Color = c;
            }
            
            public String GetColor()
            {
                return _Color;
            }
        public void SetRadius(double newRadius)
            {
                radius = newRadius;
            }
            
        }
    }

