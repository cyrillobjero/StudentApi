using StudentApi.Model.Domain;
using StudentApi.Model.DTO;

namespace StudentApi.Mapper
{
    public static class StudentMapper
    {
        public static AddStudentDto MapToAddStudentDTO(this Student student)
        {
            return new AddStudentDto
            {
                StudentNumber = student.StudentNumber,
                LastName = student.LastName,
                FirstName = student.FirstName,
                Gender = student.Gender,
                Address = student.Address,
                Birthday = student.Birthday,
                Birthplace = student.Birthplace
            };
        }

        public static Student MapToStudent(this StudentAddDto addStudentDto)
        {
            return new Student
            {
                StudentNumber = addStudentDto.StudentNumber,
                LastName = addStudentDto.LastName,
                FirstName = addStudentDto.FirstName,
                Gender = addStudentDto.Gender,
                Address = addStudentDto.Address,
                Birthday = addStudentDto.Birthday,
                Birthplace = addStudentDto.Birthplace
            };
        }

        public static void UpdateStudent(this Student student, EditStudentDto editStudentDto)
        {
            student.LastName = editStudentDto.LastName;
            student.FirstName = editStudentDto.FirstName;
            student.Gender = editStudentDto.Gender;
            student.Address = editStudentDto.Address;
            student.Birthday = editStudentDto.Birthday;
            student.Birthplace = editStudentDto.Birthplace;
        }
    }
}
