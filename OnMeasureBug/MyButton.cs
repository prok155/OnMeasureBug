using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMeasureBug
{
    public class MyButton : Button
    {
        protected override SizeRequest OnMeasure(double widthConstraint, double heightConstraint)
        {
            //some logic
            {
                int i = 0;
                i++;
                Debug.WriteLine("This method never fires. It fires in Xamarin, but it doesn't fire in MAUI. " +
                    "I hope you will fix it as soon as possible, because it's almost impossible to create advanced custom controls now."+
                    "I can't migrate my project to MAUI from Xamarin.");

            }
            return base.OnMeasure(widthConstraint, heightConstraint);
        }
    }
}
