using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Model
{
   public  class Teacher
    {
       /// <summary>
       /// 教师编号
       /// </summary>
       private string teaId;
       public string TeaId
       {
           get { return teaId; }
           set{teaId=value;}
       }
       /// <summary>
       /// 教师姓名
       /// </summary>
       private string teaName;
       public string TeaName
       {
           get { return teaName; }
           set { teaName = value; }
       }
       /// <summary>
       /// 党派
       /// </summary>
       private string party;
       public string Party
       {
           get { return party; }
           set { party = value; }
       }
       /// <summary>
       /// 职称
       /// </summary>
       private string title;
       public string Title
       {
           get { return title; }
           set { title = value; }
       }
       /// <summary>
       /// 职位
       /// </summary>
       private string post;
       public string Post
       {
           get { return post; }
           set { post = value; }
       }
       /// <summary>
       /// 时间
       /// </summary>
       private string createTime;
       public string CreateTime
       {
           get { return createTime; }
           set { createTime = value; }
       }
       /// <summary>
       /// 具体内容
       /// </summary>
       private string content;
       public string Content
       {
           get { return content; }
           set { content = value; }
       }
       /// <summary>
       /// 图片路径
       /// </summary>
       private string picPath;
       public string PicPath
       {
           get { return picPath; }
           set { picPath = value; }
       }

      
    }
}
