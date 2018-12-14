using SchoolManagement.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.BAL.BO
{
    public class StudentsBo
    {
        public SCHOOL_MNGEntities dbContext = new SCHOOL_MNGEntities();



        public Students Create()
        {
            Students std = new Students();
            //std.Name = "test student";
            //std.ClassId = 3;

            var stds = dbContext.Students.AsEnumerable();

            try
            {
                //dbContext.Professors.Add(new Professors() { Name = "test prof", ClassId = 1});
                //dbContext.Students.Add(std);
                //dbContext.Classes.Add(new Classes() {Name = "second testetssafdsd" });
                dbContext.SaveChanges();

            }
            catch(Exception e)
            {
                throw new Exception(e.Message, e);
            }

            return std;
        }
    }
}
