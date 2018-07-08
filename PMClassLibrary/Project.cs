using System;

namespace ProjectManagementLibrary
{
    public class Project
    {
        private string projectName;
        private string description;
        private bool isActive;
        private DateTime startDate, finishDate;

        public string ProjectName
        {
            set { projectName = value; }
            get { return projectName; }
        }
        public string Description
        {
            set { description = value; }
            get { return description; }
        }
        public bool IsActive
        {
            /* только для чтения */
            get { return isActive; }
        }
        public void CloseProject()
        {
            /* При закрытии проекта нужно также закрыть все его задачи.
             * Неактивные проекты не выводятся в общем списке проектов,
             * а только в архиве.
             * Нужно придумать, как удалять проект на совсем.*/
            if (isActive == true)
            {
                isActive = false;
            }
        }
        public DateTime StartDate
        {
            get { return startDate; }
        }
        public DateTime FinishDate
        {
            set
            {
                TimeZoneInfo tz = TimeZoneInfo.Local; // getting the current system timezone
                if (tz.IsAmbiguousTime(value))
                {
                    if (value > startDate)
                    {
                        finishDate = value;
                    }
                }
            }
            get { return finishDate; }
        }
        public Project(bool activity, DateTime now)
        {
            isActive = activity;
            startDate = now;
        }
    }
}
