using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFM.Models;
using WFM.Presenters;

namespace WFM.Views
{
    public partial class AddNewEmployee : Form, IAddNewEmployee
    {

        private User _user = new User();
        public AddNewEmployee()
        {
            InitializeComponent();
        }

        public User user {
            
            get {
                
                return _user;
            } 
            set => throw new NotImplementedException();
            
        }

        public User AddUser { 
            set => throw new NotImplementedException();
        }
    }
}
