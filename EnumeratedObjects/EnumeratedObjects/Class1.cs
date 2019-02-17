using System;
using System.Collections.Generic;
using System.Text;

namespace Qazi.Commons
{
    [Serializable]
    public class ObjectX
    {
        private int _ID;
        public int ID
        {
            get {
                return _ID;
            }
            set {
                _ID = value;
            }
        }

        public override string ToString()
        {
            return _ID.ToString();
        }

    }
}
