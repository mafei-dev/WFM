namespace WFM.Models
{
    public class ProjectEmployee
    {
        public ProjectEmployee(string Project_Employee_id, string EMP_Id, string View_Row)
        {
            this.EMP_Id = EMP_Id;
            this.View_Row = View_Row;
            this.Project_Employee_id = Project_Employee_id;
        }

        public string EMP_Id { get; set; }
        public string View_Row { get; set; }
        public string Project_Employee_id { get; set; }
    }
}