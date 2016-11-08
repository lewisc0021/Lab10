using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Extended
{
    public class Movie
    {
        #region VARIABLES 
        private string category;
        private string title;
        #endregion VARIABLES

        #region PROPERTIES
        public string CATEGORY
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }

        public string TITLE
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }
        #endregion PROPERTIES  

        #region CONSTRUCTOR
        public Movie(string title, string category)
        {
            CATEGORY = category;
            TITLE = title;
        }
        #endregion CONSTRUCTOR

    }
}//END-----------

