using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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




    public void AddDamage(string damage)
    {
       
        if (string.IsNullOrWhiteSpace(damage))
            throw new ArgumentException("Damage must not be empty or whitespace");
        Id++;
        DamageLog.Add(Id, damage);
        
    }

    public void Repair(int damageLogId)
    {
        if (damageLogId < 0)
            throw new ArgumentException("Damage must not be less than zero");

        string skade = DamageLog[damageLogId];
        DamageLog.Remove(damageLogId);
        MaintenanceLog.Add(skade);
    }

}
