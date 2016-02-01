using System;
using System.Collections.Generic;

namespace DaRT
{
    using System.Collections;
    using System.Windows.Forms;

    /// <summary>
    /// This class is an implementation of the 'IComparer' interface.
    /// </summary>
    public class ColumnSorter : IComparer<ListViewItem>
    {
        /// <summary>
        /// Specifies the column to be sorted
        /// </summary>
        private int ColumnToSort;
        /// <summary>
        /// Specifies the order in which to sort (i.e. 'Ascending').
        /// </summary>
        private SortOrder OrderOfSort;
        /// <summary>
        /// Case insensitive comparer object
        /// </summary>
        private CaseInsensitiveComparer ObjectCompare;

        /// <summary>
        /// Class constructor.  Initializes various elements
        /// </summary>
        public ColumnSorter()
        {
            // Initialize the column to '0'
            ColumnToSort = 0;

            // Initialize the sort order to 'none'
            OrderOfSort = SortOrder.None;

            // Initialize the CaseInsensitiveComparer object
            ObjectCompare = new CaseInsensitiveComparer();
        }

        /// <summary>
        /// This method is inherited from the IComparer interface.  It compares the two objects passed using a case insensitive comparison.
        /// </summary>
        /// <param name="x">First object to be compared</param>
        /// <param name="y">Second object to be compared</param>
        /// <returns>The result of the comparison. "0" if equal, negative if 'x' is less than 'y' and positive if 'x' is greater than 'y'</returns>
        public int Compare(ListViewItem x, ListViewItem y)
        {
            int compareResult;
            ListViewItem listviewX, listviewY;

            // Cast the objects to be compared to ListViewItem objects
            listviewX = (ListViewItem)x;
            listviewY = (ListViewItem)y;

            // Compare the two items
            if (ColumnToSort > 0)
                compareResult = CompareTwoObjects(listviewX.SubItems[ColumnToSort - 1].Text, listviewY.SubItems[ColumnToSort - 1].Text);
            else
                compareResult = CompareTwoObjects(listviewX.Text, listviewY.Text);
            // Calculate correct return value based on object comparison
            if (OrderOfSort == SortOrder.Ascending)
            {
                // Ascending sort is selected, return normal result of compare operation
                return compareResult;
            }
            else if (OrderOfSort == SortOrder.Descending)
            {
                // Descending sort is selected, return negative result of compare operation
                return (-compareResult);
            }
            else
            {
                // Return '0' to indicate they are equal
                return 0;
            }
        }

        //Compare object depend upon their types.
        private int CompareTwoObjects(object x, object y)
        {
            int res = 0;
            if (x.GetType() == typeof(string))
            {
                res = Comparer.Default.Compare(x, y);
            }
            else if (x.GetType() == typeof(int))
            {
                int t1 = (int)x;
                int t2 = (int)y;
                if (t1 == t2)
                    res = 0;
                else if (t1 < t2)
                    res = -1;
                else
                    res = 1;
            }
            else if (x.GetType() == typeof(DateTime))
            {
                DateTime d1 = (DateTime)x;
                DateTime d2 = (DateTime)y;
                if (d1 == d2)
                    res = 0;
                else if (d1 < d2)
                    res = -1;
                else
                    res = 1;
            }
            return res;
        }
        /// <summary>
        /// Gets or sets the number of the column to which to apply the sorting operation (Defaults to '0').
        /// </summary>
        public int SortColumn
        {
            set
            {
                ColumnToSort = value;
            }
            get
            {
                return ColumnToSort;
            }
        }

        /// <summary>
        /// Gets or sets the order of sorting to apply (for example, 'Ascending' or 'Descending').
        /// </summary>
        public SortOrder Order
        {
            set
            {
                OrderOfSort = value;
            }
            get
            {
                return OrderOfSort;
            }
        }
    }

}