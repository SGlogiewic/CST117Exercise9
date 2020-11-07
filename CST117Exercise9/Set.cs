using System;
using System.Collections.Generic;
using System.Text;
//Lydia's code
/// <summary>
/// Debugged by: Stephen Glogiewicz
/// </summary>
namespace CST117Exercise9
{
    class Set
    {
        private List<int> elements;


        public Set()
        {
            elements = new List<int>();
        }

        public bool addElement(int val)
        {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }

        private bool containsElement(int val)
        {
            //added a variable to set to default value then to false
            bool hasElements = false;

            for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i])
                    //set the var to true if elements are found
                    hasElements = true;
                //else
                //    return false;
            }
            //return false;
            ///this section always returned false and I changed it so it returned true if elements were found
            return hasElements;
        }
        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }
        public void clearSet()
        {
            elements.Clear();
        }

        public Set union(Set rhs)
        {

            for (int i = 0; i < rhs.elements.Count; i++)
            {
                this.addElement(rhs.elements[i]);
            }
            return rhs;
        }

    }
}
