namespace StudentMVC.Models
{
    public class StudentMockData
    {
        public List<Student> students;
        public StudentMockData()
        {
            students = new List<Student>(); 
            students.Add(new Student() { Id=1,Name="Mohamed Ashraf",Address="10st almaadi",Image="1.jpg"});
            students.Add(new Student() { Id=2,Name="Ahmed Ashraf",Address="15st Cairo",Image="2.jpg"});
            students.Add(new Student() { Id=3,Name="Hassan ayman",Address="109st alex",Image="1.jpg"});
        }
        public Student GetById(int id) => students.FirstOrDefault(s => s.Id == id);
        public List<Student> GetALL() => students;  
    }
}
