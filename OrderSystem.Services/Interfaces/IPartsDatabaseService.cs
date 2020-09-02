using OrderSystem.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Services.Interfaces
{
    public interface IPartsDatabaseService
    {
        List<Part> GetParts();

        Part GetPart(int id);

        List<Part> GetPartsByIds(string ids);

        void AddPart(Part part);

        void DeletePart(Part part);

        void UpdatePart(Part part);

    }
}
