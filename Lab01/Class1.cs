using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Segment
    {
        int x1=0, y1=0, x2=0, y2=0;
        double length=0.0, angle0X=0.0;
        public Segment(int x1, int y1, int x2, int y2)
        {
            this.set(x1,y1,x2,y2);
        }

        public void set(int x1, int y1, int x2, int y2)
        {
            this.x1=x1;
            this.y1=y1;
            this.x2=x2;
            this.y2=y2;
            this.calcLength();
            this.calcAngle0X();
        }

        public void calcLength()
        {
            int c1 = (x2>x1)?x2-x1:x1-x2, c2 = (y2>y1)?y2-y1:y1-y2;
            this.length=Math.Sqrt(c1*c1+c2*c2);
        }

        public void calcAngle0X()
        {
            // tg a = c2 / c1
            int c1 = (x2>x1)?x2-x1:x1-x2, c2 = (y2>y1)?y2-y1:y1-y2;
            if (c1 == 0)
            {
                this.angle0X = 90;
                return;
            }
            if (c2==0)
            {
                this.angle0X = 0;
                return;
            }
            this.angle0X=Math.Atan(c2/c1)*(180.0/Math.PI);
        }

        public void print()
        {
            System.Console.WriteLine("Segment (" + this.x1 + "," + this.y1 + ")-(" + this.x2 + ","+this.y2+"):");
            System.Console.WriteLine("        length="+this.length+"; angle(0X)="+this.angle0X);
        }

        ~Segment()
        {
            // destruct
        }
    }
}
