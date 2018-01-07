using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Otomasyonu
{
    public class LinkedList : LinkedListADT
    {
        public override void Insert(Musteri value)
        {
            Node tmpHead = new Node
            {
                Data = value
            };

            if (Head == null)
                Head = tmpHead;
            else
            {
                Node oldLast = Head;
                Node newLast = new Node
                {
                    Data = value
                };


                while (oldLast != null)
                {
                    if (oldLast.Next != null)
                        oldLast = oldLast.Next;
                    else
                        break;
                }


                oldLast.Next = newLast;
            }
            Size++;
        }

        public override int InsertPos(int position, Musteri value)
        {
                        
            Node tempNode = Head;
            int count = 1;
            int sayac = 0;

            while (tempNode != null)
            {
                if (count == position)
                {
                    if (tempNode.Data.Ad == "")
                    {
                        tempNode.Data = value;
                        sayac++;
                        break;
                    }
                    
                    
                }
                count++;
                tempNode = tempNode.Next;
                
            }
            return sayac;
        }

        public override void DeletePos(int position)
        {
            Node tempNode = Head;
            int count = 1;
            Musteri m = new Musteri();
            m.KoltukNo = position;
            m.Ad = "";
            m.Soyad = "";
            while (tempNode != null)
            {
                if (count == position)
                {
                    tempNode.Data = m;
                    break;
                }
                count++;
                tempNode = tempNode.Next;
            }
            Size--;
        }

        public override int GetElement(Musteri position)
        {
            Node retNode = null;
            Node tempNode = Head;            
           

            while (tempNode != null)
            {
                if (tempNode.Data.Ad == position.Ad && tempNode.Data.Soyad==position.Soyad)
                {
                    retNode = tempNode;
                    break;
                }               
                tempNode = tempNode.Next;
                
            }
            if (retNode == null)
            {
                return 61; 
            }
            else
            return retNode.Data.KoltukNo;
        }


        public override string DisplayElements()
        {
            Node tempNode = Head;
            
            string temp="";
            
            while (tempNode != null)
            {
               if(tempNode.Data.Ad=="")
                temp += "Koltuk No:" + tempNode.Data.KoltukNo + Environment.NewLine + Environment.NewLine;
                  
                tempNode = tempNode.Next;
            }
            return temp;
        }

        public override string DisplayEmpty()
        {

            Node tempNode = Head;

            string temp = "";

            while (tempNode != null)
            {
                if (tempNode.Data.Ad != "")
                    temp += "Koltuk No:" + tempNode.Data.KoltukNo + Environment.NewLine + "\nAd:" + tempNode.Data.Ad + Environment.NewLine + "\nSoyad:" + tempNode.Data.Soyad + Environment.NewLine + Environment.NewLine;

                tempNode = tempNode.Next;
            }
            return temp;
        }    
    }
}
