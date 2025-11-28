using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum EnumStatus
{
    UdeAfDrift,
    UnderReperation,
    Klar

}
abstract public class Maintenance
{
    protected Dictionary<int, string> DamageLog { get; private set; } = new Dictionary<int, string>();
    protected int Id { get; private set; }
    protected List<string> MaintenanceLog { get; private set; } = new List<string>();

    protected EnumStatus Status = EnumStatus.Klar;




    public bool AddDamage(string damage)
    {
        try
        {
            Id++;
            DamageLog.Add(Id, damage);
            return true;
        }
        catch
        {
            return false;
        }

    }

    public bool Repair(int damageLogId)
    {
        try
        {
            string skade = DamageLog[damageLogId];
            DamageLog.Remove(damageLogId);
            MaintenanceLog.Add(skade);

            return true;
        }
        catch
        {
            return false;
        }




    }

}
