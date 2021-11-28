using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clawPDF.Service.typeEnum
{
    public   enum Printststus 
    {   
        //打印中
        printing = 1,
        //打印完成
        success = 2,
        //打印失败
        fails = -1
    }
}
