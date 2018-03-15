using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {

            /*
        * Create a List of Courses (add three example Courses ...
        * make up the details).  Each Course should have at least two
        * Students enrolled in them.  Use Object and Collection
        * Initializers.  Then, iterate through each Course and print
        * out the Course's details and the Students that are enrolled in
        * each Course.
        */
        List<Course> course = new List<Course>() {

           new Course() { CourseId=1, Name="Advanced Underwater Basket Weaving", Students=new List<Student>()
           {
               new Student() {StudentId=100, Name="Alex Martin"},
               new Student() {StudentId=101, Name="Kathryn Martin" }
           }},

           new Course() {CourseId=2, Name="There, they're, their: How they're handling their business over there.", Students= new List<Student>()
           {
               new Student() { StudentId=102, Name="Steven Odien",},
               new Student() { StudentId=103, Name="Issac Meza", },
               new Student() { StudentId=101, Name="Kathryn Martin", }
           }},

           new Course() {CourseId=3, Name="Step 1:______ Step 2:________ Step 3: Profit", Students=new List<Student>()
           {
               new Student() { StudentId=100, Name="Alex Martin" },
               new Student() { StudentId=102, Name="Steven Odien" }
           }}
       };
   
       foreach (var courses in course)
       {
                resultLabel.Text += String.Format("Course: {0} - {1}<br>", courses.CourseId, courses.Name);
                foreach (var student in courses.Students)
                {
                    resultLabel.Text += String.Format("&nbsp;&nbsp;{0} - {1}<br>", student.StudentId, student.Name);
                }

       }
   }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */

            Course course1 = new Course() { CourseId = 100, Name = "Dog Sitting 101" };
            Course course2 = new Course() { CourseId = 101, Name = "Dog Grooming 305" };
            Course course3 = new Course() { CourseId = 102, Name = "Dog Training 201" };

            Dictionary<int, Student> students = new Dictionary<int, Student>(){
                {1, new Student() { StudentId= 100, Name="Alex Martin", Courses = new List<Course> {course1, course3}} },
                {2, new Student() { StudentId= 102, Name="Steven Odien", Courses = new List<Course> {course2, course3}} },
                {3, new Student() { StudentId= 101, Name="Kathryn Martin", Courses = new List<Course> {course1, course2}} },
        };

            foreach (var student in students)
            {
                resultLabel.Text += String.Format("Student- {0} -{1}<br>", student.Value.StudentId, student.Value.Name);
                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += string.Format("&nbsp&nbspCourse:{0}- {1}<br>", course.CourseId, course.Name);
                }
            }
        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */

            Student student = new Student();
            student.StudentId = 100;
            student.Name = "Alex Martin";
            student.Enrolled = new List<Enrolled>()
            {
                new Enrolled { Grade = 97, Course = new Course(){CourseId = 101, Name = "Dog Grooming 305"}},
                new Enrolled { Grade = 56, Course = new Course(){CourseId = 100, Name = "Dog Sitting 101"}}
            };

            resultLabel.Text += String.Format("Student: {0} - {1}<br>", student.StudentId, student.Name);
            foreach (var enrollments in student.Enrolled)
            {
                resultLabel.Text += String.Format("&nbsp;&nbsp;Enrolled in: {0} - {1} : {2}<br>", enrollments.Course.CourseId, enrollments.Course.Name, enrollments.Grade);
            }
           
        }
    }
}