using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A.assignment6
{
    public class News : INews
    {
        public int[] RateList=new int[3];
        public int ID;
        public String Title;
        public String PublishDate;
        public String Author;
        public String Content;
        public float AverageRate;

        public News()
        {
        }
        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }
        public string tilte
        {
            get { return Title; }
            set { Title = value; }
        }
        public string publishDate
        {
            get { return PublishDate; }
            set { PublishDate = value; }
        }
        public string author
        {
            get { return Author; }
            set { Author = value; }
        }
        public string content
        {
            get { return Content; }
            set { Content = value; }
        }
        public float averageRate
        {
            get { return AverageRate; }
            set { AverageRate = value; }
        }
    public void Display()
        {
            Console.WriteLine("Title " + Title);
            Console.WriteLine("PublishDate " + PublishDate);
            Console.WriteLine("Author " + Author);
            Console.WriteLine("Content " + Content);
        }

    public void Calculate()
        {
            AverageRate = (float)(RateList[0] + RateList[1] + RateList[2]) / 3;
            Console.WriteLine("AverageRate " + AverageRate);
        }
    }
}
