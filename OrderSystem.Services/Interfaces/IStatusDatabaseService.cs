using OrderSystem.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Services.Interfaces
{
    public interface IStatusDatabaseService
    {
         List<Status> GetStatuss();

        Status GetStatus(int id);

        void AddStatus(Status status);

        void DeleteStatus(Status status);

        void UpdateStatus(Status status);
    }
}
