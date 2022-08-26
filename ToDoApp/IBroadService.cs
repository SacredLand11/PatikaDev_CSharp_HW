using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    interface IBroadService
    {
        void kartEkle();
        void kartGuncelle();
        void kartSil();
        void kartTasi();
        void boardListeleme();
    }
}
