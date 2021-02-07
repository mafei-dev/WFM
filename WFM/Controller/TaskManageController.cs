using System;
using System.Collections.Generic;
using WFM.Database;
using WFM.Enity;
using WFM.Entity;
using WFM.Repository;

namespace WFM.Controller
{
    public class TaskManageController
    {
        private IProjectTaskRepository _projectTaskRepository;
        private IAssetRepository _assetRepository;
        private ITaskEmpExpenseRepository _taskEmpExpenseRepository;
        private ITaskAssetExpenseRepository _taskAssetExpenseRepository;
        private ITaskExpenseRepository _taskExpenseRepository;
        private ITaskOtherExpenseRepository _taskOtherExpenseRepository;

        public List<ProjectTaskNormalised> GetAllTasksForProject(string projectId)
        {
            using (DalSession dalSession = new DalSession())
            {
                UnitOfWork unitOfWork = dalSession.UnitOfWork();
                unitOfWork.Begin();
                try
                {
                    _projectTaskRepository = new ProjectTaskRepository(unitOfWork);
                    List<ProjectTaskNormalised> projectList = _projectTaskRepository.GetAllTasksForProject(projectId);
                    unitOfWork.Commit();
                    return projectList;
                }
                catch
                {
                    unitOfWork.Rollback();
                    throw;
                }
            }
        }


        public List<Asset> GetAllAsset()
        {
            using (DalSession dalSession = new DalSession())
            {
                UnitOfWork unitOfWork = dalSession.UnitOfWork();
                unitOfWork.Begin();
                try
                {
                    _assetRepository = new AssetRepository(unitOfWork);
                    List<Asset> allAssets = _assetRepository.GetAllAssets();
                    unitOfWork.Commit();
                    return allAssets;
                }
                catch
                {
                    unitOfWork.Rollback();
                    throw;
                }
            }
        }


        public bool AddTaskEmpExpense(TaskEmpExpense taskEmpExpense)
        {
            using (DalSession dalSession = new DalSession())
            {
                UnitOfWork unitOfWork = dalSession.UnitOfWork();
                unitOfWork.Begin();
                try
                {
                    _taskExpenseRepository = new TaskExpenseRepository(unitOfWork);
                    _taskEmpExpenseRepository = new TaskEmpExpenseRepository(unitOfWork);
                    taskEmpExpense.TaskExpense.Task_Expense_Id = Guid.NewGuid().ToString();
                    taskEmpExpense.Task_Emp_Expense_Id = Guid.NewGuid().ToString();
                    if (_taskExpenseRepository.addNewTaskExpense(taskEmpExpense.TaskExpense) == 1)
                    {
                        if (_taskEmpExpenseRepository.addNewTaskEmpExpense(taskEmpExpense) == 1)
                        {
                            unitOfWork.Commit();
                            return true;
                        }
                        else
                        {
                            unitOfWork.Rollback();
                            return false;
                        }
                    }
                    else
                    {
                        unitOfWork.Rollback();
                        return false;
                    }
                }
                catch
                {
                    unitOfWork.Rollback();
                    throw;
                }
            }
        }


        public bool AddAssetExpense(TaskAssetExpense taskAssetExpense)
        {
            using (DalSession dalSession = new DalSession())
            {
                UnitOfWork unitOfWork = dalSession.UnitOfWork();
                unitOfWork.Begin();
                try
                {
                    _taskAssetExpenseRepository = new TaskAssetExpenseRepository(unitOfWork);
                    _taskExpenseRepository = new TaskExpenseRepository(unitOfWork);
                    taskAssetExpense.Task_Asset_Expense_Id = Guid.NewGuid().ToString();
                    taskAssetExpense.TaskExpense.Task_Expense_Id = Guid.NewGuid().ToString();

                    if (_taskExpenseRepository.addNewTaskExpense(taskAssetExpense.TaskExpense) == 1)
                    {
                        if (_taskAssetExpenseRepository.addNewTaskAssetExpense(taskAssetExpense) == 1)
                        {
                            unitOfWork.Commit();
                            return true;
                        }
                        else
                        {
                            unitOfWork.Rollback();
                            return false;
                        }
                    }
                    else
                    {
                        unitOfWork.Rollback();
                        return false;
                    }
                }
                catch
                {
                    unitOfWork.Rollback();
                    throw;
                }
            }
        }


        public bool AddOtherExpense(TaskOtherExpense taskOtherExpense)
        {
            using (DalSession dalSession = new DalSession())
            {
                UnitOfWork unitOfWork = dalSession.UnitOfWork();
                unitOfWork.Begin();
                try
                {
                    _taskOtherExpenseRepository = new TaskOtherExpenseRepository(unitOfWork);
                    _taskExpenseRepository = new TaskExpenseRepository(unitOfWork);
                    taskOtherExpense.Task_Other_Expense_Id = Guid.NewGuid().ToString();
                    taskOtherExpense.TaskExpense.Task_Expense_Id = Guid.NewGuid().ToString();

                    if (_taskExpenseRepository.addNewTaskExpense(taskOtherExpense.TaskExpense) == 1)
                    {
                        if (_taskOtherExpenseRepository.addNewTaskOtherExpense(taskOtherExpense) == 1)
                        {
                            unitOfWork.Commit();
                            return true;
                        }
                        else
                        {
                            unitOfWork.Rollback();
                            return false;
                        }
                    }
                    else
                    {
                        unitOfWork.Rollback();
                        return false;
                    }
                }
                catch
                {
                    unitOfWork.Rollback();
                    throw;
                }
            }
        }

        private EmployeeRepo _employeeRepo;

        public List<Employee> GetAllEmp()
        {
            using (DalSession dalSession = new DalSession())
            {
                UnitOfWork unitOfWork = dalSession.UnitOfWork();
                unitOfWork.Begin();
                try
                {
                    _employeeRepo = new EmployeeRepo(unitOfWork);
                    List<Employee> allEmPs = _employeeRepo.GetAllEMPs();

                    unitOfWork.Commit();
                    return allEmPs;
                }
                catch
                {
                    unitOfWork.Rollback();
                    throw;
                }
            }
        }


        public List<TaskExpense> GetAllExpensesForTask(string projectTaskId)
        {
            using (DalSession dalSession = new DalSession())
            {
                UnitOfWork unitOfWork = dalSession.UnitOfWork();
                unitOfWork.Begin();
                try
                {
                    _taskExpenseRepository = new TaskExpenseRepository(unitOfWork);
                    List<TaskExpense> expenses = _taskExpenseRepository.GetAllEXPsByProjectTaskId(projectTaskId);
                    unitOfWork.Commit();
                    return expenses;
                }
                catch
                {
                    unitOfWork.Rollback();
                    throw;
                }
            }
        }
    }
}