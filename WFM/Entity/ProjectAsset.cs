using System;

namespace WFM.Entity
{
    public class ProjectAsset
    {
        public string Project_Asset_Id { get; set; }
        public string Note { get; set; }
        public DateTime Added_Datetime { get; set; }
        public Project Project { get; set; }
        public Asset Asset { get; set; }
    }
}