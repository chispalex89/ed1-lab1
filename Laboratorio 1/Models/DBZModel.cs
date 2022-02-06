using System;
using Laboratorio_1.Helpers;



namespace Laboratorio_1.Models
{
    public class DBZModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NPower { get; set; }
        public string SpecialAttack { set; get; }
        public static bool Save(DBZModel mode1)
        {
            DataDBZ.InstanceDBZ.dbzList.Add(mode1);
            return true;
        }
        public static bool Edit(int id, DBZModel model)
        {
            var position = DataDBZ.InstanceDBZ.dbzList.FindIndex(dbz => dbz.Id == id);
            DataDBZ.InstanceDBZ.dbzList[position] = new DBZModel
            {
                Id = id,
                Name = model.Name,
                NPower = model.NPower,
                SpecialAttack = model.SpecialAttack
            };
            return true;

        }
    }
    

}
