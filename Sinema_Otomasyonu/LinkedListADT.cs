using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Otomasyonu
{
    public abstract class LinkedListADT
    {
        public Node Head;
        public int Size = 0;
        public abstract void Insert(Musteri value);
        public abstract int InsertPos(int position, Musteri value);
        public abstract void DeletePos(int position);
        public abstract int GetElement(Musteri position);

        public abstract string DisplayElements();
        public abstract string DisplayEmpty();
    }
}
