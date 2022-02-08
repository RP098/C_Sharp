using System;
using System.Collections.Generic;
using System.Text;

namespace PodstawoweKonstrukcjeC_Sharp
{
    class StruktureInfo{

        public string Info="tekst";
     
    
    }

    struct Point // type value
    {
     private int pointX ;
     private int pointY ;
     private string text_;   
     public StruktureInfo text_New; //type reference

       public Point(int pointX,int pointY, string text_,string text_New)
        {
            StruktureInfo struktureInfo = new StruktureInfo();
        this.pointX  = pointX;
        this.pointY  = pointY;
        this.text_  = text_;
        this.text_New  = struktureInfo;

        }

     public int showX()
        {
            return pointX;
        }

        public int showY()
        {
            return pointY;
        }
        public void showStringa()
        {
            Console.WriteLine(text_);
        }

        public void SetString(string text)
        {
            text_ = text;
        }
    }
}
