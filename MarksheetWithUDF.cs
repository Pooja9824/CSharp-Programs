using System;
namespace kscstudent
{
    class student
    {
        string name;
        int age;
        int mathmark;
        int engmark;
        int scimark;
        int totmark=300;
        int obtainedmark;
        double per;

        void caltotmark()
        {
            obtainedmark=mathmark+engmark+scimark;
        }
        void calper()
        {
            per=(double)obtainedmark/totmark*100;
        }
        double getper()
        {
            return per;
        }
        static void Main()
        {
            student s=new student();
            Console.WriteLine("Enter name");
            s.name=Console.ReadLine();

            Console.WriteLine("Enter age:-");
            s.age=Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter marks for maths");
            s.mathmark=Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter marks of english:-");
            s.engmark=Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter marks for science");
            s.scimark=Int32.Parse(Console.ReadLine());

            s.caltotmark();
            s.calper();
            double sper=s.getper();
            Console.WriteLine("name:{0}   age:{1} \n marks:- math:{2} \n english:{3} \n science:{4} \n total mark obtained:{5} \n percentage:{6}",s.name,s.age,s.mathmark,s.engmark,s.scimark,s.totmark,s.per);
        }
    }
}