using OrganizationModelsLibrary;
using OrgnationGetwaysLibrary;
using System.Collections.Generic;

namespace OrgnationManagersLibrary
{
    public class DesignationManager
    {
        private readonly DesignationGetway _designationGetway;

        public DesignationManager(DesignationGetway designationGetway)
        {
            _designationGetway = designationGetway;

        }

        public Designation GetDesignationById(int id)
        {
            return _designationGetway.GetDesignationById(id);
        }

        public Designation FindSingleDesignationbyId(int id)
        {
            return _designationGetway.FindSingleDesignationbyId(id);
        }

        public Designation FindSingleDesignationByShortName(string shortName)
        {
            return _designationGetway.FindSingleDesignationByShortName(shortName);
        }

        public IEnumerable<Designation> GetAllDesignations()
        {
            return _designationGetway.GetAllDesignations();
        }

        // find
        public IEnumerable<Designation> FindDesignationsByName(string name)
        {
            return _designationGetway.FindDesignationsByName(name);
        }

        // save
        public int Save(Designation aDesignation)
        {
            return _designationGetway.Save(aDesignation);
        }

        public int SaveList(IEnumerable<Designation> designations)
        {
            return _designationGetway.SaveList(designations);
        }

        // Update
        public int Update(Designation aDesignation)
        {
            return _designationGetway.Update(aDesignation);
        }

        // Delete
        public int Delete(Designation aDesignation)
        {
            return _designationGetway.Delete(aDesignation);
        }

        public int DeleteList(IEnumerable<Designation> designations)
        {
            return _designationGetway.DeleteList(designations);
        }
    }
}
