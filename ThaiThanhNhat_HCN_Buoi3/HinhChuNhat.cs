using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaiThanhNhat_HCN_Buoi3
{
    internal class HinhChuNhat
    {
        public int cd;
        public int cr;

        public void setCd(int cd)
        {
            this.cd = cd;
        }
        public void setCr(int cr) 
        {
             this.cr = cr; 
        }
        public int getcd()
        {
            return this.cd;
        }
        public int getCr()
        {
            return this.cr;
        }
        public void nhapHcn(int cd, int cr)
        {
            setCd(cd); setCr(cr); 
        }
    }
}
