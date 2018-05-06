using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUI.Controls
{
    public class DataPointViewModel: IComparable
    {
        public double XValue { get; set; }
        public double YValue { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            DataPointViewModel otherModel = obj as DataPointViewModel;
            if (otherModel != null)
                return this.XValue.CompareTo(otherModel.XValue);
            else
                throw new ArgumentException("Object is not a DataPointViewModel");
        }

        public override string ToString()
        {
            return "("+ XValue + "|" + YValue + ")";
        }
    }
}
