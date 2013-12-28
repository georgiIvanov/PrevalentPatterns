using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Group : Party
    {
        public Group()
        {
            this.Members = new List<Party>();
        }
        public string Name { get; set; }
        public List<Party> Members { get; set; }


        public int Gold
        {
            get
            {
                int totalGold = 0;
                foreach (var item in this.Members)
                {
                    totalGold += item.Gold;
                }
                return totalGold;
            }
            set
            {
                var eachSplit = value / Members.Count;
                var leftOver = value % Members.Count;
                foreach (var item in this.Members)
                {
                    item.Gold += eachSplit + leftOver;
                    leftOver = 0;
                }
            }
        }

        public void Stats()
        {
            foreach (var item in this.Members)
            {
                item.Stats();
            }
        }
    }
}
